//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElorganizationMonitoringEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElorganizationMonitoring file
/// </summary>
[Table("ElorganizationMonitoring", Schema = "EarlyLearning")]
public partial class ElorganizationMonitoringEntity : EntityBase, IElorganizationMonitoring
{
    #region "IElorganizationMonitoring Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
    /// </summary>
    [ForeignKey("RefOrganizationMonitoringNotifications")]
    public Guid? RefOrganizationMonitoringNotificationsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPurposeOfMonitoringVisit"/> model
    /// </summary>
    [ForeignKey("RefPurposeOfMonitoringVisit")]
    public Guid? RefPurposeOfMonitoringVisitId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TypeOfMonitoring { get; set; }

    public DateTime? VisitEndDate { get; set; }

    public DateTime? VisitStartDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefPurposeOfMonitoringVisit"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefPurposeOfMonitoringVisitEntity? RefPurposeOfMonitoringVisitEntity { get; set; }

    #endregion
}
