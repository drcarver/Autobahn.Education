//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElqualityInitiativeViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElqualityInitiative file
/// </summary>
public partial class ElqualityInitiativeViewModel : ObservableValidator, IElqualityInitiative
{
    #region "ElqualityInitiativeViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElqualityInitiativeViewModel Constructor
    /// </summary>
    public ElqualityInitiativeViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElqualityInitiativeViewModelConstruction();
    }

    /// <summary>
    /// ElqualityInitiativeViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElqualityInitiativeViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElqualityInitiative";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the MaximumScore property
    private System.String maximumScore;

    // member variable for the MinimumScore property
    private System.String minimumScore;

    // member variable for the ParticipationEndDate property
    private DateTime? participationEndDate;

    // member variable for the ParticipationIndicator property
    private Boolean? participationIndicator;

    // member variable for the ParticipationStartDate property
    private DateTime? participationStartDate;

    // member variable for the ProgramHeathSafetyChecklistUseStatus property
    private Boolean? programHeathSafetyChecklistUseStatus;

    // member variable for the ScoreLevel property
    private System.String scoreLevel;

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

    #region "IElqualityInitiative Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MaximumScore { get => maximumScore; set => SetProperty(ref maximumScore, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MinimumScore { get => minimumScore; set => SetProperty(ref minimumScore, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    public DateTime? ParticipationEndDate { get => participationEndDate; set => SetProperty(ref participationEndDate, value, false); }

    public Boolean? ParticipationIndicator { get => participationIndicator; set => SetProperty(ref participationIndicator, value, false); }

    public DateTime? ParticipationStartDate { get => participationStartDate; set => SetProperty(ref participationStartDate, value, false); }

    public Boolean? ProgramHeathSafetyChecklistUseStatus { get => programHeathSafetyChecklistUseStatus; set => SetProperty(ref programHeathSafetyChecklistUseStatus, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScoreLevel { get => scoreLevel; set => SetProperty(ref scoreLevel, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElqualityInitiative model)
    {
        IsBusy = true;
        Id = model.Id;
        MaximumScore = model.MaximumScore; // 
        MinimumScore = model.MinimumScore; // 
        OrganizationId = model.OrganizationId; // 
        ParticipationEndDate = model.ParticipationEndDate; // 
        ParticipationIndicator = model.ParticipationIndicator; // 
        ParticipationStartDate = model.ParticipationStartDate; // 
        ProgramHeathSafetyChecklistUseStatus = model.ProgramHeathSafetyChecklistUseStatus; // 
        ScoreLevel = model.ScoreLevel; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
