//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaFederalFundEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaFederalFund file
/// </summary>
[Table("K12leaFederalFund", Schema = "K12")]
public partial class K12leaFederalFundEntity : EntityBase, IK12leaFederalFund
{
    #region "IK12leaFederalFund Properties"
    public Decimal? InnovativeDollarsSpent { get; set; }

    public Decimal? InnovativeDollarsSpentOnStrategicPriorities { get; set; }

    public Decimal? InnovativeProgramsFundsReceived { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leaFederalFunds"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12leaFederalFunds")]
    public Guid K12leaFederalFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationCalendarSession")]
    public Guid OrganizationCalendarSessionId { get; set; }

    public Decimal? ParentalInvolvementReservationFunds { get; set; }

    public Decimal? PublicSchoolChoiceFundsSpent { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
    /// </summary>
    [ForeignKey("RefRlisProgramUse")]
    public Guid? RefRlisProgramUseId { get; set; }

    public Decimal? SesFundsSpent { get; set; }

    public Decimal? SesSchoolChoice20PercentObligation { get; set; }

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
    /// Reference to an optional instance of the <see cref="IRefRlisProgramUse"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefRlisProgramUseEntity? RefRlisProgramUseEntity { get; set; }

    #endregion
}
