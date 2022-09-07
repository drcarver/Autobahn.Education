//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolStatusViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolStatus file
/// </summary>
public partial class K12schoolStatusViewModel : ObservableValidator, IK12schoolStatus
{
    #region "K12schoolStatusViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12schoolStatusViewModel Constructor
    /// </summary>
    public K12schoolStatusViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12schoolStatusViewModelConstruction();
    }

    /// <summary>
    /// K12schoolStatusViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12schoolStatusViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12schoolStatus";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ConsolidatedMepFundsStatus property
    private Boolean? consolidatedMepFundsStatus;

    // member variable for the ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus property
    private System.String progressAcheivingEnglishLearnerProficiencyStateDefinedStatus;

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

    #region "IK12schoolStatus Properties"
    public Boolean? ConsolidatedMepFundsStatus { get => consolidatedMepFundsStatus; set => SetProperty(ref consolidatedMepFundsStatus, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    public Guid K12schoolId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get => progressAcheivingEnglishLearnerProficiencyStateDefinedStatus; set => SetProperty(ref progressAcheivingEnglishLearnerProficiencyStateDefinedStatus, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocus"/> model
    /// </summary>
    public Guid? RefAlternativeSchoolFocusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
    /// </summary>
    public Guid? RefBlendedLearningModelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefComprehensiveAndTargetedSupport"/> model
    /// </summary>
    public Guid? RefComprehensiveAndTargetedSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefComprehensiveSupport"/> model
    /// </summary>
    public Guid? RefComprehensiveSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefInternetAccess"/> model
    /// </summary>
    public Guid? RefInternetAccessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMagnetSpecialProgram"/> model
    /// </summary>
    public Guid? RefMagnetSpecialProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNationalSchoolLunchProgramStatus"/> model
    /// </summary>
    public Guid? RefNationalSchoolLunchProgramStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNslpstatus"/> model
    /// </summary>
    public Guid? RefNslpstatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> model
    /// </summary>
    public Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRestructuringAction"/> model
    /// </summary>
    public Guid? RefRestructuringActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolDangerousStatus"/> model
    /// </summary>
    public Guid? RefSchoolDangerousStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
    /// </summary>
    public Guid? RefSchoolImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTargetedSupport"/> model
    /// </summary>
    public Guid? RefTargetedSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIschoolStatus"/> model
    /// </summary>
    public Guid? RefTitleIschoolStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefVirtualSchoolStatus"/> model
    /// </summary>
    public Guid? RefVirtualSchoolStatusId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12schoolStatus model)
    {
        IsBusy = true;
        Id = model.Id;
        ConsolidatedMepFundsStatus = model.ConsolidatedMepFundsStatus; // 
        K12schoolId = model.K12schoolId; // 
        ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus = model.ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus; // 
        RefAlternativeSchoolFocusId = model.RefAlternativeSchoolFocusId; // 
        RefBlendedLearningModelTypeId = model.RefBlendedLearningModelTypeId; // 
        RefComprehensiveAndTargetedSupportId = model.RefComprehensiveAndTargetedSupportId; // 
        RefComprehensiveSupportId = model.RefComprehensiveSupportId; // 
        RefInternetAccessId = model.RefInternetAccessId; // 
        RefMagnetSpecialProgramId = model.RefMagnetSpecialProgramId; // 
        RefNationalSchoolLunchProgramStatusId = model.RefNationalSchoolLunchProgramStatusId; // 
        RefNslpstatusId = model.RefNslpstatusId; // 
        RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId = model.RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId; // 
        RefRestructuringActionId = model.RefRestructuringActionId; // 
        RefSchoolDangerousStatusId = model.RefSchoolDangerousStatusId; // 
        RefSchoolImprovementStatusId = model.RefSchoolImprovementStatusId; // 
        RefTargetedSupportId = model.RefTargetedSupportId; // 
        RefTitleIschoolStatusId = model.RefTitleIschoolStatusId; // 
        RefVirtualSchoolStatusId = model.RefVirtualSchoolStatusId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
