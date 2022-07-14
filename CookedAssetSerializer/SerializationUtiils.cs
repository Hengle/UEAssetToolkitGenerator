﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using UAssetAPI;
using UAssetAPI.FieldTypes;
using UAssetAPI.Kismet.Bytecode;
using UAssetAPI.PropertyTypes;
using UAssetAPI.StructTypes;
using static CookedAssetSerializer.KismetExpressionSerializer;

namespace CookedAssetSerializer
{
    public class SerializationUtils
    {
        public JArray SerializeScript(FunctionExport function)
        {
            var jscript = new JArray();
            var index = 0;
            foreach (var instruction in function.ScriptBytecode)
                jscript.Add(SerializeExpression(instruction, ref index, true));

            return jscript;
        }

        public void CollectGeneratedVariables(ClassExport mainobject)
        {
            //Collect variable names generated by SCS components
            if (FindPropertyData(mainobject, "SimpleConstructionScript", out PropertyData scs))
                if (FindPropertyData(((ObjectPropertyData)scs).Value, "AllNodes", out PropertyData allnodes))
                {
                    var nodes = (ArrayPropertyData)allnodes;
                    foreach (ObjectPropertyData node in nodes.Value)
                        if (FindPropertyData(node.Value, "InternalVariableName", out PropertyData property))
                            GeneratedVariables.Add(property.ToString());
                }


            //Collect variables generated by timelines
            if (FindPropertyData(mainobject, "Timelines", out PropertyData _timelines))
            {
                var timelines = (ArrayPropertyData)_timelines;
                foreach (ObjectPropertyData timeline in timelines.Value)
                {
                    var timelineindex = timeline.Value.Index - 1;
                    var timelineexport = (NormalExport)Exports[timelineindex];
                    if (FindPropertyData(timelineexport, "VariableName", out PropertyData _name))
                        GeneratedVariables.Add(((NamePropertyData)_name).Value.ToName());
                    if (FindPropertyData(timelineexport, "DirectionPropertyName", out PropertyData _dname))
                        GeneratedVariables.Add(((NamePropertyData)_dname).Value.ToName());
                    if (FindPropertyData(timelineexport, "FloatTracks", out PropertyData _floattracks))
                    {
                        var floattracks = (ArrayPropertyData)_floattracks;
                        foreach (StructPropertyData floattrack in floattracks.Value)
                            if (FindPropertyData(floattrack.Value, "PropertyName", out PropertyData _pname))
                                GeneratedVariables.Add(((NamePropertyData)_pname).Value.ToName());
                    }

                    if (FindPropertyData(timelineexport, "VectorTracks", out _floattracks))
                    {
                        var floattracks = (ArrayPropertyData)_floattracks;
                        foreach (StructPropertyData floattrack in floattracks.Value)
                            if (FindPropertyData(floattrack.Value, "PropertyName", out PropertyData _pname))
                                GeneratedVariables.Add(((NamePropertyData)_pname).Value.ToName());
                    }

                    if (FindPropertyData(timelineexport, "LinearColorTracks", out _floattracks))
                    {
                        var floattracks = (ArrayPropertyData)_floattracks;
                        foreach (StructPropertyData floattrack in floattracks.Value)
                            if (FindPropertyData(floattrack.Value, "PropertyName", out PropertyData _pname))
                                GeneratedVariables.Add(((NamePropertyData)_pname).Value.ToName());
                    }
                }
            }

            if (Asset.assetType == EAssetType.WidgetBlueprint)
            {
                //Also append widget tree generated variables
                if (FindPropertyData(mainobject, "WidgetTree", out PropertyData _wtree))
                {
                    var wtree = (ObjectPropertyData)_wtree;

                    if (wtree.Value.Index > 0 && Exports[wtree.Value.Index - 1] is NormalExport widgettree)
                        if (FindPropertyData(widgettree, "RootWidget", out PropertyData _root))
                        {
                            var root = (ObjectPropertyData)_root;
                            GetAllWidgets(root);
                        }
                }

                if (FindPropertyData(mainobject, "Bindings", out PropertyData _bindings))
                {
                    var bindings = (ArrayPropertyData)_bindings;
                    foreach (StructPropertyData binding in bindings.Value)
                        if (FindPropertyData(binding.Value, "ObjectName", out PropertyData _objname))
                            GeneratedVariables.Add(((StrPropertyData)_objname).Value.ToString());
                    //Console.WriteLine("bindings "+asset.FilePath);
                }

                //if (FindPropertyData(mainobject, "NamedSlots", out PropertyData _namedslots)) {
                //	ArrayPropertyData namedslots = (ArrayPropertyData)_namedslots;
                //	foreach (NamePropertyData nameslot in namedslots.Value) {
                //		GeneratedVariables.Add(nameslot.Value.ToName());
                //	}
                //	//Console.WriteLine("namedslots " + asset.FilePath);
                //}

                ////Also append animations, they always have backing variables too
                if (FindPropertyData(mainobject, "Animations", out PropertyData _animations))
                {
                    var animations = (ArrayPropertyData)_animations;
                    foreach (ObjectPropertyData animation in animations.Value)
                        if (animation.Value.Index > 0)
                        {
                            var animname = animation.Value.ToExport(Asset).ObjectName.ToName();
                            if (animname.EndsWith("_INST"))
                                GeneratedVariables.Add(animname.Substring(0, animname.Length - 5));
                        }
                }
            }
        }

