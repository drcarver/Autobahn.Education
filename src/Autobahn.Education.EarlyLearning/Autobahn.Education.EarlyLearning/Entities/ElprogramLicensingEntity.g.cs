//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElprogramLicensingEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElprogramLicensing file
/// </summary>
[Table("ElprogramLicensing", Schema = "EarlyLearning")]
public partial class ElprogramLicensingEntity : EntityBase, IElprogramLicensing
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
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprogramLicenseStatus"/> model
    /// </summary>
    [ForeignKey("RefElprogramLicenseStatus")]
    public Guid? RefElprogramLicenseStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
    /// </summary>
    [ForeignKey("RefLicenseExempt")]
    public Guid? RefLicenseExemptId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElprogramLicenseStatus"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefElprogramLicenseStatusEntity? RefElprogramLicenseStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefLicenseExempt"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefLicenseExemptEntity? RefLicenseExemptEntity { get; set; }

    #endregion
}
