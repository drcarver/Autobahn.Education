//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAeViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationAe file
/// </summary>
public partial class ProgramParticipationAeViewModel : ObservableValidator, IProgramParticipationAe
{
    #region "ProgramParticipationAeViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProgramParticipationAeViewModel Constructor
    /// </summary>
    public ProgramParticipationAeViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProgramParticipationAeViewModelConstruction();
    }

    /// <summary>
    /// ProgramParticipationAeViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProgramParticipationAeViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProgramParticipationAe";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the DisplacedHomemakerIndicator property
    private Boolean? displacedHomemakerIndicator;

    // member variable for the InstructionalActivityHoursCompleted property
    private Decimal? instructionalActivityHoursCompleted;

    // member variable for the OutOfWorkforceIndicator property
    private Boolean? outOfWorkforceIndicator;

    // member variable for the PostsecondaryTransitionDate property
    private DateTime? postsecondaryTransitionDate;

    // member variable for the ProgramParticipationAeid property
    private System.Int32 programParticipationAeid;

    // member variable for the ProxyContactHours property
    private Decimal? proxyContactHours;

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

    #region "IProgramParticipationAe Properties"
    public Boolean? DisplacedHomemakerIndicator { get => displacedHomemakerIndicator; set => SetProperty(ref displacedHomemakerIndicator, value, false); }

    public Decimal? InstructionalActivityHoursCompleted { get => instructionalActivityHoursCompleted; set => SetProperty(ref instructionalActivityHoursCompleted, value, false); }

    public Boolean? OutOfWorkforceIndicator { get => outOfWorkforceIndicator; set => SetProperty(ref outOfWorkforceIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    public DateTime? PostsecondaryTransitionDate { get => postsecondaryTransitionDate; set => SetProperty(ref postsecondaryTransitionDate, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 ProgramParticipationAeid { get => programParticipationAeid; set => SetProperty(ref programParticipationAeid, value, true); }

    public Decimal? ProxyContactHours { get => proxyContactHours; set => SetProperty(ref proxyContactHours, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdultEducationProgramExitReason"/> model
    /// </summary>
    public Guid? RefAdultEducationProgramExitReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtIntake"/> model
    /// </summary>
    public Guid? RefAeFunctioningLevelAtIntakeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtPosttest"/> model
    /// </summary>
    public Guid? RefAeFunctioningLevelAtPosttestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeInstructionalProgramType"/> model
    /// </summary>
    public Guid? RefAeInstructionalProgramTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAePostsecondaryTransitionAction"/> model
    /// </summary>
    public Guid? RefAePostsecondaryTransitionActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeSpecialProgramType"/> model
    /// </summary>
    public Guid? RefAeSpecialProgramTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCorrectionalEducationFacilityType"/> model
    /// </summary>
    public Guid? RefCorrectionalEducationFacilityTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGoalsForAttendingAdultEducation"/> model
    /// </summary>
    public Guid? RefGoalsForAttendingAdultEducationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
    /// </summary>
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProgramParticipationAe model)
    {
        IsBusy = true;
        Id = model.Id;
        DisplacedHomemakerIndicator = model.DisplacedHomemakerIndicator; // 
        InstructionalActivityHoursCompleted = model.InstructionalActivityHoursCompleted; // 
        OutOfWorkforceIndicator = model.OutOfWorkforceIndicator; // 
        PersonProgramParticipationId = model.PersonProgramParticipationId; // 
        PostsecondaryTransitionDate = model.PostsecondaryTransitionDate; // 
        ProgramParticipationAeid = model.ProgramParticipationAeid; // 
        ProxyContactHours = model.ProxyContactHours; // 
        RefAdultEducationProgramExitReasonId = model.RefAdultEducationProgramExitReasonId; // 
        RefAeFunctioningLevelAtIntakeId = model.RefAeFunctioningLevelAtIntakeId; // 
        RefAeFunctioningLevelAtPosttestId = model.RefAeFunctioningLevelAtPosttestId; // 
        RefAeInstructionalProgramTypeId = model.RefAeInstructionalProgramTypeId; // 
        RefAePostsecondaryTransitionActionId = model.RefAePostsecondaryTransitionActionId; // 
        RefAeSpecialProgramTypeId = model.RefAeSpecialProgramTypeId; // 
        RefCorrectionalEducationFacilityTypeId = model.RefCorrectionalEducationFacilityTypeId; // 
        RefGoalsForAttendingAdultEducationId = model.RefGoalsForAttendingAdultEducationId; // 
        RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
