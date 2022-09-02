//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingFireProtectionSystemTypeEntity.g.cs
//* Name:       Building Fire Protection System Type
//* Definition: The type of system that protects the facility against fire.
//***************************************************************************

/// <summary>
/// Building Fire Protection System Type <see cref="RefBuildingFireProtectionSystemType"/>
/// <para>
/// The type of system that protects the facility against fire.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20779">Building Fire Protection System Type</a>
/// </para>
/// </summary>
[Table("RefBuildingFireProtectionSystemType", Schema = "Facilities")]
[Comment("The type of system that protects the facility against fire.")]
public partial class RefBuildingFireProtectionSystemTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
