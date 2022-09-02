//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAssessmentPurposeEntity.g.cs
//* Name:       Assessment Purpose
//* Definition: The reason for which an assessment is designed or delivered.
//***************************************************************************

/// <summary>
/// Assessment Purpose <see cref="RefAssessmentPurpose"/>
/// <para>
/// The reason for which an assessment is designed or delivered.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19026">Assessment Purpose</a>
/// </para>
/// </summary>
[Table("RefAssessmentPurpose", Schema = "Common")]
[Comment("The reason for which an assessment is designed or delivered.")]
public partial class RefAssessmentPurposeEntity : ReferenceBaseEntity, IReferenceBase
{
}
