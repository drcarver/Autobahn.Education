//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefFirearmTypeEntity.g.cs
//* Name:       Firearm Type
//* Definition: The type of firearm.
//***************************************************************************

/// <summary>
/// Firearm Type <see cref="RefFirearmType"/>
/// <para>
/// The type of firearm.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19548">Firearm Type</a>
/// </para>
/// </summary>
[Table("RefFirearmType", Schema = "Invalid")]
[Comment("The type of firearm.")]
public partial class RefFirearmTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
