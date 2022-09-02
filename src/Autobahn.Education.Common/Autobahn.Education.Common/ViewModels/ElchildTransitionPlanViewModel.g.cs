//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildTransitionPlanViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElchildTransitionPlan file
/// </summary>
public partial class ElchildTransitionPlanViewModel : ObservableValidator, IElchildTransitionPlan
{
    #region "ElchildTransitionPlanViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElchildTransitionPlanViewModel Constructor
    /// </summary>
    public ElchildTransitionPlanViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElchildTransitionPlanViewModelConstruction();
    }

    /// <summary>
    /// ElchildTransitionPlanViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElchildTransitionPlanViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElchildTransitionPlan";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the DateOfTransitionPlan property
    private DateTime? dateOfTransitionPlan;

    // member variable for the IdeapartCtoPartBnotificationDate property
    private DateTime? ideapartCtoPartBnotificationDate;

    // member variable for the IdeapartCtoPartBnotificationOptOutDate property
    private DateTime? ideapartCtoPartBnotificationOptOutDate;

    // member variable for the IdeapartCtoPartBnotificationOptOutIndicator property
    private Boolean? ideapartCtoPartBnotificationOptOutIndicator;

    // member variable for the PartB619potentialEligibilityInd property
    private Boolean? partB619potentialEligibilityInd;

    // member variable for the TransitionConferenceDate property
    private DateTime? transitionConferenceDate;

    // member variable for the TransitionConferenceDeclineDate property
    private DateTime? transitionConferenceDeclineDate;

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

    #region "IElchildTransitionPlan Properties"
    public DateTime? DateOfTransitionPlan { get => dateOfTransitionPlan; set => SetProperty(ref dateOfTransitionPlan, value, false); }

    public DateTime? IdeapartCtoPartBnotificationDate { get => ideapartCtoPartBnotificationDate; set => SetProperty(ref ideapartCtoPartBnotificationDate, value, false); }

    public DateTime? IdeapartCtoPartBnotificationOptOutDate { get => ideapartCtoPartBnotificationOptOutDate; set => SetProperty(ref ideapartCtoPartBnotificationOptOutDate, value, false); }

    public Boolean? IdeapartCtoPartBnotificationOptOutIndicator { get => ideapartCtoPartBnotificationOptOutIndicator; set => SetProperty(ref ideapartCtoPartBnotificationOptOutIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid? IndividualizedProgramId { get; set; }

    public Boolean? PartB619potentialEligibilityInd { get => partB619potentialEligibilityInd; set => SetProperty(ref partB619potentialEligibilityInd, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefReasonDelayTransitionConf"/> model
    /// </summary>
    public Guid? RefReasonDelayTransitionConfId { get; set; }

    public DateTime? TransitionConferenceDate { get => transitionConferenceDate; set => SetProperty(ref transitionConferenceDate, value, false); }

    public DateTime? TransitionConferenceDeclineDate { get => transitionConferenceDeclineDate; set => SetProperty(ref transitionConferenceDeclineDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElchildTransitionPlan model)
    {
        IsBusy = true;
        Id = model.Id;
        DateOfTransitionPlan = model.DateOfTransitionPlan; // 
        IdeapartCtoPartBnotificationDate = model.IdeapartCtoPartBnotificationDate; // 
        IdeapartCtoPartBnotificationOptOutDate = model.IdeapartCtoPartBnotificationOptOutDate; // 
        IdeapartCtoPartBnotificationOptOutIndicator = model.IdeapartCtoPartBnotificationOptOutIndicator; // 
        IndividualizedProgramId = model.IndividualizedProgramId; // 
        PartB619potentialEligibilityInd = model.PartB619potentialEligibilityInd; // 
        PersonId = model.PersonId; // 
        RefReasonDelayTransitionConfId = model.RefReasonDelayTransitionConfId; // 
        TransitionConferenceDate = model.TransitionConferenceDate; // 
        TransitionConferenceDeclineDate = model.TransitionConferenceDeclineDate; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
