//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSystemComponentService file
/// </summary>
public partial class BuildingSystemComponentServiceModel : AutobahnBaseModel, IBuildingSystemComponentService
{
    #region "IBuildingSystemComponentService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
    /// </summary>
    public Guid BuildingSystemComponentId { get; set; }

    /// <summary>
    /// Component or Fixture Scheduled Serviced Date
    /// <para>
    /// The month, day, and year a major component, system, equipment, or fixture is scheduled to be serviced for preventive or routine maintenance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20881">Component or Fixture Scheduled Serviced Date</a>
    /// </para>
    /// </summary>
    public DateTime? ComponentOrFixtureScheduledServicedDate { get; set; }

    /// <summary>
    /// Component or Fixture Serviced Date
    /// <para>
    /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20880">Component or Fixture Serviced Date</a>
    /// </para>
    /// </summary>
    public DateTime? ComponentOrFixtureServicedDate { get; set; }

    #endregion
}
