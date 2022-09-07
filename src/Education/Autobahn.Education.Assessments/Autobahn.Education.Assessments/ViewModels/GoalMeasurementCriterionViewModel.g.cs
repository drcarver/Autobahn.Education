//***************************************************************************
//* DomainName: Assessments
//* FileName:   GoalMeasurementCriterionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IGoalMeasurementCriterion file
/// </summary>
public partial class GoalMeasurementCriterionViewModel : ObservableValidator, IGoalMeasurementCriterion
{
    #region "GoalMeasurementCriterionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// GoalMeasurementCriterionViewModel Constructor
    /// </summary>
    public GoalMeasurementCriterionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnGoalMeasurementCriterionViewModelConstruction();
    }

    /// <summary>
    /// GoalMeasurementCriterionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnGoalMeasurementCriterionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from GoalMeasurementCriterion";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AccuracyPercent -- (backing property for Goal Measurement Criterion Accuracy Percent)
    private Decimal? accuracyPercent;

    // AttemptsCount -- (backing property for Goal Measurement Criterion Attempts Count)
    private Int32? attemptsCount;

    // Metric -- (backing property for Goal Measurement Criterion Metric)
    private System.String metric;

    // SuccessCount -- (backing property for Goal Measurement Criterion Success Count)
    private Int32? successCount;

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

    #region "IGoalMeasurementCriterion Properties"
    /// <summary>
    /// Goal Measurement Criterion Accuracy Percent
    /// <para>
    /// The percent of correct results that will be considered to represent successful achievement of a goal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20672">Goal Measurement Criterion Accuracy Percent</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Measurement Criterion Accuracy Percent")]
    public Decimal? AccuracyPercent { get => accuracyPercent; set => SetProperty(ref accuracyPercent, value, false); }

    /// <summary>
    /// Goal Measurement Criterion Attempts Count
    /// <para>
    /// The number of attempts representing a completed trial for assessing achievement of a goal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20673">Goal Measurement Criterion Attempts Count</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Measurement Criterion Attempts Count")]
    public Int32? AttemptsCount { get => attemptsCount; set => SetProperty(ref attemptsCount, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IGoalMeasurement"/> model
    /// </summary>
    public Guid GoalMeasurementId { get; set; }

    /// <summary>
    /// Goal Measurement Criterion Metric
    /// <para>
    /// A metric used for evaluating achievement of a goal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20674">Goal Measurement Criterion Metric</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Measurement Criterion Metric")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Metric { get => metric; set => SetProperty(ref metric, value, true); }

    /// <summary>
    /// Goal Measurement Criterion Success Count
    /// <para>
    /// The number of correct results that will be considered to represent successful achievement of a goal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20675">Goal Measurement Criterion Success Count</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Measurement Criterion Success Count")]
    public Int32? SuccessCount { get => successCount; set => SetProperty(ref successCount, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IGoalMeasurementCriterion model)
    {
        IsBusy = true;
        Id = model.Id;
        AccuracyPercent = model.AccuracyPercent; // Goal Measurement Criterion Accuracy Percent
        AttemptsCount = model.AttemptsCount; // Goal Measurement Criterion Attempts Count
        GoalMeasurementId = model.GoalMeasurementId; // 
        Metric = model.Metric; // Goal Measurement Criterion Metric
        SuccessCount = model.SuccessCount; // Goal Measurement Criterion Success Count
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
