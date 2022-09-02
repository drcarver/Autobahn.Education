//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefSchoolImprovementStatusEntity.g.cs
//* Name:       School Improvement Status
//* Definition: An indication of the improvement stage of the school.
//***************************************************************************

/// <summary>
/// School Improvement Status <see cref="RefSchoolImprovementStatus"/>
/// <para>
/// An indication of the improvement stage of the school.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19240">School Improvement Status</a>
/// </para>
/// </summary>
[Table("RefSchoolImprovementStatus", Schema = "Common")]
[Comment("An indication of the improvement stage of the school.")]
public partial class RefSchoolImprovementStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
