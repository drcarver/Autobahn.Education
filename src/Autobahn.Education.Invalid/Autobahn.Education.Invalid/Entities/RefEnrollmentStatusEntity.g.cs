//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefEnrollmentStatusEntity.g.cs
//* Name:       Enrollment Status
//* Definition: An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
//***************************************************************************

/// <summary>
/// Enrollment Status <see cref="RefEnrollmentStatus"/>
/// <para>
/// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19094">Enrollment Status</a>
/// </para>
/// </summary>
[Table("RefEnrollmentStatus", Schema = "Invalid")]
[Comment("An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.")]
public partial class RefEnrollmentStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
