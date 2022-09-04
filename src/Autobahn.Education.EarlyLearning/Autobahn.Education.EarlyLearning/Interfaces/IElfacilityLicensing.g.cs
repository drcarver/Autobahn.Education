//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IElfacilityLicensing.g.cs
//***************************************************************************

/// <summary>
/// The IElfacilityLicensing file
/// </summary>
public partial interface IElfacilityLicensing
{
    #region "IElfacilityLicensing Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? ContinuingLicenseDate { get; set; }

    DateTime? InitialLicensingDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfacilityLicensingStatus"/> model
    /// </summary>
    Guid? RefElfacilityLicensingStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
    /// </summary>
    Guid? RefLicenseExemptId { get; set; }

    Int32? StateLicensedFacilityCapacity { get; set; }

    #endregion
}
