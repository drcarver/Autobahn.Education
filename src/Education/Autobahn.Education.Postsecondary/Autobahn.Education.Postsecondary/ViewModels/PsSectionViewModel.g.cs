//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsSection file
/// </summary>
public partial class PsSectionViewModel : ObservableValidator, IPsSection
{
    #region "PsSectionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsSectionViewModel Constructor
    /// </summary>
    public PsSectionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsSectionViewModelConstruction();
    }

    /// <summary>
    /// PsSectionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsSectionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsSection";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // GradeValueQualifier -- (backing property for Course Academic Grade Scale Code)
    private System.String gradeValueQualifier;

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

    #region "IPsSection Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    public Guid CourseSectionId { get; set; }

    /// <summary>
    /// Course Academic Grade Scale Code
    /// <para>
    /// The grading scale used by an academic educational institution for an academic course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20264">Course Academic Grade Scale Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Academic Grade Scale Code")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GradeValueQualifier { get => gradeValueQualifier; set => SetProperty(ref gradeValueQualifier, value, true); }

    /// <summary>
    /// Classification of Instructional Program Code
    /// <para>
    /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Classification of Instructional Program Code")]
    public Guid? RefCipCodeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    public Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Course Honors Type
    /// <para>
    /// An indication that the course is or can be counted as an honors course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20273">Course Honors Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Honors Type")]
    public Guid? RefCourseHonorsTypeId { get; set; }

    /// <summary>
    /// Course Instruction Method
    /// <para>
    /// The primary method of instruction used for the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20274">Course Instruction Method</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Instruction Method")]
    public Guid? RefCourseInstructionMethodId { get; set; }

    /// <summary>
    /// Course Level Type
    /// <para>
    /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Level Type")]
    public Guid? RefCourseLevelTypeId { get; set; }

    /// <summary>
    /// Developmental Education Type
    /// <para>
    /// An indicator of the category of developmental education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20568">Developmental Education Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Developmental Education Type")]
    public Guid? RefDevelopmentalEducationTypeId { get; set; }

    /// <summary>
    /// Work-based Learning Opportunity Type
    /// <para>
    /// The type of work-based learning opportunity a student participated in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Work-based Learning Opportunity Type")]
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsSection model)
    {
        IsBusy = true;
        Id = model.Id;
        CourseSectionId = model.CourseSectionId; // 
        GradeValueQualifier = model.GradeValueQualifier; // Course Academic Grade Scale Code
        RefCipCodeId = model.RefCipCodeId; // Classification of Instructional Program Code
        RefCourseGpaapplicabilityId = model.RefCourseGpaapplicabilityId; // 
        RefCourseHonorsTypeId = model.RefCourseHonorsTypeId; // Course Honors Type
        RefCourseInstructionMethodId = model.RefCourseInstructionMethodId; // Course Instruction Method
        RefCourseLevelTypeId = model.RefCourseLevelTypeId; // Course Level Type
        RefDevelopmentalEducationTypeId = model.RefDevelopmentalEducationTypeId; // Developmental Education Type
        RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // Work-based Learning Opportunity Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
