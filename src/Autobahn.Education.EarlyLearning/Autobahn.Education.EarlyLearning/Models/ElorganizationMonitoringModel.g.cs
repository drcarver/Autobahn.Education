//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElorganizationMonitoringEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElorganizationMonitoring file
/// </summary>
public partial class ElorganizationMonitoringModel : AutobahnBaseModel, IElorganizationMonitoring
{
    #region "IElorganizationMonitoring Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
    /// </summary>
    public Guid? RefOrganizationMonitoringNotificationsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPurposeOfMonitoringVisit"/> model
    /// </summary>
    public Guid? RefPurposeOfMonitoringVisitId { get; set; }

    public System.String TypeOfMonitoring { get; set; }

    public DateTime? VisitEndDate { get; set; }

    public DateTime? VisitStartDate { get; set; }

    #endregion
}
