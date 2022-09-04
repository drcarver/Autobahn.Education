//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProgramParticipationNeglectedViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationNeglected file
/// </summary>
public partial class ProgramParticipationNeglectedViewModel : ObservableValidator, IProgramParticipationNeglected
{
    #region "ProgramParticipationNeglectedViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProgramParticipationNeglectedViewModel Constructor
    /// </summary>
    public ProgramParticipationNeglectedViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProgramParticipationNeglectedViewModelConstruction();
    }

    /// <summary>
    /// ProgramParticipationNeglectedViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProgramParticipationNeglectedViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProgramParticipationNeglected";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AchievementIndicator -- (backing property for Neglected or Delinquent Academic Achievement Indicator)
    private Boolean? achievementIndicator;

    // ObtainedEmployment -- (backing property for Neglected or Delinquent Obtained Employment)
    private Boolean? obtainedEmployment;

    // OutcomeIndicator -- (backing property for Neglected or Delinquent Academic Outcome Indicator)
    private Boolean? outcomeIndicator;

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

    #region "IProgramParticipationNeglected Properties"
    /// <summary>
    /// Neglected or Delinquent Academic Achievement Indicator
    /// <para>
    /// Student was served by Title I, Part D, Subpart 1 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
    /// </para>
    /// <para>
    /// <a href="">Neglected or Delinquent Academic Achievement Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Neglected or Delinquent Academic Achievement Indicator")]
    public Boolean? AchievementIndicator { get => achievementIndicator; set => SetProperty(ref achievementIndicator, value, false); }

    /// <summary>
    /// Neglected or Delinquent Obtained Employment
    /// <para>
    /// An indication that a Neglected or Delinquent student obtained employment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19475">Neglected or Delinquent Obtained Employment</a>
    /// </para>
    /// </summary>
    [DisplayName("Neglected or Delinquent Obtained Employment")]
    public Boolean? ObtainedEmployment { get => obtainedEmployment; set => SetProperty(ref obtainedEmployment, value, false); }

    /// <summary>
    /// Neglected or Delinquent Academic Outcome Indicator
    /// <para>
    /// Student was served by Title I, Part D, Subpart 2 of ESEA as amended for at least 90 consecutive days during the reporting period who took both a pre- and post-test.
    /// </para>
    /// <para>
    /// <a href="">Neglected or Delinquent Academic Outcome Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Neglected or Delinquent Academic Outcome Indicator")]
    public Boolean? OutcomeIndicator { get => outcomeIndicator; set => SetProperty(ref outcomeIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Neglected or Delinquent Program Type
    /// <para>
    /// The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19194">Neglected or Delinquent Program Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Neglected or Delinquent Program Type")]
    public Guid? RefNeglectedProgramTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProgramParticipationNeglected model)
    {
        IsBusy = true;
        Id = model.Id;
        AchievementIndicator = model.AchievementIndicator; // Neglected or Delinquent Academic Achievement Indicator
        ObtainedEmployment = model.ObtainedEmployment; // Neglected or Delinquent Obtained Employment
        OutcomeIndicator = model.OutcomeIndicator; // Neglected or Delinquent Academic Outcome Indicator
        PersonProgramParticipationId = model.PersonProgramParticipationId; // 
        RefNeglectedProgramTypeId = model.RefNeglectedProgramTypeId; // Neglected or Delinquent Program Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
