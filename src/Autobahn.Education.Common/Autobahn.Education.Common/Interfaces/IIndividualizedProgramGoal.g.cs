//***************************************************************************
//* DomainName: Common Models
//* FileName:   IIndividualizedProgramGoal.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramGoal file
/// </summary>
public partial interface IIndividualizedProgramGoal
{
    #region "IIndividualizedProgramGoal Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoal"/> model
    /// </summary>
    Guid GoalId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIepgoalType"/> model
    /// </summary>
    Guid? RefIepgoalTypeId { get; set; }

    #endregion
}
