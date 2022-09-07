//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCourseSectionMarkViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentCourseSectionMark file
/// </summary>
public partial class PsStudentCourseSectionMarkViewModel : ObservableValidator, IPsStudentCourseSectionMark
{
    #region "PsStudentCourseSectionMarkViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsStudentCourseSectionMarkViewModel Constructor
    /// </summary>
    public PsStudentCourseSectionMarkViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsStudentCourseSectionMarkViewModelConstruction();
    }

    /// <summary>
    /// PsStudentCourseSectionMarkViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsStudentCourseSectionMarkViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsStudentCourseSectionMark";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CourseNarrativeExplanationGrade -- (backing property for Course Narrative Explanation Grade)
    private System.String courseNarrativeExplanationGrade;

    // StudentCourseSectionGradeNarrative -- (backing property for Student Course Section Grade Narrative)
    private System.String studentCourseSectionGradeNarrative;

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

    #region "IPsStudentCourseSectionMark Properties"
    /// <summary>
    /// Course Narrative Explanation Grade
    /// <para>
    /// The narrative of the grade awarded to an individual in an academic course in those cases where a course does not receive a letter or numeric grade included in the grading scale of the Course Academic Grade Qualifier.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20279">Course Narrative Explanation Grade</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Narrative Explanation Grade")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CourseNarrativeExplanationGrade { get => courseNarrativeExplanationGrade; set => SetProperty(ref courseNarrativeExplanationGrade, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsStudentSection"/> model
    /// </summary>
    public Guid PsStudentSectionId { get; set; }

    /// <summary>
    /// Course Academic Grade Status Code
    /// <para>
    /// Additional information regarding the context of the given grade.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20265">Course Academic Grade Status Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Academic Grade Status Code")]
    public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

    /// <summary>
    /// Student Course Section Grade Narrative
    /// <para>
    /// The narrative of the student performance in a course section as submitted by the instructor.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20552">Student Course Section Grade Narrative</a>
    /// </para>
    /// </summary>
    [DisplayName("Student Course Section Grade Narrative")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String StudentCourseSectionGradeNarrative { get => studentCourseSectionGradeNarrative; set => SetProperty(ref studentCourseSectionGradeNarrative, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsStudentCourseSectionMark model)
    {
        IsBusy = true;
        Id = model.Id;
        CourseNarrativeExplanationGrade = model.CourseNarrativeExplanationGrade; // Course Narrative Explanation Grade
        PsStudentSectionId = model.PsStudentSectionId; // 
        RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId; // Course Academic Grade Status Code
        StudentCourseSectionGradeNarrative = model.StudentCourseSectionGradeNarrative; // Student Course Section Grade Narrative
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
