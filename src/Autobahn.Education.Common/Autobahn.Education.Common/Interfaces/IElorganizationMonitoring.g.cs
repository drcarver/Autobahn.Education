//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElorganizationMonitoring.g.cs
//***************************************************************************

/// <summary>
/// The IElorganizationMonitoring file
/// </summary>
public partial interface IElorganizationMonitoring
{
    #region "IElorganizationMonitoring Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
    /// </summary>
    Guid? RefOrganizationMonitoringNotificationsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPurposeOfMonitoringVisit"/> model
    /// </summary>
    Guid? RefPurposeOfMonitoringVisitId { get; set; }

    System.String TypeOfMonitoring { get; set; }

    DateTime? VisitEndDate { get; set; }

    DateTime? VisitStartDate { get; set; }

    #endregion
}
