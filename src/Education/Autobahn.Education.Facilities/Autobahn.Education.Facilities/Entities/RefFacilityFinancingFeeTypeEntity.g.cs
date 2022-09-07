//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityFinancingFeeTypeEntity.g.cs
//* Name:       Facility Financing Fee Type
//* Definition: The type of fee that one must pay when getting a mortgage.
//***************************************************************************

/// <summary>
/// Facility Financing Fee Type <see cref="RefFacilityFinancingFeeType"/>
/// <para>
/// The type of fee that one must pay when getting a mortgage.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20867">Facility Financing Fee Type</a>
/// </para>
/// </summary>
[Table("RefFacilityFinancingFeeType", Schema = "Facilities")]
[Comment("The type of fee that one must pay when getting a mortgage.")]
public partial class RefFacilityFinancingFeeTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
