//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacility file
/// </summary>
public partial class FacilityModel : AutobahnBaseModel, IFacility
{
    #region "IFacility Properties"
    /// <summary>
    /// Building Area
    /// <para>
    /// The sum of the areas at each floor level included within the principal outside faces of exterior walls, including roofed areas with finished floors that may not have exterior walls, but are connected to the main building. This sum should include all stories or areas having floor surfaces with clear standing head room (6.5 feet or 1.98 meters) but omit architectural setbacks or projections.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20745">Building Area</a>
    /// </para>
    /// </summary>
    public System.String BuildingArea { get; set; }

    /// <summary>
    /// Site Name
    /// <para>
    /// The full, legally accepted  name of the institution at the site level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19625">Site Name</a>
    /// </para>
    /// </summary>
    public System.String BuildingName { get; set; }

    /// <summary>
    /// Building Number of Stories
    /// <para>
    /// The number of stories in a building, excluding the basement if its ceiling is less than three feet above ground level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20766">Building Number of Stories</a>
    /// </para>
    /// </summary>
    public System.String BuildingNumberOfStories { get; set; }

    /// <summary>
    /// Building Site Number
    /// <para>
    /// The number of the building on the site, if more than one building shares the same address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19595">Building Site Number</a>
    /// </para>
    /// </summary>
    public System.String BuildingSiteNumber { get; set; }

    /// <summary>
    /// Building Year Built
    /// <para>
    /// The year a building was constructed, as indicated by cornerstone or official government records.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20769">Building Year Built</a>
    /// </para>
    /// </summary>
    public System.String BuildingYearBuilt { get; set; }

    /// <summary>
    /// Building Year of Last Modernization
    /// <para>
    /// The most recent year that a comprehensive upgrade of ALL major building systems and components was completed, such that it functions as a modern building, as measured by a facility condition index not greater than 15%.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20770">Building Year of Last Modernization</a>
    /// </para>
    /// </summary>
    public System.String BuildingYearOfLastModernization { get; set; }

    /// <summary>
    /// Facility Acquisition Date
    /// <para>
    /// The date the property/facility was acquired.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20749">Facility Acquisition Date</a>
    /// </para>
    /// </summary>
    public DateTime? FacilityAcquisitionDate { get; set; }

    /// <summary>
    /// Facility Building Permanency
    /// <para>
    /// An indication of whether the building is built for permanent use in the same location or is relocatable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20751">Facility Building Permanency</a>
    /// </para>
    /// </summary>
    public System.String FacilityBuildingPermanency { get; set; }

    /// <summary>
    /// Facility Expected Life
    /// <para>
    /// The time, in years, of the expected useful life of a facility for the purposes of depreciation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20764">Facility Expected Life</a>
    /// </para>
    /// </summary>
    public System.String FacilityExpectedLife { get; set; }

    /// <summary>
    /// Facility Ownership Indicator
    /// <para>
    /// Indicates the public or private entity holds legal title to the building and/or site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20887">Facility Ownership Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? FacilityOwnershipIndicator { get; set; }

    /// <summary>
    /// Facilities Identifier
    /// <para>
    /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19495">Facilities Identifier</a>
    /// </para>
    /// </summary>
    public System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Building Historic Status
    /// <para>
    /// An indication of whether or not a building is eligible to be or has been declared a landmark or historic building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20753">Building Historic Status</a>
    /// </para>
    /// </summary>
    public Guid? RefBuildingHistoricStatusId { get; set; }

    /// <summary>
    /// Building Primary Use Type
    /// <para>
    /// The primary use type of the building in which a school is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20758">Building Primary Use Type</a>
    /// </para>
    /// </summary>
    public Guid? RefBuildingPrimaryUseTypeId { get; set; }

    /// <summary>
    /// Building Use Type
    /// <para>
    /// How a building is principally used, regardless of its original design.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20173">Building Use Type</a>
    /// </para>
    /// </summary>
    public Guid? RefBuildingUseTypeId { get; set; }

    /// <summary>
    /// Campus Status
    /// <para>
    /// The generalized use or control of a campus, independent of program type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20759">Campus Status</a>
    /// </para>
    /// </summary>
    public Guid? RefCampusStatusId { get; set; }

    /// <summary>
    /// Campus Facility Type
    /// <para>
    /// The primary purpose for which a campus is designed and/or used.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20878">Campus Facility Type</a>
    /// </para>
    /// </summary>
    public Guid? RefCampusTypeId { get; set; }

    #endregion
}
