//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCourseSectionAssessmentReportingMethodEntity.g.cs
//* Name:       Course Section Assessment Reporting Method
//* Definition: The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.
//***************************************************************************

/// <summary>
/// Course Section Assessment Reporting Method <see cref="RefCourseSectionAssessmentReportingMethod"/>
/// <para>
/// The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19027">Course Section Assessment Reporting Method</a>
/// </para>
/// </summary>
[Table("RefCourseSectionAssessmentReportingMethod", Schema = "Common")]
[Comment("The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.")]
public partial class RefCourseSectionAssessmentReportingMethodEntity : ReferenceBaseEntity, IReferenceBase
{
}
