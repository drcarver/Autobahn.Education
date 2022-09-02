//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSystemComponent file
/// </summary>
public partial class BuildingSystemComponentModel : AutobahnBaseModel, IBuildingSystemComponent
{
    #region "IBuildingSystemComponent Properties"
    /// <summary>
    /// Building Institutional Equipment Description
    /// <para>
    /// Equipment that is installed for use in support of instructional program such as kilns for art, planetarium equipment for astronomy, fitness equipment for physical education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20782">Building Institutional Equipment Description</a>
    /// </para>
    /// </summary>
    public System.String BuildingInstitutionalEquipmentDescription { get; set; }

    /// <summary>
    /// Component or Fixture Useful Life
    /// <para>
    /// The anticipated time (in years) from the time of installation or service that a properly maintained system, component, equipment, or fixture is expected to operate effectively and efficiently.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20882">Component or Fixture Useful Life</a>
    /// </para>
    /// </summary>
    public Int32? ComponentOrFixtureUsefulLife { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Component Identification Code
    /// <para>
    /// A unique number or alphanumeric code assigned to a component by a school, school system, state, or other agency or entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20821">Facility Component Identification Code</a>
    /// </para>
    /// </summary>
    public System.String Identifier { get; set; }

    /// <summary>
    /// Installation Date
    /// <para>
    /// The year in which the system, component, equipment, or fixture was originally installed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20829">Installation Date</a>
    /// </para>
    /// </summary>
    public System.String InstallationDate { get; set; }

    /// <summary>
    /// Life-cycle Cost
    /// <para>
    /// The total cost of acquiring, owning, operating, and disposing of a building, facility, or piece of equipment over its useful life.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20830">Life-cycle Cost</a>
    /// </para>
    /// </summary>
    public Decimal? LifecycleCost { get; set; }

    /// <summary>
    /// Facility Furnishings Type
    /// <para>
    /// Moveable assets that are provided so the building or interior assets can be utilized by occupants for their intended purposes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20801">Facility Furnishings Type</a>
    /// </para>
    /// </summary>
    public Guid? RefFacilityFurnishingsTypeId { get; set; }

    /// <summary>
    /// Facility System or Component Condition
    /// <para>
    /// The rating of the system or component functions under the demands of its regular operation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20774">Facility System or Component Condition</a>
    /// </para>
    /// </summary>
    public Guid? RefFacilitySystemOrComponentConditionId { get; set; }

    #endregion
}
