//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCurriculumFrameworkTypeEntity.g.cs
//* Name:       Curriculum Framework Type
//* Definition: An indication of the standard curriculum used for this course.
//***************************************************************************

/// <summary>
/// Curriculum Framework Type <see cref="RefCurriculumFrameworkType"/>
/// <para>
/// An indication of the standard curriculum used for this course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19688">Curriculum Framework Type</a>
/// </para>
/// </summary>
[Table("RefCurriculumFrameworkType", Schema = "Common")]
[Comment("An indication of the standard curriculum used for this course.")]
public partial class RefCurriculumFrameworkTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
