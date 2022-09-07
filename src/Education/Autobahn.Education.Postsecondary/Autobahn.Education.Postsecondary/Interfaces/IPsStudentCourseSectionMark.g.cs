//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPsStudentCourseSectionMark.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentCourseSectionMark file
/// </summary>
public partial interface IPsStudentCourseSectionMark
{
    #region "IPsStudentCourseSectionMark Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Course Narrative Explanation Grade
    /// <para>
    /// The narrative of the grade awarded to an individual in an academic course in those cases where a course does not receive a letter or numeric grade included in the grading scale of the Course Academic Grade Qualifier.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20279">Course Narrative Explanation Grade</a>
    /// </para>
    /// </summary>
    System.String CourseNarrativeExplanationGrade { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsStudentSection"/> model
    /// </summary>
    Guid PsStudentSectionId { get; set; }

    /// <summary>
    /// Course Academic Grade Status Code
    /// <para>
    /// Additional information regarding the context of the given grade.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20265">Course Academic Grade Status Code</a>
    /// </para>
    /// </summary>
    Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

    /// <summary>
    /// Student Course Section Grade Narrative
    /// <para>
    /// The narrative of the student performance in a course section as submitted by the instructor.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20552">Student Course Section Grade Narrative</a>
    /// </para>
    /// </summary>
    System.String StudentCourseSectionGradeNarrative { get; set; }

    #endregion
}
