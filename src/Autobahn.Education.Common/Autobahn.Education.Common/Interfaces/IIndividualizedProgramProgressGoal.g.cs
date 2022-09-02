//***************************************************************************
//* DomainName: Common Models
//* FileName:   IIndividualizedProgramProgressGoal.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramProgressGoal file
/// </summary>
public partial interface IIndividualizedProgramProgressGoal
{
    #region "IIndividualizedProgramProgressGoal Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoalPerformance"/> model
    /// </summary>
    Guid GoalPerformanceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReport"/> model
    /// </summary>
    Guid IndividualizedProgramProgressReportId { get; set; }

    #endregion
}
