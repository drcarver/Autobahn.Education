//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubTestViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubTest file
/// </summary>
public partial class AssessmentSubTestViewModel : ObservableValidator, IAssessmentSubTest
{
    #region "AssessmentSubTestViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentSubTestViewModel Constructor
    /// </summary>
    public AssessmentSubTestViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentSubTestViewModelConstruction();
    }

    /// <summary>
    /// AssessmentSubTestViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentSubTestViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentSubTest";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the Abbreviation property
    private System.String abbreviation;

    // member variable for the ContainerOnly property
    private System.String containerOnly;

    // member variable for the Identifier property
    private System.String identifier;

    // member variable for the MaximumValue property
    private System.String maximumValue;

    // member variable for the MinimumValue property
    private System.String minimumValue;

    // member variable for the OptimalValue property
    private System.String optimalValue;

    // member variable for the PublishedDate property
    private DateTime? publishedDate;

    // member variable for the Rules property
    private System.String rules;

    // member variable for the Tier property
    private Int32? tier;

    // member variable for the Title property
    private System.String title;

    // member variable for the Version property
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

    #region "IAssessmentSubTest Properties"
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

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ContainerOnly { get => containerOnly; set => SetProperty(ref containerOnly, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MaximumValue { get => maximumValue; set => SetProperty(ref maximumValue, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MinimumValue { get => minimumValue; set => SetProperty(ref minimumValue, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OptimalValue { get => optimalValue; set => SetProperty(ref optimalValue, value, true); }

    public DateTime? PublishedDate { get => publishedDate; set => SetProperty(ref publishedDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAcademicSubject"/> model
    /// </summary>
    public Guid? RefAcademicSubjectId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
    /// </summary>
    public Guid? RefAssessmentPurposeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentSubtestentifierType"/> model
    /// </summary>
    public Guid? RefAssessmentSubtestIdentifierTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefContentStandardType"/> model
    /// </summary>
    public Guid? RefContentStandardTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
    /// </summary>
    public Guid? RefScoreMetricTypeId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String Rules { get => rules; set => SetProperty(ref rules, value, true); }

    public Int32? Tier { get => tier; set => SetProperty(ref tier, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get => title; set => SetProperty(ref title, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Version { get => version; set => SetProperty(ref version, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentSubTest model)
    {
        IsBusy = true;
        Id = model.Id;
        Abbreviation = model.Abbreviation; // 
        AssessmentFormId = model.AssessmentFormId; // 
        ChildOfAssessmentSubtestId = model.ChildOfAssessmentSubtestId; // 
        ContainerOnly = model.ContainerOnly; // 
        Identifier = model.Identifier; // 
        MaximumValue = model.MaximumValue; // 
        MinimumValue = model.MinimumValue; // 
        OptimalValue = model.OptimalValue; // 
        PublishedDate = model.PublishedDate; // 
        RefAcademicSubjectId = model.RefAcademicSubjectId; // 
        RefAssessmentPurposeId = model.RefAssessmentPurposeId; // 
        RefAssessmentSubtestIdentifierTypeId = model.RefAssessmentSubtestIdentifierTypeId; // 
        RefContentStandardTypeId = model.RefContentStandardTypeId; // 
        RefScoreMetricTypeId = model.RefScoreMetricTypeId; // 
        Rules = model.Rules; // 
        Tier = model.Tier; // 
        Title = model.Title; // 
        Version = model.Version; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
