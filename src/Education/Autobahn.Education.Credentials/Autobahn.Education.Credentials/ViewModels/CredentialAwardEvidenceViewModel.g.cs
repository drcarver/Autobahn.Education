//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardEvidenceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialAwardEvidence file
/// </summary>
public partial class CredentialAwardEvidenceViewModel : ObservableValidator, ICredentialAwardEvidence
{
    #region "CredentialAwardEvidenceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CredentialAwardEvidenceViewModel Constructor
    /// </summary>
    public CredentialAwardEvidenceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCredentialAwardEvidenceViewModelConstruction();
    }

    /// <summary>
    /// CredentialAwardEvidenceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCredentialAwardEvidenceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CredentialAwardEvidence";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Statement -- (backing property for Credential Evidence Statement)
    private System.String statement;

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

    #region "ICredentialAwardEvidence Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
    /// </summary>
    public Guid? AssessmentResultId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialAward"/> model
    /// </summary>
    public Guid CredentialAwardId { get; set; }

    /// <summary>
    /// Credential Evidence Statement
    /// <para>
    /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19901">Credential Evidence Statement</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Evidence Statement")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Statement { get => statement; set => SetProperty(ref statement, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICredentialAwardEvidence model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentResultId = model.AssessmentResultId; // 
        CredentialAwardId = model.CredentialAwardId; // 
        Statement = model.Statement; // Credential Evidence Statement
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
