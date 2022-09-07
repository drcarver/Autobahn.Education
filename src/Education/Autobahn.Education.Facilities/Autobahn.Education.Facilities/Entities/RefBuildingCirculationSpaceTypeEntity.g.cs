//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingCirculationSpaceTypeEntity.g.cs
//* Name:       Building Circulation Space Type
//* Definition: A space designed to enable people to move within the building.
//***************************************************************************

/// <summary>
/// Building Circulation Space Type <see cref="RefBuildingCirculationSpaceType"/>
/// <para>
/// A space designed to enable people to move within the building.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20799">Building Circulation Space Type</a>
/// </para>
/// </summary>
[Table("RefBuildingCirculationSpaceType", Schema = "Facilities")]
[Comment("A space designed to enable people to move within the building.")]
public partial class RefBuildingCirculationSpaceTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
