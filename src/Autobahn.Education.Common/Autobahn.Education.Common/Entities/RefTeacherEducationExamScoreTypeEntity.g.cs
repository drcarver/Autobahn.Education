//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTeacherEducationExamScoreTypeEntity.g.cs
//* Name:       Teacher Education Credential Exam Score Type
//* Definition: An indication of the type of credential exam associated with a given exam score.
//***************************************************************************

/// <summary>
/// Teacher Education Credential Exam Score Type <see cref="RefTeacherEducationExamScoreType"/>
/// <para>
/// An indication of the type of credential exam associated with a given exam score.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19757">Teacher Education Credential Exam Score Type</a>
/// </para>
/// </summary>
[Table("RefTeacherEducationExamScoreType", Schema = "Common")]
[Comment("An indication of the type of credential exam associated with a given exam score.")]
public partial class RefTeacherEducationExamScoreTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
