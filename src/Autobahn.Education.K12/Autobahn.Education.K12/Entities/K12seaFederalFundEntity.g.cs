//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12seaFederalFundEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12seaFederalFund file
/// </summary>
[Table("K12seaFederalFund", Schema = "K12")]
public partial class K12seaFederalFundEntity : EntityBase, IK12seaFederalFund
{
    #region "IK12seaFederalFund Properties"
    public DateTime? DateStateReceivedTitleIiiallocation { get; set; }

    public DateTime? DateTitleIiifundsAvailableToSubgrantees { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12seaFederalFunds")]
    public Guid K12seaFederalFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12sea"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12sea")]
    public Guid K12seaId { get; set; }

    public Decimal? NumberOfDaysForTitleIiisubgrants { get; set; }

    public Boolean? StateTransferabilityOfFunds { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12sea"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual K12seaEntity K12seaEntity { get; set; }

    #endregion
}
