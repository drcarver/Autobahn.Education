//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElclassSectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElclassSection file
/// </summary>
[Table("ElclassSection", Schema = "EarlyLearning")]
public partial class ElclassSectionEntity : EntityBase, IElclassSection
{
    #region "IElclassSection Properties"
    public Int32? DaysAvailablePerWeek { get; set; }

    public Int32? ElprogramAnnualOperatingWeeks { get; set; }

    public Int32? GroupSize { get; set; }

    public Decimal? HoursAvailablePerDay { get; set; }

    public Boolean? LanguageTranslationPolicy { get; set; }

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
    /// Reference to an optional instance of the <see cref="IRefServiceOption"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefServiceOptionEntity? RefServiceOptionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEnvironmentSetting"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefEnvironmentSettingEntity? RefEnvironmentSettingEntity { get; set; }

    #endregion
}
