//***************************************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementCriterionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IGoalMeasurementCriterion file
/// </summary>
[Table("GoalMeasurementCriterion", Schema = "Assessments")]
public partial class GoalMeasurementCriterionEntity : EntityBase, IGoalMeasurementCriterion
{
    #region "IGoalMeasurementCriterion Properties"
    /// <summary>
    /// Goal Measurement Criterion Accuracy Percent
    /// <para>
    /// The percent of correct results that will be considered to represent successful achievement of a goal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20672">Goal Measurement Criterion Accuracy Percent</a>
    /// </para>
    /// </summary>
    [Comment("The percent of correct results that will be considered to represent successful achievement of a goal.")]
    public Decimal? AccuracyPercent { get; set; }

    /// <summary>
    /// Goal Measurement Criterion Attempts Count
    /// <para>
    /// The number of attempts representing a completed trial for assessing achievement of a goal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20673">Goal Measurement Criterion Attempts Count</a>
    /// </para>
    /// </summary>
    [Comment("The number of attempts representing a completed trial for assessing achievement of a goal.")]
    public Int32? AttemptsCount { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoalMeasurement"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("GoalMeasurement")]
    public Guid GoalMeasurementId { get; set; }

    /// <summary>
    /// Goal Measurement Criterion Metric
    /// <para>
    /// A metric used for evaluating achievement of a goal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20674">Goal Measurement Criterion Metric</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A metric used for evaluating achievement of a goal.")]
    public System.String Metric { get; set; }

    /// <summary>
    /// Goal Measurement Criterion Success Count
    /// <para>
    /// The number of correct results that will be considered to represent successful achievement of a goal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20675">Goal Measurement Criterion Success Count</a>
    /// </para>
    /// </summary>
    [Comment("The number of correct results that will be considered to represent successful achievement of a goal.")]
    public Int32? SuccessCount { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoalMeasurement"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual GoalMeasurementEntity GoalMeasurementEntity { get; set; }

    #endregion
}
