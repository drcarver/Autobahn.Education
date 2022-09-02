//***************************************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IGoalMeasurement file
/// </summary>
public partial class GoalMeasurementModel : AutobahnBaseModel, IGoalMeasurement
{
    #region "IGoalMeasurement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoal"/> model
    /// </summary>
    public Guid GoalId { get; set; }

    /// <summary>
    /// Goal Measurement Type
    /// <para>
    /// Type of evidence appropriate for assessing achievement of a goal or short-term objective.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20678">Goal Measurement Type</a>
    /// </para>
    /// </summary>
    public Guid? RefGoalMeasurementTypeId { get; set; }

    /// <summary>
    /// Goal Measurement Schedule
    /// <para>
    /// Frequency of evaluation of progress toward meeting the goal or short-term objective.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20677">Goal Measurement Schedule</a>
    /// </para>
    /// </summary>
    public System.String Schedule { get; set; }

    /// <summary>
    /// Goal Success Criteria
    /// <para>
    /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19902">Goal Success Criteria</a>
    /// </para>
    /// </summary>
    public System.String SuccessCriteria { get; set; }

    #endregion
}
