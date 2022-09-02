//***************************************************************************
//* DomainName: Common Models
//* FileName:   IServiceProvider.g.cs
//***************************************************************************

/// <summary>
/// The IServiceProvider file
/// </summary>
public partial interface IServiceProvider
{
    #region "IServiceProvider Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServiceProvided"/> model
    /// </summary>
    Guid ServiceProvidedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServiceStaff"/> model
    /// </summary>
    Guid ServiceStaffId { get; set; }

    #endregion
}
