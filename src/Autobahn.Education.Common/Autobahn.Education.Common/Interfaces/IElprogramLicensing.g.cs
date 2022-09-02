//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElprogramLicensing.g.cs
//***************************************************************************

/// <summary>
/// The IElprogramLicensing file
/// </summary>
public partial interface IElprogramLicensing
{
    #region "IElprogramLicensing Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? ContinuingLicenseDate { get; set; }

    DateTime? InitialLicenseDate { get; set; }

    Boolean? LicenseRevocationStatus { get; set; }

    Boolean? LicenseSuspensionStatus { get; set; }

    Int32? NumberOfFatalities { get; set; }

    Int32? NumberOfInjuries { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprogramLicenseStatus"/> model
    /// </summary>
    Guid? RefElprogramLicenseStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
    /// </summary>
    Guid? RefLicenseExemptId { get; set; }

    #endregion
}
