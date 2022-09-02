//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCampusTypeEntity.g.cs
//* Name:       Campus Facility Type
//* Definition: The primary purpose for which a campus is designed and/or used.
//***************************************************************************

/// <summary>
/// Campus Facility Type <see cref="RefCampusType"/>
/// <para>
/// The primary purpose for which a campus is designed and/or used.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20878">Campus Facility Type</a>
/// </para>
/// </summary>
[Table("RefCampusType", Schema = "Common")]
[Comment("The primary purpose for which a campus is designed and/or used.")]
public partial class RefCampusTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
