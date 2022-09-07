//***************************************************************************
//* DomainName: Assessments
//* FileName:   GoalEntity.g.cs
//***************************************************************************

/// <summary>
/// The IGoal file
/// </summary>
public partial class GoalModel : AutobahnBaseModel, IGoal
{
    #region "IGoal Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
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
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
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
    public DateTime? StartDate { get; set; }

    #endregion
}
