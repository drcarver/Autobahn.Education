//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefWageVerificationEntity.g.cs
//* Name:       Wage Verification Code
//* Definition: An indication of whether the wage information has been verified.
//***************************************************************************

/// <summary>
/// Wage Verification Code <see cref="RefWageVerification"/>
/// <para>
/// An indication of whether the wage information has been verified.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19818">Wage Verification Code</a>
/// </para>
/// </summary>
[Table("RefWageVerification", Schema = "Invalid")]
[Comment("An indication of whether the wage information has been verified.")]
public partial class RefWageVerificationEntity : ReferenceBaseEntity, IReferenceBase
{
}
