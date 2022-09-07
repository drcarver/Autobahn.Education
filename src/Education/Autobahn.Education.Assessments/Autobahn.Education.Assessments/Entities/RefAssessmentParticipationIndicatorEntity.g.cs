//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentParticipationIndicatorEntity.g.cs
//* Name:       Assessment Registration Participation Indicator
//* Definition: An indication of whether a student participated in an assessment.
//***************************************************************************

/// <summary>
/// Assessment Registration Participation Indicator <see cref="RefAssessmentParticipationIndicator"/>
/// <para>
/// An indication of whether a student participated in an assessment.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19025">Assessment Registration Participation Indicator</a>
/// </para>
/// </summary>
[Table("RefAssessmentParticipationIndicator", Schema = "Assessments")]
[Comment("An indication of whether a student participated in an assessment.")]
public partial class RefAssessmentParticipationIndicatorEntity : ReferenceBaseEntity, IReferenceBase
{
}
