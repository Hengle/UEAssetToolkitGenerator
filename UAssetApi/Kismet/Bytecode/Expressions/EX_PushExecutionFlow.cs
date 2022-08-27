﻿namespace UAssetAPI.Kismet.Bytecode.Expressions;

/// <summary>
/// A single Kismet bytecode instruction, corresponding to the <see cref="EExprToken.PushExecutionFlow"/> instruction.
/// </summary>
public class EX_PushExecutionFlow : KismetExpression
{
    /// <summary>
    /// The token of this expression.
    /// </summary>
    public override EExprToken Token { get { return EExprToken.PushExecutionFlow; } }

    /// <summary>
    /// The address to push onto the execution flow stack.
    /// </summary>
    [JsonProperty]
    public uint PushingAddress;

    public EX_PushExecutionFlow()
    {

    }

    /// <summary>
    /// Reads out the expression from a BinaryReader.
    /// </summary>
    /// <param name="reader">The BinaryReader to read from.</param>
    public override void Read(AssetBinaryReader reader)
    {
        PushingAddress = reader.ReadUInt32();
    }

    /// <summary>
    /// Writes the expression to a BinaryWriter.
    /// </summary>
    /// <param name="writer">The BinaryWriter to write from.</param>
    /// <returns>The iCode offset of the data that was written.</returns>
    public override int Write(AssetBinaryWriter writer)
    {
        writer.Write(PushingAddress);
        return sizeof(uint);
    }
}
