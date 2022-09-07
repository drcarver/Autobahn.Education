//***************************************************************************
//* DomainName: Role Models
//* FileName:   RefAttendanceEventTypeEntity.g.cs
//* Name:       Attendance Event Type
//* Definition: The type of attendance event.
//***************************************************************************

/// <summary>
/// Attendance Event Type <see cref="RefAttendanceEventType"/>
/// <para>
/// The type of attendance event.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19594">Attendance Event Type</a>
/// </para>
/// </summary>
[Table("RefAttendanceEventType", Schema = "Role")]
[Comment("The type of attendance event.")]
public partial class RefAttendanceEventTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
