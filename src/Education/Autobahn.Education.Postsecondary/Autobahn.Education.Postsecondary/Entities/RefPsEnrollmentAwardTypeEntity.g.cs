//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   RefPsEnrollmentAwardTypeEntity.g.cs
//* Name:       Enrollment in Postsecondary Award Type
//* Definition: An indicator of the award level in which the person is currently enrolled.
//***************************************************************************

/// <summary>
/// Enrollment in Postsecondary Award Type <see cref="RefPsEnrollmentAwardType"/>
/// <para>
/// An indicator of the award level in which the person is currently enrolled.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19360">Enrollment in Postsecondary Award Type</a>
/// </para>
/// </summary>
[Table("RefPsEnrollmentAwardType", Schema = "Postsecondary")]
[Comment("An indicator of the award level in which the person is currently enrolled.")]
public partial class RefPsEnrollmentAwardTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
