//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPerformanceLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPerformanceLevel file
/// </summary>
[Table("AssessmentPerformanceLevel", Schema = "Assessments")]
public partial class AssessmentPerformanceLevelEntity : EntityBase, IAssessmentPerformanceLevel
{
    #region "IAssessmentPerformanceLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    [ForeignKey("AssessmentSubtest")]
    public Guid? AssessmentSubtestId { get; set; }

    /// <summary>
    /// Assessment Performance Level Descriptive Feedback
    /// <para>
    /// A feedback message designed to be reported with the assessment performance level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20184">Assessment Performance Level Descriptive Feedback</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("A feedback message designed to be reported with the assessment performance level.")]
    public System.String DescriptiveFeedback { get; set; }

    /// <summary>
    /// Assessment Performance Level Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to an assessment performance level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19693">Assessment Performance Level Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A unique number or alphanumeric code assigned to an assessment performance level.")]
    public System.String Identifier { get; set; }

    /// <summary>
    /// Assessment Performance Level Label
    /// <para>
    /// A label representing the performance level appropriate for use on a report.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19694">Assessment Performance Level Label</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A label representing the performance level appropriate for use on a report.")]
    public System.String Label { get; set; }

    /// <summary>
    /// Assessment Performance Level Lower Cut Score
    /// <para>
    /// Lowest possible score for the performance level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19408">Assessment Performance Level Lower Cut Score</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Lowest possible score for the performance level.")]
    public System.String LowerCutScore { get; set; }

    /// <summary>
    /// Assessment Performance Level Score Metric
    /// <para>
    /// The metric or scale used for score reporting.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19407">Assessment Performance Level Score Metric</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The metric or scale used for score reporting.")]
    public System.String ScoreMetric { get; set; }

    /// <summary>
    /// Assessment Performance Level Upper Cut Score
    /// <para>
    /// Highest possible score for the performance level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19409">Assessment Performance Level Upper Cut Score</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Highest possible score for the performance level.")]
    public System.String UpperCutScore { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentSubtestEntity AssessmentSubtestEntity { get; set; }

    #endregion
}