        public List<string> VariableWidgets = new()
        {
            "Button",
            "CheckBox",
            "CircularThrobber",
            "ComboBoxString",
            "DetailsView",
            "DynamicEntryBox",
            "EditableText",
            "EditableTextBox",
            "ExpandableArea",
            "Image",
            "InputKeySelector",
            "InvalidationBox",
            "ListView",
            "MenuAnchor",
            "MultiLineEditableText",
            "MultiLineEditableTextBox",
            "NamedSlot",
            "ProgressBar",
            "RetainerBox",
            "RichTextBlock",
            "RichTextSizable",
            "RichTextStylable",
            "SafeZone",
            "SinglePropertyView",
            "Slider",
            "SpinBox",
            "Synth2DSlider",
            "SynthKnob",
            "Throbber",
            "TileView",
            "TreeView",
            "WebBrowser",
            "WidgetSwitcher"
        };

        public void GetAllWidgets(ObjectPropertyData reftowidget)
        {
            var isvariable = false;
            if (reftowidget.Value.Index > 0 && Exports[reftowidget.Value.Index - 1] is NormalExport widget)
            {
                if (FindPropertyData(widget, "bIsVariable", out PropertyData _bisvariable))
                {
                    var bisvariable = (BoolPropertyData)_bisvariable;
                    isvariable = bisvariable.Value;
                }
                else
                {
                    if (widget.ClassIndex.IsImport())
                    {
                        var baseclass = widget.ClassIndex.ToImport(Asset);
                        if (baseclass.ClassName.ToName() == "Class" &&
                            VariableWidgets.Contains(baseclass.ObjectName.ToName())) isvariable = true;
                        if (baseclass.ClassName.ToName() == "WidgetBlueprintGeneratedClass") isvariable = true;
                    }
                }

                if (isvariable) GeneratedVariables.Add(widget.ObjectName.ToName());

                if (FindPropertyData(widget, "Slots", out PropertyData _slots))
                {
                    var slots = (ArrayPropertyData)_slots;
                    foreach (ObjectPropertyData slot in slots.Value)
                        if (slot.Value.IsExport() && Exports[slot.Value.Index - 1] is NormalExport child)
                            if (FindPropertyData(child, "Content", out PropertyData content))
                                GetAllWidgets((ObjectPropertyData)content);
                }
            }
        }


        public JArray SerializeScript(KismetExpression[] code)
        {
            var jscript = new JArray();
            var index = 0;
            foreach (var instruction in code) jscript.Add(SerializeExpression(instruction, ref index, true));

            return jscript;
        }

        public JArray SerializeInterfaces(List<SerializedInterfaceReference> interfaces)
        {
            var jinterfaces = new JArray();
            foreach (var iinterface in interfaces)
            {
                var jinterface = new JObject();
                jinterface.Add("Class", Index(iinterface.Class));
                jinterface.Add("PointerOffset", iinterface.PointerOffset);
                jinterface.Add("bImplementedByK2", iinterface.bImplementedByK2);
                jinterfaces.Add(jinterface);
            }

            return jinterfaces;
        }

