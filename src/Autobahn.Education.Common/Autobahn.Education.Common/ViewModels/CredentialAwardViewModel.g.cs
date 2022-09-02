//***************************************************************************
//* DomainName: Common Models
//* FileName:   CredentialAwardViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialAward file
/// </summary>
public partial class CredentialAwardViewModel : ObservableValidator, ICredentialAward
{
    #region "CredentialAwardViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CredentialAwardViewModel Constructor
    /// </summary>
    public CredentialAwardViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCredentialAwardViewModelConstruction();
    }

    /// <summary>
    /// CredentialAwardViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCredentialAwardViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CredentialAward";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AdvancedStandingDescription -- (backing property for Credential Advanced Standing Description)
    private System.String advancedStandingDescription;

    // member variable for the AdvancedStandingUrl property
    private System.String advancedStandingUrl;

    // ApproverName -- (backing property for Credential Award Approver Name)
    private System.String approverName;

    // CompletionDate -- (backing property for Credential Completion Date)
    private DateTime? completionDate;

    // CredentialAwardEndDate -- (backing property for Credential Award End Date)
    private DateTime? credentialAwardEndDate;

    // CredentialAwardStartDate -- (backing property for Credential Award Start Date)
    private DateTime? credentialAwardStartDate;

    // member variable for the EvidenceUrl property
    private System.String evidenceUrl;

    // RevokedDate -- (backing property for Credential Revoked Date)
    private DateTime? revokedDate;

    // RevokedIndicator -- (backing property for Credential Revoked Indicator)
    private Boolean? revokedIndicator;

    // RevokedReason -- (backing property for Credential Revoked Reason)
    private System.String revokedReason;

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

    #region "ICredentialAward Properties"
    /// <summary>
    /// Credential Advanced Standing Description
    /// <para>
    /// A description of a credential that reduced the time or cost of attaining this credential.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20715">Credential Advanced Standing Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Advanced Standing Description")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String AdvancedStandingDescription { get => advancedStandingDescription; set => SetProperty(ref advancedStandingDescription, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AdvancedStandingUrl { get => advancedStandingUrl; set => SetProperty(ref advancedStandingUrl, value, true); }

    /// <summary>
    /// Credential Award Approver Name
    /// <para>
    /// Pronouncement of a favorable judgment by the agent being referenced.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20718">Credential Award Approver Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Award Approver Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ApproverName { get => approverName; set => SetProperty(ref approverName, value, true); }

    /// <summary>
    /// Credential Completion Date
    /// <para>
    /// The date on which the person's requirements for earning a credential were met or completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20645">Credential Completion Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Completion Date")]
    public DateTime? CompletionDate { get => completionDate; set => SetProperty(ref completionDate, value, false); }

    /// <summary>
    /// Credential Award End Date
    /// <para>
    /// The date, if any, on which the qualification, achievement, personal or organizational quality, or aspect of an identity expires or requires renewal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20121">Credential Award End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Award End Date")]
    public DateTime? CredentialAwardEndDate { get => credentialAwardEndDate; set => SetProperty(ref credentialAwardEndDate, value, false); }

    /// <summary>
    /// Credential Award Start Date
    /// <para>
    /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20120">Credential Award Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Award Start Date")]
    public DateTime? CredentialAwardStartDate { get => credentialAwardStartDate; set => SetProperty(ref credentialAwardStartDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    public Guid CredentialDefinitionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> model
    /// </summary>
    public Guid CredentialIssuerId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EvidenceUrl { get => evidenceUrl; set => SetProperty(ref evidenceUrl, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid? PersonId { get; set; }

    /// <summary>
    /// Credential Revoked Date
    /// <para>
    /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was revoked.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20641">Credential Revoked Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Revoked Date")]
    public DateTime? RevokedDate { get => revokedDate; set => SetProperty(ref revokedDate, value, false); }

    /// <summary>
    /// Credential Revoked Indicator
    /// <para>
    /// Indicates whether the credential has been revoked by the credential provider.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20732">Credential Revoked Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Revoked Indicator")]
    public Boolean? RevokedIndicator { get => revokedIndicator; set => SetProperty(ref revokedIndicator, value, false); }

    /// <summary>
    /// Credential Revoked Reason
    /// <para>
    /// Published reason for revocation of a credential award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20642">Credential Revoked Reason</a>
    /// </para>
    /// </summary>
    [DisplayName("Credential Revoked Reason")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String RevokedReason { get => revokedReason; set => SetProperty(ref revokedReason, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICredentialAward model)
    {
        IsBusy = true;
        Id = model.Id;
        AdvancedStandingDescription = model.AdvancedStandingDescription; // Credential Advanced Standing Description
        AdvancedStandingUrl = model.AdvancedStandingUrl; // 
        ApproverName = model.ApproverName; // Credential Award Approver Name
        CompletionDate = model.CompletionDate; // Credential Completion Date
        CredentialAwardEndDate = model.CredentialAwardEndDate; // Credential Award End Date
        CredentialAwardStartDate = model.CredentialAwardStartDate; // Credential Award Start Date
        CredentialDefinitionId = model.CredentialDefinitionId; // 
        CredentialIssuerId = model.CredentialIssuerId; // 
        EvidenceUrl = model.EvidenceUrl; // 
        OrganizationId = model.OrganizationId; // 
        PersonId = model.PersonId; // 
        RevokedDate = model.RevokedDate; // Credential Revoked Date
        RevokedIndicator = model.RevokedIndicator; // Credential Revoked Indicator
        RevokedReason = model.RevokedReason; // Credential Revoked Reason
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
