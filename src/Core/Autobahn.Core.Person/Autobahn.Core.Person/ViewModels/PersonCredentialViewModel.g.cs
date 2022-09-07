//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonCredentialViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonCredential file
/// </summary>
public partial class PersonCredentialViewModel : ObservableValidator, IPersonCredential
{
    #region "PersonCredentialViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonCredentialViewModel Constructor
    /// </summary>
    public PersonCredentialViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonCredentialViewModelConstruction();
    }

    /// <summary>
    /// PersonCredentialViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonCredentialViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonCredential";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CredentialName -- (backing property for Name of Professional Credential or License)
    private System.String credentialName;

    // CredentialOrLicenseAwardEntity -- (backing property for Credential or License Award Entity)
    private System.String credentialOrLicenseAwardEntity;

    // ExpirationDate -- (backing property for Credential Expiration Date)
    private DateTime? expirationDate;

    // IssuanceDate -- (backing property for Credential Issuance Date)
    private DateTime? issuanceDate;

    // ProfessionalCertificateOrLicenseNumber -- (backing property for Professional Certificate or License Number)
    private System.String professionalCertificateOrLicenseNumber;

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

    #region "IPersonCredential Properties"
    /// <summary>
    /// Name of Professional Credential or License
    /// <para>
    /// The name of the license/credential awarded by a given profession.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20064">Name of Professional Credential or License</a>
    /// </para>
    /// </summary>
    [DisplayName("Name of Professional Credential or License")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CredentialName { get => credentialName; set => SetProperty(ref credentialName, value, true); }

    /// <summary>
    /// Credential or License Award Entity
    /// <para>
    /// The name of the organization awarding the individual's credential or license.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20566">Credential or License Award Entity</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential or License Award Entity")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CredentialOrLicenseAwardEntity { get => credentialOrLicenseAwardEntity; set => SetProperty(ref credentialOrLicenseAwardEntity, value, true); }

    /// <summary>
    /// Credential Expiration Date
    /// <para>
    /// The year, month and day on which an active credential held by a person will expire.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19069">Credential Expiration Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Expiration Date")]
    public DateTime? ExpirationDate { get => expirationDate; set => SetProperty(ref expirationDate, value, false); }

    /// <summary>
    /// Credential Issuance Date
    /// <para>
    /// The year, month and day on which an active credential was issued to a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19070">Credential Issuance Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Issuance Date")]
    public DateTime? IssuanceDate { get => issuanceDate; set => SetProperty(ref issuanceDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Professional Certificate or License Number
    /// <para>
    /// The number issued by the credentialing/licensing agency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20398">Professional Certificate or License Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Certificate or License Number")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ProfessionalCertificateOrLicenseNumber { get => professionalCertificateOrLicenseNumber; set => SetProperty(ref professionalCertificateOrLicenseNumber, value, true); }

    /// <summary>
    /// Credential Type
    /// <para>
    /// An indication of the category of credential a person holds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19071">Credential Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Type")]
    public Guid? RefCredentialTypeId { get; set; }

    /// <summary>
    /// State Issuing Professional Credential or License
    /// <para>
    /// State where the professional license/credential was issued.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19804">State Issuing Professional Credential or License</a>
    /// </para>
    /// </summary>
    [DisplayName("State Issuing Professional Credential or License")]
    public Guid? RefIssuingStateId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonCredential model)
    {
        IsBusy = true;
        Id = model.Id;
        CredentialName = model.CredentialName; // Name of Professional Credential or License
        CredentialOrLicenseAwardEntity = model.CredentialOrLicenseAwardEntity; // Credential or License Award Entity
        ExpirationDate = model.ExpirationDate; // Credential Expiration Date
        IssuanceDate = model.IssuanceDate; // Credential Issuance Date
        PersonId = model.PersonId; // 
        ProfessionalCertificateOrLicenseNumber = model.ProfessionalCertificateOrLicenseNumber; // Professional Certificate or License Number
        RefCredentialTypeId = model.RefCredentialTypeId; // Credential Type
        RefIssuingStateId = model.RefIssuingStateId; // State Issuing Professional Credential or License
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
