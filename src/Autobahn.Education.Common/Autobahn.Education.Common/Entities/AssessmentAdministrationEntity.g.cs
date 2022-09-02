//***************************************************************************
//* DomainName: Common Models
//* FileName:   AssessmentAdministrationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAdministration file
/// </summary>
[Table("AssessmentAdministration", Schema = "Common")]
public partial class AssessmentAdministrationEntity : EntityBase, IAssessmentAdministration
{
    #region "IAssessmentAdministration Properties"
    /// <summary>
    /// Assessment Administration Period Description
    /// <para>
    /// The period or window in which an assessment is supposed to be administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20506">Assessment Administration Period Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The period or window in which an assessment is supposed to be administered.")]
    public System.String AssessmentAdministrationPeriodDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    [ForeignKey("Assessment")]
    public Guid? AssessmentId { get; set; }

    /// <summary>
    /// Assessment Secure Indicator
    /// <para>
    /// Indicates whether or not the assessment is a secure assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19375">Assessment Secure Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates whether or not the assessment is a secure assessment.")]
    public Boolean? AssessmentSecureIndicator { get; set; }

    /// <summary>
    /// Assessment Administration Finish Date
    /// <para>
    /// The finish date of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19965">Assessment Administration Finish Date</a>
    /// </para>
    /// </summary>
    [Comment("The finish date of the time period designated for the assessment administration.")]
    public DateTime? FinishDate { get; set; }

    /// <summary>
    /// Assessment Administration Finish Time
    /// <para>
    /// The finish time of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19966">Assessment Administration Finish Time</a>
    /// </para>
    /// </summary>
    [Comment("The finish time of the time period designated for the assessment administration.")]
    public TimeSpan? FinishTime { get; set; }

    /// <summary>
    /// Assessment Administration Name
    /// <para>
    /// The name given to an assessment event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19978">Assessment Administration Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name given to an assessment event.")]
    public System.String Name { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentReportingMethod"/> model
    /// </summary>
    [ForeignKey("RefAssessmentReportingMethod")]
    public Guid? RefAssessmentReportingMethodId { get; set; }

    /// <summary>
    /// Assessment Administration Start Date
    /// <para>
    /// The start date of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19963">Assessment Administration Start Date</a>
    /// </para>
    /// </summary>
    [Comment("The start date of the time period designated for the assessment administration.")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Assessment Administration Start Time
    /// <para>
    /// The start time of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19964">Assessment Administration Start Time</a>
    /// </para>
    /// </summary>
    [Comment("The start time of the time period designated for the assessment administration.")]
    public TimeSpan? StartTime { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentEntity AssessmentEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAssessmentReportingMethod"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentReportingMethodEntity RefAssessmentReportingMethodEntity { get; set; }

    #endregion
}
