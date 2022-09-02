//***************************************************************************
//* DomainName: Common Models
//* FileName:   GoalPerformanceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IGoalPerformance file
/// </summary>
public partial class GoalPerformanceViewModel : ObservableValidator, IGoalPerformance
{
    #region "GoalPerformanceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// GoalPerformanceViewModel Constructor
    /// </summary>
    public GoalPerformanceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnGoalPerformanceViewModelConstruction();
    }

    /// <summary>
    /// GoalPerformanceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnGoalPerformanceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from GoalPerformance";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CurrentPerformanceDescription -- (backing property for Goal Current Performance Description)
    private System.String currentPerformanceDescription;

    // member variable for the Date property
    private DateTime? date;

    // Status -- (backing property for Goal Status)
    private System.String status;

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

    #region "IGoalPerformance Properties"
    /// <summary>
    /// Goal Current Performance Description
    /// <para>
    /// Current performance explanation related to the annual goal or short-term objectives.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20671">Goal Current Performance Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Current Performance Description")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String CurrentPerformanceDescription { get => currentPerformanceDescription; set => SetProperty(ref currentPerformanceDescription, value, true); }

    public DateTime? Date { get => date; set => SetProperty(ref date, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoal"/> model
    /// </summary>
    public Guid GoalId { get; set; }

    /// <summary>
    /// Goal Status Type
    /// <para>
    /// Status toward achievement of the annual goal or short-term objectives.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20683">Goal Status Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Status Type")]
    public Guid? RefGoalStatusTypeId { get; set; }

    /// <summary>
    /// Goal Status
    /// <para>
    /// Description of status toward achievement of the annual goal or short-term objectives.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20684">Goal Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Status")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Status { get => status; set => SetProperty(ref status, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IGoalPerformance model)
    {
        IsBusy = true;
        Id = model.Id;
        CurrentPerformanceDescription = model.CurrentPerformanceDescription; // Goal Current Performance Description
        Date = model.Date; // 
        GoalId = model.GoalId; // 
        RefGoalStatusTypeId = model.RefGoalStatusTypeId; // Goal Status Type
        Status = model.Status; // Goal Status
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
