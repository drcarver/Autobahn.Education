//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefCredentialTypeEntity.g.cs
//* Name:       Credential Type
//* Definition: An indication of the category of credential a person holds.
//***************************************************************************

/// <summary>
/// Credential Type <see cref="RefCredentialType"/>
/// <para>
/// An indication of the category of credential a person holds.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19071">Credential Type</a>
/// </para>
/// </summary>
[Table("RefCredentialType", Schema = "Person")]
[Comment("An indication of the category of credential a person holds.")]
public partial class RefCredentialTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
