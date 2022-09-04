//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ActivityViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IActivity file
/// </summary>
public partial class ActivityViewModel : ObservableValidator, IActivity
{
    #region "ActivityViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ActivityViewModel Constructor
    /// </summary>
    public ActivityViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnActivityViewModelConstruction();
    }

    /// <summary>
    /// ActivityViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnActivityViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Activity";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ActivityDescription -- (backing property for Activity Description)
    private System.String activityDescription;

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

    #region "IActivity Properties"
    /// <summary>
    /// Activity Description
    /// <para>
    /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20505">Activity Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Activity Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ActivityDescription { get => activityDescription; set => SetProperty(ref activityDescription, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IActivity model)
    {
        IsBusy = true;
        Id = model.Id;
        ActivityDescription = model.ActivityDescription; // Activity Description
        OrganizationId = model.OrganizationId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
