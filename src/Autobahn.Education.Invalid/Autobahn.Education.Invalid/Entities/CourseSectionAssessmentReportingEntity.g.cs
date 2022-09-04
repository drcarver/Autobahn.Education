//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   CourseSectionAssessmentReportingEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionAssessmentReporting file
/// </summary>
[Table("CourseSectionAssessmentReporting", Schema = "Invalid")]
public partial class CourseSectionAssessmentReportingEntity : EntityBase, ICourseSectionAssessmentReporting
{
    #region "ICourseSectionAssessmentReporting Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    [ForeignKey("CourseSection")]
    public Guid? CourseSectionId { get; set; }

    /// <summary>
    /// Course Section Assessment Reporting Method
    /// <para>
    /// The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19027">Course Section Assessment Reporting Method</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCourseSectionAssessmentReportingMethod")]
    [Comment("The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.")]
    public Guid? RefCourseSectionAssessmentReportingMethodId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual CourseSectionEntity? CourseSectionEntity { get; set; }

    /// <summary>
    /// The method that the instructor of the course uses to report the performance and achievement of all students. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or a numerical grade. In some cases, more than one type of reporting method may be used.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19027">Course Section Assessment Reporting Method</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseSectionAssessmentReportingMethodEntity? RefCourseSectionAssessmentReportingMethodEntity { get; set; }

    #endregion
}
