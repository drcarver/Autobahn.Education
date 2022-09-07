//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElorganizationAvailabilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElorganizationAvailability file
/// </summary>
[Table("ElorganizationAvailability", Schema = "EarlyLearning")]
public partial class ElorganizationAvailabilityEntity : EntityBase, IElorganizationAvailability
{
    #region "IElorganizationAvailability Properties"
    public Int32? AnnualOperatingWeeks { get; set; }

    public Int32? DaysAvailablePerWeek { get; set; }

    public Decimal? HoursAvailablePerDay { get; set; }

    public Int32? NumberOfClassrooms { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEnvironmentSetting"/> model
    /// </summary>
    [ForeignKey("RefEnvironmentSetting")]
    public Guid? RefEnvironmentSettingId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
    /// </summary>
    [ForeignKey("RefServiceOption")]
    public Guid? RefServiceOptionId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEnvironmentSetting"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefEnvironmentSettingEntity? RefEnvironmentSettingEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefServiceOption"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefServiceOptionEntity? RefServiceOptionEntity { get; set; }

    #endregion
}
