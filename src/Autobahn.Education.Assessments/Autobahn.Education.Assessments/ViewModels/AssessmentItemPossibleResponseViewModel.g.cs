//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemPossibleResponseViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemPossibleResponse file
/// </summary>
public partial class AssessmentItemPossibleResponseViewModel : ObservableValidator, IAssessmentItemPossibleResponse
{
    #region "AssessmentItemPossibleResponseViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentItemPossibleResponseViewModel Constructor
    /// </summary>
    public AssessmentItemPossibleResponseViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentItemPossibleResponseViewModelConstruction();
    }

    /// <summary>
    /// AssessmentItemPossibleResponseViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentItemPossibleResponseViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentItemPossibleResponse";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CorrectIndicator -- (backing property for Assessment Item Possible Response Correct Indicator)
    private Boolean? correctIndicator;

    // FeedbackMessage -- (backing property for Assessment Item Possible Response Feedback Message)
    private System.String feedbackMessage;

    // PossibleResponseOption -- (backing property for Assessment Item Possible Response Option)
    private System.String possibleResponseOption;

    // SequenceNumber -- (backing property for Assessment Item Possible Response Sequence Number)
    private Int32? sequenceNumber;

    // Value -- (backing property for Assessment Item Possible Response Value)
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

    #region "IAssessmentItemPossibleResponse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Assessment Item Possible Response Correct Indicator
    /// <para>
    /// Indicates that the possible response is the correct response.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20183">Assessment Item Possible Response Correct Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Possible Response Correct Indicator")]
    public Boolean? CorrectIndicator { get => correctIndicator; set => SetProperty(ref correctIndicator, value, false); }

    /// <summary>
    /// Assessment Item Possible Response Feedback Message
    /// <para>
    /// A message provided to the person being assessed after giving a response that matches the possible response.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19904">Assessment Item Possible Response Feedback Message</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Possible Response Feedback Message")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FeedbackMessage { get => feedbackMessage; set => SetProperty(ref feedbackMessage, value, true); }

    /// <summary>
    /// Assessment Item Possible Response Option
    /// <para>
    /// The possible response presented to the participant within a selected-response/multiple-choice assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20235">Assessment Item Possible Response Option</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Possible Response Option")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String PossibleResponseOption { get => possibleResponseOption; set => SetProperty(ref possibleResponseOption, value, true); }

    /// <summary>
    /// Assessment Item Possible Response Sequence Number
    /// <para>
    /// The position of this response in the list of responses displayed, such as for a multiple choice item type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19905">Assessment Item Possible Response Sequence Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Possible Response Sequence Number")]
    public Int32? SequenceNumber { get => sequenceNumber; set => SetProperty(ref sequenceNumber, value, false); }

    /// <summary>
    /// Assessment Item Possible Response Value
    /// <para>
    /// The description of each distracter on an assessment item, explaining why it is there, what misunderstandings it exposes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19908">Assessment Item Possible Response Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Possible Response Value")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Value { get => value; set => SetProperty(ref value, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentItemPossibleResponse model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentItemId = model.AssessmentItemId; // 
        CorrectIndicator = model.CorrectIndicator; // Assessment Item Possible Response Correct Indicator
        FeedbackMessage = model.FeedbackMessage; // Assessment Item Possible Response Feedback Message
        PossibleResponseOption = model.PossibleResponseOption; // Assessment Item Possible Response Option
        SequenceNumber = model.SequenceNumber; // Assessment Item Possible Response Sequence Number
        Value = model.Value; // Assessment Item Possible Response Value
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
