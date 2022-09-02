//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentSessionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentSession file
/// </summary>
public partial class K12studentSessionModel : AutobahnBaseModel, IK12studentSession
{
    #region "IK12studentSession Properties"
    public Decimal? GradePointAverageGivenSession { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    public Guid? OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion
}
