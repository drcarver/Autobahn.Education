//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefClassroomPositionTypeEntity.g.cs
//* Name:       Classroom Position Type
//* Definition: The type of position the staff member holds in the specific course section.
//***************************************************************************

/// <summary>
/// Classroom Position Type <see cref="RefClassroomPositionType"/>
/// <para>
/// The type of position the staff member holds in the specific course section.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19615">Classroom Position Type</a>
/// </para>
/// </summary>
[Table("RefClassroomPositionType", Schema = "Common")]
[Comment("The type of position the staff member holds in the specific course section.")]
public partial class RefClassroomPositionTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
