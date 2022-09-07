//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IElclassSection.g.cs
//***************************************************************************

/// <summary>
/// The IElclassSection file
/// </summary>
public partial interface IElclassSection
{
    #region "IElclassSection Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Int32? DaysAvailablePerWeek { get; set; }

    Int32? ElprogramAnnualOperatingWeeks { get; set; }

    Int32? GroupSize { get; set; }

    Decimal? HoursAvailablePerDay { get; set; }

    Boolean? LanguageTranslationPolicy { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEnvironmentSetting"/> model
    /// </summary>
    Guid? RefEnvironmentSettingId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
    /// </summary>
    Guid? RefServiceOptionId { get; set; }

    #endregion
}
