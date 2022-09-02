//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCourseHonorsTypeEntity.g.cs
//* Name:       Course Honors Type
//* Definition: An indication that the course is or can be counted as an honors course.
//***************************************************************************

/// <summary>
/// Course Honors Type <see cref="RefCourseHonorsType"/>
/// <para>
/// An indication that the course is or can be counted as an honors course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20273">Course Honors Type</a>
/// </para>
/// </summary>
[Table("RefCourseHonorsType", Schema = "Common")]
[Comment("An indication that the course is or can be counted as an honors course.")]
public partial class RefCourseHonorsTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
