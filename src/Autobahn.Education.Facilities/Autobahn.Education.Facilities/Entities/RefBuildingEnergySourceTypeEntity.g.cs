//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingEnergySourceTypeEntity.g.cs
//* Name:       Building Energy Source Type
//* Definition: The source of energy that directly powers a school district facility or building system.
//***************************************************************************

/// <summary>
/// Building Energy Source Type <see cref="RefBuildingEnergySourceType"/>
/// <para>
/// The source of energy that directly powers a school district facility or building system.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20851">Building Energy Source Type</a>
/// </para>
/// </summary>
[Table("RefBuildingEnergySourceType", Schema = "Facilities")]
[Comment("The source of energy that directly powers a school district facility or building system.")]
public partial class RefBuildingEnergySourceTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
