//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemResponse file
/// </summary>
public partial class AssessmentItemResponseViewModel : ObservableValidator, IAssessmentItemResponse
{
    #region "AssessmentItemResponseViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentItemResponseViewModel Constructor
    /// </summary>
    public AssessmentItemResponseViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentItemResponseViewModelConstruction();
    }

    /// <summary>
    /// AssessmentItemResponseViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentItemResponseViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentItemResponse";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AidSetUsed -- (backing property for Assessment Item Response Aid Set Used)
    private System.String aidSetUsed;

    // AssessmentItemResponseDescriptiveFeedbackDate -- (backing property for Assessment Item Response Descriptive Feedback Date)
    private DateTime? assessmentItemResponseDescriptiveFeedbackDate;

    // DescriptiveFeedback -- (backing property for Assessment Item Response Descriptive Feedback)
    private System.String descriptiveFeedback;

    // Duration -- (backing property for Assessment Item Response Duration)
    private TimeSpan? duration;

    // FirstAttemptDuration -- (backing property for Assessment Item Response First Attempt Duration)
    private TimeSpan? firstAttemptDuration;

    // HintCount -- (backing property for Assessment Item Response Hint Count)
    private Int32? hintCount;

    // HintIncludedAnswer -- (backing property for Assessment Item Response Hint Included Answer)
    private Boolean? hintIncludedAnswer;

    // member variable for the ResultXml property
    private System.String resultXml;

    // ScaffoldingItemFlag -- (backing property for Assessment Item Response Scaffolding Item Flag)
    private Boolean? scaffoldingItemFlag;

    // ScoreValue -- (backing property for Assessment Item Response Score Value)
    private System.String scoreValue;

    // SecurityIssue -- (backing property for Assessment Item Response Security Issue)
    private System.String securityIssue;

    // StartDate -- (backing property for Assessment Item Response Start Date)
    private DateTime? startDate;

    // StartTime -- (backing property for Assessment Item Response Start Time)
    private TimeSpan? startTime;

    // Value -- (backing property for Assessment Item Response Value)
    private System.String value;

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

    #region "IAssessmentItemResponse Properties"
    /// <summary>
    /// Assessment Item Response Aid Set Used
    /// <para>
    /// A tool or aid set used while viewing the item. This can include things like a calculator, reference tools, etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19397">Assessment Item Response Aid Set Used</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Aid Set Used")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AidSetUsed { get => aidSetUsed; set => SetProperty(ref aidSetUsed, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Assessment Item Response Descriptive Feedback Date
    /// <para>
    /// The date and time the descriptive feedback was entered in response to the results from a scored/evaluated assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20512">Assessment Item Response Descriptive Feedback Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Descriptive Feedback Date")]
    public DateTime? AssessmentItemResponseDescriptiveFeedbackDate { get => assessmentItemResponseDescriptiveFeedbackDate; set => SetProperty(ref assessmentItemResponseDescriptiveFeedbackDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
    /// </summary>
    public Guid AssessmentParticipantSessionId { get; set; }

    /// <summary>
    /// Assessment Item Response Descriptive Feedback
    /// <para>
    /// The formative descriptive feedback that was given to a learner in response to the results from a scored/evaluated assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19891">Assessment Item Response Descriptive Feedback</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Descriptive Feedback")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DescriptiveFeedback { get => descriptiveFeedback; set => SetProperty(ref descriptiveFeedback, value, true); }

    /// <summary>
    /// Assessment Item Response Duration
    /// <para>
    /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19394">Assessment Item Response Duration</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Duration")]
    public TimeSpan? Duration { get => duration; set => SetProperty(ref duration, value, false); }

    /// <summary>
    /// Assessment Item Response First Attempt Duration
    /// <para>
    /// The amount of time in seconds or milliseconds that a person took to give an initial response, a first attempt to answer a formative assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19958">Assessment Item Response First Attempt Duration</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response First Attempt Duration")]
    public TimeSpan? FirstAttemptDuration { get => firstAttemptDuration; set => SetProperty(ref firstAttemptDuration, value, false); }

    /// <summary>
    /// Assessment Item Response Hint Count
    /// <para>
    /// The total number of hints presented as the learner responded to a formative assessment item.  This may include hints requested by the learner or hints automatically presented such as in an online tutoring system. Presentation of a scaffolding item is a separate response record and not counted as a hint.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19956">Assessment Item Response Hint Count</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Hint Count")]
    public Int32? HintCount { get => hintCount; set => SetProperty(ref hintCount, value, false); }

    /// <summary>
    /// Assessment Item Response Hint Included Answer
    /// <para>
    /// Indicates that one of the hints presented included the correct answer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19957">Assessment Item Response Hint Included Answer</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Hint Included Answer")]
    public Boolean? HintIncludedAnswer { get => hintIncludedAnswer; set => SetProperty(ref hintIncludedAnswer, value, false); }

    /// <summary>
    /// Assessment Item Response Score Status
    /// <para>
    /// The status of scoring a person's response to an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20513">Assessment Item Response Score Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Score Status")]
    public Guid? RefAssessmentItemResponseScoreStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentItemResponseStatus"/> model
    /// </summary>
    public Guid? RefAssessmentItemResponseStatusId { get; set; }

    /// <summary>
    /// Proficiency Status
    /// <para>
    /// An indication of whether a student's scores were proficient.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19565">Proficiency Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Proficiency Status")]
    public Guid? RefProficiencyStatusId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String ResultXml { get => resultXml; set => SetProperty(ref resultXml, value, true); }

    /// <summary>
    /// Assessment Item Response Scaffolding Item Flag
    /// <para>
    /// Indicates that the response is to a scaffolding problem rather than the main/assigned problem.  A scaffolding item is a follow-up formative assessment item used to assess prerequisite or component skills, presented immediately after a learner gives an incorrect answer on the previous item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19955">Assessment Item Response Scaffolding Item Flag</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Scaffolding Item Flag")]
    public Boolean? ScaffoldingItemFlag { get => scaffoldingItemFlag; set => SetProperty(ref scaffoldingItemFlag, value, false); }

    /// <summary>
    /// Assessment Item Response Score Value
    /// <para>
    /// The score given to a person's response to an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19700">Assessment Item Response Score Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Score Value")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScoreValue { get => scoreValue; set => SetProperty(ref scoreValue, value, true); }

    /// <summary>
    /// Assessment Item Response Security Issue
    /// <para>
    /// The description of security issue, if any, related to a learner's response to an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19970">Assessment Item Response Security Issue</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Security Issue")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SecurityIssue { get => securityIssue; set => SetProperty(ref securityIssue, value, true); }

    /// <summary>
    /// Assessment Item Response Start Date
    /// <para>
    /// The date on which the assessment item was presented to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19960">Assessment Item Response Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Start Date")]
    public DateTime? StartDate { get => startDate; set => SetProperty(ref startDate, value, false); }

    /// <summary>
    /// Assessment Item Response Start Time
    /// <para>
    /// The time of day that the assessment item was presented to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19959">Assessment Item Response Start Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Start Time")]
    public TimeSpan? StartTime { get => startTime; set => SetProperty(ref startTime, value, false); }

    /// <summary>
    /// Assessment Item Response Value
    /// <para>
    /// �A specific response to an assessment item by the person being assessed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20069">Assessment Item Response Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Value")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Value { get => value; set => SetProperty(ref value, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentItemResponse model)
    {
        IsBusy = true;
        Id = model.Id;
        AidSetUsed = model.AidSetUsed; // Assessment Item Response Aid Set Used
        AssessmentItemId = model.AssessmentItemId; // 
        AssessmentItemResponseDescriptiveFeedbackDate = model.AssessmentItemResponseDescriptiveFeedbackDate; // Assessment Item Response Descriptive Feedback Date
        AssessmentParticipantSessionId = model.AssessmentParticipantSessionId; // 
        DescriptiveFeedback = model.DescriptiveFeedback; // Assessment Item Response Descriptive Feedback
        Duration = model.Duration; // Assessment Item Response Duration
        FirstAttemptDuration = model.FirstAttemptDuration; // Assessment Item Response First Attempt Duration
        HintCount = model.HintCount; // Assessment Item Response Hint Count
        HintIncludedAnswer = model.HintIncludedAnswer; // Assessment Item Response Hint Included Answer
        RefAssessmentItemResponseScoreStatusId = model.RefAssessmentItemResponseScoreStatusId; // Assessment Item Response Score Status
        RefAssessmentItemResponseStatusId = model.RefAssessmentItemResponseStatusId; // 
        RefProficiencyStatusId = model.RefProficiencyStatusId; // Proficiency Status
        ResultXml = model.ResultXml; // 
        ScaffoldingItemFlag = model.ScaffoldingItemFlag; // Assessment Item Response Scaffolding Item Flag
        ScoreValue = model.ScoreValue; // Assessment Item Response Score Value
        SecurityIssue = model.SecurityIssue; // Assessment Item Response Security Issue
        StartDate = model.StartDate; // Assessment Item Response Start Date
        StartTime = model.StartTime; // Assessment Item Response Start Time
        Value = model.Value; // Assessment Item Response Value
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
