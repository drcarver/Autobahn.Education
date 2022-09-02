//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTeacherPrepEnrollmentStatusEntity.g.cs
//* Name:       Teacher Preparation Program Enrollment Status
//* Definition: An indication of whether a person is pursuing certification as a teacher.
//***************************************************************************

/// <summary>
/// Teacher Preparation Program Enrollment Status <see cref="RefTeacherPrepEnrollmentStatus"/>
/// <para>
/// An indication of whether a person is pursuing certification as a teacher.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19749">Teacher Preparation Program Enrollment Status</a>
/// </para>
/// </summary>
[Table("RefTeacherPrepEnrollmentStatus", Schema = "Common")]
[Comment("An indication of whether a person is pursuing certification as a teacher.")]
public partial class RefTeacherPrepEnrollmentStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
