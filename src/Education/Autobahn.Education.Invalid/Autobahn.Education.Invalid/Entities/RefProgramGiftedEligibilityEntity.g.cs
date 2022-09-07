//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefProgramGiftedEligibilityEntity.g.cs
//* Name:       Program Gifted Eligibility Criteria
//* Definition: State/local code used to determine a student's eligibility for Gifted/Talented program.
//***************************************************************************

/// <summary>
/// Program Gifted Eligibility Criteria <see cref="RefProgramGiftedEligibility"/>
/// <para>
/// State/local code used to determine a student's eligibility for Gifted/Talented program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20210">Program Gifted Eligibility Criteria</a>
/// </para>
/// </summary>
[Table("RefProgramGiftedEligibility", Schema = "Invalid")]
[Comment("State/local code used to determine a student's eligibility for Gifted/Talented program.")]
public partial class RefProgramGiftedEligibilityEntity : ReferenceBaseEntity, IReferenceBase
{
}
