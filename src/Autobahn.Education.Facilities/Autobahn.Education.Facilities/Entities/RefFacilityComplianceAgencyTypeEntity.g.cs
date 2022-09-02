//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityComplianceAgencyTypeEntity.g.cs
//* Name:       Facility Compliance Agency Type
//* Definition: The type of agency that has ultimate responsibility for the compliance determination.
//***************************************************************************

/// <summary>
/// Facility Compliance Agency Type <see cref="RefFacilityComplianceAgencyType"/>
/// <para>
/// The type of agency that has ultimate responsibility for the compliance determination.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20848">Facility Compliance Agency Type</a>
/// </para>
/// </summary>
[Table("RefFacilityComplianceAgencyType", Schema = "Facilities")]
[Comment("The type of agency that has ultimate responsibility for the compliance determination.")]
public partial class RefFacilityComplianceAgencyTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
