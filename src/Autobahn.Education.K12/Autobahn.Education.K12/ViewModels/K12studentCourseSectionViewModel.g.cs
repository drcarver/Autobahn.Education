//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCourseSectionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCourseSection file
/// </summary>
public partial class K12studentCourseSectionViewModel : ObservableValidator, IK12studentCourseSection
{
    #region "K12studentCourseSectionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12studentCourseSectionViewModel Constructor
    /// </summary>
    public K12studentCourseSectionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12studentCourseSectionViewModelConstruction();
    }

    /// <summary>
    /// K12studentCourseSectionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12studentCourseSectionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12studentCourseSection";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ExitWithdrawalDate property
    private DateTime? exitWithdrawalDate;

    // member variable for the GradeEarned property
    private System.String gradeEarned;

    // member variable for the GradeValueQualifier property
    private System.String gradeValueQualifier;

    // member variable for the NumberOfCreditsAttempted property
    private Decimal? numberOfCreditsAttempted;

    // member variable for the NumberOfCreditsEarned property
    private Decimal? numberOfCreditsEarned;

    // member variable for the TuitionFunded property
    private Boolean? tuitionFunded;

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

    #region "IK12studentCourseSection Properties"
    public DateTime? ExitWithdrawalDate { get => exitWithdrawalDate; set => SetProperty(ref exitWithdrawalDate, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(15,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GradeEarned { get => gradeEarned; set => SetProperty(ref gradeEarned, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GradeValueQualifier { get => gradeValueQualifier; set => SetProperty(ref gradeValueQualifier, value, true); }

    public Decimal? NumberOfCreditsAttempted { get => numberOfCreditsAttempted; set => SetProperty(ref numberOfCreditsAttempted, value, false); }

    public Decimal? NumberOfCreditsEarned { get => numberOfCreditsEarned; set => SetProperty(ref numberOfCreditsEarned, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
    /// </summary>
    public Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    public Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
    /// </summary>
    public Guid? RefCourseRepeatCodeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionEnrollmentStatusType"/> model
    /// </summary>
    public Guid? RefCourseSectionEnrollmentStatusTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionEntryType"/> model
    /// </summary>
    public Guid? RefCourseSectionEntryTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionExitType"/> model
    /// </summary>
    public Guid? RefCourseSectionExitTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
    /// </summary>
    public Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
    /// </summary>
    public Guid? RefExitOrWithdrawalStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
    /// </summary>
    public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
    /// </summary>
    public Guid? RefPreAndPostTestIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
    /// </summary>
    public Guid? RefProgressLevelId { get; set; }

    public Boolean? TuitionFunded { get => tuitionFunded; set => SetProperty(ref tuitionFunded, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12studentCourseSection model)
    {
        IsBusy = true;
        Id = model.Id;
        ExitWithdrawalDate = model.ExitWithdrawalDate; // 
        GradeEarned = model.GradeEarned; // 
        GradeValueQualifier = model.GradeValueQualifier; // 
        NumberOfCreditsAttempted = model.NumberOfCreditsAttempted; // 
        NumberOfCreditsEarned = model.NumberOfCreditsEarned; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // 
        RefCourseGpaapplicabilityId = model.RefCourseGpaapplicabilityId; // 
        RefCourseRepeatCodeId = model.RefCourseRepeatCodeId; // 
        RefCourseSectionEnrollmentStatusTypeId = model.RefCourseSectionEnrollmentStatusTypeId; // 
        RefCourseSectionEntryTypeId = model.RefCourseSectionEntryTypeId; // 
        RefCourseSectionExitTypeId = model.RefCourseSectionExitTypeId; // 
        RefCreditTypeEarnedId = model.RefCreditTypeEarnedId; // 
        RefExitOrWithdrawalStatusId = model.RefExitOrWithdrawalStatusId; // 
        RefGradeLevelWhenCourseTakenId = model.RefGradeLevelWhenCourseTakenId; // 
        RefPreAndPostTestIndicatorId = model.RefPreAndPostTestIndicatorId; // 
        RefProgressLevelId = model.RefProgressLevelId; // 
        TuitionFunded = model.TuitionFunded; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
