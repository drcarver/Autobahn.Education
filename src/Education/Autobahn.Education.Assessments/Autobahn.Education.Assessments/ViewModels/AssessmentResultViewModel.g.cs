//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentResult file
/// </summary>
public partial class AssessmentResultViewModel : ObservableValidator, IAssessmentResult
{
    #region "AssessmentResultViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentResultViewModel Constructor
    /// </summary>
    public AssessmentResultViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentResultViewModelConstruction();
    }

    /// <summary>
    /// AssessmentResultViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentResultViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentResult";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AssessmentResultDescriptiveFeedbackDateTime -- (backing property for Assessment Result Descriptive Feedback Date Time)
    private DateTime? assessmentResultDescriptiveFeedbackDateTime;

    // AssessmentResultScoreStandardError -- (backing property for Assessment Result Score Standard Error)
    private Decimal? assessmentResultScoreStandardError;

    // DateCreated -- (backing property for Assessment Result Date Created)
    private DateTime? dateCreated;

    // DateUpdated -- (backing property for Assessment Result Date Updated)
    private DateTime? dateUpdated;

    // DescriptiveFeedback -- (backing property for Assessment Result Descriptive Feedback)
    private System.String descriptiveFeedback;

    // DescriptiveFeedbackSource -- (backing property for Assessment Result Descriptive Feedback Source)
    private System.String descriptiveFeedbackSource;

    // DiagnosticStatement -- (backing property for Assessment Result Diagnostic Statement)
    private System.String diagnosticStatement;

    // DiagnosticStatementSource -- (backing property for Diagnostic Statement Source)
    private System.String diagnosticStatementSource;

    // member variable for the IncludedInAypCalculation property
    private Boolean? includedInAypCalculation;

    // InstructionalRecommendation -- (backing property for Instructional Recommendation)
    private System.String instructionalRecommendation;

    // NumberOfResponses -- (backing property for Assessment Result Number of Responses)
    private Int32? numberOfResponses;

    // PreliminaryIndicator -- (backing property for Assessment Result Preliminary Indicator)
    private Boolean? preliminaryIndicator;

    // ScoreValue -- (backing property for Assessment Result Score Value)
    private System.String scoreValue;

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

    #region "IAssessmentResult Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
    /// </summary>
    public Guid AssessmentRegistrationId { get; set; }

    /// <summary>
    /// Assessment Result Descriptive Feedback Date Time
    /// <para>
    /// The date and time the descriptive feedback was entered for a scored/evaluated portion of an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20520">Assessment Result Descriptive Feedback Date Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Descriptive Feedback Date Time")]
    public DateTime? AssessmentResultDescriptiveFeedbackDateTime { get => assessmentResultDescriptiveFeedbackDateTime; set => SetProperty(ref assessmentResultDescriptiveFeedbackDateTime, value, false); }

    /// <summary>
    /// Assessment Result Score Standard Error
    /// <para>
    /// The measure of sampling variability and measurement error for the score, the amount of error to be expected in the score.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20522">Assessment Result Score Standard Error</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Score Standard Error")]
    public Decimal? AssessmentResultScoreStandardError { get => assessmentResultScoreStandardError; set => SetProperty(ref assessmentResultScoreStandardError, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    public Guid AssessmentSubtestId { get; set; }

    /// <summary>
    /// Assessment Result Date Created
    /// <para>
    /// The date on which the assessment result was generated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19972">Assessment Result Date Created</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Date Created")]
    public DateTime? DateCreated { get => dateCreated; set => SetProperty(ref dateCreated, value, false); }

    /// <summary>
    /// Assessment Result Date Updated
    /// <para>
    /// The most recent date that the result was calculated/updated.  The value should be the same as Assessment Result Date Created if the subtest has only been scored once, but may be different if the score was recalculated with a different result.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19971">Assessment Result Date Updated</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Date Updated")]
    public DateTime? DateUpdated { get => dateUpdated; set => SetProperty(ref dateUpdated, value, false); }

    /// <summary>
    /// Assessment Result Descriptive Feedback
    /// <para>
    /// The formative descriptive feedback that was given to a learner based on a scored/evaluated portion of an assessment as recorded in the result entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19890">Assessment Result Descriptive Feedback</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Descriptive Feedback")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DescriptiveFeedback { get => descriptiveFeedback; set => SetProperty(ref descriptiveFeedback, value, true); }

    /// <summary>
    /// Assessment Result Descriptive Feedback Source
    /// <para>
    /// Identifies the source of the descriptive feedback that was given to a learner based on a scored/evaluated portion of an assessment. May indicate if this is teacher, scorer, or system generated feedback. Values for this attribute would be determined by the assessment program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20076">Assessment Result Descriptive Feedback Source</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Descriptive Feedback Source")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DescriptiveFeedbackSource { get => descriptiveFeedbackSource; set => SetProperty(ref descriptiveFeedbackSource, value, true); }

    /// <summary>
    /// Assessment Result Diagnostic Statement
    /// <para>
    /// A statement intended for use by education professionals, using professional terminology, to interpret learner needs based on the scored/evaluated portion of an assessment.  This statement may inform Descriptive Feedback given to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20185">Assessment Result Diagnostic Statement</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Diagnostic Statement")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String DiagnosticStatement { get => diagnosticStatement; set => SetProperty(ref diagnosticStatement, value, true); }

    /// <summary>
    /// Diagnostic Statement Source
    /// <para>
    /// Identifies the source of the Diagnostic Statement based on a scored/evaluated portion of an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20011">Diagnostic Statement Source</a>
    /// </para>
    /// </summary>
    [DisplayName("Diagnostic Statement Source")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DiagnosticStatementSource { get => diagnosticStatementSource; set => SetProperty(ref diagnosticStatementSource, value, true); }

    public Boolean? IncludedInAypCalculation { get => includedInAypCalculation; set => SetProperty(ref includedInAypCalculation, value, false); }

    /// <summary>
    /// Instructional Recommendation
    /// <para>
    /// This provides the next steps for instruction for the student based upon the assessment results and student characteristics.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19369">Instructional Recommendation</a>
    /// </para>
    /// </summary>
    [DisplayName("Instructional Recommendation")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String InstructionalRecommendation { get => instructionalRecommendation; set => SetProperty(ref instructionalRecommendation, value, true); }

    /// <summary>
    /// Assessment Result Number of Responses
    /// <para>
    /// The number of responses that are included with the Student Score Set. Responses are those items that were attempted (partially or fully answered) by the student and not necessarily the number of items in the assessment (which can be determined from the assessment object).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20012">Assessment Result Number of Responses</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Number of Responses")]
    public Int32? NumberOfResponses { get => numberOfResponses; set => SetProperty(ref numberOfResponses, value, false); }

    /// <summary>
    /// Assessment Result Preliminary Indicator
    /// <para>
    /// If this score is preliminary, then this attribute value should be set.  Preliminary scores may be provided for early use by the assessment program or user while final scoring is occurring.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20010">Assessment Result Preliminary Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Preliminary Indicator")]
    public Boolean? PreliminaryIndicator { get => preliminaryIndicator; set => SetProperty(ref preliminaryIndicator, value, false); }

    /// <summary>
    /// Assessment Result Pretest Outcome
    /// <para>
    /// The results of a pre-test in academic subjects.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19564">Assessment Result Pretest Outcome</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Pretest Outcome")]
    public Guid? RefAssessmentPretestOutcomeId { get; set; }

    /// <summary>
    /// Assessment Result Data Type
    /// <para>
    ///  The data type of the assessment result score value.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20518">Assessment Result Data Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Data Type")]
    public Guid? RefAssessmentResultDataTypeId { get; set; }

    /// <summary>
    /// Assessment Result Score Type
    /// <para>
    /// Indicates the purpose for which this assessment score instance was recorded.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20523">Assessment Result Score Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Score Type")]
    public Guid? RefAssessmentResultScoreTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEloutcomeMeasurementLevel"/> model
    /// </summary>
    public Guid? RefEloutcomeMeasurementLevelId { get; set; }

    /// <summary>
    /// Early Learning Outcome Time Point
    /// <para>
    /// The point in time for which the result is used for an outcome measure.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20475">Early Learning Outcome Time Point</a>
    /// </para>
    /// </summary>
    [DisplayName("Early Learning Outcome Time Point")]
    public Guid? RefOutcomeTimePointId { get; set; }

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
    /// Assessment Result Score Value
    /// <para>
    /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19245">Assessment Result Score Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Result Score Value")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(35,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScoreValue { get => scoreValue; set => SetProperty(ref scoreValue, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentResult model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentRegistrationId = model.AssessmentRegistrationId; // 
        AssessmentResultDescriptiveFeedbackDateTime = model.AssessmentResultDescriptiveFeedbackDateTime; // Assessment Result Descriptive Feedback Date Time
        AssessmentResultScoreStandardError = model.AssessmentResultScoreStandardError; // Assessment Result Score Standard Error
        AssessmentSubtestId = model.AssessmentSubtestId; // 
        DateCreated = model.DateCreated; // Assessment Result Date Created
        DateUpdated = model.DateUpdated; // Assessment Result Date Updated
        DescriptiveFeedback = model.DescriptiveFeedback; // Assessment Result Descriptive Feedback
        DescriptiveFeedbackSource = model.DescriptiveFeedbackSource; // Assessment Result Descriptive Feedback Source
        DiagnosticStatement = model.DiagnosticStatement; // Assessment Result Diagnostic Statement
        DiagnosticStatementSource = model.DiagnosticStatementSource; // Diagnostic Statement Source
        IncludedInAypCalculation = model.IncludedInAypCalculation; // 
        InstructionalRecommendation = model.InstructionalRecommendation; // Instructional Recommendation
        NumberOfResponses = model.NumberOfResponses; // Assessment Result Number of Responses
        PreliminaryIndicator = model.PreliminaryIndicator; // Assessment Result Preliminary Indicator
        RefAssessmentPretestOutcomeId = model.RefAssessmentPretestOutcomeId; // Assessment Result Pretest Outcome
        RefAssessmentResultDataTypeId = model.RefAssessmentResultDataTypeId; // Assessment Result Data Type
        RefAssessmentResultScoreTypeId = model.RefAssessmentResultScoreTypeId; // Assessment Result Score Type
        RefEloutcomeMeasurementLevelId = model.RefEloutcomeMeasurementLevelId; // 
        RefOutcomeTimePointId = model.RefOutcomeTimePointId; // Early Learning Outcome Time Point
        RefScoreMetricTypeId = model.RefScoreMetricTypeId; // Assessment Score Metric Type
        ScoreValue = model.ScoreValue; // Assessment Result Score Value
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
