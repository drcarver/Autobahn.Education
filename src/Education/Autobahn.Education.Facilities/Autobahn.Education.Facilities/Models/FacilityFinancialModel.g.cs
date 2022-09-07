//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinancialEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityFinancial file
/// </summary>
public partial class FacilityFinancialModel : AutobahnBaseModel, IFacilityFinancial
{
    #region "IFacilityFinancial Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityLease"/> model
    /// </summary>
    public Guid? FacilityLeaseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMortgageFee"/> model
    /// </summary>
    public Guid? FacilityMortgageFeeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
    /// </summary>
    public Guid? FacilityMortgageId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> model
    /// </summary>
    public Guid OrganizationFinancialId { get; set; }

    #endregion
}
