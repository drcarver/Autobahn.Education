//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramGoalEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramGoal file
/// </summary>
public partial class IndividualizedProgramGoalModel : AutobahnBaseModel, IIndividualizedProgramGoal
{
    #region "IIndividualizedProgramGoal Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoal"/> model
    /// </summary>
    public Guid GoalId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIepgoalType"/> model
    /// </summary>
    public Guid? RefIepgoalTypeId { get; set; }

    #endregion
}
