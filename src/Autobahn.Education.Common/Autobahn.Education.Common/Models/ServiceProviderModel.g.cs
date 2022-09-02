//***************************************************************************
//* DomainName: Common Models
//* FileName:   ServiceProviderEntity.g.cs
//***************************************************************************

/// <summary>
/// The IServiceProvider file
/// </summary>
public partial class ServiceProviderModel : AutobahnBaseModel, IServiceProvider
{
    #region "IServiceProvider Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServiceProvided"/> model
    /// </summary>
    public Guid ServiceProvidedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServiceStaff"/> model
    /// </summary>
    public Guid ServiceStaffId { get; set; }

    #endregion
}
