//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElorganizationMonitoringViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElorganizationMonitoring file
/// </summary>
public partial class ElorganizationMonitoringViewModel : ObservableValidator, IElorganizationMonitoring
{
    #region "ElorganizationMonitoringViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElorganizationMonitoringViewModel Constructor
    /// </summary>
    public ElorganizationMonitoringViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElorganizationMonitoringViewModelConstruction();
    }

    /// <summary>
    /// ElorganizationMonitoringViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElorganizationMonitoringViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElorganizationMonitoring";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the TypeOfMonitoring property
    private System.String typeOfMonitoring;

    // member variable for the VisitEndDate property
    private DateTime? visitEndDate;

    // member variable for the VisitStartDate property
    private DateTime? visitStartDate;

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

    #region "IElorganizationMonitoring Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
    /// </summary>
    public Guid? RefOrganizationMonitoringNotificationsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPurposeOfMonitoringVisit"/> model
    /// </summary>
    public Guid? RefPurposeOfMonitoringVisitId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TypeOfMonitoring { get => typeOfMonitoring; set => SetProperty(ref typeOfMonitoring, value, true); }

    public DateTime? VisitEndDate { get => visitEndDate; set => SetProperty(ref visitEndDate, value, false); }

    public DateTime? VisitStartDate { get => visitStartDate; set => SetProperty(ref visitStartDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElorganizationMonitoring model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationId = model.OrganizationId; // 
        RefOrganizationMonitoringNotificationsId = model.RefOrganizationMonitoringNotificationsId; // 
        RefPurposeOfMonitoringVisitId = model.RefPurposeOfMonitoringVisitId; // 
        TypeOfMonitoring = model.TypeOfMonitoring; // 
        VisitEndDate = model.VisitEndDate; // 
        VisitStartDate = model.VisitStartDate; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
