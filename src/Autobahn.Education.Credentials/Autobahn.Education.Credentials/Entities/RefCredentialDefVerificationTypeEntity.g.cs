//***************************************************************************
//* DomainName: Credentials
//* FileName:   RefCredentialDefVerificationTypeEntity.g.cs
//* Name:       Credential Definition Verification Type
//* Definition: A resource describing the means by which someone can verify whether a credential has been attained by a person.
//***************************************************************************

/// <summary>
/// Credential Definition Verification Type <see cref="RefCredentialDefVerificationType"/>
/// <para>
/// A resource describing the means by which someone can verify whether a credential has been attained by a person.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20734">Credential Definition Verification Type</a>
/// </para>
/// </summary>
[Table("RefCredentialDefVerificationType", Schema = "Credentials")]
[Comment("A resource describing the means by which someone can verify whether a credential has been attained by a person.")]
public partial class RefCredentialDefVerificationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
