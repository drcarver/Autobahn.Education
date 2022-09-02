//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCredentialDefStatusTypeEntity.g.cs
//* Name:       Credential Definition Status Type
//* Definition: The status of the credential offered by a credentialing organization.
//***************************************************************************

/// <summary>
/// Credential Definition Status Type <see cref="RefCredentialDefStatusType"/>
/// <para>
/// The status of the credential offered by a credentialing organization.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20721">Credential Definition Status Type</a>
/// </para>
/// </summary>
[Table("RefCredentialDefStatusType", Schema = "Common")]
[Comment("The status of the credential offered by a credentialing organization.")]
public partial class RefCredentialDefStatusTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
