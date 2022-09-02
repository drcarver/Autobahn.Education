//***************************************************************************
//* DomainName: Common Models
//* FileName:   ICourseSectionAssessmentReporting.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionAssessmentReporting file
/// </summary>
public partial interface ICourseSectionAssessmentReporting
{
    #region "ICourseSectionAssessmentReporting Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    Guid? CourseSectionId { get; set; }

    /// <summary>
    /// Course Section Assessment Reporting Method
    /// <para>
    /// The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19027">Course Section Assessment Reporting Method</a>
    /// </para>
    /// </summary>
    Guid? RefCourseSectionAssessmentReportingMethodId { get; set; }

    #endregion
}
