//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingSecuritySystemTypeEntity.g.cs
//* Name:       Building Security System Type
//* Definition: The type of system that protects the facility from intrusion.
//***************************************************************************

/// <summary>
/// Building Security System Type <see cref="RefBuildingSecuritySystemType"/>
/// <para>
/// The type of system that protects the facility from intrusion.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20785">Building Security System Type</a>
/// </para>
/// </summary>
[Table("RefBuildingSecuritySystemType", Schema = "Facilities")]
[Comment("The type of system that protects the facility from intrusion.")]
public partial class RefBuildingSecuritySystemTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
