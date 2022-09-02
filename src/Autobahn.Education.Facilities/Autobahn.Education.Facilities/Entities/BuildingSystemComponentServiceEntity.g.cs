//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSystemComponentService file
/// </summary>
[Table("BuildingSystemComponentService", Schema = "Facilities")]
public partial class BuildingSystemComponentServiceEntity : EntityBase, IBuildingSystemComponentService
{
    #region "IBuildingSystemComponentService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("BuildingSystemComponent")]
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
    [Comment("The month, day, and year a major component, system, equipment, or fixture is scheduled to be serviced for preventive or routine maintenance.")]
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
    [Comment("The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.")]
    public DateTime? ComponentOrFixtureServicedDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual BuildingSystemComponentEntity BuildingSystemComponentEntity { get; set; }

    #endregion
}
