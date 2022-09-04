//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefAssessmentTypeEntity.g.cs
//* Name:       Assessment Type
//* Definition: The category of an assessment based on format and content.
//***************************************************************************

/// <summary>
/// Assessment Type <see cref="RefAssessmentType"/>
/// <para>
/// The category of an assessment based on format and content.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19029">Assessment Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentType", Schema = "Invalid")]
[Comment("The category of an assessment based on format and content.")]
public partial class RefAssessmentTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
