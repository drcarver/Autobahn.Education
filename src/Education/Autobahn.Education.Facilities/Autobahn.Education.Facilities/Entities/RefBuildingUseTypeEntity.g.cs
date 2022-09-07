//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingUseTypeEntity.g.cs
//* Name:       Building Use Type
//* Definition: How a building is principally used, regardless of its original design.
//***************************************************************************

/// <summary>
/// Building Use Type <see cref="RefBuildingUseType"/>
/// <para>
/// How a building is principally used, regardless of its original design.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20173">Building Use Type</a>
/// </para>
/// </summary>
[Table("RefBuildingUseType", Schema = "Facilities")]
[Comment("How a building is principally used, regardless of its original design.")]
public partial class RefBuildingUseTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
