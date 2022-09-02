//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementPlanViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityManagementPlan file
/// </summary>
public partial class FacilityManagementPlanViewModel : ObservableValidator, IFacilityManagementPlan
{
    #region "FacilityManagementPlanViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityManagementPlanViewModel Constructor
    /// </summary>
    public FacilityManagementPlanViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityManagementPlanViewModelConstruction();
    }

    /// <summary>
    /// FacilityManagementPlanViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityManagementPlanViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityManagementPlan";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FacilitiesPlanDescription -- (backing property for Facilities Plan Description)
    private System.String facilitiesPlanDescription;

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

    #region "IFacilityManagementPlan Properties"
    /// <summary>
    /// Facilities Plan Description
    /// <para>
    /// A description of the management and accountability plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20863">Facilities Plan Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Facilities Plan Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilitiesPlanDescription { get => facilitiesPlanDescription; set => SetProperty(ref facilitiesPlanDescription, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityManagement"/> model
    /// </summary>
    public Guid FacilityManagementId { get; set; }

    /// <summary>
    /// Facilities Management Emergency Type
    /// <para>
    /// The type of abnormal and urgent circumstances that disrupt the normal operation of the building, threaten the health and safety of the occupants, or require an emergency response.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20852">Facilities Management Emergency Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facilities Management Emergency Type")]
    public Guid? RefFacilitiesMgmtEmergencyTypeId { get; set; }

    /// <summary>
    /// Facilities Plan Type
    /// <para>
    /// The type of management and accountability plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20864">Facilities Plan Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facilities Plan Type")]
    public Guid? RefFacilitiesPlanTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityManagementPlan model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilitiesPlanDescription = model.FacilitiesPlanDescription; // Facilities Plan Description
        FacilityManagementId = model.FacilityManagementId; // 
        RefFacilitiesMgmtEmergencyTypeId = model.RefFacilitiesMgmtEmergencyTypeId; // Facilities Management Emergency Type
        RefFacilitiesPlanTypeId = model.RefFacilitiesPlanTypeId; // Facilities Plan Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
