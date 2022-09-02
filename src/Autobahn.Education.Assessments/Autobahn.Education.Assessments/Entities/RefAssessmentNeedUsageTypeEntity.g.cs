//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentNeedUsageTypeEntity.g.cs
//* Name:       Assessment Need Usage Type
//* Definition: Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
//***************************************************************************

/// <summary>
/// Assessment Need Usage Type <see cref="RefAssessmentNeedUsageType"/>
/// <para>
/// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20028">Assessment Need Usage Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentNeedUsageType", Schema = "Assessments")]
[Comment("Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.")]
public partial class RefAssessmentNeedUsageTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
