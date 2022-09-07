//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityDesign file
/// </summary>
public partial class FacilityDesignViewModel : ObservableValidator, IFacilityDesign
{
    #region "FacilityDesignViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityDesignViewModel Constructor
    /// </summary>
    public FacilityDesignViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityDesignViewModelConstruction();
    }

    /// <summary>
    /// FacilityDesignViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityDesignViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityDesign";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // BuildingArchitectName -- (backing property for Building Architect Name)
    private System.String buildingArchitectName;

    // BuildingArchitecturalFirmName -- (backing property for Building Architectural Firm Name)
    private System.String buildingArchitecturalFirmName;

    // BuildingDateOfCertificateOfOccupancy -- (backing property for Building Date of Certificate of Occupancy)
    private DateTime? buildingDateOfCertificateOfOccupancy;

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

    #region "IFacilityDesign Properties"
    /// <summary>
    /// Building Architect Name
    /// <para>
    /// The name of the architect of record for the building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20815">Building Architect Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Architect Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(45,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingArchitectName { get => buildingArchitectName; set => SetProperty(ref buildingArchitectName, value, true); }

    /// <summary>
    /// Building Architectural Firm Name
    /// <para>
    /// The name of the architectural firm responsible for the building design.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20816">Building Architectural Firm Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Architectural Firm Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingArchitecturalFirmName { get => buildingArchitecturalFirmName; set => SetProperty(ref buildingArchitecturalFirmName, value, true); }

    /// <summary>
    /// Building Date of Certificate of Occupancy
    /// <para>
    /// The month, day and year in which a certificate of occupancy was granted by the appropriate local authority.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20861">Building Date of Certificate of Occupancy</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Date of Certificate of Occupancy")]
    public DateTime? BuildingDateOfCertificateOfOccupancy { get => buildingDateOfCertificateOfOccupancy; set => SetProperty(ref buildingDateOfCertificateOfOccupancy, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Building Design Type
    /// <para>
    /// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20797">Building Design Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Design Type")]
    public Guid? RefBuildingDesignTypeId { get; set; }

    /// <summary>
    /// Building Environmental or Energy Performance Rating Category
    /// <para>
    /// The primary groupings that rating organizations use to evaluate environmental sustainability and energy use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20800">Building Environmental or Energy Performance Rating Category</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Environmental or Energy Performance Rating Category")]
    public Guid? RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityDesign model)
    {
        IsBusy = true;
        Id = model.Id;
        BuildingArchitectName = model.BuildingArchitectName; // Building Architect Name
        BuildingArchitecturalFirmName = model.BuildingArchitecturalFirmName; // Building Architectural Firm Name
        BuildingDateOfCertificateOfOccupancy = model.BuildingDateOfCertificateOfOccupancy; // Building Date of Certificate of Occupancy
        FacilityId = model.FacilityId; // 
        RefBuildingDesignTypeId = model.RefBuildingDesignTypeId; // Building Design Type
        RefBuildingEnvOrEnergyPerformanceRatingCatId = model.RefBuildingEnvOrEnergyPerformanceRatingCatId; // Building Environmental or Energy Performance Rating Category
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
