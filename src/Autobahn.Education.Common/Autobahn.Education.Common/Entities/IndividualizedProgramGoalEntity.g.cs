//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramGoalEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramGoal file
/// </summary>
[Table("IndividualizedProgramGoal", Schema = "Common")]
public partial class IndividualizedProgramGoalEntity : EntityBase, IIndividualizedProgramGoal
{
    #region "IIndividualizedProgramGoal Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoal"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Goal")]
    public Guid GoalId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIepgoalType"/> model
    /// </summary>
    [ForeignKey("RefIepgoalType")]
    public Guid? RefIepgoalTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoal"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual GoalEntity GoalEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIepgoalType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIepgoalTypeEntity RefIepgoalTypeEntity { get; set; }

    #endregion
}
