//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefCourseApplicableEducationLevelEntity.g.cs
//* Name:       Course Applicable Education Level
//* Definition: The education level, grade level or primary instructional level at which a course is intended.
//***************************************************************************

/// <summary>
/// Course Applicable Education Level <see cref="RefCourseApplicableEducationLevel"/>
/// <para>
/// The education level, grade level or primary instructional level at which a course is intended.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20267">Course Applicable Education Level</a>
/// </para>
/// </summary>
[Table("RefCourseApplicableEducationLevel", Schema = "EarlyLearning")]
[Comment("The education level, grade level or primary instructional level at which a course is intended.")]
public partial class RefCourseApplicableEducationLevelEntity : ReferenceBaseEntity, IReferenceBase
{
}
