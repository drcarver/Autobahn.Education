//***************************************************************************
//* DomainName: Organization Models
//* FileName:   ActivityRecognitionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IActivityRecognition file
/// </summary>
public partial class ActivityRecognitionViewModel : ObservableValidator, IActivityRecognition
{
    #region "ActivityRecognitionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ActivityRecognitionViewModel Constructor
    /// </summary>
    public ActivityRecognitionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnActivityRecognitionViewModelConstruction();
    }

    /// <summary>
    /// ActivityRecognitionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnActivityRecognitionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ActivityRecognition";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

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

    #region "IActivityRecognition Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Recognition for Participation or Performance in an Activity
    /// <para>
    /// The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19229">Recognition for Participation or Performance in an Activity</a>
    /// </para>
    /// </summary>
    [DisplayName("Recognition for Participation or Performance in an Activity")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefActivityRecognitionTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IActivityRecognition model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefActivityRecognitionTypeId = model.RefActivityRecognitionTypeId; // Recognition for Participation or Performance in an Activity
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
