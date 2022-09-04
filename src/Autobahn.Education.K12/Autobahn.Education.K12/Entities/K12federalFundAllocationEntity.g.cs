//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12federalFundAllocationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12federalFundAllocation file
/// </summary>
[Table("K12federalFundAllocation", Schema = "K12")]
public partial class K12federalFundAllocationEntity : EntityBase, IK12federalFundAllocation
{
    #region "IK12federalFundAllocation Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(10,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FederalProgramCode { get; set; }

    public Decimal? FederalProgramsFundingAllocation { get; set; }

    public Decimal? FundsTransferAmount { get; set; }

    public Boolean? LeaTransferabilityOfFunds { get; set; }

    public Int32? NumberOfImmigrantProgramSubgrants { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationCalendarSession")]
    public Guid OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationType"/> model
    /// </summary>
    [ForeignKey("RefFederalProgramFundingAllocationType")]
    public Guid? RefFederalProgramFundingAllocationTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaFundsTransferType"/> model
    /// </summary>
    [ForeignKey("RefLeaFundsTransferType")]
    public Guid? RefLeaFundsTransferTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefReapAlternativeFundingStatus"/> model
    /// </summary>
    [ForeignKey("RefReapAlternativeFundingStatus")]
    public Guid? RefReapAlternativeFundingStatusId { get; set; }

    public Decimal? SchoolImprovementAllocation { get; set; }

    public Decimal? SchoolImprovementReservedPercent { get; set; }

    public Decimal? SesPerPupilExpenditure { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual OrganizationCalendarSessionEntity OrganizationCalendarSessionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefFederalProgramFundingAllocationType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefFederalProgramFundingAllocationTypeEntity? RefFederalProgramFundingAllocationTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefLeaFundsTransferType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefLeaFundsTransferTypeEntity? RefLeaFundsTransferTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefReapAlternativeFundingStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefReapAlternativeFundingStatusEntity? RefReapAlternativeFundingStatusEntity { get; set; }

    #endregion
}
