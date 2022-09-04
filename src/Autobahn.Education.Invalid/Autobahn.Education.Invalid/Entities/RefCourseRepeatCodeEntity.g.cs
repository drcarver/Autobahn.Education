//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefCourseRepeatCodeEntity.g.cs
//* Name:       Course Repeat Code
//* Definition: Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student's academic grade average.
//***************************************************************************

/// <summary>
/// Course Repeat Code <see cref="RefCourseRepeatCode"/>
/// <para>
/// Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student's academic grade average.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19065">Course Repeat Code</a>
/// </para>
/// </summary>
[Table("RefCourseRepeatCode", Schema = "Invalid")]
[Comment("Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student's academic grade average.")]
public partial class RefCourseRepeatCodeEntity : ReferenceBaseEntity, IReferenceBase
{
}
