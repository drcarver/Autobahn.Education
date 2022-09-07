//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingHistoricStatusEntity.g.cs
//* Name:       Building Historic Status
//* Definition: An indication of whether or not a building is eligible to be or has been declared a landmark or historic building.
//***************************************************************************

/// <summary>
/// Building Historic Status <see cref="RefBuildingHistoricStatus"/>
/// <para>
/// An indication of whether or not a building is eligible to be or has been declared a landmark or historic building.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20753">Building Historic Status</a>
/// </para>
/// </summary>
[Table("RefBuildingHistoricStatus", Schema = "Facilities")]
[Comment("An indication of whether or not a building is eligible to be or has been declared a landmark or historic building.")]
public partial class RefBuildingHistoricStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
