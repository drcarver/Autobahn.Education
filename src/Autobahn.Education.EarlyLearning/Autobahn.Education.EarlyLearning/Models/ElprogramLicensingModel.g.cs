//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElprogramLicensingEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElprogramLicensing file
/// </summary>
public partial class ElprogramLicensingModel : AutobahnBaseModel, IElprogramLicensing
{
    #region "IElprogramLicensing Properties"
    public DateTime? ContinuingLicenseDate { get; set; }

    public DateTime? InitialLicenseDate { get; set; }

    public Boolean? LicenseRevocationStatus { get; set; }

    public Boolean? LicenseSuspensionStatus { get; set; }

    public Int32? NumberOfFatalities { get; set; }

    public Int32? NumberOfInjuries { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprogramLicenseStatus"/> model
    /// </summary>
    public Guid? RefElprogramLicenseStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
    /// </summary>
    public Guid? RefLicenseExemptId { get; set; }

    #endregion
}
