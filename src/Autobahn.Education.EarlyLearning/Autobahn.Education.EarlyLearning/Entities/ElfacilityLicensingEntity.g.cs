//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElfacilityLicensingEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElfacilityLicensing file
/// </summary>
[Table("ElfacilityLicensing", Schema = "EarlyLearning")]
public partial class ElfacilityLicensingEntity : EntityBase, IElfacilityLicensing
{
    #region "IElfacilityLicensing Properties"
    public DateTime? ContinuingLicenseDate { get; set; }

    public DateTime? InitialLicensingDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfacilityLicensingStatus"/> model
    /// </summary>
    [ForeignKey("RefElfacilityLicensingStatus")]
    public Guid? RefElfacilityLicensingStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
    /// </summary>
    [ForeignKey("RefLicenseExempt")]
    public Guid? RefLicenseExemptId { get; set; }

    public Int32? StateLicensedFacilityCapacity { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElfacilityLicensingStatus"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefElfacilityLicensingStatusEntity? RefElfacilityLicensingStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefLicenseExempt"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefLicenseExemptEntity? RefLicenseExemptEntity { get; set; }

    #endregion
}
