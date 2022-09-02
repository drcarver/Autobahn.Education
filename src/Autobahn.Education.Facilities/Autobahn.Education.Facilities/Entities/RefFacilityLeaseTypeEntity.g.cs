//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityLeaseTypeEntity.g.cs
//* Name:       Facility Lease Type
//* Definition: The type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.
//***************************************************************************

/// <summary>
/// Facility Lease Type <see cref="RefFacilityLeaseType"/>
/// <para>
/// The type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20870">Facility Lease Type</a>
/// </para>
/// </summary>
[Table("RefFacilityLeaseType", Schema = "Facilities")]
[Comment("The type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.")]
public partial class RefFacilityLeaseTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
