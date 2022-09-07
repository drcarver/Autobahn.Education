//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentEnrollmentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentEnrollment file
/// </summary>
public partial class K12studentEnrollmentViewModel : ObservableValidator, IK12studentEnrollment
{
    #region "K12studentEnrollmentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12studentEnrollmentViewModel Constructor
    /// </summary>
    public K12studentEnrollmentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12studentEnrollmentViewModelConstruction();
    }

    /// <summary>
    /// K12studentEnrollmentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12studentEnrollmentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12studentEnrollment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the DisplacedStudentStatus property
    private Boolean? displacedStudentStatus;

    // member variable for the FirstEntryDateIntoUsschool property
    private DateTime? firstEntryDateIntoUsschool;

    // member variable for the NslpdirectCertificationIndicator property
    private Boolean? nslpdirectCertificationIndicator;

    // member variable for the RefEntryType property
    private Int32? refEntryType;

    // member variable for the RefPublicSchoolResidence property
    private Int32? refPublicSchoolResidence;

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

    #region "IK12studentEnrollment Properties"
    public Boolean? DisplacedStudentStatus { get => displacedStudentStatus; set => SetProperty(ref displacedStudentStatus, value, false); }

    public DateTime? FirstEntryDateIntoUsschool { get => firstEntryDateIntoUsschool; set => SetProperty(ref firstEntryDateIntoUsschool, value, false); }

    public Boolean? NslpdirectCertificationIndicator { get => nslpdirectCertificationIndicator; set => SetProperty(ref nslpdirectCertificationIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
    /// </summary>
    public Guid? RefDirectoryInformationBlockStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEndOfTermStatus"/> model
    /// </summary>
    public Guid? RefEndOfTermStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEnrollmentStatus"/> model
    /// </summary>
    public Guid? RefEnrollmentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEntryGradeLevel"/> model
    /// </summary>
    public Guid? RefEntryGradeLevelId { get; set; }

    public Int32? RefEntryType { get => refEntryType; set => SetProperty(ref refEntryType, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitGradeLevel"/> model
    /// </summary>
    public Guid? RefExitGradeLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
    /// </summary>
    public Guid? RefExitOrWithdrawalStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalType"/> model
    /// </summary>
    public Guid? RefExitOrWithdrawalTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
    /// </summary>
    public Guid? RefFoodServiceEligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNonPromotionReason"/> model
    /// </summary>
    public Guid? RefNonPromotionReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPromotionReason"/> model
    /// </summary>
    public Guid? RefPromotionReasonId { get; set; }

    public Int32? RefPublicSchoolResidence { get => refPublicSchoolResidence; set => SetProperty(ref refPublicSchoolResidence, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessType"/> model
    /// </summary>
    public Guid? RefStudentEnrollmentAccessTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12studentEnrollment model)
    {
        IsBusy = true;
        Id = model.Id;
        DisplacedStudentStatus = model.DisplacedStudentStatus; // 
        FirstEntryDateIntoUsschool = model.FirstEntryDateIntoUsschool; // 
        NslpdirectCertificationIndicator = model.NslpdirectCertificationIndicator; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefDirectoryInformationBlockStatusId = model.RefDirectoryInformationBlockStatusId; // 
        RefEndOfTermStatusId = model.RefEndOfTermStatusId; // 
        RefEnrollmentStatusId = model.RefEnrollmentStatusId; // 
        RefEntryGradeLevelId = model.RefEntryGradeLevelId; // 
        RefEntryType = model.RefEntryType; // 
        RefExitGradeLevelId = model.RefExitGradeLevelId; // 
        RefExitOrWithdrawalStatusId = model.RefExitOrWithdrawalStatusId; // 
        RefExitOrWithdrawalTypeId = model.RefExitOrWithdrawalTypeId; // 
        RefFoodServiceEligibilityId = model.RefFoodServiceEligibilityId; // 
        RefNonPromotionReasonId = model.RefNonPromotionReasonId; // 
        RefPromotionReasonId = model.RefPromotionReasonId; // 
        RefPublicSchoolResidence = model.RefPublicSchoolResidence; // 
        RefStudentEnrollmentAccessTypeId = model.RefStudentEnrollmentAccessTypeId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
