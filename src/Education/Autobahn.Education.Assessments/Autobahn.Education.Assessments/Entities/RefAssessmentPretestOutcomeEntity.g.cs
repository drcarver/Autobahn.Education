//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentPretestOutcomeEntity.g.cs
//* Name:       Assessment Result Pretest Outcome
//* Definition: The results of a pre-test in academic subjects.
//***************************************************************************

/// <summary>
/// Assessment Result Pretest Outcome <see cref="RefAssessmentPretestOutcome"/>
/// <para>
/// The results of a pre-test in academic subjects.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19564">Assessment Result Pretest Outcome</a>
/// </para>
/// </summary>
[Table("RefAssessmentPretestOutcome", Schema = "Assessments")]
[Comment("The results of a pre-test in academic subjects.")]
public partial class RefAssessmentPretestOutcomeEntity : ReferenceBaseEntity, IReferenceBase
{
}
