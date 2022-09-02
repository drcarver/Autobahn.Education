//***************************************************************************
//* DomainName: Facilities
//* FileName:   IFacilityFinancial.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityFinancial file
/// </summary>
public partial interface IFacilityFinancial
{
    #region "IFacilityFinancial Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityLease"/> model
    /// </summary>
    Guid? FacilityLeaseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMortgageFee"/> model
    /// </summary>
    Guid? FacilityMortgageFeeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
    /// </summary>
    Guid? FacilityMortgageId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> model
    /// </summary>
    Guid OrganizationFinancialId { get; set; }

    #endregion
}
