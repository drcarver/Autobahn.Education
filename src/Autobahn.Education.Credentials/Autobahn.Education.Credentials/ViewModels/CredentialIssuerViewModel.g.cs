//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialIssuer file
/// </summary>
public partial class CredentialIssuerViewModel : ObservableValidator, ICredentialIssuer
{
    #region "CredentialIssuerViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CredentialIssuerViewModel Constructor
    /// </summary>
    public CredentialIssuerViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCredentialIssuerViewModelConstruction();
    }

    /// <summary>
    /// CredentialIssuerViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCredentialIssuerViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CredentialIssuer";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the AwardIssuerOriginUrl property
    private System.String awardIssuerOriginUrl;

    // member variable for the RevocationListUrl property
    private System.String revocationListUrl;

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

    #region "ICredentialIssuer Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AwardIssuerOriginUrl { get => awardIssuerOriginUrl; set => SetProperty(ref awardIssuerOriginUrl, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCtdlorganizationType"/> model
    /// </summary>
    public Guid? RefCtdlorganizationTypeId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RevocationListUrl { get => revocationListUrl; set => SetProperty(ref revocationListUrl, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICredentialIssuer model)
    {
        IsBusy = true;
        Id = model.Id;
        AwardIssuerOriginUrl = model.AwardIssuerOriginUrl; // 
        OrganizationId = model.OrganizationId; // 
        RefCtdlorganizationTypeId = model.RefCtdlorganizationTypeId; // 
        RevocationListUrl = model.RevocationListUrl; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
