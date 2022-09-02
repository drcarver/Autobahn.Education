//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityFurnishingsTypeEntity.g.cs
//* Name:       Facility Furnishings Type
//* Definition: Moveable assets that are provided so the building or interior assets can be utilized by occupants for their intended purposes.
//***************************************************************************

/// <summary>
/// Facility Furnishings Type <see cref="RefFacilityFurnishingsType"/>
/// <para>
/// Moveable assets that are provided so the building or interior assets can be utilized by occupants for their intended purposes.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20801">Facility Furnishings Type</a>
/// </para>
/// </summary>
[Table("RefFacilityFurnishingsType", Schema = "Facilities")]
[Comment("Moveable assets that are provided so the building or interior assets can be utilized by occupants for their intended purposes.")]
public partial class RefFacilityFurnishingsTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
