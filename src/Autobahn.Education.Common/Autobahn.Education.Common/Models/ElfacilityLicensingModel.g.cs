//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElfacilityLicensingEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElfacilityLicensing file
/// </summary>
public partial class ElfacilityLicensingModel : AutobahnBaseModel, IElfacilityLicensing
{
    #region "IElfacilityLicensing Properties"
    public DateTime? ContinuingLicenseDate { get; set; }

    public DateTime? InitialLicensingDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfacilityLicensingStatus"/> model
    /// </summary>
    public Guid? RefElfacilityLicensingStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
    /// </summary>
    public Guid? RefLicenseExemptId { get; set; }

    public Int32? StateLicensedFacilityCapacity { get; set; }

    #endregion
}
