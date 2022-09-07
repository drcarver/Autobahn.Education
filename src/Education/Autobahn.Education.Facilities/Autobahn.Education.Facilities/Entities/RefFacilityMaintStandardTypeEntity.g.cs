//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityMaintStandardTypeEntity.g.cs
//* Name:       Facility Maintenance Standard Type
//* Definition: The standard for maintenance of a component, system, or building.
//***************************************************************************

/// <summary>
/// Facility Maintenance Standard Type <see cref="RefFacilityMaintStandardType"/>
/// <para>
/// The standard for maintenance of a component, system, or building.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20857">Facility Maintenance Standard Type</a>
/// </para>
/// </summary>
[Table("RefFacilityMaintStandardType", Schema = "Facilities")]
[Comment("The standard for maintenance of a component, system, or building.")]
public partial class RefFacilityMaintStandardTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
