//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingElectricalSystemTypeEntity.g.cs
//* Name:       Building Electrical System Type
//* Definition: The components and system required to distribute electricity throughout the building or site.
//***************************************************************************

/// <summary>
/// Building Electrical System Type <see cref="RefBuildingElectricalSystemType"/>
/// <para>
/// The components and system required to distribute electricity throughout the building or site.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20776">Building Electrical System Type</a>
/// </para>
/// </summary>
[Table("RefBuildingElectricalSystemType", Schema = "Facilities")]
[Comment("The components and system required to distribute electricity throughout the building or site.")]
public partial class RefBuildingElectricalSystemTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
