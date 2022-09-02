//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentSessionTypeEntity.g.cs
//* Name:       Assessment Session Type
//* Definition: The type of session that is scheduled.
//***************************************************************************

/// <summary>
/// Assessment Session Type <see cref="RefAssessmentSessionType"/>
/// <para>
/// The type of session that is scheduled.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20020">Assessment Session Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentSessionType", Schema = "Assessments")]
[Comment("The type of session that is scheduled.")]
public partial class RefAssessmentSessionTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
