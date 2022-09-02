//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefIdentifierViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefIdentifier file
/// </summary>
public partial class CredentialDefIdentifierViewModel : ObservableValidator, ICredentialDefIdentifier
{
    #region "CredentialDefIdentifierViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CredentialDefIdentifierViewModel Constructor
    /// </summary>
    public CredentialDefIdentifierViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCredentialDefIdentifierViewModelConstruction();
    }

    /// <summary>
    /// CredentialDefIdentifierViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCredentialDefIdentifierViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CredentialDefIdentifier";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Identifier -- (backing property for Credential Definition Identifier)
    private System.String identifier;

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

    #region "ICredentialDefIdentifier Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    public Guid CredentialDefinitionId { get; set; }

    /// <summary>
    /// Credential Definition Identifier
    /// <para>
    /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
    /// </para>
    /// <para>
    /// <a href="">Credential Definition Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Credential Definition Identifier System
    /// <para>
    /// A coding scheme that is used for identification and record-keeping purposes by a credentialing organization to refer to a qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20720">Credential Definition Identifier System</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Definition Identifier System")]
    public Guid? RefCredentialIdentifierSystemId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICredentialDefIdentifier model)
    {
        IsBusy = true;
        Id = model.Id;
        CredentialDefinitionId = model.CredentialDefinitionId; // 
        Identifier = model.Identifier; // Credential Definition Identifier
        RefCredentialIdentifierSystemId = model.RefCredentialIdentifierSystemId; // Credential Definition Identifier System
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
