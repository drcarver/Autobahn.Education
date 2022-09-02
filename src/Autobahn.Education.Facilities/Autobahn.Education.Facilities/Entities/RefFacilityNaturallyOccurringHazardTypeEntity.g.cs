//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityNaturallyOccurringHazardTypeEntity.g.cs
//* Name:       Facility Naturally Occurring Hazard Type
//* Definition: Type of natural hazard that can affect the health, safety and operation of school facilities and their occupants.
//***************************************************************************

/// <summary>
/// Facility Naturally Occurring Hazard Type <see cref="RefFacilityNaturallyOccurringHazardType"/>
/// <para>
/// Type of natural hazard that can affect the health, safety and operation of school facilities and their occupants.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20858">Facility Naturally Occurring Hazard Type</a>
/// </para>
/// </summary>
[Table("RefFacilityNaturallyOccurringHazardType", Schema = "Facilities")]
[Comment("Type of natural hazard that can affect the health, safety and operation of school facilities and their occupants.")]
public partial class RefFacilityNaturallyOccurringHazardTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
