//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentItemResponseStatusEntity.g.cs
//* Name:       Assessment Item Response Status
//* Definition: The status of the response for a given item.
//***************************************************************************

/// <summary>
/// Assessment Item Response Status <see cref="RefAssessmentItemResponseStatus"/>
/// <para>
/// The status of the response for a given item.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19396">Assessment Item Response Status</a>
/// </para>
/// </summary>
[Table("RefAssessmentItemResponseStatus", Schema = "Assessments")]
[Comment("The status of the response for a given item.")]
public partial class RefAssessmentItemResponseStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
