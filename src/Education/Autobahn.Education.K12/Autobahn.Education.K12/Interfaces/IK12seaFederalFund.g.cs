//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12seaFederalFund.g.cs
//***************************************************************************

/// <summary>
/// The IK12seaFederalFund file
/// </summary>
public partial interface IK12seaFederalFund
{
    #region "IK12seaFederalFund Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? DateStateReceivedTitleIiiallocation { get; set; }

    DateTime? DateTitleIiifundsAvailableToSubgrantees { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
    /// </summary>
    Guid K12seaFederalFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12sea"/> model
    /// </summary>
    Guid K12seaId { get; set; }

    Decimal? NumberOfDaysForTitleIiisubgrants { get; set; }

    Boolean? StateTransferabilityOfFunds { get; set; }

    #endregion
}
