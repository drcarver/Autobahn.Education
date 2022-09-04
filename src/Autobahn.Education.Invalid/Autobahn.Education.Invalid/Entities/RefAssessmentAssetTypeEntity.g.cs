//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefAssessmentAssetTypeEntity.g.cs
//* Name:       Assessment Asset Type
//* Definition: Specifies a predominant type of assessment asset represented by the Learning Resource.  Assessment assets represent any content used to compose an assessment item, is referenced by an item but not part of the item content itself, or is content that is included as part of a section within an assessment form. Assets can be static content such as art work or dynamic assets such as calculators.
//***************************************************************************

/// <summary>
/// Assessment Asset Type <see cref="RefAssessmentAssetType"/>
/// <para>
/// Specifies a predominant type of assessment asset represented by the Learning Resource.  Assessment assets represent any content used to compose an assessment item, is referenced by an item but not part of the item content itself, or is content that is included as part of a section within an assessment form. Assets can be static content such as art work or dynamic assets such as calculators.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20147">Assessment Asset Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentAssetType", Schema = "Invalid")]
[Comment("Specifies a predominant type of assessment asset represented by the Learning Resource.  Assessment assets represent any content used to compose an assessment item, is referenced by an item but not part of the item content itself, or is content that is included as part of a section within an assessment form. Assets can be static content such as art work or dynamic assets such as calculators.")]
public partial class RefAssessmentAssetTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
