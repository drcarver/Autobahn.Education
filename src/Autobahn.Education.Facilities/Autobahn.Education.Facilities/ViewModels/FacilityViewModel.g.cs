//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacility file
/// </summary>
public partial class FacilityViewModel : ObservableValidator, IFacility
{
    #region "FacilityViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityViewModel Constructor
    /// </summary>
    public FacilityViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityViewModelConstruction();
    }

    /// <summary>
    /// FacilityViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Facility";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // BuildingArea -- (backing property for Building Area)
    private System.String buildingArea;

    // BuildingName -- (backing property for Site Name)
    private System.String buildingName;

    // BuildingNumberOfStories -- (backing property for Building Number of Stories)
    private System.String buildingNumberOfStories;

    // BuildingSiteNumber -- (backing property for Building Site Number)
    private System.String buildingSiteNumber;

    // BuildingYearBuilt -- (backing property for Building Year Built)
    private System.String buildingYearBuilt;

    // BuildingYearOfLastModernization -- (backing property for Building Year of Last Modernization)
    private System.String buildingYearOfLastModernization;

    // FacilityAcquisitionDate -- (backing property for Facility Acquisition Date)
    private DateTime? facilityAcquisitionDate;

    // FacilityBuildingPermanency -- (backing property for Facility Building Permanency)
    private System.String facilityBuildingPermanency;

    // FacilityExpectedLife -- (backing property for Facility Expected Life)
    private System.String facilityExpectedLife;

    // FacilityOwnershipIndicator -- (backing property for Facility Ownership Indicator)
    private Boolean? facilityOwnershipIndicator;

    // Identifier -- (backing property for Facilities Identifier)
    private System.String identifier;

    #endregion

    #region "IAutobahnBase Properties"
    /// <summary>
    /// The title of the View Model
    /// </summary>
    public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

    /// <summary>
    /// The IsNew property is set if the view model has been created but not saved to the database
    /// </summary>
    public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

    /// <summary>
    /// The IsDeleted property is set if the view model is to be delted from the database
    /// </summary>
    public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

    /// <summary>
    /// The primary key of the view model
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The view model is changed and needs to be save to the database.
    /// </summary>
    public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

    /// <summary>
    /// The view model is performing a long running task
    /// </summary>
    public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

    /// <summary>
    /// The view model's changes have been save so update its tracking properties
    /// </summary>
    public void AcceptChanges()
    {
        IsNew = false;
        IsChanged = false;
    }
    #endregion

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
    [DisplayName("Building Area")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingArea { get => buildingArea; set => SetProperty(ref buildingArea, value, true); }

    /// <summary>
    /// Site Name
    /// <para>
    /// The full, legally accepted  name of the institution at the site level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19625">Site Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Site Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingName { get => buildingName; set => SetProperty(ref buildingName, value, true); }

    /// <summary>
    /// Building Number of Stories
    /// <para>
    /// The number of stories in a building, excluding the basement if its ceiling is less than three feet above ground level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20766">Building Number of Stories</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Number of Stories")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingNumberOfStories { get => buildingNumberOfStories; set => SetProperty(ref buildingNumberOfStories, value, true); }

    /// <summary>
    /// Building Site Number
    /// <para>
    /// The number of the building on the site, if more than one building shares the same address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19595">Building Site Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Site Number")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingSiteNumber { get => buildingSiteNumber; set => SetProperty(ref buildingSiteNumber, value, true); }

    /// <summary>
    /// Building Year Built
    /// <para>
    /// The year a building was constructed, as indicated by cornerstone or official government records.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20769">Building Year Built</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Year Built")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingYearBuilt { get => buildingYearBuilt; set => SetProperty(ref buildingYearBuilt, value, true); }

    /// <summary>
    /// Building Year of Last Modernization
    /// <para>
    /// The most recent year that a comprehensive upgrade of ALL major building systems and components was completed, such that it functions as a modern building, as measured by a facility condition index not greater than 15%.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20770">Building Year of Last Modernization</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Year of Last Modernization")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingYearOfLastModernization { get => buildingYearOfLastModernization; set => SetProperty(ref buildingYearOfLastModernization, value, true); }

    /// <summary>
    /// Facility Acquisition Date
    /// <para>
    /// The date the property/facility was acquired.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20749">Facility Acquisition Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Acquisition Date")]
    public DateTime? FacilityAcquisitionDate { get => facilityAcquisitionDate; set => SetProperty(ref facilityAcquisitionDate, value, false); }

    /// <summary>
    /// Facility Building Permanency
    /// <para>
    /// An indication of whether the building is built for permanent use in the same location or is relocatable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20751">Facility Building Permanency</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Building Permanency")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilityBuildingPermanency { get => facilityBuildingPermanency; set => SetProperty(ref facilityBuildingPermanency, value, true); }

    /// <summary>
    /// Facility Expected Life
    /// <para>
    /// The time, in years, of the expected useful life of a facility for the purposes of depreciation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20764">Facility Expected Life</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Expected Life")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilityExpectedLife { get => facilityExpectedLife; set => SetProperty(ref facilityExpectedLife, value, true); }

    /// <summary>
    /// Facility Ownership Indicator
    /// <para>
    /// Indicates the public or private entity holds legal title to the building and/or site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20887">Facility Ownership Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Ownership Indicator")]
    public Boolean? FacilityOwnershipIndicator { get => facilityOwnershipIndicator; set => SetProperty(ref facilityOwnershipIndicator, value, false); }

    /// <summary>
    /// Facilities Identifier
    /// <para>
    /// A locally assigned unique number or alphanumeric code used to capture precise information on locations specific to a school (e.g., building number, class number, hall number, school bus number, computer station number, or internet protocol (IP) address).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19495">Facilities Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Facilities Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

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
    [DisplayName("Building Historic Status")]
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
    [DisplayName("Building Primary Use Type")]
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
    [DisplayName("Building Use Type")]
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
    [DisplayName("Campus Status")]
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
    [DisplayName("Campus Facility Type")]
    public Guid? RefCampusTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacility model)
    {
        IsBusy = true;
        Id = model.Id;
        BuildingArea = model.BuildingArea; // Building Area
        BuildingName = model.BuildingName; // Site Name
        BuildingNumberOfStories = model.BuildingNumberOfStories; // Building Number of Stories
        BuildingSiteNumber = model.BuildingSiteNumber; // Building Site Number
        BuildingYearBuilt = model.BuildingYearBuilt; // Building Year Built
        BuildingYearOfLastModernization = model.BuildingYearOfLastModernization; // Building Year of Last Modernization
        FacilityAcquisitionDate = model.FacilityAcquisitionDate; // Facility Acquisition Date
        FacilityBuildingPermanency = model.FacilityBuildingPermanency; // Facility Building Permanency
        FacilityExpectedLife = model.FacilityExpectedLife; // Facility Expected Life
        FacilityOwnershipIndicator = model.FacilityOwnershipIndicator; // Facility Ownership Indicator
        Identifier = model.Identifier; // Facilities Identifier
        OrganizationId = model.OrganizationId; // 
        RefBuildingHistoricStatusId = model.RefBuildingHistoricStatusId; // Building Historic Status
        RefBuildingPrimaryUseTypeId = model.RefBuildingPrimaryUseTypeId; // Building Primary Use Type
        RefBuildingUseTypeId = model.RefBuildingUseTypeId; // Building Use Type
        RefCampusStatusId = model.RefCampusStatusId; // Campus Status
        RefCampusTypeId = model.RefCampusTypeId; // Campus Facility Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
