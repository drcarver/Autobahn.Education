//***************************************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementCriterionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IGoalMeasurementCriterion file
/// </summary>
public partial class GoalMeasurementCriterionModel : AutobahnBaseModel, IGoalMeasurementCriterion
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
    public Int32? AttemptsCount { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoalMeasurement"/> model
    /// </summary>
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
    public Int32? SuccessCount { get; set; }

    #endregion
}
