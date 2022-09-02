//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefEmployedWhileEnrolledEntity.g.cs
//* Name:       Employed While Enrolled
//* Definition: An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
//***************************************************************************

/// <summary>
/// Employed While Enrolled <see cref="RefEmployedWhileEnrolled"/>
/// <para>
/// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19989">Employed While Enrolled</a>
/// </para>
/// </summary>
[Table("RefEmployedWhileEnrolled", Schema = "Common")]
[Comment("An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.")]
public partial class RefEmployedWhileEnrolledEntity : ReferenceBaseEntity, IReferenceBase
{
}
