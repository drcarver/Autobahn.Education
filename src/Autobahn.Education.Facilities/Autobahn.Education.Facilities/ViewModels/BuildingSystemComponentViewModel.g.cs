//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSystemComponent file
/// </summary>
public partial class BuildingSystemComponentViewModel : ObservableValidator, IBuildingSystemComponent
{
    #region "BuildingSystemComponentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// BuildingSystemComponentViewModel Constructor
    /// </summary>
    public BuildingSystemComponentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnBuildingSystemComponentViewModelConstruction();
    }

    /// <summary>
    /// BuildingSystemComponentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnBuildingSystemComponentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from BuildingSystemComponent";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // BuildingInstitutionalEquipmentDescription -- (backing property for Building Institutional Equipment Description)
    private System.String buildingInstitutionalEquipmentDescription;

    // ComponentOrFixtureUsefulLife -- (backing property for Component or Fixture Useful Life)
    private Int32? componentOrFixtureUsefulLife;

    // Identifier -- (backing property for Facility Component Identification Code)
    private System.String identifier;

    // InstallationDate -- (backing property for Installation Date)
    private System.String installationDate;

    // LifecycleCost -- (backing property for Life-cycle Cost)
    private Decimal? lifecycleCost;

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
    [DisplayName("Building Institutional Equipment Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingInstitutionalEquipmentDescription { get => buildingInstitutionalEquipmentDescription; set => SetProperty(ref buildingInstitutionalEquipmentDescription, value, true); }

    /// <summary>
    /// Component or Fixture Useful Life
    /// <para>
    /// The anticipated time (in years) from the time of installation or service that a properly maintained system, component, equipment, or fixture is expected to operate effectively and efficiently.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20882">Component or Fixture Useful Life</a>
    /// </para>
    /// </summary>
    [DisplayName("Component or Fixture Useful Life")]
    public Int32? ComponentOrFixtureUsefulLife { get => componentOrFixtureUsefulLife; set => SetProperty(ref componentOrFixtureUsefulLife, value, false); }

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
    [DisplayName("Facility Component Identification Code")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Installation Date
    /// <para>
    /// The year in which the system, component, equipment, or fixture was originally installed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20829">Installation Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Installation Date")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String InstallationDate { get => installationDate; set => SetProperty(ref installationDate, value, true); }

    /// <summary>
    /// Life-cycle Cost
    /// <para>
    /// The total cost of acquiring, owning, operating, and disposing of a building, facility, or piece of equipment over its useful life.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20830">Life-cycle Cost</a>
    /// </para>
    /// </summary>
    [DisplayName("Life-cycle Cost")]
    public Decimal? LifecycleCost { get => lifecycleCost; set => SetProperty(ref lifecycleCost, value, false); }

    /// <summary>
    /// Facility Furnishings Type
    /// <para>
    /// Moveable assets that are provided so the building or interior assets can be utilized by occupants for their intended purposes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20801">Facility Furnishings Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Furnishings Type")]
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
    [DisplayName("Facility System or Component Condition")]
    public Guid? RefFacilitySystemOrComponentConditionId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IBuildingSystemComponent model)
    {
        IsBusy = true;
        Id = model.Id;
        BuildingInstitutionalEquipmentDescription = model.BuildingInstitutionalEquipmentDescription; // Building Institutional Equipment Description
        ComponentOrFixtureUsefulLife = model.ComponentOrFixtureUsefulLife; // Component or Fixture Useful Life
        FacilityId = model.FacilityId; // 
        Identifier = model.Identifier; // Facility Component Identification Code
        InstallationDate = model.InstallationDate; // Installation Date
        LifecycleCost = model.LifecycleCost; // Life-cycle Cost
        RefFacilityFurnishingsTypeId = model.RefFacilityFurnishingsTypeId; // Facility Furnishings Type
        RefFacilitySystemOrComponentConditionId = model.RefFacilitySystemOrComponentConditionId; // Facility System or Component Condition
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
