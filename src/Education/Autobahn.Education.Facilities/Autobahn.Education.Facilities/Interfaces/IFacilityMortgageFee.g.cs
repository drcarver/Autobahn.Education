//***************************************************************************
//* DomainName: Facilities
//* FileName:   IFacilityMortgageFee.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityMortgageFee file
/// </summary>
public partial interface IFacilityMortgageFee
{
    #region "IFacilityMortgageFee Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
    /// </summary>
    Guid FacilityMortgageId { get; set; }

    /// <summary>
    /// Facility Financing Fee Type
    /// <para>
    /// The type of fee that one must pay when getting a mortgage.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20867">Facility Financing Fee Type</a>
    /// </para>
    /// </summary>
    Guid RefFacilityFinancingFeeTypeId { get; set; }

    #endregion
}
