//***************************************************************************
//* DomainName: Role Models
//* FileName:   RefAttendanceStatusEntity.g.cs
//* Name:       Attendance Status
//* Definition: The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
//***************************************************************************

/// <summary>
/// Attendance Status <see cref="RefAttendanceStatus"/>
/// <para>
/// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19076">Attendance Status</a>
/// </para>
/// </summary>
[Table("RefAttendanceStatus", Schema = "Role")]
[Comment("The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.")]
public partial class RefAttendanceStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
