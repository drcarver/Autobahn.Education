//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingMechanicalSystemTypeEntity.g.cs
//* Name:       Building Mechanical System Type
//* Definition: The major manufactured systems required to operate a building.
//***************************************************************************

/// <summary>
/// Building Mechanical System Type <see cref="RefBuildingMechanicalSystemType"/>
/// <para>
/// The major manufactured systems required to operate a building.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20790">Building Mechanical System Type</a>
/// </para>
/// </summary>
[Table("RefBuildingMechanicalSystemType", Schema = "Facilities")]
[Comment("The major manufactured systems required to operate a building.")]
public partial class RefBuildingMechanicalSystemTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
