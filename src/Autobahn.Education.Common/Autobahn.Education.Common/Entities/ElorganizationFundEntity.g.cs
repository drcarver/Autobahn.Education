//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElorganizationFundEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElorganizationFund file
/// </summary>
[Table("ElorganizationFund", Schema = "Common")]
public partial class ElorganizationFundEntity : EntityBase, IElorganizationFund
{
    #region "IElorganizationFund Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IElorganizationFunds"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The ElorganizationFunds property is obsolete and will be removed in a later version")]
    [ForeignKey("ElorganizationFunds")]
    public Guid ElorganizationFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBillableBasisType"/> model
    /// </summary>
    [ForeignKey("RefBillableBasisType")]
    public Guid? RefBillableBasisTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfederalFundingType"/> model
    /// </summary>
    [ForeignKey("RefElfederalFundingType")]
    public Guid? RefElfederalFundingTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEllocalRevenueSource"/> model
    /// </summary>
    [ForeignKey("RefEllocalRevenueSource")]
    public Guid? RefEllocalRevenueSourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElotherFederalFundingSources"/> model
    /// </summary>
    [Obsolete("The RefElotherFederalFundingSources property is obsolete and will be removed in a later version")]
    [ForeignKey("RefElotherFederalFundingSources")]
    public Guid? RefElotherFederalFundingSourcesId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElstateRevenueSource"/> model
    /// </summary>
    [ForeignKey("RefElstateRevenueSource")]
    public Guid? RefElstateRevenueSourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefReimbursementType"/> model
    /// </summary>
    [ForeignKey("RefReimbursementType")]
    public Guid? RefReimbursementTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElfederalFundingType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefElfederalFundingTypeEntity RefElfederalFundingTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEllocalRevenueSource"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefEllocalRevenueSourceEntity RefEllocalRevenueSourceEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElstateRevenueSource"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefElstateRevenueSourceEntity RefElstateRevenueSourceEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefBillableBasisType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefBillableBasisTypeEntity RefBillableBasisTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefReimbursementType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefReimbursementTypeEntity RefReimbursementTypeEntity { get; set; }

    #endregion
}
