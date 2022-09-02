//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityConstructionDateTypeEntity.g.cs
//* Name:       Facility Construction Date Type
//* Definition: Designation of the nature of the construction completion date.
//***************************************************************************

/// <summary>
/// Facility Construction Date Type <see cref="RefFacilityConstructionDateType"/>
/// <para>
/// Designation of the nature of the construction completion date.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20762">Facility Construction Date Type</a>
/// </para>
/// </summary>
[Table("RefFacilityConstructionDateType", Schema = "Facilities")]
[Comment("Designation of the nature of the construction completion date.")]
public partial class RefFacilityConstructionDateTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
