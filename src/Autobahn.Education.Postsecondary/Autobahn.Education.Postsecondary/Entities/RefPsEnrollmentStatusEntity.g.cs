//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   RefPsEnrollmentStatusEntity.g.cs
//* Name:       Postsecondary Enrollment Status
//* Definition: An indication of the student's enrollment status for a particular term as defined by the institution
//***************************************************************************

/// <summary>
/// Postsecondary Enrollment Status <see cref="RefPsEnrollmentStatus"/>
/// <para>
/// An indication of the student's enrollment status for a particular term as defined by the institution
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19096">Postsecondary Enrollment Status</a>
/// </para>
/// </summary>
[Table("RefPsEnrollmentStatus", Schema = "Postsecondary")]
[Comment("An indication of the student's enrollment status for a particular term as defined by the institution")]
public partial class RefPsEnrollmentStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
