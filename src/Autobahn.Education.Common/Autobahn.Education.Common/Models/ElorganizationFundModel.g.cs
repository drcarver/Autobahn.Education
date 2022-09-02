//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElorganizationFundEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElorganizationFund file
/// </summary>
public partial class ElorganizationFundModel : AutobahnBaseModel, IElorganizationFund
{
    #region "IElorganizationFund Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IElorganizationFunds"/> model
    /// </summary>
    public Guid ElorganizationFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBillableBasisType"/> model
    /// </summary>
    public Guid? RefBillableBasisTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfederalFundingType"/> model
    /// </summary>
    public Guid? RefElfederalFundingTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEllocalRevenueSource"/> model
    /// </summary>
    public Guid? RefEllocalRevenueSourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElotherFederalFundingSources"/> model
    /// </summary>
    public Guid? RefElotherFederalFundingSourcesId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElstateRevenueSource"/> model
    /// </summary>
    public Guid? RefElstateRevenueSourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefReimbursementType"/> model
    /// </summary>
    public Guid? RefReimbursementTypeId { get; set; }

    #endregion
}
