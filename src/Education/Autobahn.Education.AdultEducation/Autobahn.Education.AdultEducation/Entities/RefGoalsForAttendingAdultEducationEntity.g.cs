//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   RefGoalsForAttendingAdultEducationEntity.g.cs
//* Name:       Goals for Attending Adult Education
//* Definition: A person's reasons for attending an adult education class or program.
//***************************************************************************

/// <summary>
/// Goals for Attending Adult Education <see cref="RefGoalsForAttendingAdultEducation"/>
/// <para>
/// A person's reasons for attending an adult education class or program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19767">Goals for Attending Adult Education</a>
/// </para>
/// </summary>
[Table("RefGoalsForAttendingAdultEducation", Schema = "AdultEducation")]
[Comment("A person's reasons for attending an adult education class or program.")]
public partial class RefGoalsForAttendingAdultEducationEntity : ReferenceBaseEntity, IReferenceBase
{
}
