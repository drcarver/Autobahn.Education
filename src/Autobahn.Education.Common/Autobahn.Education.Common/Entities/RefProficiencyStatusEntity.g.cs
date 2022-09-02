//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefProficiencyStatusEntity.g.cs
//* Name:       Proficiency Status
//* Definition: An indication of whether a student's scores were proficient.
//***************************************************************************

/// <summary>
/// Proficiency Status <see cref="RefProficiencyStatus"/>
/// <para>
/// An indication of whether a student's scores were proficient.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19565">Proficiency Status</a>
/// </para>
/// </summary>
[Table("RefProficiencyStatus", Schema = "Common")]
[Comment("An indication of whether a student's scores were proficient.")]
public partial class RefProficiencyStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
