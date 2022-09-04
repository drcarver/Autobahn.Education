//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefWeaponTypeEntity.g.cs
//* Name:       Weapon Type
//* Definition: Identifies the type of weapon used during an incident.
//***************************************************************************

/// <summary>
/// Weapon Type <see cref="RefWeaponType"/>
/// <para>
/// Identifies the type of weapon used during an incident.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20178">Weapon Type</a>
/// </para>
/// </summary>
[Table("RefWeaponType", Schema = "Invalid")]
[Comment("Identifies the type of weapon used during an incident.")]
public partial class RefWeaponTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
