//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IElorganizationAvailability.g.cs
//***************************************************************************

/// <summary>
/// The IElorganizationAvailability file
/// </summary>
public partial interface IElorganizationAvailability
{
    #region "IElorganizationAvailability Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Int32? AnnualOperatingWeeks { get; set; }

    Int32? DaysAvailablePerWeek { get; set; }

    Decimal? HoursAvailablePerDay { get; set; }

    Int32? NumberOfClassrooms { get; set; }

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
