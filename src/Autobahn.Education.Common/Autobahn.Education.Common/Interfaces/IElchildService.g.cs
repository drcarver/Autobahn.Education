//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElchildService.g.cs
//***************************************************************************

/// <summary>
/// The IElchildService file
/// </summary>
public partial interface IElchildService
{
    #region "IElchildService Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? Eceapeligibility { get; set; }

    System.String EligibilityPriorityPoints { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesOffered"/> model
    /// </summary>
    Guid? RefEarlyChildhoodServicesOfferedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesReceived"/> model
    /// </summary>
    Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElserviceType"/> model
    /// </summary>
    Guid? RefElserviceTypeId { get; set; }

    DateTime? ServiceDate { get; set; }

    #endregion
}
