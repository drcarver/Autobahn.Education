//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12school file
/// </summary>
public partial class K12schoolViewModel : ObservableValidator, IK12school
{
    #region "K12schoolViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12schoolViewModel Constructor
    /// </summary>
    public K12schoolViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12schoolViewModelConstruction();
    }

    /// <summary>
    /// K12schoolViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12schoolViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12school";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the AccreditationAgencyName property
    private System.String accreditationAgencyName;

    // member variable for the CharterSchoolApprovalYear property
    private System.String charterSchoolApprovalYear;

    // member variable for the CharterSchoolContractApprovalDate property
    private DateTime? charterSchoolContractApprovalDate;

    // member variable for the CharterSchoolContractIdNumber property
    private System.String charterSchoolContractIdNumber;

    // member variable for the CharterSchoolContractRenewalDate property
    private DateTime? charterSchoolContractRenewalDate;

    // member variable for the CharterSchoolIndicator property
    private Boolean? charterSchoolIndicator;

    // member variable for the CharterSchoolOpenEnrollmentIndicator property
    private Boolean? charterSchoolOpenEnrollmentIndicator;

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

    #region "IK12school Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AccreditationAgencyName { get => accreditationAgencyName; set => SetProperty(ref accreditationAgencyName, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(9,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CharterSchoolApprovalYear { get => charterSchoolApprovalYear; set => SetProperty(ref charterSchoolApprovalYear, value, true); }

    public DateTime? CharterSchoolContractApprovalDate { get => charterSchoolContractApprovalDate; set => SetProperty(ref charterSchoolContractApprovalDate, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CharterSchoolContractIdNumber { get => charterSchoolContractIdNumber; set => SetProperty(ref charterSchoolContractIdNumber, value, true); }

    public DateTime? CharterSchoolContractRenewalDate { get => charterSchoolContractRenewalDate; set => SetProperty(ref charterSchoolContractRenewalDate, value, false); }

    public Boolean? CharterSchoolIndicator { get => charterSchoolIndicator; set => SetProperty(ref charterSchoolIndicator, value, false); }

    public Boolean? CharterSchoolOpenEnrollmentIndicator { get => charterSchoolOpenEnrollmentIndicator; set => SetProperty(ref charterSchoolOpenEnrollmentIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12charterSchoolAuthorizerAgency"/> model
    /// </summary>
    public Guid? K12charterSchoolAuthorizerAgencyId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12charterSchoolManagementOrganization"/> model
    /// </summary>
    public Guid? K12charterSchoolManagementOrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
    /// </summary>
    public Guid? RefAdministrativeFundingControlId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterSchoolType"/> model
    /// </summary>
    public Guid? RefCharterSchoolTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
    /// </summary>
    public Guid? RefIncreasedLearningTimeTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolLevel"/> model
    /// </summary>
    public Guid? RefSchoolLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolType"/> model
    /// </summary>
    public Guid? RefSchoolTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStatePovertyDesignation"/> model
    /// </summary>
    public Guid? RefStatePovertyDesignationId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12school model)
    {
        IsBusy = true;
        Id = model.Id;
        AccreditationAgencyName = model.AccreditationAgencyName; // 
        CharterSchoolApprovalYear = model.CharterSchoolApprovalYear; // 
        CharterSchoolContractApprovalDate = model.CharterSchoolContractApprovalDate; // 
        CharterSchoolContractIdNumber = model.CharterSchoolContractIdNumber; // 
        CharterSchoolContractRenewalDate = model.CharterSchoolContractRenewalDate; // 
        CharterSchoolIndicator = model.CharterSchoolIndicator; // 
        CharterSchoolOpenEnrollmentIndicator = model.CharterSchoolOpenEnrollmentIndicator; // 
        K12charterSchoolAuthorizerAgencyId = model.K12charterSchoolAuthorizerAgencyId; // 
        K12charterSchoolManagementOrganizationId = model.K12charterSchoolManagementOrganizationId; // 
        OrganizationId = model.OrganizationId; // 
        RefAdministrativeFundingControlId = model.RefAdministrativeFundingControlId; // 
        RefCharterSchoolTypeId = model.RefCharterSchoolTypeId; // 
        RefIncreasedLearningTimeTypeId = model.RefIncreasedLearningTimeTypeId; // 
        RefSchoolLevelId = model.RefSchoolLevelId; // 
        RefSchoolTypeId = model.RefSchoolTypeId; // 
        RefStatePovertyDesignationId = model.RefStatePovertyDesignationId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
