//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefIndividualizedProgramTypeEntity.g.cs
//* Name:       Individualized Program Type
//* Definition: A designation of the type of program developed for a student.
//***************************************************************************

/// <summary>
/// Individualized Program Type <see cref="RefIndividualizedProgramType"/>
/// <para>
/// A designation of the type of program developed for a student.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19320">Individualized Program Type</a>
/// </para>
/// </summary>
[Table("RefIndividualizedProgramType", Schema = "Common")]
[Comment("A designation of the type of program developed for a student.")]
public partial class RefIndividualizedProgramTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
