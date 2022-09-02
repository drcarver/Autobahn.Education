//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElservicePartnerEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElservicePartner file
/// </summary>
public partial class ElservicePartnerModel : AutobahnBaseModel, IElservicePartner
{
    #region "IElservicePartner Properties"
    public DateTime? MemorandumOfUnderstandingEndDate { get; set; }

    public DateTime? MemorandumOfUnderstandingStartDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    public System.String ServicePartnerDescription { get; set; }

    public System.String ServicePartnerName { get; set; }

    #endregion
}
