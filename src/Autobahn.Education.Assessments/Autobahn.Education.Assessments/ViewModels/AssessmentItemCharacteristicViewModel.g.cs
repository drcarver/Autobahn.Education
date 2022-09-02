//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemCharacteristicViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemCharacteristic file
/// </summary>
public partial class AssessmentItemCharacteristicViewModel : ObservableValidator, IAssessmentItemCharacteristic
{
    #region "AssessmentItemCharacteristicViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentItemCharacteristicViewModel Constructor
    /// </summary>
    public AssessmentItemCharacteristicViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentItemCharacteristicViewModelConstruction();
    }

    /// <summary>
    /// AssessmentItemCharacteristicViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentItemCharacteristicViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentItemCharacteristic";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ResponseChoicePattern -- (backing property for Assessment Item Response Choice Pattern)
    private System.String responseChoicePattern;

    // Value -- (backing property for Assessment Item Characteristic Value)
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

    #region "IAssessmentItemCharacteristic Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Assessment Item Characteristic Type
    /// <para>
    /// The type of psychometric measure provided for assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19384">Assessment Item Characteristic Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Characteristic Type")]
    public Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

    /// <summary>
    /// Assessment Item Response Choice Pattern
    /// <para>
    /// The distribution of responses for each choice in the assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19385">Assessment Item Response Choice Pattern</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Response Choice Pattern")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ResponseChoicePattern { get => responseChoicePattern; set => SetProperty(ref responseChoicePattern, value, true); }

    /// <summary>
    /// Assessment Item Characteristic Value
    /// <para>
    /// A psychometric measure provided for an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19685">Assessment Item Characteristic Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Characteristic Value")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Value { get => value; set => SetProperty(ref value, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentItemCharacteristic model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentItemId = model.AssessmentItemId; // 
        RefAssessmentItemCharacteristicTypeId = model.RefAssessmentItemCharacteristicTypeId; // Assessment Item Characteristic Type
        ResponseChoicePattern = model.ResponseChoicePattern; // Assessment Item Response Choice Pattern
        Value = model.Value; // Assessment Item Characteristic Value
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
