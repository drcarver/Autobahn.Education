//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefReferralOutcomeEntity.g.cs
//* Name:       Referral Outcome
//* Definition: The outcome of the referral.
//***************************************************************************

/// <summary>
/// Referral Outcome <see cref="RefReferralOutcome"/>
/// <para>
/// The outcome of the referral.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20454">Referral Outcome</a>
/// </para>
/// </summary>
[Table("RefReferralOutcome", Schema = "Common")]
[Comment("The outcome of the referral.")]
public partial class RefReferralOutcomeEntity : ReferenceBaseEntity, IReferenceBase
{
}
