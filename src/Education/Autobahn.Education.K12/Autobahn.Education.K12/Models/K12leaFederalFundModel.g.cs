//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaFederalFundEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaFederalFund file
/// </summary>
public partial class K12leaFederalFundModel : AutobahnBaseModel, IK12leaFederalFund
{
    #region "IK12leaFederalFund Properties"
    public Decimal? InnovativeDollarsSpent { get; set; }

    public Decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

    public Decimal? InnovativeProgramsFundsReceived { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leaFederalFunds"/> model
    /// </summary>
    public Guid K12leaFederalFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    public Guid OrganizationCalendarSessionId { get; set; }

    public Decimal? ParentalInvolvementReservationFunds { get; set; }

    public Decimal? PublicSchoolChoiceFundsSpent { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
    /// </summary>
    public Guid? RefRlisProgramUseId { get; set; }

    public Decimal? SesFundsSpent { get; set; }

    public Decimal? SesSchoolChoice20PercentObligation { get; set; }

    #endregion
}
