//***************************************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteCourseViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICteCourse file
/// </summary>
public partial class CteCourseViewModel : ObservableValidator, ICteCourse
{
    #region "CteCourseViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CteCourseViewModel Constructor
    /// </summary>
    public CteCourseViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCteCourseViewModelConstruction();
    }

    /// <summary>
    /// CteCourseViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCteCourseViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CteCourse";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AvailableCarnegieUnitCredit -- (backing property for Available Carnegie Unit Credit)
    private Decimal? availableCarnegieUnitCredit;

    // CoreAcademicCourse -- (backing property for Core Academic Course)
    private Boolean? coreAcademicCourse;

    // CourseAlignedWithStandards -- (backing property for Course Aligned with Standards)
    private Boolean? courseAlignedWithStandards;

    // CourseDepartmentName -- (backing property for Course Department Name)
    private System.String courseDepartmentName;

    // HighSchoolCourseRequirement -- (backing property for High School Course Requirement)
    private Boolean? highSchoolCourseRequirement;

    // member variable for the ScedcourseCode property
    private System.String scedcourseCode;

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

    #region "ICteCourse Properties"
    /// <summary>
    /// Available Carnegie Unit Credit
    /// <para>
    /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19030">Available Carnegie Unit Credit</a>
    /// </para>
    /// </summary>
    [DisplayName("Available Carnegie Unit Credit")]
    public Decimal? AvailableCarnegieUnitCredit { get => availableCarnegieUnitCredit; set => SetProperty(ref availableCarnegieUnitCredit, value, false); }

    /// <summary>
    /// Core Academic Course
    /// <para>
    /// The course meets the state definition of a core academic course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19509">Core Academic Course</a>
    /// </para>
    /// </summary>
    [DisplayName("Core Academic Course")]
    public Boolean? CoreAcademicCourse { get => coreAcademicCourse; set => SetProperty(ref coreAcademicCourse, value, false); }

    /// <summary>
    /// Course Aligned with Standards
    /// <para>
    /// An indication whether a course is aligned with the established standards of a curriculum framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19013">Course Aligned with Standards</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Aligned with Standards")]
    public Boolean? CourseAlignedWithStandards { get => courseAlignedWithStandards; set => SetProperty(ref courseAlignedWithStandards, value, false); }

    /// <summary>
    /// Course Department Name
    /// <para>
    /// Department with jurisdiction over this course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20525">Course Department Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Department Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CourseDepartmentName { get => courseDepartmentName; set => SetProperty(ref courseDepartmentName, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    public Guid CourseId { get; set; }

    /// <summary>
    /// High School Course Requirement
    /// <para>
    /// An indication that this course credit is required for a high school diploma.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19137">High School Course Requirement</a>
    /// </para>
    /// </summary>
    [DisplayName("High School Course Requirement")]
    public Boolean? HighSchoolCourseRequirement { get => highSchoolCourseRequirement; set => SetProperty(ref highSchoolCourseRequirement, value, false); }

    /// <summary>
    /// Additional Credit Type
    /// <para>
    /// The type of credits or units of value available for the completion of a course in addition to Carnegie Units.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19589">Additional Credit Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Additional Credit Type")]
    public Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Career Cluster
    /// <para>
    /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
    /// </para>
    /// </summary>
    [DisplayName("Career Cluster")]
    public Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    public Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Credit Unit Type
    /// <para>
    /// The type of credits or units of value awarded for the completion of a course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19072">Credit Unit Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Credit Unit Type")]
    public Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Curriculum Framework Type
    /// <para>
    /// An indication of the standard curriculum used for this course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19688">Curriculum Framework Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Curriculum Framework Type")]
    public Guid? RefCurriculumFrameworkTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseLevel"/> model
    /// </summary>
    public Guid? RefScedcourseLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    public Guid? RefScedcourseSubjectAreaId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(5,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScedcourseCode { get => scedcourseCode; set => SetProperty(ref scedcourseCode, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICteCourse model)
    {
        IsBusy = true;
        Id = model.Id;
        AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit; // Available Carnegie Unit Credit
        CoreAcademicCourse = model.CoreAcademicCourse; // Core Academic Course
        CourseAlignedWithStandards = model.CourseAlignedWithStandards; // Course Aligned with Standards
        CourseDepartmentName = model.CourseDepartmentName; // Course Department Name
        CourseId = model.CourseId; // 
        HighSchoolCourseRequirement = model.HighSchoolCourseRequirement; // High School Course Requirement
        RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // Additional Credit Type
        RefCareerClusterId = model.RefCareerClusterId; // Career Cluster
        RefCourseGpaapplicabilityId = model.RefCourseGpaapplicabilityId; // 
        RefCreditTypeEarnedId = model.RefCreditTypeEarnedId; // Credit Unit Type
        RefCurriculumFrameworkTypeId = model.RefCurriculumFrameworkTypeId; // Curriculum Framework Type
        RefScedcourseLevelId = model.RefScedcourseLevelId; // 
        RefScedcourseSubjectAreaId = model.RefScedcourseSubjectAreaId; // 
        ScedcourseCode = model.ScedcourseCode; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
