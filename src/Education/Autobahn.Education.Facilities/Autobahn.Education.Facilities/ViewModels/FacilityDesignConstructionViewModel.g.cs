//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignConstructionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityDesignConstruction file
/// </summary>
public partial class FacilityDesignConstructionViewModel : ObservableValidator, IFacilityDesignConstruction
{
    #region "FacilityDesignConstructionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityDesignConstructionViewModel Constructor
    /// </summary>
    public FacilityDesignConstructionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityDesignConstructionViewModelConstruction();
    }

    /// <summary>
    /// FacilityDesignConstructionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityDesignConstructionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityDesignConstruction";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // BuildingAdditionCode -- (backing property for Building Addition Code)
    private System.String buildingAdditionCode;

    // BuildingAdditionDescription -- (backing property for Building Addition Description)
    private System.String buildingAdditionDescription;

    // BuildingSiteImprovementDescription -- (backing property for Building Site Improvement Description)
    private System.String buildingSiteImprovementDescription;

    // FacilityAdditionYear -- (backing property for Facility Addition Year)
    private System.String facilityAdditionYear;

    // FacilityConstructionDate -- (backing property for Facility Construction Date)
    private DateTime? facilityConstructionDate;

    // FacilityConstructionYear -- (backing property for Facility Construction Year)
    private System.String facilityConstructionYear;

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

    #region "IFacilityDesignConstruction Properties"
    /// <summary>
    /// Building Addition Code
    /// <para>
    /// A unique number or alphanumeric code assigned to a building addition by a school, school system, state, or other agency or entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20757">Building Addition Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Addition Code")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingAdditionCode { get => buildingAdditionCode; set => SetProperty(ref buildingAdditionCode, value, true); }

    /// <summary>
    /// Building Addition Description
    /// <para>
    /// A description of the permanent structure added to the original building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20756">Building Addition Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Addition Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingAdditionDescription { get => buildingAdditionDescription; set => SetProperty(ref buildingAdditionDescription, value, true); }

    /// <summary>
    /// Building Site Improvement Description
    /// <para>
    /// A description of the designed and constructed improvements made to a site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20831">Building Site Improvement Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Site Improvement Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingSiteImprovementDescription { get => buildingSiteImprovementDescription; set => SetProperty(ref buildingSiteImprovementDescription, value, true); }

    /// <summary>
    /// Facility Addition Year
    /// <para>
    /// The year the construction on the addition was completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20750">Facility Addition Year</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Addition Year")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilityAdditionYear { get => facilityAdditionYear; set => SetProperty(ref facilityAdditionYear, value, true); }

    /// <summary>
    /// Facility Construction Date
    /// <para>
    /// The month, day, and year on which construction of a building, addition, or improvement was completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20761">Facility Construction Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Construction Date")]
    public DateTime? FacilityConstructionDate { get => facilityConstructionDate; set => SetProperty(ref facilityConstructionDate, value, false); }

    /// <summary>
    /// Facility Construction Year
    /// <para>
    /// The year the building was first constructed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20752">Facility Construction Year</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Construction Year")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilityConstructionYear { get => facilityConstructionYear; set => SetProperty(ref facilityConstructionYear, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityDesign"/> model
    /// </summary>
    public Guid FacilityDesignId { get; set; }

    /// <summary>
    /// Building Energy Conservation Measure Type
    /// <para>
    /// The type of modification to, or replacement of, a piece of equipment or building shell/system that increases energy efficiency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20849">Building Energy Conservation Measure Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Energy Conservation Measure Type")]
    public Guid? RefBuildingEnergyConservationMeasureTypeId { get; set; }

    /// <summary>
    /// Facility Construction Date Type
    /// <para>
    /// Designation of the nature of the construction completion date.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20762">Facility Construction Date Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Construction Date Type")]
    public Guid? RefFacilityConstructionDateTypeId { get; set; }

    /// <summary>
    /// Facility Construction Material Type
    /// <para>
    /// The primary material used for the construction of a building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20763">Facility Construction Material Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Construction Material Type")]
    public Guid? RefFacilityConstructionMaterialTypeId { get; set; }

    /// <summary>
    /// Facility Joint Development Type
    /// <para>
    /// The type of development where two or more entities partner to plan, site, design, and/or build a new school or renovate an existing school to better support the joint use of the building and/or land.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20856">Facility Joint Development Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Joint Development Type")]
    public Guid? RefFacilityJointDevelopmentTypeId { get; set; }

    /// <summary>
    /// Facility Site Improvement Location Type
    /// <para>
    /// The type of location of the designed and constructed improvements made to a site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20768">Facility Site Improvement Location Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Site Improvement Location Type")]
    public Guid? RefFacilitySiteImprovementLocationTypeId { get; set; }

    /// <summary>
    /// Facility Standard Type
    /// <para>
    /// An indication of the district or state requirements or guidelines for the design and construction of school facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20865">Facility Standard Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Standard Type")]
    public Guid? RefFacilityStandardTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityDesignConstruction model)
    {
        IsBusy = true;
        Id = model.Id;
        BuildingAdditionCode = model.BuildingAdditionCode; // Building Addition Code
        BuildingAdditionDescription = model.BuildingAdditionDescription; // Building Addition Description
        BuildingSiteImprovementDescription = model.BuildingSiteImprovementDescription; // Building Site Improvement Description
        FacilityAdditionYear = model.FacilityAdditionYear; // Facility Addition Year
        FacilityConstructionDate = model.FacilityConstructionDate; // Facility Construction Date
        FacilityConstructionYear = model.FacilityConstructionYear; // Facility Construction Year
        FacilityDesignId = model.FacilityDesignId; // 
        RefBuildingEnergyConservationMeasureTypeId = model.RefBuildingEnergyConservationMeasureTypeId; // Building Energy Conservation Measure Type
        RefFacilityConstructionDateTypeId = model.RefFacilityConstructionDateTypeId; // Facility Construction Date Type
        RefFacilityConstructionMaterialTypeId = model.RefFacilityConstructionMaterialTypeId; // Facility Construction Material Type
        RefFacilityJointDevelopmentTypeId = model.RefFacilityJointDevelopmentTypeId; // Facility Joint Development Type
        RefFacilitySiteImprovementLocationTypeId = model.RefFacilitySiteImprovementLocationTypeId; // Facility Site Improvement Location Type
        RefFacilityStandardTypeId = model.RefFacilityStandardTypeId; // Facility Standard Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
