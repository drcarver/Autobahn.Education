//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefNeglectedProgramTypeEntity.g.cs
//* Name:       Neglected or Delinquent Program Type
//* Definition: The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
//***************************************************************************

/// <summary>
/// Neglected or Delinquent Program Type <see cref="RefNeglectedProgramType"/>
/// <para>
/// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19194">Neglected or Delinquent Program Type</a>
/// </para>
/// </summary>
[Table("RefNeglectedProgramType", Schema = "Common")]
[Comment("The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).")]
public partial class RefNeglectedProgramTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
