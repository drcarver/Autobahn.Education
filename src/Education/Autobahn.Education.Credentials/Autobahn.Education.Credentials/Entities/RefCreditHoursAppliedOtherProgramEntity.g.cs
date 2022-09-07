//***************************************************************************
//* DomainName: Credentials
//* FileName:   RefCreditHoursAppliedOtherProgramEntity.g.cs
//* Name:       Credit Hours Applied Other Program
//* Definition: Codes identifying the set of credit hours taken in other programs or degrees that were applied to the individual's degree.
//***************************************************************************

/// <summary>
/// Credit Hours Applied Other Program <see cref="RefCreditHoursAppliedOtherProgram"/>
/// <para>
/// Codes identifying the set of credit hours taken in other programs or degrees that were applied to the individual's degree.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20283">Credit Hours Applied Other Program</a>
/// </para>
/// </summary>
[Table("RefCreditHoursAppliedOtherProgram", Schema = "Credentials")]
[Comment("Codes identifying the set of credit hours taken in other programs or degrees that were applied to the individual's degree.")]
public partial class RefCreditHoursAppliedOtherProgramEntity : ReferenceBaseEntity, IReferenceBase
{
}
