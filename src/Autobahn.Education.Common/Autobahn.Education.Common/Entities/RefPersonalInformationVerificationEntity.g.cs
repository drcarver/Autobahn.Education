//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefPersonalInformationVerificationEntity.g.cs
//* Name:       Personal Information Verification
//* Definition: The evidence by which a persons name, address, date of birth, etc. is confirmed.
//***************************************************************************

/// <summary>
/// Personal Information Verification <see cref="RefPersonalInformationVerification"/>
/// <para>
/// The evidence by which a persons name, address, date of birth, etc. is confirmed.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
/// </para>
/// </summary>
[Table("RefPersonalInformationVerification", Schema = "Common")]
[Comment("The evidence by which a persons name, address, date of birth, etc. is confirmed.")]
public partial class RefPersonalInformationVerificationEntity : ReferenceBaseEntity, IReferenceBase
{
}
