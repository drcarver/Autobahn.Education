//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramProgressGoalEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramProgressGoal file
/// </summary>
[Table("IndividualizedProgramProgressGoal", Schema = "Common")]
public partial class IndividualizedProgramProgressGoalEntity : EntityBase, IIndividualizedProgramProgressGoal
{
    #region "IIndividualizedProgramProgressGoal Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoalPerformance"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("GoalPerformance")]
    public Guid GoalPerformanceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReport"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgramProgressReport")]
    public Guid IndividualizedProgramProgressReportId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoalPerformance"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual GoalPerformanceEntity GoalPerformanceEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReport"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramProgressReportEntity IndividualizedProgramProgressReportEntity { get; set; }

    #endregion
}
