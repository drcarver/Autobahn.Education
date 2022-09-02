//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCourseSectionEnrollmentStatusTypeEntity.g.cs
//* Name:       Course Section Enrollment Status Type
//* Definition: The status related to a student enrollment in an instance of a course.
//***************************************************************************

/// <summary>
/// Course Section Enrollment Status Type <see cref="RefCourseSectionEnrollmentStatusType"/>
/// <para>
/// The status related to a student enrollment in an instance of a course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19977">Course Section Enrollment Status Type</a>
/// </para>
/// </summary>
[Table("RefCourseSectionEnrollmentStatusType", Schema = "Common")]
[Comment("The status related to a student enrollment in an instance of a course.")]
public partial class RefCourseSectionEnrollmentStatusTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
