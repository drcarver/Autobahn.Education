//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonCareerEducationPlanViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonCareerEducationPlan file
/// </summary>
public partial class PersonCareerEducationPlanViewModel : ObservableValidator, IPersonCareerEducationPlan
{
    #region "PersonCareerEducationPlanViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonCareerEducationPlanViewModel Constructor
    /// </summary>
    public PersonCareerEducationPlanViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonCareerEducationPlanViewModelConstruction();
    }

    /// <summary>
    /// PersonCareerEducationPlanViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonCareerEducationPlanViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonCareerEducationPlan";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // LastUpdated -- (backing property for Career Education Plan Date)
    private DateTime? lastUpdated;

    // ProfessionalDevelopmentPlanApprovedBySupervisor -- (backing property for Professional Development Plan Approved by Supervisor)
    private Boolean? professionalDevelopmentPlanApprovedBySupervisor;

    // ProfessionalDevelopmentPlanCompletion -- (backing property for Professional Development Plan Completion)
    private DateTime? professionalDevelopmentPlanCompletion;

    // TuitionFunded -- (backing property for Tuition Funded)
    private Boolean? tuitionFunded;

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

    #region "IPersonCareerEducationPlan Properties"
    /// <summary>
    /// Career Education Plan Date
    /// <para>
    /// The date on which an individual's professional development career plan was last updated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20255">Career Education Plan Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Career Education Plan Date")]
    public DateTime? LastUpdated { get => lastUpdated; set => SetProperty(ref lastUpdated, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Professional Development Plan Approved by Supervisor
    /// <para>
    /// Professional development plan is approved by the employee's supervisor.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20599">Professional Development Plan Approved by Supervisor</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Plan Approved by Supervisor")]
    public Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get => professionalDevelopmentPlanApprovedBySupervisor; set => SetProperty(ref professionalDevelopmentPlanApprovedBySupervisor, value, false); }

    /// <summary>
    /// Professional Development Plan Completion
    /// <para>
    /// The date the professional development plan is completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20600">Professional Development Plan Completion</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Plan Completion")]
    public DateTime? ProfessionalDevelopmentPlanCompletion { get => professionalDevelopmentPlanCompletion; set => SetProperty(ref professionalDevelopmentPlanCompletion, value, false); }

    /// <summary>
    /// Career Education Plan Type
    /// <para>
    /// An indication of whether an individual completed an individualized guidance and counseling plan
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20256">Career Education Plan Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Career Education Plan Type")]
    public Guid? RefCareerEducationPlanTypeId { get; set; }

    /// <summary>
    /// Tuition Funded
    /// <para>
    /// Indicates that tuition for person's participation in a program, service, or course is funded or partially funded by an external grant program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20554">Tuition Funded</a>
    /// </para>
    /// </summary>
    [DisplayName("Tuition Funded")]
    public Boolean? TuitionFunded { get => tuitionFunded; set => SetProperty(ref tuitionFunded, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonCareerEducationPlan model)
    {
        IsBusy = true;
        Id = model.Id;
        LastUpdated = model.LastUpdated; // Career Education Plan Date
        PersonId = model.PersonId; // 
        ProfessionalDevelopmentPlanApprovedBySupervisor = model.ProfessionalDevelopmentPlanApprovedBySupervisor; // Professional Development Plan Approved by Supervisor
        ProfessionalDevelopmentPlanCompletion = model.ProfessionalDevelopmentPlanCompletion; // Professional Development Plan Completion
        RefCareerEducationPlanTypeId = model.RefCareerEducationPlanTypeId; // Career Education Plan Type
        TuitionFunded = model.TuitionFunded; // Tuition Funded
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
