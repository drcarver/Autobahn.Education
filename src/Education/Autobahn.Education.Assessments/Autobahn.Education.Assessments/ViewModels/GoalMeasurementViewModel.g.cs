//***************************************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IGoalMeasurement file
/// </summary>
public partial class GoalMeasurementViewModel : ObservableValidator, IGoalMeasurement
{
    #region "GoalMeasurementViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// GoalMeasurementViewModel Constructor
    /// </summary>
    public GoalMeasurementViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnGoalMeasurementViewModelConstruction();
    }

    /// <summary>
    /// GoalMeasurementViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnGoalMeasurementViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from GoalMeasurement";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Schedule -- (backing property for Goal Measurement Schedule)
    private System.String schedule;

    // SuccessCriteria -- (backing property for Goal Success Criteria)
    private System.String successCriteria;

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

    #region "IGoalMeasurement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoal"/> model
    /// </summary>
    public Guid GoalId { get; set; }

    /// <summary>
    /// Goal Measurement Type
    /// <para>
    /// Type of evidence appropriate for assessing achievement of a goal or short-term objective.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20678">Goal Measurement Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Measurement Type")]
    public Guid? RefGoalMeasurementTypeId { get; set; }

    /// <summary>
    /// Goal Measurement Schedule
    /// <para>
    /// Frequency of evaluation of progress toward meeting the goal or short-term objective.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20677">Goal Measurement Schedule</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Measurement Schedule")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Schedule { get => schedule; set => SetProperty(ref schedule, value, true); }

    /// <summary>
    /// Goal Success Criteria
    /// <para>
    /// One or more statements that describes the criteria used by teachers and students to check for attainment of a goal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19902">Goal Success Criteria</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Success Criteria")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SuccessCriteria { get => successCriteria; set => SetProperty(ref successCriteria, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IGoalMeasurement model)
    {
        IsBusy = true;
        Id = model.Id;
        GoalId = model.GoalId; // 
        RefGoalMeasurementTypeId = model.RefGoalMeasurementTypeId; // Goal Measurement Type
        Schedule = model.Schedule; // Goal Measurement Schedule
        SuccessCriteria = model.SuccessCriteria; // Goal Success Criteria
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
