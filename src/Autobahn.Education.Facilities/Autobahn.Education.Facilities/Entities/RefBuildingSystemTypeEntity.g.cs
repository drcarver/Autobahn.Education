//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingSystemTypeEntity.g.cs
//* Name:       Building System Type
//* Definition: The type of system that is installed in the building or site.
//***************************************************************************

/// <summary>
/// Building System Type <see cref="RefBuildingSystemType"/>
/// <para>
/// The type of system that is installed in the building or site.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20792">Building System Type</a>
/// </para>
/// </summary>
[Table("RefBuildingSystemType", Schema = "Facilities")]
[Comment("The type of system that is installed in the building or site.")]
public partial class RefBuildingSystemTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
