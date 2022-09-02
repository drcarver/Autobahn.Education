//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityMortgage file
/// </summary>
[Table("FacilityMortgage", Schema = "Facilities")]
public partial class FacilityMortgageEntity : EntityBase, IFacilityMortgage
{
    #region "IFacilityMortgage Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Mortgage Interest Amount
    /// <para>
    /// The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20871">Facility Mortgage Interest Amount</a>
    /// </para>
    /// </summary>
    [Comment("The amount the borrower pays the lender to compensate the lender for the use of money to purchase a building or facility.")]
    public Decimal? FacilityMortgageInterestAmount { get; set; }

    /// <summary>
    /// Facility Total Assessed Value
    /// <para>
    /// The total assessed value of property that constitutes the basis for public borrowing.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20877">Facility Total Assessed Value</a>
    /// </para>
    /// </summary>
    [Comment("The total assessed value of property that constitutes the basis for public borrowing.")]
    public Decimal? FacilityTotalAssessedValue { get; set; }

    /// <summary>
    /// Facility Mortgage Interest Type
    /// <para>
    /// The type of interest paid on a mortgage to the lender to compensate the lender for the use of money to purchase a building or facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20872">Facility Mortgage Interest Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityMortgageInterestType")]
    [Comment("The type of interest paid on a mortgage to the lender to compensate the lender for the use of money to purchase a building or facility.")]
    public Guid? RefFacilityMortgageInterestTypeId { get; set; }

    /// <summary>
    /// Facility Mortgage Type
    /// <para>
    /// The status of a mortgage as it relates to priority of payment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20873">Facility Mortgage Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityMortgageType")]
    [Comment("The status of a mortgage as it relates to priority of payment.")]
    public Guid? RefFacilityMortgageTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityEntity FacilityEntity { get; set; }

    /// <summary>
    /// The type of interest paid on a mortgage to the lender to compensate the lender for the use of money to purchase a building or facility.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20872">Facility Mortgage Interest Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityMortgageInterestTypeEntity RefFacilityMortgageInterestTypeEntity { get; set; }

    /// <summary>
    /// The status of a mortgage as it relates to priority of payment.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20873">Facility Mortgage Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityMortgageTypeEntity RefFacilityMortgageTypeEntity { get; set; }

    #endregion
}
