//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElorganizationAvailabilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElorganizationAvailability file
/// </summary>
public partial class ElorganizationAvailabilityModel : AutobahnBaseModel, IElorganizationAvailability
{
    #region "IElorganizationAvailability Properties"
    public Int32? AnnualOperatingWeeks { get; set; }

    public Int32? DaysAvailablePerWeek { get; set; }

    public Decimal? HoursAvailablePerDay { get; set; }

    public Int32? NumberOfClassrooms { get; set; }

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
