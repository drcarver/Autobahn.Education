//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   RefPsEnrollmentTypeEntity.g.cs
//* Name:       Postsecondary Enrollment Type
//* Definition: An indicator of the enrollment type associated with the enrollment award level of a person at the beginning of a term.
//***************************************************************************

/// <summary>
/// Postsecondary Enrollment Type <see cref="RefPsEnrollmentType"/>
/// <para>
/// An indicator of the enrollment type associated with the enrollment award level of a person at the beginning of a term.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19095">Postsecondary Enrollment Type</a>
/// </para>
/// </summary>
[Table("RefPsEnrollmentType", Schema = "Postsecondary")]
[Comment("An indicator of the enrollment type associated with the enrollment award level of a person at the beginning of a term.")]
public partial class RefPsEnrollmentTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
