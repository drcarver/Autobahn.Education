//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12leaFederalFund.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaFederalFund file
/// </summary>
public partial interface IK12leaFederalFund
{
    #region "IK12leaFederalFund Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Decimal? InnovativeDollarsSpent { get; set; }

    Decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

    Decimal? InnovativeProgramsFundsReceived { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leaFederalFunds"/> model
    /// </summary>
    Guid K12leaFederalFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    Guid OrganizationCalendarSessionId { get; set; }

    Decimal? ParentalInvolvementReservationFunds { get; set; }

    Decimal? PublicSchoolChoiceFundsSpent { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
    /// </summary>
    Guid? RefRlisProgramUseId { get; set; }

    Decimal? SesFundsSpent { get; set; }

    Decimal? SesSchoolChoice20PercentObligation { get; set; }

    #endregion
}
