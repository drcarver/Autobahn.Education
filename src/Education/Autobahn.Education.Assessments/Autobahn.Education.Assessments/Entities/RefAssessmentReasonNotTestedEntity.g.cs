//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentReasonNotTestedEntity.g.cs
//* Name:       Reason Not Tested
//* Definition: The primary reason a student is not tested.
//***************************************************************************

/// <summary>
/// Reason Not Tested <see cref="RefAssessmentReasonNotTested"/>
/// <para>
/// The primary reason a student is not tested.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19228">Reason Not Tested</a>
/// </para>
/// </summary>
[Table("RefAssessmentReasonNotTested", Schema = "Assessments")]
[Comment("The primary reason a student is not tested.")]
public partial class RefAssessmentReasonNotTestedEntity : ReferenceBaseEntity, IReferenceBase
{
}
