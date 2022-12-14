//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefScoreMetricTypeEntity.g.cs
//* Name:       Assessment Score Metric Type
//* Definition: The specific method used to report the performance and achievement of the assessment. This is the metric that is being used to derive the scores.
//***************************************************************************

/// <summary>
/// Assessment Score Metric Type <see cref="RefScoreMetricType"/>
/// <para>
/// The specific method used to report the performance and achievement of the assessment. This is the metric that is being used to derive the scores.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19368">Assessment Score Metric Type</a>
/// </para>
/// </summary>
[Table("RefScoreMetricType", Schema = "Assessments")]
[Comment("The specific method used to report the performance and achievement of the assessment. This is the metric that is being used to derive the scores.")]
public partial class RefScoreMetricTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
