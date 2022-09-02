//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefGraduateOrDoctoralExamResultsStatusEntity.g.cs
//* Name:       Graduate or Doctoral Exam Results Status
//* Definition: The individual's status in completing exams required for graduate or doctoral degree programs.
//***************************************************************************

/// <summary>
/// Graduate or Doctoral Exam Results Status <see cref="RefGraduateOrDoctoralExamResultsStatus"/>
/// <para>
/// The individual's status in completing exams required for graduate or doctoral degree programs.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20324">Graduate or Doctoral Exam Results Status</a>
/// </para>
/// </summary>
[Table("RefGraduateOrDoctoralExamResultsStatus", Schema = "Common")]
[Comment("The individual's status in completing exams required for graduate or doctoral degree programs.")]
public partial class RefGraduateOrDoctoralExamResultsStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
