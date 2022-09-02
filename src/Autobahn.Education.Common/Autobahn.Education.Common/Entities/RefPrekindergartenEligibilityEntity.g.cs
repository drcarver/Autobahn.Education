//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefPrekindergartenEligibilityEntity.g.cs
//* Name:       Prekindergarten Eligibility
//* Definition: The groups of students for whom pre-kindergarten programs are available.
//***************************************************************************

/// <summary>
/// Prekindergarten Eligibility <see cref="RefPrekindergartenEligibility"/>
/// <para>
/// The groups of students for whom pre-kindergarten programs are available.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19216">Prekindergarten Eligibility</a>
/// </para>
/// </summary>
[Table("RefPrekindergartenEligibility", Schema = "Common")]
[Comment("The groups of students for whom pre-kindergarten programs are available.")]
public partial class RefPrekindergartenEligibilityEntity : ReferenceBaseEntity, IReferenceBase
{
}
