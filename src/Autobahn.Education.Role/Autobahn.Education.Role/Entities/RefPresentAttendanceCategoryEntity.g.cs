//***************************************************************************
//* DomainName: Role Models
//* FileName:   RefPresentAttendanceCategoryEntity.g.cs
//* Name:       Present Attendance Category
//* Definition: The category that describes how the student spends his or her time when attending an instructional program approved by the state and/or school.
//***************************************************************************

/// <summary>
/// Present Attendance Category <see cref="RefPresentAttendanceCategory"/>
/// <para>
/// The category that describes how the student spends his or her time when attending an instructional program approved by the state and/or school.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19593">Present Attendance Category</a>
/// </para>
/// </summary>
[Table("RefPresentAttendanceCategory", Schema = "Role")]
[Comment("The category that describes how the student spends his or her time when attending an instructional program approved by the state and/or school.")]
public partial class RefPresentAttendanceCategoryEntity : ReferenceBaseEntity, IReferenceBase
{
}
