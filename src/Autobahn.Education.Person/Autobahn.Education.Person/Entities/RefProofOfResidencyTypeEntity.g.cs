//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefProofOfResidencyTypeEntity.g.cs
//* Name:       Proof of Residency Type
//* Definition: An accepted form of proof of residency in the district/county/other locality.
//***************************************************************************

/// <summary>
/// Proof of Residency Type <see cref="RefProofOfResidencyType"/>
/// <para>
/// An accepted form of proof of residency in the district/county/other locality.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19305">Proof of Residency Type</a>
/// </para>
/// </summary>
[Table("RefProofOfResidencyType", Schema = "Person")]
[Comment("An accepted form of proof of residency in the district/county/other locality.")]
public partial class RefProofOfResidencyTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
