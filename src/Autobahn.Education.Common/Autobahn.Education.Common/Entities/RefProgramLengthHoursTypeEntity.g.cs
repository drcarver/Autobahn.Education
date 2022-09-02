//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefProgramLengthHoursTypeEntity.g.cs
//* Name:       Program Length Hours Type
//* Definition: The type of hours (credit or contact) by which the normal length of a program of study is measured.
//***************************************************************************

/// <summary>
/// Program Length Hours Type <see cref="RefProgramLengthHoursType"/>
/// <para>
/// The type of hours (credit or contact) by which the normal length of a program of study is measured.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19224">Program Length Hours Type</a>
/// </para>
/// </summary>
[Table("RefProgramLengthHoursType", Schema = "Common")]
[Comment("The type of hours (credit or contact) by which the normal length of a program of study is measured.")]
public partial class RefProgramLengthHoursTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
