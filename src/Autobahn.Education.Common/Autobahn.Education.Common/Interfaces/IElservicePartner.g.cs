//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElservicePartner.g.cs
//***************************************************************************

/// <summary>
/// The IElservicePartner file
/// </summary>
public partial interface IElservicePartner
{
    #region "IElservicePartner Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? MemorandumOfUnderstandingEndDate { get; set; }

    DateTime? MemorandumOfUnderstandingStartDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    System.String ServicePartnerDescription { get; set; }

    System.String ServicePartnerName { get; set; }

    #endregion
}
