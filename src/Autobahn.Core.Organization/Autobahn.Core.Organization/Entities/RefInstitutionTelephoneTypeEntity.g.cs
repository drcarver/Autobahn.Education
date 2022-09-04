//***************************************************************************
//* DomainName: Organization Models
//* FileName:   RefInstitutionTelephoneTypeEntity.g.cs
//* Name:       Institution Telephone Number Type
//* Definition: The type of communication number listed for an organization.
//***************************************************************************

/// <summary>
/// Institution Telephone Number Type <see cref="RefInstitutionTelephoneType"/>
/// <para>
/// The type of communication number listed for an organization.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19167">Institution Telephone Number Type</a>
/// </para>
/// </summary>
[Table("RefInstitutionTelephoneType", Schema = "Autobahn.Core.Organization")]
[Comment("The type of communication number listed for an organization.")]
public partial class RefInstitutionTelephoneTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
