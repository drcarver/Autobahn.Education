//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingFoodServiceSpaceTypeEntity.g.cs
//* Name:       Building Food Service Space Type
//* Definition: The space located, designed, furnished and equipped to support meal programs.
//***************************************************************************

/// <summary>
/// Building Food Service Space Type <see cref="RefBuildingFoodServiceSpaceType"/>
/// <para>
/// The space located, designed, furnished and equipped to support meal programs.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20802">Building Food Service Space Type</a>
/// </para>
/// </summary>
[Table("RefBuildingFoodServiceSpaceType", Schema = "Facilities")]
[Comment("The space located, designed, furnished and equipped to support meal programs.")]
public partial class RefBuildingFoodServiceSpaceTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
