//***************************************************************************
//* DomainName: Role Models
//* FileName:   RefRoleEntity.g.cs
//* Name:       Role
//* Definition: A description of the way in which a person relates to an organization.
//***************************************************************************

/// <summary>
/// Role <see cref="RefRole"/>
/// <para>
/// A description of the way in which a person relates to an organization.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20959">Role</a>
/// </para>
/// </summary>
[Table("RefRole", Schema = "Autobahn.Core.Role")]
[Comment("A description of the way in which a person relates to an organization.")]
public partial class RefRoleEntity : ReferenceBaseEntity, IReferenceBase
{
}
