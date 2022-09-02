//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefInstructionLocationTypeEntity.g.cs
//* Name:       Receiving Location of Instruction
//* Definition: The type of location at which instruction or service takes place.
//***************************************************************************

/// <summary>
/// Receiving Location of Instruction <see cref="RefInstructionLocationType"/>
/// <para>
/// The type of location at which instruction or service takes place.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19515">Receiving Location of Instruction</a>
/// </para>
/// </summary>
[Table("RefInstructionLocationType", Schema = "Common")]
[Comment("The type of location at which instruction or service takes place.")]
public partial class RefInstructionLocationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