        public JObject SerializeFunction(FunctionExport function, bool FieldKind = true)
        {
            //currentfunction = function;
            var jfunc = new JObject();
            if (FieldKind) jfunc.Add("FieldKind", "Function");

            jfunc.Add("ObjectClass", Asset.Imports[Math.Abs(function.TemplateIndex.Index) - 1].ClassName.ToName());
            jfunc.Add("ObjectName", function.ObjectName.ToName());
            jfunc.Add("SuperStruct", Index(function.SuperIndex.Index));
            jfunc.Add("Children", new JArray());
            var ChildProperties = new JArray();

            foreach (var property in function.LoadedProperties) ChildProperties.Add(SerializeProperty(property));
            jfunc.Add("ChildProperties", ChildProperties);
            jfunc.Add("Script", SerializeScript(function));
            jfunc.Add("FunctionFlags", ((uint)function.FunctionFlags).ToString());

            return jfunc;
        }

        public JObject SerializeProperty(FProperty property, bool FieldKind = true)
        {
            var jprop = new JObject();
            if (FieldKind) jprop.Add("FieldKind", "Property");
            jprop.Add("ObjectClass", property.SerializedType.ToName());
            jprop.Add("ObjectName", property.Name.ToName());

            jprop.Add("ArrayDim", (byte)property.ArrayDim);
            jprop.Add("PropertyFlags", ((long)property.PropertyFlags).ToString());
            jprop.Add("RepNotifyFunc", property.RepNotifyFunc.ToName());
            jprop.Add("BlueprintReplicationCondition", (byte)property.BlueprintReplicationCondition);

            switch (property)
            {
                case FEnumProperty fenum:
                {
                    jprop.Add("Enum", Index(fenum.Enum.Index));
                    jprop.Add("UnderlyingProp", SerializeProperty(fenum.UnderlyingProp, false));
                    break;
                }
                case FArrayProperty farray:
                {
                    jprop.Add("Inner", SerializeProperty(farray.Inner, false));
                    break;
                }
                    ;
                case FSetProperty fset:
                {
                    jprop.Add("ElementType", SerializeProperty(fset.ElementProp, false));
                    break;
                }
                    ;
                case FMapProperty fmap:
                {
                    jprop.Add("KeyProp", SerializeProperty(fmap.KeyProp, false));
                    jprop.Add("ValueProp", SerializeProperty(fmap.ValueProp, false));
                    break;
                }
                    ;
                case FInterfaceProperty finterface:
                {
                    jprop.Add("InterfaceClass", Index(finterface.InterfaceClass.Index));
                    break;
                }
                    ;
                case FBoolProperty fbool:
                {
                    jprop.Add("BoolSize", fbool.ElementSize);
                    jprop.Add("NativeBool", fbool.NativeBool);
                    break;
                }
                    ;
                case FByteProperty fbyte:
                {
                    jprop.Add("Enum", Index(fbyte.Enum.Index));
                    break;
                }
                    ;
                case FStructProperty fstruct:
                {
                    jprop.Add("Struct", Index(fstruct.Struct.Index));
                    break;
                }
                    ;
                case FNumericProperty fnumeric:
                {
                    break;
                }
                    ;
                case FGenericProperty fgeneric:
                {
                    break;
                }
                    ;

                case FSoftClassProperty fsoftclassprop:
                {
                    jprop.Add("MetaClass", Index(fsoftclassprop.MetaClass.Index));
                    break;
                }
                    ;
                case FSoftObjectProperty fsoftobjprop:
                {
                    jprop.Add("PropertyClass", Index(fsoftobjprop.PropertyClass.Index));
                    break;
                }
                    ;
                case FClassProperty fclassprop:
                {
                    jprop.Add("MetaClass", Index(fclassprop.MetaClass.Index));
                    break;
                }
                    ;
                case FObjectProperty fobjprop:
                {
                    jprop.Add("PropertyClass", Index(fobjprop.PropertyClass.Index));
                    break;
                }
                    ;

                //case FMulticastInlineDelegateProperty fmidelegate: {
                //        jprop.Add("SignatureFunction", Index(fmidelegate.SignatureFunction.Index));
                //        break; };
                //case FMulticastDelegateProperty fmdelegate: {
                //        jprop.Add("SignatureFunction", Index(fmdelegate.SignatureFunction.Index));
                //        break; };
                case FDelegateProperty fdelegate:
                {
                    if (fdelegate.SignatureFunction.Index > 0)
                        jprop.Add("SignatureFunction",
                            Asset.Exports[fdelegate.SignatureFunction.Index - 1].ObjectName.ToName());
                    else if (fdelegate.SignatureFunction.Index < 0)
                        jprop.Add("SignatureFunction",
                            Asset.Imports[-fdelegate.SignatureFunction.Index - 1].ObjectName.ToName());
                    else
                        jprop.Add("SignatureFunction", -1);
                    break;
                }
                    ;
                default:
                    break;
            }


            return jprop;
        }

