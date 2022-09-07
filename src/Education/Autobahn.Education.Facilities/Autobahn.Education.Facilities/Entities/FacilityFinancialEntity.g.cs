//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinancialEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityFinancial file
/// </summary>
[Table("FacilityFinancial", Schema = "Facilities")]
public partial class FacilityFinancialEntity : EntityBase, IFacilityFinancial
{
    #region "IFacilityFinancial Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityLease"/> model
    /// </summary>
    [ForeignKey("FacilityLease")]
    public Guid? FacilityLeaseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMortgageFee"/> model
    /// </summary>
    [ForeignKey("FacilityMortgageFee")]
    public Guid? FacilityMortgageFeeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
    /// </summary>
    [ForeignKey("FacilityMortgage")]
    public Guid? FacilityMortgageId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationFinancial")]
    public Guid OrganizationFinancialId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual OrganizationFinancialEntity OrganizationFinancialEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityLease"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityLeaseEntity? FacilityLeaseEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityMortgageEntity? FacilityMortgageEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMortgageFee"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityMortgageFeeEntity? FacilityMortgageFeeEntity { get; set; }

    #endregion
}
