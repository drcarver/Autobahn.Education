//***************************************************************************
//* DomainName: Common Models
//* FileName:   GoalEntity.g.cs
//***************************************************************************

/// <summary>
/// The IGoal file
/// </summary>
[Table("Goal", Schema = "Common")]
public partial class GoalEntity : EntityBase, IGoal
{
    #region "IGoal Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    [ForeignKey("CompetencySet")]
    public Guid? CompetencySetId { get; set; }

    /// <summary>
    /// Goal End Date
    /// <para>
    /// The date on which the goal expires or has been achieved.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20170">Goal End Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the goal expires or has been achieved.")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [ForeignKey("OrganizationPersonRole")]
    public Guid? OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Goal Start Date
    /// <para>
    /// The date on which the goal becomes active.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20169">Goal Start Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the goal becomes active.")]
    public DateTime? StartDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual CompetencySetEntity CompetencySetEntity { get; set; }

    #endregion
}
