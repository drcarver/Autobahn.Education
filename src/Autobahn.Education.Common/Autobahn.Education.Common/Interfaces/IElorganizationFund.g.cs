//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElorganizationFund.g.cs
//***************************************************************************

/// <summary>
/// The IElorganizationFund file
/// </summary>
public partial interface IElorganizationFund
{
    #region "IElorganizationFund Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IElorganizationFunds"/> model
    /// </summary>
    Guid ElorganizationFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBillableBasisType"/> model
    /// </summary>
    Guid? RefBillableBasisTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfederalFundingType"/> model
    /// </summary>
    Guid? RefElfederalFundingTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEllocalRevenueSource"/> model
    /// </summary>
    Guid? RefEllocalRevenueSourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElotherFederalFundingSources"/> model
    /// </summary>
    Guid? RefElotherFederalFundingSourcesId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElstateRevenueSource"/> model
    /// </summary>
    Guid? RefElstateRevenueSourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefReimbursementType"/> model
    /// </summary>
    Guid? RefReimbursementTypeId { get; set; }

    #endregion
}
