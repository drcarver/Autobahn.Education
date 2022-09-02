//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentNeedSigningTypeEntity.g.cs
//* Name:       Assessment Need Signing Type
//* Definition: Defines as part of an Assessment Personal Needs Profile the type of signing preferred by the user.
//***************************************************************************

/// <summary>
/// Assessment Need Signing Type <see cref="RefAssessmentNeedSigningType"/>
/// <para>
/// Defines as part of an Assessment Personal Needs Profile the type of signing preferred by the user.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20044">Assessment Need Signing Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentNeedSigningType", Schema = "Assessments")]
[Comment("Defines as part of an Assessment Personal Needs Profile the type of signing preferred by the user.")]
public partial class RefAssessmentNeedSigningTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
