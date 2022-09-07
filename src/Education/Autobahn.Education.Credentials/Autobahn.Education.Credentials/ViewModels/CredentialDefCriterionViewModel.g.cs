//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCriterionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefCriterion file
/// </summary>
public partial class CredentialDefCriterionViewModel : ObservableValidator, ICredentialDefCriterion
{
    #region "CredentialDefCriterionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CredentialDefCriterionViewModel Constructor
    /// </summary>
    public CredentialDefCriterionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCredentialDefCriterionViewModelConstruction();
    }

    /// <summary>
    /// CredentialDefCriterionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCredentialDefCriterionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CredentialDefCriterion";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the Criteria property
    private System.String criteria;

    // member variable for the CriteriaUrl property
    private System.String criteriaUrl;

    // member variable for the EstimatedDuration property
    private System.String estimatedDuration;

    // member variable for the MaximumDuration property
    private System.String maximumDuration;

    // member variable for the MinimumAge property
    private Int32? minimumAge;

    // member variable for the MinimumDuration property
    private System.String minimumDuration;

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

    #region "ICredentialDefCriterion Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    public Guid? CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
    /// </summary>
    public Guid CredentialDefCriteriaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    public Guid CredentialDefinitionId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Criteria { get => criteria; set => SetProperty(ref criteria, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CriteriaUrl { get => criteriaUrl; set => SetProperty(ref criteriaUrl, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(5,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EstimatedDuration { get => estimatedDuration; set => SetProperty(ref estimatedDuration, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(5,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MaximumDuration { get => maximumDuration; set => SetProperty(ref maximumDuration, value, true); }

    public Int32? MinimumAge { get => minimumAge; set => SetProperty(ref minimumAge, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(5,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MinimumDuration { get => minimumDuration; set => SetProperty(ref minimumDuration, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCredentialDefAssessMethodType"/> model
    /// </summary>
    public Guid? RefCredentialDefAssessMethodTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICredentialDefCriterion model)
    {
        IsBusy = true;
        Id = model.Id;
        CompetencySetId = model.CompetencySetId; // 
        CredentialDefCriteriaId = model.CredentialDefCriteriaId; // 
        CredentialDefinitionId = model.CredentialDefinitionId; // 
        Criteria = model.Criteria; // 
        CriteriaUrl = model.CriteriaUrl; // 
        EstimatedDuration = model.EstimatedDuration; // 
        MaximumDuration = model.MaximumDuration; // 
        MinimumAge = model.MinimumAge; // 
        MinimumDuration = model.MinimumDuration; // 
        RefCredentialDefAssessMethodTypeId = model.RefCredentialDefAssessMethodTypeId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
