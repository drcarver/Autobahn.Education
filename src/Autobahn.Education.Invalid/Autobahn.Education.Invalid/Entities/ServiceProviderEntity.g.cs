//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ServiceProviderEntity.g.cs
//***************************************************************************

/// <summary>
/// The IServiceProvider file
/// </summary>
[Table("ServiceProvider", Schema = "Invalid")]
public partial class ServiceProviderEntity : EntityBase, IServiceProvider
{
    #region "IServiceProvider Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServiceProvided"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ServiceProvided")]
    public Guid ServiceProvidedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServiceStaff"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ServiceStaff")]
    public Guid ServiceStaffId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IServiceProvided"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual ServiceProvidedEntity ServiceProvidedEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServiceStaff"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual ServiceStaffEntity ServiceStaffEntity { get; set; }

    #endregion
}
