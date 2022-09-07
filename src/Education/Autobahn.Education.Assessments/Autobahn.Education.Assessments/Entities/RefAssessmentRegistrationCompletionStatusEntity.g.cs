//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentRegistrationCompletionStatusEntity.g.cs
//* Name:       Assessment Registration Completion Status
//* Definition: The completion and scoring status for an instance of a person taking an assessment.
//***************************************************************************

/// <summary>
/// Assessment Registration Completion Status <see cref="RefAssessmentRegistrationCompletionStatus"/>
/// <para>
/// The completion and scoring status for an instance of a person taking an assessment.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20516">Assessment Registration Completion Status</a>
/// </para>
/// </summary>
[Table("RefAssessmentRegistrationCompletionStatus", Schema = "Assessments")]
[Comment("The completion and scoring status for an instance of a person taking an assessment.")]
public partial class RefAssessmentRegistrationCompletionStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
