//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationSpecialEducationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationSpecialEducation file
/// </summary>
public partial class ProgramParticipationSpecialEducationViewModel : ObservableValidator, IProgramParticipationSpecialEducation
{
    #region "ProgramParticipationSpecialEducationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProgramParticipationSpecialEducationViewModel Constructor
    /// </summary>
    public ProgramParticipationSpecialEducationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProgramParticipationSpecialEducationViewModelConstruction();
    }

    /// <summary>
    /// ProgramParticipationSpecialEducationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProgramParticipationSpecialEducationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProgramParticipationSpecialEducation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the AwaitingInitialIdeaevaluationStatus property
    private Boolean? awaitingInitialIdeaevaluationStatus;

    // member variable for the IdeaplacementRationale property
    private System.String ideaplacementRationale;

    // member variable for the RefIdeaeducationalEnvironmentEcid property
    private Int32? refIdeaeducationalEnvironmentEcid;

    // member variable for the SpecialEducationFte property
    private Decimal? specialEducationFte;

    // SpecialEducationServicesExitDate -- (backing property for Special Education Services Exit Date)
    private DateTime? specialEducationServicesExitDate;

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

    #region "IProgramParticipationSpecialEducation Properties"
    public Boolean? AwaitingInitialIdeaevaluationStatus { get => awaitingInitialIdeaevaluationStatus; set => SetProperty(ref awaitingInitialIdeaevaluationStatus, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    public System.String IdeaplacementRationale { get => ideaplacementRationale; set => SetProperty(ref ideaplacementRationale, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    public Int32? RefIdeaeducationalEnvironmentEcid { get => refIdeaeducationalEnvironmentEcid; set => SetProperty(ref refIdeaeducationalEnvironmentEcid, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaeducationalEnvironmentSchoolAge"/> model
    /// </summary>
    public Guid? RefIdeaeducationalEnvironmentSchoolAgeId { get; set; }

    /// <summary>
    /// Special Education Exit Reason
    /// <para>
    /// The reason children who were in special education at the start of the reporting period were not in special education at the end of the reporting period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19260">Special Education Exit Reason</a>
    /// </para>
    /// </summary>
    [DisplayName("Special Education Exit Reason")]
    public Guid? RefSpecialEducationExitReasonId { get; set; }

    public Decimal? SpecialEducationFte { get => specialEducationFte; set => SetProperty(ref specialEducationFte, value, false); }

    /// <summary>
    /// Special Education Services Exit Date
    /// <para>
    /// The year, month and day a child with disabilities (IDEA) ages 14 through 21 exited special education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19263">Special Education Services Exit Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Special Education Services Exit Date")]
    public DateTime? SpecialEducationServicesExitDate { get => specialEducationServicesExitDate; set => SetProperty(ref specialEducationServicesExitDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProgramParticipationSpecialEducation model)
    {
        IsBusy = true;
        Id = model.Id;
        AwaitingInitialIdeaevaluationStatus = model.AwaitingInitialIdeaevaluationStatus; // 
        IdeaplacementRationale = model.IdeaplacementRationale; // 
        PersonProgramParticipationId = model.PersonProgramParticipationId; // 
        RefIdeaeducationalEnvironmentEcid = model.RefIdeaeducationalEnvironmentEcid; // 
        RefIdeaeducationalEnvironmentSchoolAgeId = model.RefIdeaeducationalEnvironmentSchoolAgeId; // 
        RefSpecialEducationExitReasonId = model.RefSpecialEducationExitReasonId; // Special Education Exit Reason
        SpecialEducationFte = model.SpecialEducationFte; // 
        SpecialEducationServicesExitDate = model.SpecialEducationServicesExitDate; // Special Education Services Exit Date
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
