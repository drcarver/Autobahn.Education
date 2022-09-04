//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildServicesApplicationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElchildServicesApplication file
/// </summary>
public partial class ElchildServicesApplicationViewModel : ObservableValidator, IElchildServicesApplication
{
    #region "ElchildServicesApplicationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElchildServicesApplicationViewModel Constructor
    /// </summary>
    public ElchildServicesApplicationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElchildServicesApplicationViewModelConstruction();
    }

    /// <summary>
    /// ElchildServicesApplicationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElchildServicesApplicationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElchildServicesApplication";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ApplicationDate property
    private DateTime? applicationDate;

    // member variable for the ElapplicationIdentifier property
    private System.String elapplicationIdentifier;

    // member variable for the ElapplicationRequiredDocument property
    private Boolean? elapplicationRequiredDocument;

    // member variable for the ElenrollmentApplicationDocumentIdentifier property
    private System.String elenrollmentApplicationDocumentIdentifier;

    // member variable for the ElenrollmentApplicationDocumentName property
    private System.String elenrollmentApplicationDocumentName;

    // member variable for the ElenrollmentApplicationDocumentType property
    private System.String elenrollmentApplicationDocumentType;

    // member variable for the ElenrollmentApplicationVerificationDate property
    private DateTime? elenrollmentApplicationVerificationDate;

    // member variable for the ElenrollmentApplicationVerificationReasonType property
    private System.String elenrollmentApplicationVerificationReasonType;

    // member variable for the SitePreferenceRank property
    private System.String sitePreferenceRank;

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

    #region "IElchildServicesApplication Properties"
    public DateTime? ApplicationDate { get => applicationDate; set => SetProperty(ref applicationDate, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElapplicationIdentifier { get => elapplicationIdentifier; set => SetProperty(ref elapplicationIdentifier, value, true); }

    public Boolean? ElapplicationRequiredDocument { get => elapplicationRequiredDocument; set => SetProperty(ref elapplicationRequiredDocument, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElenrollmentApplicationDocumentIdentifier { get => elenrollmentApplicationDocumentIdentifier; set => SetProperty(ref elenrollmentApplicationDocumentIdentifier, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElenrollmentApplicationDocumentName { get => elenrollmentApplicationDocumentName; set => SetProperty(ref elenrollmentApplicationDocumentName, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElenrollmentApplicationDocumentType { get => elenrollmentApplicationDocumentType; set => SetProperty(ref elenrollmentApplicationDocumentType, value, true); }

    public DateTime? ElenrollmentApplicationVerificationDate { get => elenrollmentApplicationVerificationDate; set => SetProperty(ref elenrollmentApplicationVerificationDate, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElenrollmentApplicationVerificationReasonType { get => elenrollmentApplicationVerificationReasonType; set => SetProperty(ref elenrollmentApplicationVerificationReasonType, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SitePreferenceRank { get => sitePreferenceRank; set => SetProperty(ref sitePreferenceRank, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElchildServicesApplication model)
    {
        IsBusy = true;
        Id = model.Id;
        ApplicationDate = model.ApplicationDate; // 
        ElapplicationIdentifier = model.ElapplicationIdentifier; // 
        ElapplicationRequiredDocument = model.ElapplicationRequiredDocument; // 
        ElenrollmentApplicationDocumentIdentifier = model.ElenrollmentApplicationDocumentIdentifier; // 
        ElenrollmentApplicationDocumentName = model.ElenrollmentApplicationDocumentName; // 
        ElenrollmentApplicationDocumentType = model.ElenrollmentApplicationDocumentType; // 
        ElenrollmentApplicationVerificationDate = model.ElenrollmentApplicationVerificationDate; // 
        ElenrollmentApplicationVerificationReasonType = model.ElenrollmentApplicationVerificationReasonType; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        SitePreferenceRank = model.SitePreferenceRank; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
