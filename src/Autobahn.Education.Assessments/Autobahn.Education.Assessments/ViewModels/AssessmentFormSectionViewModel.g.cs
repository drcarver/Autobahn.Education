//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSection file
/// </summary>
public partial class AssessmentFormSectionViewModel : ObservableValidator, IAssessmentFormSection
{
    #region "AssessmentFormSectionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentFormSectionViewModel Constructor
    /// </summary>
    public AssessmentFormSectionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentFormSectionViewModelConstruction();
    }

    /// <summary>
    /// AssessmentFormSectionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentFormSectionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentFormSection";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AssessmentItemBankIdentifier -- (backing property for Assessment Item Bank Identifier)
    private System.String assessmentItemBankIdentifier;

    // AssessmentItemBankName -- (backing property for Assessment Item Bank Name)
    private System.String assessmentItemBankName;

    // member variable for the Guid property
    private System.String guid;

    // Identifier -- (backing property for Assessment Form Section Identifier)
    private System.String identifier;

    // PublishedDate -- (backing property for Learning Resource Published Date)
    private DateTime? publishedDate;

    // SectionReentry -- (backing property for Assessment Form Section Reentry)
    private Boolean? sectionReentry;

    // SectionSealed -- (backing property for Assessment Form Section Sealed)
    private Boolean? sectionSealed;

    // SectionTimeLimit -- (backing property for Assessment Form Section Time Limit)
    private TimeSpan? sectionTimeLimit;

    // Version -- (backing property for Assessment Form Section Version)
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

    #region "IAssessmentFormSection Properties"
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
    /// Reference to an optional instance of the <see cref="IChildOfFormSection"/> model
    /// </summary>
    public Guid? ChildOfFormSectionId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Guid { get => guid; set => SetProperty(ref guid, value, true); }

    /// <summary>
    /// Assessment Form Section Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to�the Assessment Form Section using the system specified by Identification System for Assessment Form Section.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20142">Assessment Form Section Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Section Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid? LearningResourceId { get; set; }

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
    /// Identification System for Assessment Form Section
    /// <para>
    /// A coding scheme that is used for identification of an Assessment Form Section.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20141">Identification System for Assessment Form Section</a>
    /// </para>
    /// </summary>
    [DisplayName("Identification System for Assessment Form Section")]
    public Guid? RefAssessmentFormSectionIdentificationSystemId { get; set; }

    /// <summary>
    /// Assessment Form Section Reentry
    /// <para>
    /// Indicates that this section can be re-entered, meaning the test taker can return to this section after they have left the section. A common example of this is a two section test where one section does not allow the use of a calculator and the other does. Typically the test taker cannot return to the non-calculator section after they have used a calculator.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20145">Assessment Form Section Reentry</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Section Reentry")]
    public Boolean? SectionReentry { get => sectionReentry; set => SetProperty(ref sectionReentry, value, false); }

    /// <summary>
    /// Assessment Form Section Sealed
    /// <para>
    /// Indicates this section is sealed, meaning the test taker cannot enter the section until authorized by the proctor.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20144">Assessment Form Section Sealed</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Section Sealed")]
    public Boolean? SectionSealed { get => sectionSealed; set => SetProperty(ref sectionSealed, value, false); }

    /// <summary>
    /// Assessment Form Section Time Limit
    /// <para>
    /// If this section is timed, then this will identify the maximum amount of time the test taker can spend within this section.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20143">Assessment Form Section Time Limit</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Section Time Limit")]
    public TimeSpan? SectionTimeLimit { get => sectionTimeLimit; set => SetProperty(ref sectionTimeLimit, value, false); }

    /// <summary>
    /// Assessment Form Section Version
    /// <para>
    /// The version number of the Assessment Form Section.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20140">Assessment Form Section Version</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Form Section Version")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Version { get => version; set => SetProperty(ref version, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentFormSection model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier; // Assessment Item Bank Identifier
        AssessmentItemBankName = model.AssessmentItemBankName; // Assessment Item Bank Name
        ChildOfFormSectionId = model.ChildOfFormSectionId; // 
        Guid = model.Guid; // 
        Identifier = model.Identifier; // Assessment Form Section Identifier
        LearningResourceId = model.LearningResourceId; // 
        PublishedDate = model.PublishedDate; // Learning Resource Published Date
        RefAssessmentFormSectionIdentificationSystemId = model.RefAssessmentFormSectionIdentificationSystemId; // Identification System for Assessment Form Section
        SectionReentry = model.SectionReentry; // Assessment Form Section Reentry
        SectionSealed = model.SectionSealed; // Assessment Form Section Sealed
        SectionTimeLimit = model.SectionTimeLimit; // Assessment Form Section Time Limit
        Version = model.Version; // Assessment Form Section Version
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
