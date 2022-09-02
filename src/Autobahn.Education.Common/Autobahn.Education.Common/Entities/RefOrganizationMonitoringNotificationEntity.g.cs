//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefOrganizationMonitoringNotificationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefOrganizationMonitoringNotification file
/// </summary>
[Table("RefOrganizationMonitoringNotification", Schema = "Common")]
public partial class RefOrganizationMonitoringNotificationEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefOrganizationMonitoringNotification Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefOrganizationMonitoringNotifications property is obsolete and will be removed in a later version")]
    [ForeignKey("RefOrganizationMonitoringNotifications")]
    public Guid RefOrganizationMonitoringNotificationsId { get; set; }

    #endregion
}
