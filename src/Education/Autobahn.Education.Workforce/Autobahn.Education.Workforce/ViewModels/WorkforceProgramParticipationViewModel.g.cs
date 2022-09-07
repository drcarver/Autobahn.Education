//***************************************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IWorkforceProgramParticipation file
/// </summary>
public partial class WorkforceProgramParticipationViewModel : ObservableValidator, IWorkforceProgramParticipation
{
    #region "WorkforceProgramParticipationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// WorkforceProgramParticipationViewModel Constructor
    /// </summary>
    public WorkforceProgramParticipationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnWorkforceProgramParticipationViewModelConstruction();
    }

    /// <summary>
    /// WorkforceProgramParticipationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnWorkforceProgramParticipationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from WorkforceProgramParticipation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // DiplomaOrCredentialAwardDate -- (backing property for Diploma or Credential Award Date)
    private System.String diplomaOrCredentialAwardDate;

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

    #region "IWorkforceProgramParticipation Properties"
    /// <summary>
    /// Diploma or Credential Award Date
    /// <para>
    /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Diploma or Credential Award Date")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(7,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DiplomaOrCredentialAwardDate { get => diplomaOrCredentialAwardDate; set => SetProperty(ref diplomaOrCredentialAwardDate, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Professional or Technical Credential Conferred
    /// <para>
    /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional or Technical Credential Conferred")]
    public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    /// <summary>
    /// Workforce Program Type
    /// <para>
    /// The type of workforce and employment development program that an individual is participating in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20000">Workforce Program Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Workforce Program Type")]
    public Guid? RefWfProgramParticipationId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IWorkforceProgramParticipation model)
    {
        IsBusy = true;
        Id = model.Id;
        DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
        PersonProgramParticipationId = model.PersonProgramParticipationId; // 
        RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // Professional or Technical Credential Conferred
        RefWfProgramParticipationId = model.RefWfProgramParticipationId; // Workforce Program Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
