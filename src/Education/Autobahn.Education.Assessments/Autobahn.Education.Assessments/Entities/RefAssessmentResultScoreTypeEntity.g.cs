//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentResultScoreTypeEntity.g.cs
//* Name:       Assessment Result Score Type
//* Definition: Indicates the purpose for which this assessment score instance was recorded.
//***************************************************************************

/// <summary>
/// Assessment Result Score Type <see cref="RefAssessmentResultScoreType"/>
/// <para>
/// Indicates the purpose for which this assessment score instance was recorded.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20523">Assessment Result Score Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentResultScoreType", Schema = "Assessments")]
[Comment("Indicates the purpose for which this assessment score instance was recorded.")]
public partial class RefAssessmentResultScoreTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
