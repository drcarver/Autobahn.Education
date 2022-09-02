//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefDevelopmentalEducationReferralStatusEntity.g.cs
//* Name:       Developmental Education Referral Status
//* Definition: The status of a student's referral to or placement into  developmental education.
//***************************************************************************

/// <summary>
/// Developmental Education Referral Status <see cref="RefDevelopmentalEducationReferralStatus"/>
/// <para>
/// The status of a student's referral to or placement into  developmental education.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20567">Developmental Education Referral Status</a>
/// </para>
/// </summary>
[Table("RefDevelopmentalEducationReferralStatus", Schema = "Common")]
[Comment("The status of a student's referral to or placement into  developmental education.")]
public partial class RefDevelopmentalEducationReferralStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
