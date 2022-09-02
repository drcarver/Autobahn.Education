//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentAssetIdentifierTypeEntity.g.cs
//* Name:       Assessment Asset Identifier Type
//* Definition: The type of identifier that is provided for this asset.
//***************************************************************************

/// <summary>
/// Assessment Asset Identifier Type <see cref="RefAssessmentAssetIdentifierType"/>
/// <para>
/// The type of identifier that is provided for this asset.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20150">Assessment Asset Identifier Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentAssetIdentifierType", Schema = "Assessments")]
[Comment("The type of identifier that is provided for this asset.")]
public partial class RefAssessmentAssetIdentifierTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
