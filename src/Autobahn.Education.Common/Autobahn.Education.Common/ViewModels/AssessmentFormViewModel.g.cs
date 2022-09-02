//***************************************************************************
//* DomainName: Common Models
//* FileName:   AssessmentFormViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentForm file
/// </summary>
public partial class AssessmentFormViewModel : ObservableValidator, IAssessmentForm
{
    #region "AssessmentFormViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentFormViewModel Constructor
    /// </summary>
    public AssessmentFormViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentFormViewModelConstruction();
    }

    /// <summary>
    /// AssessmentFormViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentFormViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentForm";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AccommodationList -- (backing property for Assessment Form Accommodation List)
    private System.String accommodationList;

    // AssessmentFormAdaptiveIndicator -- (backing property for Assessment Form Adaptive Indicator)
    private Boolean? assessmentFormAdaptiveIndicator;

    // AssessmentFormAlgorithmIdentifier -- (backing property for Assessment Form Algorithm Identifier)
    private System.String assessmentFormAlgorithmIdentifier;

    // AssessmentFormAlgorithmVersion -- (backing property for Assessment Form Algorithm Version)
    private System.String assessmentFormAlgorithmVersion;

    // member variable for the AssessmentFormGuid property
    private System.String assessmentFormGuid;

    // AssessmentItemBankIdentifier -- (backing property for Assessment Item Bank Identifier)
    private System.String assessmentItemBankIdentifier;

    // AssessmentItemBankName -- (backing property for Assessment Item Bank Name)
    private System.String assessmentItemBankName;

    // AssessmentSecureIndicator -- (backing property for Assessment Secure Indicator)
    private Boolean? assessmentSecureIndicator;

    // FormNumber -- (backing property for Assessment Form Number)
    private System.String formNumber;

    // IntendedAdministrationEndDate -- (backing property for Assessment Form Intended Administration End Date)
    private DateTime? intendedAdministrationEndDate;

    // IntendedAdministrationStartDate -- (backing property for Intended Administration Start Date)
    private DateTime? intendedAdministrationStartDate;

    // Name -- (backing property for Assessment Form Name)
    private System.String name;

    // PlatformsSupported -- (backing property for Assessment Form Platforms Supported)
    private System.String platformsSupported;

    // PublishedDate -- (backing property for Learning Resource Published Date)
    private DateTime? publishedDate;

    // Version -- (backing property for Assessment Form Version)
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

    #region "IAssessmentForm Properties"
    /// <summary>
    /// Assessment Form Accommodation List
    /// <para>
    /// The human readable list of one or more of the specific accommodations available. If no accommodations are provided, then this list will not be present.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20136">Assessment Form Accommodation List</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Accommodation List")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String AccommodationList { get => accommodationList; set => SetProperty(ref accommodationList, value, true); }

    /// <summary>
    /// Assessment Form Adaptive Indicator
    /// <para>
    /// Indicates that the assessment form was generated using an algorithm rather than a fixed form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20507">Assessment Form Adaptive Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Adaptive Indicator")]
    public Boolean? AssessmentFormAdaptiveIndicator { get => assessmentFormAdaptiveIndicator; set => SetProperty(ref assessmentFormAdaptiveIndicator, value, false); }

    /// <summary>
    /// Assessment Form Algorithm Identifier
    /// <para>
    /// An identifier for algorithm used to generate a custom form for an adaptive test.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20508">Assessment Form Algorithm Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Algorithm Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentFormAlgorithmIdentifier { get => assessmentFormAlgorithmIdentifier; set => SetProperty(ref assessmentFormAlgorithmIdentifier, value, true); }

    /// <summary>
    /// Assessment Form Algorithm Version
    /// <para>
    /// The version of the algorithm used to generate a custom form for an adaptive test.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20509">Assessment Form Algorithm Version</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Algorithm Version")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentFormAlgorithmVersion { get => assessmentFormAlgorithmVersion; set => SetProperty(ref assessmentFormAlgorithmVersion, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentFormGuid { get => assessmentFormGuid; set => SetProperty(ref assessmentFormGuid, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    public Guid AssessmentId { get; set; }

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
    /// Assessment Secure Indicator
    /// <para>
    /// Indicates whether or not the assessment is a secure assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19375">Assessment Secure Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Secure Indicator")]
    public Boolean? AssessmentSecureIndicator { get => assessmentSecureIndicator; set => SetProperty(ref assessmentSecureIndicator, value, false); }

    /// <summary>
    /// Assessment Form Number
    /// <para>
    /// The number of a given assessment form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19365">Assessment Form Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Number")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FormNumber { get => formNumber; set => SetProperty(ref formNumber, value, true); }

    /// <summary>
    /// Assessment Form Intended Administration End Date
    /// <para>
    /// The ending date of the time period in which the assessment form is intended to be administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20138">Assessment Form Intended Administration End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Intended Administration End Date")]
    public DateTime? IntendedAdministrationEndDate { get => intendedAdministrationEndDate; set => SetProperty(ref intendedAdministrationEndDate, value, false); }

    /// <summary>
    /// Intended Administration Start Date
    /// <para>
    /// The beginning date of the time period in which the form is intended to be administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20137">Intended Administration Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Intended Administration Start Date")]
    public DateTime? IntendedAdministrationStartDate { get => intendedAdministrationStartDate; set => SetProperty(ref intendedAdministrationStartDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid? LearningResourceId { get; set; }

    /// <summary>
    /// Assessment Form Name
    /// <para>
    /// The name of a given assessment form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19024">Assessment Form Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get => name; set => SetProperty(ref name, value, true); }

    /// <summary>
    /// Assessment Form Platforms Supported
    /// <para>
    /// A human readable list of delivery platforms the form will support.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20139">Assessment Form Platforms Supported</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Platforms Supported")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String PlatformsSupported { get => platformsSupported; set => SetProperty(ref platformsSupported, value, true); }

    /// <summary>
    /// Learning Resource Published Date
    /// <para>
    /// The published date of an educational resource, such as instructional media, an assessment form, or section of an assessment form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20135">Learning Resource Published Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Published Date")]
    public DateTime? PublishedDate { get => publishedDate; set => SetProperty(ref publishedDate, value, false); }

    /// <summary>
    /// Assessment Language
    /// <para>
    /// The language in which the assessment form is designed to be delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20073">Assessment Language</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Language")]
    public Guid? RefAssessmentLanguageId { get; set; }

    /// <summary>
    /// Assessment Form Version
    /// <para>
    /// The version number of the Assessment Form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20134">Assessment Form Version</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Version")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Version { get => version; set => SetProperty(ref version, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentForm model)
    {
        IsBusy = true;
        Id = model.Id;
        AccommodationList = model.AccommodationList; // Assessment Form Accommodation List
        AssessmentFormAdaptiveIndicator = model.AssessmentFormAdaptiveIndicator; // Assessment Form Adaptive Indicator
        AssessmentFormAlgorithmIdentifier = model.AssessmentFormAlgorithmIdentifier; // Assessment Form Algorithm Identifier
        AssessmentFormAlgorithmVersion = model.AssessmentFormAlgorithmVersion; // Assessment Form Algorithm Version
        AssessmentFormGuid = model.AssessmentFormGuid; // 
        AssessmentId = model.AssessmentId; // 
        AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier; // Assessment Item Bank Identifier
        AssessmentItemBankName = model.AssessmentItemBankName; // Assessment Item Bank Name
        AssessmentSecureIndicator = model.AssessmentSecureIndicator; // Assessment Secure Indicator
        FormNumber = model.FormNumber; // Assessment Form Number
        IntendedAdministrationEndDate = model.IntendedAdministrationEndDate; // Assessment Form Intended Administration End Date
        IntendedAdministrationStartDate = model.IntendedAdministrationStartDate; // Intended Administration Start Date
        LearningResourceId = model.LearningResourceId; // 
        Name = model.Name; // Assessment Form Name
        PlatformsSupported = model.PlatformsSupported; // Assessment Form Platforms Supported
        PublishedDate = model.PublishedDate; // Learning Resource Published Date
        RefAssessmentLanguageId = model.RefAssessmentLanguageId; // Assessment Language
        Version = model.Version; // Assessment Form Version
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
