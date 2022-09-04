//***************************************************************************
//* DomainName: Role Models
//* FileName:   RefAbsentAttendanceCategoryEntity.g.cs
//* Name:       Absent Attendance Category
//* Definition:  The category that describes how the student spends his or her time not physically present on school grounds and not participating in instruction or instruction-related activities at an approved off-grounds location.
//***************************************************************************

/// <summary>
/// Absent Attendance Category <see cref="RefAbsentAttendanceCategory"/>
/// <para>
///  The category that describes how the student spends his or her time not physically present on school grounds and not participating in instruction or instruction-related activities at an approved off-grounds location.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19592">Absent Attendance Category</a>
/// </para>
/// </summary>
[Table("RefAbsentAttendanceCategory", Schema = "Role")]
[Comment(" The category that describes how the student spends his or her time not physically present on school grounds and not participating in instruction or instruction-related activities at an approved off-grounds location.")]
public partial class RefAbsentAttendanceCategoryEntity : ReferenceBaseEntity, IReferenceBase
{
}