        public JObject SerializaListOfProperties(List<PropertyData> Data, bool _struct = false)
        {
            if (!CheckDuplications(ref Data))
            {
            }

            FName prev = null;
            var buffer1 = new JObject();
            var buffer2 = new JObject();

            var jproparray = new JArray();
            JProperty[] jpropvalue = null;

            foreach (var prop in Data)
                if (!DisableGeneration.Contains(prop.Name.ToName()))
                {
                    if (prop.Name == prev && prop.DuplicationIndex != 0)
                    {
                        jpropvalue = SerializePropertyData(prop);
                        if (_struct)
                        {
                            if (jpropvalue.Length == 1)
                                jproparray.Add(jpropvalue[0].Value);
                            else
                                jproparray.Add(new JObject(jpropvalue));
                        }
                        else
                        {
                            foreach (var inprop in jpropvalue) jproparray.Add(inprop.Value);
                        }
                    }
                    else
                    {
                        if (jproparray.Count > 1)
                        {
                            buffer2.Add(prev.ToName(), jproparray);
                            buffer1 = (JObject)buffer2.DeepClone();
                        }
                        else
                        {
                            buffer2 = (JObject)buffer1.DeepClone();
                        }

                        jproparray = new JArray();
                        jpropvalue = SerializePropertyData(prop);

                        if (_struct)
                        {
                            if (jpropvalue.Length == 1)
                                jproparray.Add(jpropvalue[0].Value);
                            else
                                jproparray.Add(new JObject(jpropvalue));
                        }
                        else
                        {
                            foreach (var inprop in jpropvalue) jproparray.Add(inprop.Value);
                        }

                        buffer1.Add(jpropvalue);
                    }

                    prev = prop.Name;
                }

            if (jproparray.Count > 1)
            {
                buffer2.Add(prev.ToName(), jproparray);
                return buffer2;
            }
            else
            {
                return buffer1;
            }
        }

        public JObject SerializeNormalExport(NormalExport export, int index)
        {
            var jexport = new JObject();

            jexport.Add("ObjectIndex", index);
            jexport.Add("Type", "Export");
            jexport.Add("ObjectClass", Index(export.ClassIndex.Index));
            jexport.Add("Outer", Index(export.OuterIndex.Index));
            jexport.Add("ObjectName", export.ObjectName.ToName());
            jexport.Add("ObjectFlags", (long)export.ObjectFlags);
            var properties = SerializaListOfProperties(export.Data);
            properties.Add("$ReferencedObjects", JArray.FromObject(RefObjects.Distinct<int>()));
            jexport.Add("Properties", properties);

            RefObjects = new List<int>();
            return jexport;
        }
        
