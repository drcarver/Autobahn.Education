//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentPlatformTypeEntity.g.cs
//* Name:       Assessment Participant Session Platform Type
//* Definition: The platform with which the assessment was delivered to the student during the assessment session.
//***************************************************************************

/// <summary>
/// Assessment Participant Session Platform Type <see cref="RefAssessmentPlatformType"/>
/// <para>
/// The platform with which the assessment was delivered to the student during the assessment session.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19377">Assessment Participant Session Platform Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentPlatformType", Schema = "Assessments")]
[Comment("The platform with which the assessment was delivered to the student during the assessment session.")]
public partial class RefAssessmentPlatformTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
