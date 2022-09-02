//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationDetailViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationDetail file
/// </summary>
public partial class OrganizationDetailViewModel : ObservableValidator, IOrganizationDetail
{
    #region "OrganizationDetailViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationDetailViewModel Constructor
    /// </summary>
    public OrganizationDetailViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationDetailViewModelConstruction();
    }

    /// <summary>
    /// OrganizationDetailViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationDetailViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationDetail";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Name -- (backing property for Activity Title)
    private System.String name;

    // member variable for the RegionGeoJson property
    private System.String regionGeoJson;

    // ShortName -- (backing property for Short Name of Institution)
    private System.String shortName;

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

    #region "IOrganizationDetail Properties"
    /// <summary>
    /// Activity Title
    /// <para>
    /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19009">Activity Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Activity Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(128,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get => name; set => SetProperty(ref name, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
    /// </summary>
    public Guid? RefOrganizationTypeId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2000,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RegionGeoJson { get => regionGeoJson; set => SetProperty(ref regionGeoJson, value, true); }

    /// <summary>
    /// Short Name of Institution
    /// <para>
    /// The name of the institution, which may be the abbreviated form of the full legally accepted name.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20459">Short Name of Institution</a>
    /// </para>
    /// </summary>
    [DisplayName("Short Name of Institution")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ShortName { get => shortName; set => SetProperty(ref shortName, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationDetail model)
    {
        IsBusy = true;
        Id = model.Id;
        Name = model.Name; // Activity Title
        OrganizationId = model.OrganizationId; // 
        RefOrganizationTypeId = model.RefOrganizationTypeId; // 
        RegionGeoJson = model.RegionGeoJson; // 
        ShortName = model.ShortName; // Short Name of Institution
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