        public JProperty[] SerializePropertyData(PropertyData property, bool withname = true)
        {
            var jprop = new JProperty(property.Name.ToName());

            if (DisableGeneration.Contains(property.Name.ToName())) return null;

            var res = new List<JProperty>();
            switch (property)
            {
                case BoolPropertyData:
                case FloatPropertyData:
                case DoublePropertyData:
                case Int8PropertyData:
                case Int16PropertyData:
                case IntPropertyData:
                case Int64PropertyData:
                case UInt16PropertyData:
                case UInt32PropertyData:
                case UInt64PropertyData:
                case GameplayTagContainerPropertyData:
                case TextPropertyData:
                {
                    jprop.Value = property.ToJson();
                    res.Add(jprop);
                    break;
                }
                case BytePropertyData prop:
                {
                    if (prop.ByteType == BytePropertyType.Long)
                        jprop.Value = Asset.GetNameReference(prop.Value).Value;
                    else
                        jprop.Value = prop.Value;
                    res.Add(jprop);
                    break;
                }

                case EnumPropertyData prop:
                {
                    jprop.Value = prop.Value.ToName();
                    res.Add(jprop);
                    break;
                }
                case NamePropertyData prop:
                {
                    jprop.Value = prop.Value.ToName();
                    res.Add(jprop);
                    break;
                }
                case InterfacePropertyData prop:
                {
                    jprop.Value = Index(prop.Value.Index);
                    RefObjects.Add((int)jprop.Value);
                    res.Add(jprop);
                    break;
                }
                case ObjectPropertyData prop:
                {
                    int index = Index(prop.Value.Index);
                    if (index == -1 && prop.Value.Index != 0)
                    {
                        if (prop.Value.ToExport(Asset) is FunctionExport func)
                        {
                            jprop.Value = func.ObjectName.ToName();
                            res.Add(jprop);
                        }
                        else
                        {
                            Console.WriteLine("Non valid object index" + prop.Value.Index);
                        }
                    }
                    else
                    {
                        jprop.Value = index;
                        RefObjects.Add(index);
                        res.Add(jprop);
                    }

                    break;
                }
                case SoftObjectPropertyData prop:
                {
                    jprop.Value = prop.Value.ToJson();
                    res.Add(jprop);
                    break;
                }
                case StrPropertyData prop:
                {
                    if (prop.Value != null)
                    {
                        jprop.Value = prop.Value.Value;
                        res.Add(jprop);
                    }

                    break;
                }
                case MapPropertyData prop:
                {
                    var jvaluearray = new JArray();
                    for (var j = 1; j <= prop.Value.Count; j++)
                    {
                        var jobj = new JObject();

                        var key = SerializePropertyData(prop.Value.Keys.ElementAt(j - 1))[0];
                        var jkey = new JProperty("Key", key.Value);
                        jobj.Add(jkey);

                        key = SerializePropertyData(prop.Value.Values.ElementAt(j - 1))[0];
                        jkey = new JProperty("Value", key.Value);
                        jobj.Add(jkey);
                        jvaluearray.Add(jobj);
                    }

                    jprop.Value = jvaluearray;
                    res.Add(jprop);
                    break;
                }
                //case SetPropertyData prop: { break; }
                case ArrayPropertyData prop:
                {
                    var jvaluearray = new JArray();
                    foreach (var valueelement in prop.Value)
                    {
                        var element = SerializePropertyData(valueelement);
                        foreach (var ele in element) jvaluearray.Add(ele.Value);
                    }

                    jprop.Value = jvaluearray;
                    res.Add(jprop);
                    break;
                }
                case UnknownPropertyData:
                {
                    jprop.Value = "##NOT SERIALIZED##";
                    res.Add(jprop);
                    break;
                }
                case RawStructPropertyData:
                {
                    jprop.Value = "##NOT SERIALIZED##";
                    res.Add(jprop);
                    break;
                }
                case DateTimePropertyData:
                case TimespanPropertyData:
                case SmartNamePropertyData:
                case IntPointPropertyData:
                case GuidPropertyData:
                case ColorPropertyData:
                case LinearColorPropertyData:
                case RichCurveKeyPropertyData:
                case QuatPropertyData:
                case RotatorPropertyData:
                case Vector2DPropertyData:
                case Vector4PropertyData:
                case VectorPropertyData:
                case BoxPropertyData:
                case Box2DPropertyData:
                case SoftObjectPathPropertyData:
                case FontCharacterPropertyData:
                case FrameNumberPropertyData:
                case PerPlatformBoolPropertyData:
                case PerPlatformFloatPropertyData:
                case PerPlatformIntPropertyData:
                case MovieSceneFrameRangePropertyData:
                case MovieSceneTrackIdentifierPropertyData:
                case MovieSceneSequenceIDPropertyData:
                case MovieSceneEvaluationKeyPropertyData:
                case MovieSceneEvaluationFieldEntityTreePropertyData:
                case MovieSceneEventParametersPropertyData:
                case MovieSceneSubSequenceTreePropertyData:
                case MovieSceneSegmentIdentifierPropertyData:
                case MovieSceneTrackFieldDataPropertyData:
                //case MovieSceneSequenceInstanceDataPtrPropertyData:
                case MovieSceneFloatChannelPropertyData:
                {
                    res.AddRange(((JObject)property.ToJson()).Properties());
                    break;
                }
                case FontDataPropertyData prop:
                {
                    var value = new JObject();
                    var fontdata = prop.Value;
                    if (fontdata.bIsCooked)
                    {
                        value.Add("FontFaceAsset", Index(fontdata.LocalFontFaceAsset.Index));
                        RefObjects.Add(Index(fontdata.LocalFontFaceAsset.Index));
                        if (fontdata.FontFilename != null)
                            value.Add("FontFilename", fontdata.FontFilename.ToString());
                        else
                            value.Add("FontFilename", "");
                        value.Add("Hinting", "EFontHinting::" + fontdata.Hinting.ToString());
                        value.Add("LoadingPolicy", "EFontLoadingPolicy::" + fontdata.LoadingPolicy.ToString());
                        value.Add("SubFaceIndex", fontdata.SubFaceIndex);
                    }

                    jprop.Value = value;
                    res.AddRange(value.Properties());
                    break;
                }
                case MovieSceneSegmentPropertyData prop:
                {
                    var value = new JObject();
                    value.Add("Range", prop.Value.Range.ToJson());
                    value.Add("ID", prop.Value.ID.IdentifierIndex);
                    value.Add("bAllowEmpty", prop.Value.bAllowEmpty);

                    var jimpls = new JArray();


                    foreach (var item in prop.Value.Impls)
                    {
                        var structres = SerializaListOfProperties(item, true);
                        jimpls.Add(structres);
                    }

                    var data = new JObject();
                    value.Add("Impls", jimpls);
                    jprop.Value = value;
                    res.Add(jprop);
                    break;
                }
                case SectionEvaluationDataTreePropertyData prop:
                {
                    var Tree = prop.Value.Tree;

                    var value = new JObject();

                    var serdata = new JObject();
                    serdata.Add("RootNode", Tree.RootNode.ToJson());

                    var entries = new JArray();
                    var items = new JArray();
                    foreach (var entry in Tree.ChildNodes.Entries) entries.Add(entry.ToJson());
                    foreach (var item in Tree.ChildNodes.Items) items.Add(item.ToJson());
                    var childnodes = new JObject();

                    childnodes.Add("Entries", entries);
                    childnodes.Add("Items", items);
                    serdata.Add("ChildNodes", childnodes);

                    entries = new JArray();
                    items = new JArray();
                    foreach (var entry in Tree.Data.Entries) entries.Add(entry.ToJson());


                    foreach (var item in Tree.Data.Items)
                    {
                        var structres = SerializaListOfProperties(item, true);
                        items.Add(structres);
                    }

                    var data = new JObject();
                    data.Add("Entries", entries);
                    data.Add("Items", items);
                    serdata.Add("Data", data);
                    value.Add("Tree", serdata);
                    jprop.Value = value;
                    res.Add(jprop);
                    break;
                }
                case StructPropertyData prop:
                {
                    var structres = SerializaListOfProperties(prop.Value, true);
                    jprop.Value = structres;
                    res.Add(jprop);
                    break;
                }
                case FieldPathPropertyData prop:
                {
                    if (prop.Value.Length == 0)
                    {
                        jprop.Value = "##NOT SERIALIZED##";
                        res.Add(jprop);
                        break;
                    }
                    else
                    {
                        if (prop.Value.Length > 1)
                            Console.WriteLine("FieldPathPropertyData Values array has more than one name");
                        jprop.Value = GetFullName(prop.ResolvedOwner.Index) + ":" + prop.Value[0].ToName();
                        res.Add(jprop);
                        break;
                    }
                }
                default:
                {
                    Console.WriteLine(property.PropertyType.ToName());
                    jprop.Value = "##NOT SERIALIZED##";
                    res.Add(jprop);
                    break;
                }

                //case MulticastDelegatePropertyData prop: { break; }
                //case ExpressionInputPropertyData prop: { break; }
                //case MaterialAttributesInputPropertyData prop: { break; }
                //case ColorMaterialInputPropertyData prop: { break; }
                //case ScalarMaterialInputPropertyData prop: { break; }
                //case ShadingModelMaterialInputPropertyData prop: { break; }
                //case VectorMaterialInputPropertyData prop: { break; }
                //case Vector2MaterialInputPropertyData prop: { break; }
                //case SkeletalMeshAreaWeightedTriangleSamplerPropertyData prop: { break; }
                //case SkeletalMeshSamplingLODBuiltDataPropertyData prop: { break; }
                //case SoftAssetPathPropertyData prop: { break; }
                //case SoftClassPathPropertyData prop: { break; }
                //case ViewTargetBlendParamsPropertyData prop: { break; }
                //case WeightedRandomSamplerPropertyData prop: { break; }
                //case DelegatePropertyData prop: {
                //	Console.WriteLine(prop.Name.ToName());
                //	break; }
            }

            return res.ToArray();
        }
        
