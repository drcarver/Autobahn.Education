//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialOfferedViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialOffered file
/// </summary>
public partial class CredentialOfferedViewModel : ObservableValidator, ICredentialOffered
{
    #region "CredentialOfferedViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CredentialOfferedViewModel Constructor
    /// </summary>
    public CredentialOfferedViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCredentialOfferedViewModelConstruction();
    }

    /// <summary>
    /// CredentialOfferedViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCredentialOfferedViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CredentialOffered";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CredentialOfferedEndDate -- (backing property for Credential Offered End Date)
    private DateTime? credentialOfferedEndDate;

    // CredentialOfferedStartDate -- (backing property for Credential Offered Start Date)
    private DateTime? credentialOfferedStartDate;

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

    #region "ICredentialOffered Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    public Guid CredentialDefinitionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> model
    /// </summary>
    public Guid CredentialIssuerId { get; set; }

    /// <summary>
    /// Credential Offered End Date
    /// <para>
    /// The last date a credential was offered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20893">Credential Offered End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Offered End Date")]
    public DateTime? CredentialOfferedEndDate { get => credentialOfferedEndDate; set => SetProperty(ref credentialOfferedEndDate, value, false); }

    /// <summary>
    /// Credential Offered Start Date
    /// <para>
    /// The first date a credential was offered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20892">Credential Offered Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Offered Start Date")]
    public DateTime? CredentialOfferedStartDate { get => credentialOfferedStartDate; set => SetProperty(ref credentialOfferedStartDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICredentialOffered model)
    {
        IsBusy = true;
        Id = model.Id;
        CredentialDefinitionId = model.CredentialDefinitionId; // 
        CredentialIssuerId = model.CredentialIssuerId; // 
        CredentialOfferedEndDate = model.CredentialOfferedEndDate; // Credential Offered End Date
        CredentialOfferedStartDate = model.CredentialOfferedStartDate; // Credential Offered Start Date
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
