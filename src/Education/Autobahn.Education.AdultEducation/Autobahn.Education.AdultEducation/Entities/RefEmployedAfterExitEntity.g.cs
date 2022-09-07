//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   RefEmployedAfterExitEntity.g.cs
//* Name:       Employed After Exit
//* Definition: An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, after exiting secondary, postsecondary, or adult education or workforce programs.
//***************************************************************************

/// <summary>
/// Employed After Exit <see cref="RefEmployedAfterExit"/>
/// <para>
/// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, after exiting secondary, postsecondary, or adult education or workforce programs.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19990">Employed After Exit</a>
/// </para>
/// </summary>
[Table("RefEmployedAfterExit", Schema = "AdultEducation")]
[Comment("An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, after exiting secondary, postsecondary, or adult education or workforce programs.")]
public partial class RefEmployedAfterExitEntity : ReferenceBaseEntity, IReferenceBase
{
}
