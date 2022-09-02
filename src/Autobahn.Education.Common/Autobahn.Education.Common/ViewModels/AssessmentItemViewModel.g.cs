//***************************************************************************
//* DomainName: Common Models
//* FileName:   AssessmentItemViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItem file
/// </summary>
public partial class AssessmentItemViewModel : ObservableValidator, IAssessmentItem
{
    #region "AssessmentItemViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentItemViewModel Constructor
    /// </summary>
    public AssessmentItemViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentItemViewModelConstruction();
    }

    /// <summary>
    /// AssessmentItemViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentItemViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentItem";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AdaptiveIndicator -- (backing property for Assessment Item Adaptive Indicator)
    private Boolean? adaptiveIndicator;

    // AllottedTime -- (backing property for Assessment Item Allotted Time)
    private TimeSpan? allottedTime;

    // AssessmentFormSectionItemFieldTestIndicator -- (backing property for Assessment Form Section Item Field Test Indicator)
    private Boolean? assessmentFormSectionItemFieldTestIndicator;

    // AssessmentItemBankIdentifier -- (backing property for Assessment Item Bank Identifier)
    private System.String assessmentItemBankIdentifier;

    // AssessmentItemBankName -- (backing property for Assessment Item Bank Name)
    private System.String assessmentItemBankName;

    // BodyText -- (backing property for Assessment Item Body Text)
    private System.String bodyText;

    // Difficulty -- (backing property for Assessment Item Difficulty)
    private Decimal? difficulty;

    // DistractorAnalysis -- (backing property for Assessment Item Distractor Analysis)
    private System.String distractorAnalysis;

    // Identifier -- (backing property for Assessment Item Identifier)
    private System.String identifier;

    // LinkingItemIndicator -- (backing property for Assessment Item Linking Item Indicator)
    private Boolean? linkingItemIndicator;

    // MaximumScore -- (backing property for Assessment Item Maximum Score)
    private System.String maximumScore;

    // MinimumScore -- (backing property for Assessment Item Minimum Score)
    private System.String minimumScore;

    // ReleaseStatus -- (backing property for Assessment Item Release Status)
    private Boolean? releaseStatus;

    // Stem -- (backing property for Assessment Item Stem)
    private System.String stem;

    // Stimulus -- (backing property for Assessment Item Stimulus)
    private System.String stimulus;

    // TextComplexityValue -- (backing property for Assessment Item Text Complexity Value)
    private System.String textComplexityValue;

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

    #region "IAssessmentItem Properties"
    /// <summary>
    /// Assessment Item Adaptive Indicator
    /// <para>
    /// This indicator determines whether an assessment item is an adaptive item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20111">Assessment Item Adaptive Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Adaptive Indicator")]
    public Boolean? AdaptiveIndicator { get => adaptiveIndicator; set => SetProperty(ref adaptiveIndicator, value, false); }

    /// <summary>
    /// Assessment Item Allotted Time
    /// <para>
    /// The amount of time allotted for a specific item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19395">Assessment Item Allotted Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Allotted Time")]
    public TimeSpan? AllottedTime { get => allottedTime; set => SetProperty(ref allottedTime, value, false); }

    /// <summary>
    /// Assessment Form Section Item Field Test Indicator
    /// <para>
    /// Indicates that the assessment item is being field tested on this form of the test, and is not to be included for scoring.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20511">Assessment Form Section Item Field Test Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Section Item Field Test Indicator")]
    public Boolean? AssessmentFormSectionItemFieldTestIndicator { get => assessmentFormSectionItemFieldTestIndicator; set => SetProperty(ref assessmentFormSectionItemFieldTestIndicator, value, false); }

    /// <summary>
    /// Assessment Item Bank Identifier
    /// <para>
    /// If the assessment is provided with an item bank, then this identifies the item bank: a unique code or number used by the item banking system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20132">Assessment Item Bank Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Bank Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentItemBankIdentifier { get => assessmentItemBankIdentifier; set => SetProperty(ref assessmentItemBankIdentifier, value, true); }

    /// <summary>
    /// Assessment Item Bank Name
    /// <para>
    /// If the assessment is provided with an item bank, then this is the name of the item bank.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20133">Assessment Item Bank Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Bank Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentItemBankName { get => assessmentItemBankName; set => SetProperty(ref assessmentItemBankName, value, true); }

    /// <summary>
    /// Assessment Item Body Text
    /// <para>
    /// The complete text of an assessment item including all applicable parts such as stimulus, stem, and possible response options presented.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20233">Assessment Item Body Text</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Body Text")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String BodyText { get => bodyText; set => SetProperty(ref bodyText, value, true); }

    /// <summary>
    /// Assessment Item Difficulty
    /// <para>
    /// The percentage of students who answered the item correctly during trial testing of the item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19383">Assessment Item Difficulty</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Difficulty")]
    public Decimal? Difficulty { get => difficulty; set => SetProperty(ref difficulty, value, false); }

    /// <summary>
    /// Assessment Item Distractor Analysis
    /// <para>
    /// The analysis of the distractors provided for a specific assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19390">Assessment Item Distractor Analysis</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Distractor Analysis")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DistractorAnalysis { get => distractorAnalysis; set => SetProperty(ref distractorAnalysis, value, true); }

    /// <summary>
    /// Assessment Item Identifier
    /// <para>
    /// The identifier that uniquely identifies an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19623">Assessment Item Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid? LearningResourceId { get; set; }

    /// <summary>
    /// Assessment Item Linking Item Indicator
    /// <para>
    /// Indicates that the item is intended to be administered in two different grades for the goal of establishing cross grade comparison.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20227">Assessment Item Linking Item Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Linking Item Indicator")]
    public Boolean? LinkingItemIndicator { get => linkingItemIndicator; set => SetProperty(ref linkingItemIndicator, value, false); }

    /// <summary>
    /// Assessment Item Maximum Score
    /// <para>
    /// The maximum number of points possible for the assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19683">Assessment Item Maximum Score</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Maximum Score")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MaximumScore { get => maximumScore; set => SetProperty(ref maximumScore, value, true); }

    /// <summary>
    /// Assessment Item Minimum Score
    /// <para>
    /// The minimum number of points possible for the assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19684">Assessment Item Minimum Score</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Minimum Score")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MinimumScore { get => minimumScore; set => SetProperty(ref minimumScore, value, true); }

    /// <summary>
    /// Assessment Item Type
    /// <para>
    /// The specific type of assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19382">Assessment Item Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Type")]
    public Guid? RefAssessmentItemTypeId { get; set; }

    /// <summary>
    /// NAEP Aspects of Reading
    /// <para>
    /// Aspects of reading defined by the National Assessment of Educational Progress (NAEP 2005b Framework).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20166">NAEP Aspects of Reading</a>
    /// </para>
    /// </summary>
    [DisplayName("NAEP Aspects of Reading")]
    public Guid? RefNaepAspectsOfReadingId { get; set; }

    /// <summary>
    /// NAEP Mathematical Complexity Level
    /// <para>
    /// Complexity levels defined by the National Assessment of Educational Progress (NAEP 2005a Framework).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20072">NAEP Mathematical Complexity Level</a>
    /// </para>
    /// </summary>
    [DisplayName("NAEP Mathematical Complexity Level")]
    public Guid? RefNaepMathComplexityLevelId { get; set; }

    /// <summary>
    /// Assessment Item Text Complexity System
    /// <para>
    /// The scaling system used to specify the text complexity of an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19907">Assessment Item Text Complexity System</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Text Complexity System")]
    public Guid? RefTextComplexitySystemId { get; set; }

    /// <summary>
    /// Assessment Item Release Status
    /// <para>
    /// Indicates that the assessment item has been released to the public.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20229">Assessment Item Release Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Release Status")]
    public Boolean? ReleaseStatus { get => releaseStatus; set => SetProperty(ref releaseStatus, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubric"/> model
    /// </summary>
    public Guid? RubricId { get; set; }

    /// <summary>
    /// Assessment Item Stem
    /// <para>
    /// The statement of the question or prompt for an Assessment Item to which the student responds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19392">Assessment Item Stem</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Stem")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Stem { get => stem; set => SetProperty(ref stem, value, true); }

    /// <summary>
    /// Assessment Item Stimulus
    /// <para>
    ///  The text, source (e.g., video clip), and/or graphic about which the assessment item is written. The stimulus provides the context of the item/task to which the student must respond.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20234">Assessment Item Stimulus</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Stimulus")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Stimulus { get => stimulus; set => SetProperty(ref stimulus, value, true); }

    /// <summary>
    /// Assessment Item Text Complexity Value
    /// <para>
    /// The complexity of the text using the scaling system defined by Text Complexity System, e.g. LexileT for assessment items with a reading passage.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19906">Assessment Item Text Complexity Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Text Complexity Value")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TextComplexityValue { get => textComplexityValue; set => SetProperty(ref textComplexityValue, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentItem model)
    {
        IsBusy = true;
        Id = model.Id;
        AdaptiveIndicator = model.AdaptiveIndicator; // Assessment Item Adaptive Indicator
        AllottedTime = model.AllottedTime; // Assessment Item Allotted Time
        AssessmentFormSectionItemFieldTestIndicator = model.AssessmentFormSectionItemFieldTestIndicator; // Assessment Form Section Item Field Test Indicator
        AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier; // Assessment Item Bank Identifier
        AssessmentItemBankName = model.AssessmentItemBankName; // Assessment Item Bank Name
        BodyText = model.BodyText; // Assessment Item Body Text
        Difficulty = model.Difficulty; // Assessment Item Difficulty
        DistractorAnalysis = model.DistractorAnalysis; // Assessment Item Distractor Analysis
        Identifier = model.Identifier; // Assessment Item Identifier
        LearningResourceId = model.LearningResourceId; // 
        LinkingItemIndicator = model.LinkingItemIndicator; // Assessment Item Linking Item Indicator
        MaximumScore = model.MaximumScore; // Assessment Item Maximum Score
        MinimumScore = model.MinimumScore; // Assessment Item Minimum Score
        RefAssessmentItemTypeId = model.RefAssessmentItemTypeId; // Assessment Item Type
        RefNaepAspectsOfReadingId = model.RefNaepAspectsOfReadingId; // NAEP Aspects of Reading
        RefNaepMathComplexityLevelId = model.RefNaepMathComplexityLevelId; // NAEP Mathematical Complexity Level
        RefTextComplexitySystemId = model.RefTextComplexitySystemId; // Assessment Item Text Complexity System
        ReleaseStatus = model.ReleaseStatus; // Assessment Item Release Status
        RubricId = model.RubricId; // 
        Stem = model.Stem; // Assessment Item Stem
        Stimulus = model.Stimulus; // Assessment Item Stimulus
        TextComplexityValue = model.TextComplexityValue; // Assessment Item Text Complexity Value
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
