//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityMortgage file
/// </summary>
public partial class FacilityMortgageModel : AutobahnBaseModel, IFacilityMortgage
{
    #region "IFacilityMortgage Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
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
    public Guid? RefFacilityMortgageTypeId { get; set; }

    #endregion
}
