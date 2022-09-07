//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12courseViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12course file
/// </summary>
public partial class K12courseViewModel : ObservableValidator, IK12course
{
    #region "K12courseViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12courseViewModel Constructor
    /// </summary>
    public K12courseViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12courseViewModelConstruction();
    }

    /// <summary>
    /// K12courseViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12courseViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12course";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the AvailableCarnegieUnitCredit property
    private Decimal? availableCarnegieUnitCredit;

    // member variable for the CoreAcademicCourse property
    private Boolean? coreAcademicCourse;

    // member variable for the CourseAlignedWithStandards property
    private Boolean? courseAlignedWithStandards;

    // member variable for the CourseDepartmentName property
    private System.String courseDepartmentName;

    // member variable for the FamilyConsumerSciencesCourseInd property
    private Boolean? familyConsumerSciencesCourseInd;

    // member variable for the FundingProgram property
    private System.String fundingProgram;

    // member variable for the HighSchoolCourseRequirement property
    private Boolean? highSchoolCourseRequirement;

    // member variable for the ScedcourseCode property
    private System.String scedcourseCode;

    // member variable for the ScedgradeSpan property
    private System.String scedgradeSpan;

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

    #region "IK12course Properties"
    public Decimal? AvailableCarnegieUnitCredit { get => availableCarnegieUnitCredit; set => SetProperty(ref availableCarnegieUnitCredit, value, false); }

    public Boolean? CoreAcademicCourse { get => coreAcademicCourse; set => SetProperty(ref coreAcademicCourse, value, false); }

    public Boolean? CourseAlignedWithStandards { get => courseAlignedWithStandards; set => SetProperty(ref courseAlignedWithStandards, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CourseDepartmentName { get => courseDepartmentName; set => SetProperty(ref courseDepartmentName, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    public Guid CourseId { get; set; }

    public Boolean? FamilyConsumerSciencesCourseInd { get => familyConsumerSciencesCourseInd; set => SetProperty(ref familyConsumerSciencesCourseInd, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FundingProgram { get => fundingProgram; set => SetProperty(ref fundingProgram, value, true); }

    public Boolean? HighSchoolCourseRequirement { get => highSchoolCourseRequirement; set => SetProperty(ref highSchoolCourseRequirement, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
    /// </summary>
    public Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
    /// </summary>
    public Guid? RefBlendedLearningModelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
    /// </summary>
    public Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    public Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseInteractionMode"/> model
    /// </summary>
    public Guid? RefCourseInteractionModeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
    /// </summary>
    public Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCurriculumFrameworkType"/> model
    /// </summary>
    public Guid? RefCurriculumFrameworkTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12endOfCourseRequirement"/> model
    /// </summary>
    public Guid? RefK12endOfCourseRequirementId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseLevel"/> model
    /// </summary>
    public Guid? RefScedcourseLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    public Guid? RefScedcourseSubjectAreaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
    /// </summary>
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(5,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScedcourseCode { get => scedcourseCode; set => SetProperty(ref scedcourseCode, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScedgradeSpan { get => scedgradeSpan; set => SetProperty(ref scedgradeSpan, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12course model)
    {
        IsBusy = true;
        Id = model.Id;
        AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit; // 
        CoreAcademicCourse = model.CoreAcademicCourse; // 
        CourseAlignedWithStandards = model.CourseAlignedWithStandards; // 
        CourseDepartmentName = model.CourseDepartmentName; // 
        CourseId = model.CourseId; // 
        FamilyConsumerSciencesCourseInd = model.FamilyConsumerSciencesCourseInd; // 
        FundingProgram = model.FundingProgram; // 
        HighSchoolCourseRequirement = model.HighSchoolCourseRequirement; // 
        RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // 
        RefBlendedLearningModelTypeId = model.RefBlendedLearningModelTypeId; // 
        RefCareerClusterId = model.RefCareerClusterId; // 
        RefCourseGpaapplicabilityId = model.RefCourseGpaapplicabilityId; // 
        RefCourseInteractionModeId = model.RefCourseInteractionModeId; // 
        RefCreditTypeEarnedId = model.RefCreditTypeEarnedId; // 
        RefCurriculumFrameworkTypeId = model.RefCurriculumFrameworkTypeId; // 
        RefK12endOfCourseRequirementId = model.RefK12endOfCourseRequirementId; // 
        RefScedcourseLevelId = model.RefScedcourseLevelId; // 
        RefScedcourseSubjectAreaId = model.RefScedcourseSubjectAreaId; // 
        RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // 
        ScedcourseCode = model.ScedcourseCode; // 
        ScedgradeSpan = model.ScedgradeSpan; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
