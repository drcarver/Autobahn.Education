//***************************************************************************
//* DomainName: Common Models
//* FileName:   AssessmentSubtestViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtest file
/// </summary>
public partial class AssessmentSubtestViewModel : ObservableValidator, IAssessmentSubtest
{
    #region "AssessmentSubtestViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentSubtestViewModel Constructor
    /// </summary>
    public AssessmentSubtestViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentSubtestViewModelConstruction();
    }

    /// <summary>
    /// AssessmentSubtestViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentSubtestViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentSubtest";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Abbreviation -- (backing property for Assessment Subtest Abbreviation)
    private System.String abbreviation;

    // ContainerOnly -- (backing property for Assessment Form Subtest Container Only)
    private System.String containerOnly;

    // Identifier -- (backing property for Assessment Subtest Identifier)
    private System.String identifier;

    // MaximumValue -- (backing property for Assessment Subtest Minimum Value)
    private System.String maximumValue;

    // MinimumValue -- (backing property for Assessment Subtest Maximum Value)
    private System.String minimumValue;

    // OptimalValue -- (backing property for Assessment Subtest Optimal Value)
    private System.String optimalValue;

    // PublishedDate -- (backing property for Assessment Subtest Published Date)
    private DateTime? publishedDate;

    // Rules -- (backing property for Assessment Subtest Rules)
    private System.String rules;

    // Tier -- (backing property for Assessment Form Subtest Tier)
    private Int32? tier;

    // Title -- (backing property for Assessment Subtest Title)
    private System.String title;

    // Version -- (backing property for Assessment Subtest Version)
    private System.String version;

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

    #region "IAssessmentSubtest Properties"
    /// <summary>
    /// Assessment Subtest Abbreviation
    /// <para>
    /// The shortened name identifying the assessment for use in reference and/or reports.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19367">Assessment Subtest Abbreviation</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Subtest Abbreviation")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Abbreviation { get => abbreviation; set => SetProperty(ref abbreviation, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    public Guid? AssessmentFormId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IChildOfAssessmentSubtest"/> model
    /// </summary>
    public Guid? ChildOfAssessmentSubtestId { get; set; }

    /// <summary>
    /// Assessment Form Subtest Container Only
    /// <para>
    /// In a hierarchy of subtests, this indicates that this tier is only used as a level in the hierarchy and does not represent a scoring model.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20181">Assessment Form Subtest Container Only</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Subtest Container Only")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ContainerOnly { get => containerOnly; set => SetProperty(ref containerOnly, value, true); }

    /// <summary>
    /// Assessment Subtest Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to an assessment subtest.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19366">Assessment Subtest Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Subtest Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Assessment Subtest Minimum Value
    /// <para>
    /// The minimum value possible for the measurement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19387">Assessment Subtest Minimum Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Subtest Minimum Value")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MaximumValue { get => maximumValue; set => SetProperty(ref maximumValue, value, true); }

    /// <summary>
    /// Assessment Subtest Maximum Value
    /// <para>
    /// The maximum value for the measurement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19388">Assessment Subtest Maximum Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Subtest Maximum Value")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MinimumValue { get => minimumValue; set => SetProperty(ref minimumValue, value, true); }

    /// <summary>
    /// Assessment Subtest Optimal Value
    /// <para>
    /// The optimal value for this measurement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19389">Assessment Subtest Optimal Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Subtest Optimal Value")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OptimalValue { get => optimalValue; set => SetProperty(ref optimalValue, value, true); }

    /// <summary>
    /// Assessment Subtest Published Date
    /// <para>
    /// The date on which the Subtest was published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20075">Assessment Subtest Published Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Subtest Published Date")]
    public DateTime? PublishedDate { get => publishedDate; set => SetProperty(ref publishedDate, value, false); }

    /// <summary>
    /// Assessment Academic Subject
    /// <para>
    /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19021">Assessment Academic Subject</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Academic Subject")]
    public Guid? RefAcademicSubjectId { get; set; }

    /// <summary>
    /// Assessment Purpose
    /// <para>
    /// The reason for which an assessment is designed or delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19026">Assessment Purpose</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Purpose")]
    public Guid? RefAssessmentPurposeId { get; set; }

    /// <summary>
    /// Assessment Subtest Identifier Type
    /// <para>
    /// The type of identifier that is provided for a Subtest.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20016">Assessment Subtest Identifier Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Subtest Identifier Type")]
    public Guid? RefAssessmentSubtestIdentifierTypeId { get; set; }

    /// <summary>
    /// Assessment Content Standard Type
    /// <para>
    /// An indication as to whether an assessment conforms to a standard.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19598">Assessment Content Standard Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Content Standard Type")]
    public Guid? RefContentStandardTypeId { get; set; }

    /// <summary>
    /// Assessment Score Metric Type
    /// <para>
    /// The specific method used to report the performance and achievement of the assessment. This is the metric that is being used to derive the scores.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19368">Assessment Score Metric Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Score Metric Type")]
    public Guid? RefScoreMetricTypeId { get; set; }

    /// <summary>
    /// Assessment Subtest Rules
    /// <para>
    /// A description of the rules to produce a student test/subtest score from for a grouping of student item scores.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19695">Assessment Subtest Rules</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Subtest Rules")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Rules { get => rules; set => SetProperty(ref rules, value, true); }

    /// <summary>
    /// Assessment Form Subtest Tier
    /// <para>
    /// In a hierarchy of subtests, this element represents the level of the sub test in the hierarchy.  The top tier and default is zero.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20180">Assessment Form Subtest Tier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Subtest Tier")]
    public Int32? Tier { get => tier; set => SetProperty(ref tier, value, false); }

    /// <summary>
    /// Assessment Subtest Title
    /// <para>
    /// The name or title of the subtest.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19275">Assessment Subtest Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Subtest Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get => title; set => SetProperty(ref title, value, true); }

    /// <summary>
    /// Assessment Subtest Version
    /// <para>
    /// The version of the subtest that is included for the assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19379">Assessment Subtest Version</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Subtest Version")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Version { get => version; set => SetProperty(ref version, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentSubtest model)
    {
        IsBusy = true;
        Id = model.Id;
        Abbreviation = model.Abbreviation; // Assessment Subtest Abbreviation
        AssessmentFormId = model.AssessmentFormId; // 
        ChildOfAssessmentSubtestId = model.ChildOfAssessmentSubtestId; // 
        ContainerOnly = model.ContainerOnly; // Assessment Form Subtest Container Only
        Identifier = model.Identifier; // Assessment Subtest Identifier
        MaximumValue = model.MaximumValue; // Assessment Subtest Minimum Value
        MinimumValue = model.MinimumValue; // Assessment Subtest Maximum Value
        OptimalValue = model.OptimalValue; // Assessment Subtest Optimal Value
        PublishedDate = model.PublishedDate; // Assessment Subtest Published Date
        RefAcademicSubjectId = model.RefAcademicSubjectId; // Assessment Academic Subject
        RefAssessmentPurposeId = model.RefAssessmentPurposeId; // Assessment Purpose
        RefAssessmentSubtestIdentifierTypeId = model.RefAssessmentSubtestIdentifierTypeId; // Assessment Subtest Identifier Type
        RefContentStandardTypeId = model.RefContentStandardTypeId; // Assessment Content Standard Type
        RefScoreMetricTypeId = model.RefScoreMetricTypeId; // Assessment Score Metric Type
        Rules = model.Rules; // Assessment Subtest Rules
        Tier = model.Tier; // Assessment Form Subtest Tier
        Title = model.Title; // Assessment Subtest Title
        Version = model.Version; // Assessment Subtest Version
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
