//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentSession.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentSession file
/// </summary>
public partial interface IK12studentSession
{
    #region "IK12studentSession Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Decimal? GradePointAverageGivenSession { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    Guid? OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    #endregion
}
