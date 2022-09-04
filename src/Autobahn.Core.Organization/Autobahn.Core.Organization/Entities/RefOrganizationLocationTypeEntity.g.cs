//***************************************************************************
//* DomainName: Organization Models
//* FileName:   RefOrganizationLocationTypeEntity.g.cs
//* Name:       Address Type for Organization
//* Definition: The type of address listed for an organization.
//***************************************************************************

/// <summary>
/// Address Type for Organization <see cref="RefOrganizationLocationType"/>
/// <para>
/// The type of address listed for an organization.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19644">Address Type for Organization</a>
/// </para>
/// </summary>
[Table("RefOrganizationLocationType", Schema = "Autobahn.Core.Organization")]
[Comment("The type of address listed for an organization.")]
public partial class RefOrganizationLocationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
