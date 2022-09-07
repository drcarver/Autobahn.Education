//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingPrimaryUseTypeEntity.g.cs
//* Name:       Building Primary Use Type
//* Definition: The primary use type of the building in which a school is located.
//***************************************************************************

/// <summary>
/// Building Primary Use Type <see cref="RefBuildingPrimaryUseType"/>
/// <para>
/// The primary use type of the building in which a school is located.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20758">Building Primary Use Type</a>
/// </para>
/// </summary>
[Table("RefBuildingPrimaryUseType", Schema = "Facilities")]
[Comment("The primary use type of the building in which a school is located.")]
public partial class RefBuildingPrimaryUseTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
