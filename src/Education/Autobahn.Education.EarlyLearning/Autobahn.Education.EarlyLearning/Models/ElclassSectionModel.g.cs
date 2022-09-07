//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElclassSectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElclassSection file
/// </summary>
public partial class ElclassSectionModel : AutobahnBaseModel, IElclassSection
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
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEnvironmentSetting"/> model
    /// </summary>
    public Guid? RefEnvironmentSettingId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
    /// </summary>
    public Guid? RefServiceOptionId { get; set; }

    #endregion
}