        public JProperty SerializeData(List<PropertyData> Data, bool mainobject = true)
        {
            JProperty jdata;
            RefObjects = new List<int>();

            if (mainobject)
                jdata = new JProperty("AssetObjectData");
            else
                jdata = new JProperty("Properties");

            var jdatavalue = new JObject();
            foreach (var property in Data)
            {
                var temp = SerializePropertyData(property);
                if (temp != null) jdatavalue.Add(temp);
            }

            if (mainobject)
            {
                var hasSCS = false;
                foreach (var jprop in jdatavalue.Properties())
                    if (jprop.Name == "SimpleConstructionScript")
                    {
                        hasSCS = true;
                        break;
                    }

                if (!hasSCS) jdatavalue.Add("SimpleConstructionScript", -1);
                if (Asset.assetType == EAssetType.WidgetBlueprint)
                    if (!FindPropertyData(Data, "Animations", out PropertyData _animations))
                        jdatavalue.Add("Animations", new JArray());
            }

            jdatavalue.Add("$ReferencedObjects", JArray.FromObject(RefObjects.Distinct<int>()));
            RefObjects = new List<int>();
            jdata.Value = jdatavalue;

            return jdata;
        }

        public JProperty ObjectHierarchy(UAsset asset, bool fixnames = false)
        {
            RefObjects = new List<int>();
            var ObjHie = new JArray();
            for (var i = 1; i <= asset.Imports.Count; i++)
                if (Dict.ContainsKey(-i))
                {
                    var import = asset.Imports[i - 1];
                    var jimport = new JObject();
                    jimport.Add("ObjectIndex", Index(-i));
                    jimport.Add("Type", "Import");
                    jimport.Add("ClassPackage", import.ClassPackage.ToName());
                    jimport.Add("ClassName", import.ClassName.ToName());
                    if (import.OuterIndex.Index != 0) jimport.Add("Outer", Index(import.OuterIndex.Index));
                    if (fixnames && import.OuterIndex.Index < 0 &&
                        import.OuterIndex.ToImport(asset).ClassName.ToName() == "Package")
                    {
                        var package = import.OuterIndex.ToImport(asset).ObjectName.ToName();
                        var packagename = import.OuterIndex.ToImport(asset).ObjectName.ToName().Split("/").Last();
                        var assetname = import.ObjectName.ToName();
                        if (package.StartsWith("/Game") && packagename != assetname)
                            jimport.Add("ObjectName", packagename);
                        else
                            jimport.Add("ObjectName", assetname);
                    }
                    else
                    {
                        jimport.Add("ObjectName", import.ObjectName.ToName());
                    }

                    ObjHie.Add(jimport);
                }

            for (var i = 1; i <= asset.Exports.Count; i++)
                if (Dict.ContainsKey(i))
                {
                    var jexport = new JObject();
                    if (i == asset.mainExport)
                    {
                        jexport.Add("ObjectIndex", Index(i));
                        jexport.Add("Type", "Export");
                        jexport.Add("ObjectMark", "$AssetObject$");
                    }
                    else
                    {
                        switch (asset.Exports[i - 1])
                        {
                            case FunctionExport:
                            {
                                continue;
                            }
                            case SoundNodeExport:
                            {
                                continue;
                            }
                            case NormalExport normal:
                            {
                                jexport = SerializeNormalExport(normal, Index(i));
                                break;
                            }
                            default: break;
                        }
                    }

                    ObjHie.Add(jexport);
                }

            return new JProperty("ObjectHierarchy", ObjHie);
        }
    }
}