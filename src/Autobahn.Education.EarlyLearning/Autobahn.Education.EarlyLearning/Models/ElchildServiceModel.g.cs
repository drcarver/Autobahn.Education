//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildService file
/// </summary>
public partial class ElchildServiceModel : AutobahnBaseModel, IElchildService
{
    #region "IElchildService Properties"
    public Boolean? Eceapeligibility { get; set; }

    public System.String EligibilityPriorityPoints { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesOffered"/> model
    /// </summary>
    public Guid? RefEarlyChildhoodServicesOfferedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesReceived"/> model
    /// </summary>
    public Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElserviceType"/> model
    /// </summary>
    public Guid? RefElserviceTypeId { get; set; }

    public DateTime? ServiceDate { get; set; }

    #endregion
}
