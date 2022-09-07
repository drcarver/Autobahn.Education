//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityEnergyViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityEnergy file
/// </summary>
public partial class FacilityEnergyViewModel : ObservableValidator, IFacilityEnergy
{
    #region "FacilityEnergyViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilityEnergyViewModel Constructor
    /// </summary>
    public FacilityEnergyViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilityEnergyViewModelConstruction();
    }

    /// <summary>
    /// FacilityEnergyViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilityEnergyViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilityEnergy";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // BuildingEnergyServiceCompanyName -- (backing property for Building Energy Service Company Name)
    private System.String buildingEnergyServiceCompanyName;

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

    #region "IFacilityEnergy Properties"
    /// <summary>
    /// Building Energy Service Company Name
    /// <para>
    /// The name of the company that designs, procures, finances, installs, maintains, and guarantees the performance of energy conservation measures in an owner's facility or facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20850">Building Energy Service Company Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Energy Service Company Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BuildingEnergyServiceCompanyName { get => buildingEnergyServiceCompanyName; set => SetProperty(ref buildingEnergyServiceCompanyName, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Building Energy Source Type
    /// <para>
    /// The source of energy that directly powers a school district facility or building system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20851">Building Energy Source Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Energy Source Type")]
    public Guid? RefBuildingEnergySourceTypeId { get; set; }

    /// <summary>
    /// Facility Utility Provider Type
    /// <para>
    /// An indication of how utilities are supplied to a site or a building by a company or provider.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20859">Facility Utility Provider Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Utility Provider Type")]
    public Guid? RefFacilityUtilityProviderTypeId { get; set; }

    /// <summary>
    /// Facility Utility Type
    /// <para>
    /// The type of utility used in the operation of a facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20860">Facility Utility Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Utility Type")]
    public Guid? RefFacilityUtilityTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilityEnergy model)
    {
        IsBusy = true;
        Id = model.Id;
        BuildingEnergyServiceCompanyName = model.BuildingEnergyServiceCompanyName; // Building Energy Service Company Name
        FacilityId = model.FacilityId; // 
        RefBuildingEnergySourceTypeId = model.RefBuildingEnergySourceTypeId; // Building Energy Source Type
        RefFacilityUtilityProviderTypeId = model.RefFacilityUtilityProviderTypeId; // Facility Utility Provider Type
        RefFacilityUtilityTypeId = model.RefFacilityUtilityTypeId; // Facility Utility Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
