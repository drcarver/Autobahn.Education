//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefPrimaryLearningDeviceAwayFromSchoolEntity.g.cs
//* Name:       Primary Learning Device Away From School
//* Definition: The type of device the student uses most often to complete learning activities away from school.
//***************************************************************************

/// <summary>
/// Primary Learning Device Away From School <see cref="RefPrimaryLearningDeviceAwayFromSchool"/>
/// <para>
/// The type of device the student uses most often to complete learning activities away from school.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20953">Primary Learning Device Away From School</a>
/// </para>
/// </summary>
[Table("RefPrimaryLearningDeviceAwayFromSchool", Schema = "Person")]
[Comment("The type of device the student uses most often to complete learning activities away from school.")]
public partial class RefPrimaryLearningDeviceAwayFromSchoolEntity : ReferenceBaseEntity, IReferenceBase
{
}
