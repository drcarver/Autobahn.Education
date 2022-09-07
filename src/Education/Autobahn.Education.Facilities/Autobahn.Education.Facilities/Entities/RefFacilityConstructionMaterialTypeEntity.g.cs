//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityConstructionMaterialTypeEntity.g.cs
//* Name:       Facility Construction Material Type
//* Definition: The primary material used for the construction of a building.
//***************************************************************************

/// <summary>
/// Facility Construction Material Type <see cref="RefFacilityConstructionMaterialType"/>
/// <para>
/// The primary material used for the construction of a building.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20763">Facility Construction Material Type</a>
/// </para>
/// </summary>
[Table("RefFacilityConstructionMaterialType", Schema = "Facilities")]
[Comment("The primary material used for the construction of a building.")]
public partial class RefFacilityConstructionMaterialTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
