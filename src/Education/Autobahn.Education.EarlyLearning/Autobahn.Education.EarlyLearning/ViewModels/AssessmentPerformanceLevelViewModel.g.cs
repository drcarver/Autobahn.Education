//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   AssessmentPerformanceLevelViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPerformanceLevel file
/// </summary>
public partial class AssessmentPerformanceLevelViewModel : ObservableValidator, IAssessmentPerformanceLevel
{
    #region "AssessmentPerformanceLevelViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentPerformanceLevelViewModel Constructor
    /// </summary>
    public AssessmentPerformanceLevelViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentPerformanceLevelViewModelConstruction();
    }

    /// <summary>
    /// AssessmentPerformanceLevelViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentPerformanceLevelViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentPerformanceLevel";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // DescriptiveFeedback -- (backing property for Assessment Performance Level Descriptive Feedback)
    private System.String descriptiveFeedback;

    // Identifier -- (backing property for Assessment Performance Level Identifier)
    private System.String identifier;

    // Label -- (backing property for Assessment Performance Level Label)
    private System.String label;

    // LowerCutScore -- (backing property for Assessment Performance Level Lower Cut Score)
    private System.String lowerCutScore;

    // ScoreMetric -- (backing property for Assessment Performance Level Score Metric)
    private System.String scoreMetric;

    // UpperCutScore -- (backing property for Assessment Performance Level Upper Cut Score)
    private System.String upperCutScore;

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

    #region "IAssessmentPerformanceLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    public Guid? AssessmentSubtestId { get; set; }

    /// <summary>
    /// Assessment Performance Level Descriptive Feedback
    /// <para>
    /// A feedback message designed to be reported with the assessment performance level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20184">Assessment Performance Level Descriptive Feedback</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Performance Level Descriptive Feedback")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String DescriptiveFeedback { get => descriptiveFeedback; set => SetProperty(ref descriptiveFeedback, value, true); }

    /// <summary>
    /// Assessment Performance Level Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to an assessment performance level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19693">Assessment Performance Level Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Performance Level Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Assessment Performance Level Label
    /// <para>
    /// A label representing the performance level appropriate for use on a report.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19694">Assessment Performance Level Label</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Performance Level Label")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Label { get => label; set => SetProperty(ref label, value, true); }

    /// <summary>
    /// Assessment Performance Level Lower Cut Score
    /// <para>
    /// Lowest possible score for the performance level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19408">Assessment Performance Level Lower Cut Score</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Performance Level Lower Cut Score")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LowerCutScore { get => lowerCutScore; set => SetProperty(ref lowerCutScore, value, true); }

    /// <summary>
    /// Assessment Performance Level Score Metric
    /// <para>
    /// The metric or scale used for score reporting.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19407">Assessment Performance Level Score Metric</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Performance Level Score Metric")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScoreMetric { get => scoreMetric; set => SetProperty(ref scoreMetric, value, true); }

    /// <summary>
    /// Assessment Performance Level Upper Cut Score
    /// <para>
    /// Highest possible score for the performance level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19409">Assessment Performance Level Upper Cut Score</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Performance Level Upper Cut Score")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String UpperCutScore { get => upperCutScore; set => SetProperty(ref upperCutScore, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentPerformanceLevel model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentSubtestId = model.AssessmentSubtestId; // 
        DescriptiveFeedback = model.DescriptiveFeedback; // Assessment Performance Level Descriptive Feedback
        Identifier = model.Identifier; // Assessment Performance Level Identifier
        Label = model.Label; // Assessment Performance Level Label
        LowerCutScore = model.LowerCutScore; // Assessment Performance Level Lower Cut Score
        ScoreMetric = model.ScoreMetric; // Assessment Performance Level Score Metric
        UpperCutScore = model.UpperCutScore; // Assessment Performance Level Upper Cut Score
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
