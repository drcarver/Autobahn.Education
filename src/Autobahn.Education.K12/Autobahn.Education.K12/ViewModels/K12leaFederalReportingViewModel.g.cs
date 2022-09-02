//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaFederalReportingViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaFederalReporting file
/// </summary>
public partial class K12leaFederalReportingViewModel : ObservableValidator, IK12leaFederalReporting
{
    #region "K12leaFederalReportingViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12leaFederalReportingViewModel Constructor
    /// </summary>
    public K12leaFederalReportingViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12leaFederalReportingViewModelConstruction();
    }

    /// <summary>
    /// K12leaFederalReportingViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12leaFederalReportingViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12leaFederalReporting";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the DesegregationOrderOrPlan property
    private Boolean? desegregationOrderOrPlan;

    // member variable for the HarassmentOrBullyingPolicy property
    private Boolean? harassmentOrBullyingPolicy;

    // member variable for the InterscholasticSportParticipantsFemale property
    private Int32? interscholasticSportParticipantsFemale;

    // member variable for the InterscholasticSportParticipantsMale property
    private Int32? interscholasticSportParticipantsMale;

    // member variable for the InterscholasticSportsFemaleOnly property
    private Int32? interscholasticSportsFemaleOnly;

    // member variable for the InterscholasticSportsMaleOnly property
    private Int32? interscholasticSportsMaleOnly;

    // member variable for the InterscholasticTeamsFemaleOnly property
    private Int32? interscholasticTeamsFemaleOnly;

    // member variable for the InterscholasticTeamsMaleOnly property
    private Int32? interscholasticTeamsMaleOnly;

    // member variable for the StateAssessmentAdminFunding property
    private Decimal? stateAssessmentAdminFunding;

    // member variable for the StateAssessStandardsFunding property
    private Decimal? stateAssessStandardsFunding;

    // member variable for the TerminatedTitleIiiprogramFailure property
    private Boolean? terminatedTitleIiiprogramFailure;

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

    #region "IK12leaFederalReporting Properties"
    public Boolean? DesegregationOrderOrPlan { get => desegregationOrderOrPlan; set => SetProperty(ref desegregationOrderOrPlan, value, false); }

    public Boolean? HarassmentOrBullyingPolicy { get => harassmentOrBullyingPolicy; set => SetProperty(ref harassmentOrBullyingPolicy, value, false); }

    public Int32? InterscholasticSportParticipantsFemale { get => interscholasticSportParticipantsFemale; set => SetProperty(ref interscholasticSportParticipantsFemale, value, false); }

    public Int32? InterscholasticSportParticipantsMale { get => interscholasticSportParticipantsMale; set => SetProperty(ref interscholasticSportParticipantsMale, value, false); }

    public Int32? InterscholasticSportsFemaleOnly { get => interscholasticSportsFemaleOnly; set => SetProperty(ref interscholasticSportsFemaleOnly, value, false); }

    public Int32? InterscholasticSportsMaleOnly { get => interscholasticSportsMaleOnly; set => SetProperty(ref interscholasticSportsMaleOnly, value, false); }

    public Int32? InterscholasticTeamsFemaleOnly { get => interscholasticTeamsFemaleOnly; set => SetProperty(ref interscholasticTeamsFemaleOnly, value, false); }

    public Int32? InterscholasticTeamsMaleOnly { get => interscholasticTeamsMaleOnly; set => SetProperty(ref interscholasticTeamsMaleOnly, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomeless"/> model
    /// </summary>
    public Guid? RefBarrierToEducatingHomelessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatus"/> model
    /// </summary>
    public Guid? RefIntegratedTechnologyStatusId { get; set; }

    public Decimal? StateAssessmentAdminFunding { get => stateAssessmentAdminFunding; set => SetProperty(ref stateAssessmentAdminFunding, value, false); }

    public Decimal? StateAssessStandardsFunding { get => stateAssessStandardsFunding; set => SetProperty(ref stateAssessStandardsFunding, value, false); }

    public Boolean? TerminatedTitleIiiprogramFailure { get => terminatedTitleIiiprogramFailure; set => SetProperty(ref terminatedTitleIiiprogramFailure, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12leaFederalReporting model)
    {
        IsBusy = true;
        Id = model.Id;
        DesegregationOrderOrPlan = model.DesegregationOrderOrPlan; // 
        HarassmentOrBullyingPolicy = model.HarassmentOrBullyingPolicy; // 
        InterscholasticSportParticipantsFemale = model.InterscholasticSportParticipantsFemale; // 
        InterscholasticSportParticipantsMale = model.InterscholasticSportParticipantsMale; // 
        InterscholasticSportsFemaleOnly = model.InterscholasticSportsFemaleOnly; // 
        InterscholasticSportsMaleOnly = model.InterscholasticSportsMaleOnly; // 
        InterscholasticTeamsFemaleOnly = model.InterscholasticTeamsFemaleOnly; // 
        InterscholasticTeamsMaleOnly = model.InterscholasticTeamsMaleOnly; // 
        K12leaId = model.K12leaId; // 
        RefBarrierToEducatingHomelessId = model.RefBarrierToEducatingHomelessId; // 
        RefIntegratedTechnologyStatusId = model.RefIntegratedTechnologyStatusId; // 
        StateAssessmentAdminFunding = model.StateAssessmentAdminFunding; // 
        StateAssessStandardsFunding = model.StateAssessStandardsFunding; // 
        TerminatedTitleIiiprogramFailure = model.TerminatedTitleIiiprogramFailure; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
