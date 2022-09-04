//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefSchoolLevelEntity.g.cs
//* Name:       School Level
//* Definition: An indication of the level of the education institution.
//***************************************************************************

/// <summary>
/// School Level <see cref="RefSchoolLevel"/>
/// <para>
/// An indication of the level of the education institution.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19241">School Level</a>
/// </para>
/// </summary>
[Table("RefSchoolLevel", Schema = "EarlyLearning")]
[Comment("An indication of the level of the education institution.")]
public partial class RefSchoolLevelEntity : ReferenceBaseEntity, IReferenceBase
{
}
