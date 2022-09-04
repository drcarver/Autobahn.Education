//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefAcademicHonorTypeEntity.g.cs
//* Name:       Academic Honors Type
//* Definition: A designation of the type of academic distinctions earned by or awarded to the student.
//***************************************************************************

/// <summary>
/// Academic Honors Type <see cref="RefAcademicHonorType"/>
/// <para>
/// A designation of the type of academic distinctions earned by or awarded to the student.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19004">Academic Honors Type</a>
/// </para>
/// </summary>
[Table("RefAcademicHonorType", Schema = "Invalid")]
[Comment("A designation of the type of academic distinctions earned by or awarded to the student.")]
public partial class RefAcademicHonorTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
