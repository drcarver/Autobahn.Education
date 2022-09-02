//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityMortgageInterestTypeEntity.g.cs
//* Name:       Facility Mortgage Interest Type
//* Definition: The type of interest paid on a mortgage to the lender to compensate the lender for the use of money to purchase a building or facility.
//***************************************************************************

/// <summary>
/// Facility Mortgage Interest Type <see cref="RefFacilityMortgageInterestType"/>
/// <para>
/// The type of interest paid on a mortgage to the lender to compensate the lender for the use of money to purchase a building or facility.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20872">Facility Mortgage Interest Type</a>
/// </para>
/// </summary>
[Table("RefFacilityMortgageInterestType", Schema = "Facilities")]
[Comment("The type of interest paid on a mortgage to the lender to compensate the lender for the use of money to purchase a building or facility.")]
public partial class RefFacilityMortgageInterestTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
