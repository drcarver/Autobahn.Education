//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolIndicatorStatusViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolIndicatorStatus file
/// </summary>
public partial class K12schoolIndicatorStatusViewModel : ObservableValidator, IK12schoolIndicatorStatus
{
    #region "K12schoolIndicatorStatusViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12schoolIndicatorStatusViewModel Constructor
    /// </summary>
    public K12schoolIndicatorStatusViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12schoolIndicatorStatusViewModelConstruction();
    }

    /// <summary>
    /// K12schoolIndicatorStatusViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12schoolIndicatorStatusViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12schoolIndicatorStatus";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the IndicatorStatus property
    private System.String indicatorStatus;

    // member variable for the IndicatorStatusSubgroup property
    private System.String indicatorStatusSubgroup;

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

    #region "IK12schoolIndicatorStatus Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IndicatorStatus { get => indicatorStatus; set => SetProperty(ref indicatorStatus, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IndicatorStatusSubgroup { get => indicatorStatusSubgroup; set => SetProperty(ref indicatorStatusSubgroup, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
    /// </summary>
    public Guid? RefIndicatorStateDefinedStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
    /// </summary>
    public Guid? RefIndicatorStatusCustomTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupType"/> model
    /// </summary>
    public Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIndicatorStatusType"/> model
    /// </summary>
    public Guid RefIndicatorStatusTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12schoolIndicatorStatus model)
    {
        IsBusy = true;
        Id = model.Id;
        IndicatorStatus = model.IndicatorStatus; // 
        IndicatorStatusSubgroup = model.IndicatorStatusSubgroup; // 
        K12schoolId = model.K12schoolId; // 
        RefIndicatorStateDefinedStatusId = model.RefIndicatorStateDefinedStatusId; // 
        RefIndicatorStatusCustomTypeId = model.RefIndicatorStatusCustomTypeId; // 
        RefIndicatorStatusSubgroupTypeId = model.RefIndicatorStatusSubgroupTypeId; // 
        RefIndicatorStatusTypeId = model.RefIndicatorStatusTypeId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
