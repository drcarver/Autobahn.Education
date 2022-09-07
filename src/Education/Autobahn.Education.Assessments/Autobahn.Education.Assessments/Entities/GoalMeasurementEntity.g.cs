//***************************************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IGoalMeasurement file
/// </summary>
[Table("GoalMeasurement", Schema = "Assessments")]
public partial class GoalMeasurementEntity : EntityBase, IGoalMeasurement
{
    #region "IGoalMeasurement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoal"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Goal")]
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
    [ForeignKey("RefGoalMeasurementType")]
    [Comment("Type of evidence appropriate for assessing achievement of a goal or short-term objective.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Frequency of evaluation of progress toward meeting the goal or short-term objective.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.")]
    public System.String SuccessCriteria { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoal"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual GoalEntity GoalEntity { get; set; }

    /// <summary>
    /// Type of evidence appropriate for assessing achievement of a goal or short-term objective.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20678">Goal Measurement Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefGoalMeasurementTypeEntity? RefGoalMeasurementTypeEntity { get; set; }

    #endregion
}
