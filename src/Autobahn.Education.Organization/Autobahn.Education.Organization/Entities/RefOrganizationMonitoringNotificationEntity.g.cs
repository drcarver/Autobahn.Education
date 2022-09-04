//***************************************************************************
//* DomainName: Organization Models
//* FileName:   RefOrganizationMonitoringNotificationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefOrganizationMonitoringNotification file
/// </summary>
[Table("RefOrganizationMonitoringNotification", Schema = "Organization")]
public partial class RefOrganizationMonitoringNotificationEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefOrganizationMonitoringNotification Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefOrganizationMonitoringNotifications")]
    public Guid RefOrganizationMonitoringNotificationsId { get; set; }

    #endregion
}
