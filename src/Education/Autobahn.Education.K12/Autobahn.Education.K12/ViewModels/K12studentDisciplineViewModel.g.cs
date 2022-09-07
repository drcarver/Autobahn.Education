//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentDisciplineViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentDiscipline file
/// </summary>
public partial class K12studentDisciplineViewModel : ObservableValidator, IK12studentDiscipline
{
    #region "K12studentDisciplineViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12studentDisciplineViewModel Constructor
    /// </summary>
    public K12studentDisciplineViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12studentDisciplineViewModelConstruction();
    }

    /// <summary>
    /// K12studentDisciplineViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12studentDisciplineViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12studentDiscipline";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the DisciplinaryActionEndDate property
    private DateTime? disciplinaryActionEndDate;

    // member variable for the DisciplinaryActionStartDate property
    private DateTime? disciplinaryActionStartDate;

    // member variable for the DurationOfDisciplinaryAction property
    private Decimal? durationOfDisciplinaryAction;

    // member variable for the EducationalServicesAfterRemoval property
    private Boolean? educationalServicesAfterRemoval;

    // member variable for the FullYearExpulsion property
    private Boolean? fullYearExpulsion;

    // member variable for the IepplacementMeetingIndicator property
    private Boolean? iepplacementMeetingIndicator;

    // member variable for the RelatedToZeroTolerancePolicy property
    private Boolean? relatedToZeroTolerancePolicy;

    // member variable for the ShortenedExpulsion property
    private Boolean? shortenedExpulsion;

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

    #region "IK12studentDiscipline Properties"
    public DateTime? DisciplinaryActionEndDate { get => disciplinaryActionEndDate; set => SetProperty(ref disciplinaryActionEndDate, value, false); }

    public DateTime? DisciplinaryActionStartDate { get => disciplinaryActionStartDate; set => SetProperty(ref disciplinaryActionStartDate, value, false); }

    public Decimal? DurationOfDisciplinaryAction { get => durationOfDisciplinaryAction; set => SetProperty(ref durationOfDisciplinaryAction, value, false); }

    public Boolean? EducationalServicesAfterRemoval { get => educationalServicesAfterRemoval; set => SetProperty(ref educationalServicesAfterRemoval, value, false); }

    public Boolean? FullYearExpulsion { get => fullYearExpulsion; set => SetProperty(ref fullYearExpulsion, value, false); }

    public Boolean? IepplacementMeetingIndicator { get => iepplacementMeetingIndicator; set => SetProperty(ref iepplacementMeetingIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIncident"/> model
    /// </summary>
    public Guid? IncidentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTaken"/> model
    /// </summary>
    public Guid? RefDisciplinaryActionTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReason"/> model
    /// </summary>
    public Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
    /// </summary>
    public Guid? RefDisciplineMethodFirearmsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwd"/> model
    /// </summary>
    public Guid? RefDisciplineMethodOfCwdId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineReason"/> model
    /// </summary>
    public Guid? RefDisciplineReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeadisciplineMethodFirearm"/> model
    /// </summary>
    public Guid? RefIdeadisciplineMethodFirearmId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaInterimRemoval"/> model
    /// </summary>
    public Guid? RefIdeaInterimRemovalId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaInterimRemovalReason"/> model
    /// </summary>
    public Guid? RefIdeaInterimRemovalReasonId { get; set; }

    public Boolean? RelatedToZeroTolerancePolicy { get => relatedToZeroTolerancePolicy; set => SetProperty(ref relatedToZeroTolerancePolicy, value, false); }

    public Boolean? ShortenedExpulsion { get => shortenedExpulsion; set => SetProperty(ref shortenedExpulsion, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12studentDiscipline model)
    {
        IsBusy = true;
        Id = model.Id;
        DisciplinaryActionEndDate = model.DisciplinaryActionEndDate; // 
        DisciplinaryActionStartDate = model.DisciplinaryActionStartDate; // 
        DurationOfDisciplinaryAction = model.DurationOfDisciplinaryAction; // 
        EducationalServicesAfterRemoval = model.EducationalServicesAfterRemoval; // 
        FullYearExpulsion = model.FullYearExpulsion; // 
        IepplacementMeetingIndicator = model.IepplacementMeetingIndicator; // 
        IncidentId = model.IncidentId; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefDisciplinaryActionTakenId = model.RefDisciplinaryActionTakenId; // 
        RefDisciplineLengthDifferenceReasonId = model.RefDisciplineLengthDifferenceReasonId; // 
        RefDisciplineMethodFirearmsId = model.RefDisciplineMethodFirearmsId; // 
        RefDisciplineMethodOfCwdId = model.RefDisciplineMethodOfCwdId; // 
        RefDisciplineReasonId = model.RefDisciplineReasonId; // 
        RefIdeadisciplineMethodFirearmId = model.RefIdeadisciplineMethodFirearmId; // 
        RefIdeaInterimRemovalId = model.RefIdeaInterimRemovalId; // 
        RefIdeaInterimRemovalReasonId = model.RefIdeaInterimRemovalReasonId; // 
        RelatedToZeroTolerancePolicy = model.RelatedToZeroTolerancePolicy; // 
        ShortenedExpulsion = model.ShortenedExpulsion; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
