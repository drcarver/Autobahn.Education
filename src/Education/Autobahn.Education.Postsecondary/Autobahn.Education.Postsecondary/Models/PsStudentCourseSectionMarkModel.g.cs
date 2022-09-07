//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCourseSectionMarkEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentCourseSectionMark file
/// </summary>
public partial class PsStudentCourseSectionMarkModel : AutobahnBaseModel, IPsStudentCourseSectionMark
{
    #region "IPsStudentCourseSectionMark Properties"
    /// <summary>
    /// Course Narrative Explanation Grade
    /// <para>
    /// The narrative of the grade awarded to an individual in an academic course in those cases where a course does not receive a letter or numeric grade included in the grading scale of the Course Academic Grade Qualifier.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20279">Course Narrative Explanation Grade</a>
    /// </para>
    /// </summary>
    public System.String CourseNarrativeExplanationGrade { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsStudentSection"/> model
    /// </summary>
    public Guid PsStudentSectionId { get; set; }

    /// <summary>
    /// Course Academic Grade Status Code
    /// <para>
    /// Additional information regarding the context of the given grade.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20265">Course Academic Grade Status Code</a>
    /// </para>
    /// </summary>
    public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

    /// <summary>
    /// Student Course Section Grade Narrative
    /// <para>
    /// The narrative of the student performance in a course section as submitted by the instructor.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20552">Student Course Section Grade Narrative</a>
    /// </para>
    /// </summary>
    public System.String StudentCourseSectionGradeNarrative { get; set; }

    #endregion
}
