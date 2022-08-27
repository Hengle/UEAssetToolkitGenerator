﻿namespace UAssetAPI.StructTypes;

public class MovieSceneEvalTemplatePtrPropertyData : StructPropertyData 
{

    public MovieSceneEvalTemplatePtrPropertyData(FName name) : base(name)
    {
        Value = new List<PropertyData>();
    }

    public MovieSceneEvalTemplatePtrPropertyData(FName name, FName forcedType) : base(name)
    {
        StructType = forcedType;
        Value = new List<PropertyData>();
    }

    public MovieSceneEvalTemplatePtrPropertyData()
    {

    }

    private static readonly FName CurrentPropertyType = new FName("MovieSceneEvalTemplatePtr");
    public override bool HasCustomStructSerialization { get { return true; } }
    public override FName PropertyType { get { return CurrentPropertyType; } }



    public override void Read(AssetBinaryReader reader, bool includeHeader, long leng1, long leng2 = 0)
    {
        if (includeHeader) {
            PropertyGuid = reader.ReadPropertyGuid();
        }

        List<PropertyData> resultingList = new List<PropertyData>();
        PropertyData data = null;
        data = new StrPropertyData(new FName("TypeName"));
        //data = new StrPropertyData();
        data.Read(reader, includeHeader, leng1);
        resultingList.Add(data);
        if (((StrPropertyData)data).Value != null) {
            
            while ((data = MainSerializer.Read(reader, true)) != null) {
                resultingList.Add(data);
            }   
        }

        Value = resultingList;
    }


    public override int Write(AssetBinaryWriter writer, bool includeHeader)
    {
        if (includeHeader) {
            writer.WritePropertyGuid(PropertyGuid);
        }

        int here = (int)writer.BaseStream.Position;

        if (Value != null) {
            foreach (PropertyData t in Value) {
                if (t.Name.ToName()== "TypeName") {
                    writer.Write(((StrPropertyData)t).Value);
                } else { MainSerializer.Write(t, writer, true); }
            }

            if(((StrPropertyData)Value[0]).Value != null) {
                writer.Write(new FName("None"));
            }
        }
        
        return (int)writer.BaseStream.Position - here;
    }

}
