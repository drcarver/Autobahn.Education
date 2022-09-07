//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12seaFederalFundEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12seaFederalFund file
/// </summary>
public partial class K12seaFederalFundModel : AutobahnBaseModel, IK12seaFederalFund
{
    #region "IK12seaFederalFund Properties"
    public DateTime? DateStateReceivedTitleIiiallocation { get; set; }

    public DateTime? DateTitleIiifundsAvailableToSubgrantees { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
    /// </summary>
    public Guid K12seaFederalFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12sea"/> model
    /// </summary>
    public Guid K12seaId { get; set; }

    public Decimal? NumberOfDaysForTitleIiisubgrants { get; set; }

    public Boolean? StateTransferabilityOfFunds { get; set; }

    #endregion
}
