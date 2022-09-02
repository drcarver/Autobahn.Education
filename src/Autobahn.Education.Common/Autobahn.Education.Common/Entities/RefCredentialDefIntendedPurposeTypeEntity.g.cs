//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCredentialDefIntendedPurposeTypeEntity.g.cs
//* Name:       Credential Definition Intended Purpose Type
//* Definition: The intended type of application of the credential by the holder.
//***************************************************************************

/// <summary>
/// Credential Definition Intended Purpose Type <see cref="RefCredentialDefIntendedPurposeType"/>
/// <para>
/// The intended type of application of the credential by the holder.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20730">Credential Definition Intended Purpose Type</a>
/// </para>
/// </summary>
[Table("RefCredentialDefIntendedPurposeType", Schema = "Common")]
[Comment("The intended type of application of the credential by the holder.")]
public partial class RefCredentialDefIntendedPurposeTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
