//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityMortgageTypeEntity.g.cs
//* Name:       Facility Mortgage Type
//* Definition: The status of a mortgage as it relates to priority of payment.
//***************************************************************************

/// <summary>
/// Facility Mortgage Type <see cref="RefFacilityMortgageType"/>
/// <para>
/// The status of a mortgage as it relates to priority of payment.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20873">Facility Mortgage Type</a>
/// </para>
/// </summary>
[Table("RefFacilityMortgageType", Schema = "Facilities")]
[Comment("The status of a mortgage as it relates to priority of payment.")]
public partial class RefFacilityMortgageTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
