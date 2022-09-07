//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinanceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityFinance file
/// </summary>
[Table("FacilityFinance", Schema = "Facilities")]
public partial class FacilityFinanceEntity : EntityBase, IFacilityFinance
{
    #region "IFacilityFinance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Replacement Value
    /// <para>
    /// The estimated cost of replacing a facility using current per square foot estimates of total project costs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20765">Facility Replacement Value</a>
    /// </para>
    /// </summary>
    [Comment("The estimated cost of replacing a facility using current per square foot estimates of total project costs.")]
    public Decimal? FacilityReplacementValue { get; set; }

    /// <summary>
    /// Indebtedness Amount Allowed
    /// <para>
    /// The amount of indebtedness allowed by law to be carried by the school district.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20874">Indebtedness Amount Allowed</a>
    /// </para>
    /// </summary>
    [Comment("The amount of indebtedness allowed by law to be carried by the school district.")]
    public Decimal? IndebtednessAmountAllowed { get; set; }

    /// <summary>
    /// Insurance Deductible
    /// <para>
    /// The dollar amount a school district must pay before its insurance will compensate it for loss.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20875">Insurance Deductible</a>
    /// </para>
    /// </summary>
    [Comment("The dollar amount a school district must pay before its insurance will compensate it for loss.")]
    public Decimal? InsuranceDeductible { get; set; }

    /// <summary>
    /// Public Education Mill Rate
    /// <para>
    /// The millage rate used to calculate property tax revenue for K-12 public education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20876">Public Education Mill Rate</a>
    /// </para>
    /// </summary>
    [Comment("The millage rate used to calculate property tax revenue for K-12 public education.")]
    public Decimal? PublicEducationMillRate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityEntity FacilityEntity { get; set; }

    #endregion
}
