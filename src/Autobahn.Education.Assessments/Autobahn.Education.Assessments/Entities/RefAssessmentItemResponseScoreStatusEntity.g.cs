//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentItemResponseScoreStatusEntity.g.cs
//* Name:       Assessment Item Response Score Status
//* Definition: The status of scoring a person's response to an assessment item.
//***************************************************************************

/// <summary>
/// Assessment Item Response Score Status <see cref="RefAssessmentItemResponseScoreStatus"/>
/// <para>
/// The status of scoring a person's response to an assessment item.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20513">Assessment Item Response Score Status</a>
/// </para>
/// </summary>
[Table("RefAssessmentItemResponseScoreStatus", Schema = "Assessments")]
[Comment("The status of scoring a person's response to an assessment item.")]
public partial class RefAssessmentItemResponseScoreStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
