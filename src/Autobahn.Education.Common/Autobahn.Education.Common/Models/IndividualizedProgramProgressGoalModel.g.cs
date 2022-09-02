//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramProgressGoalEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramProgressGoal file
/// </summary>
public partial class IndividualizedProgramProgressGoalModel : AutobahnBaseModel, IIndividualizedProgramProgressGoal
{
    #region "IIndividualizedProgramProgressGoal Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoalPerformance"/> model
    /// </summary>
    public Guid GoalPerformanceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReport"/> model
    /// </summary>
    public Guid IndividualizedProgramProgressReportId { get; set; }

    #endregion
}
