//***************************************************************************
//* DomainName: Common Models
//* FileName:   GoalPerformanceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IGoalPerformance file
/// </summary>
[Table("GoalPerformance", Schema = "Common")]
public partial class GoalPerformanceEntity : EntityBase, IGoalPerformance
{
    #region "IGoalPerformance Properties"
    /// <summary>
    /// Goal Current Performance Description
    /// <para>
    /// Current performance explanation related to the annual goal or short-term objectives.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20671">Goal Current Performance Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Current performance explanation related to the annual goal or short-term objectives.")]
    public System.String CurrentPerformanceDescription { get; set; }

    public DateTime? Date { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoal"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Goal")]
    public Guid GoalId { get; set; }

    /// <summary>
    /// Goal Status Type
    /// <para>
    /// Status toward achievement of the annual goal or short-term objectives.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20683">Goal Status Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefGoalStatusType")]
    [Comment("Status toward achievement of the annual goal or short-term objectives.")]
    public Guid? RefGoalStatusTypeId { get; set; }

    /// <summary>
    /// Goal Status
    /// <para>
    /// Description of status toward achievement of the annual goal or short-term objectives.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20684">Goal Status</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Description of status toward achievement of the annual goal or short-term objectives.")]
    public System.String Status { get; set; }

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
    /// Status toward achievement of the annual goal or short-term objectives.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20683">Goal Status Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefGoalStatusTypeEntity RefGoalStatusTypeEntity { get; set; }

    #endregion
}
