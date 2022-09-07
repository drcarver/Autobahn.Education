//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityLeaseAmountCategoryEntity.g.cs
//* Name:       Facility Lease Amount Category
//* Definition: The category of payment that a school must pay to rent the facility that it is in.
//***************************************************************************

/// <summary>
/// Facility Lease Amount Category <see cref="RefFacilityLeaseAmountCategory"/>
/// <para>
/// The category of payment that a school must pay to rent the facility that it is in.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20869">Facility Lease Amount Category</a>
/// </para>
/// </summary>
[Table("RefFacilityLeaseAmountCategory", Schema = "Facilities")]
[Comment("The category of payment that a school must pay to rent the facility that it is in.")]
public partial class RefFacilityLeaseAmountCategoryEntity : ReferenceBaseEntity, IReferenceBase
{
}
