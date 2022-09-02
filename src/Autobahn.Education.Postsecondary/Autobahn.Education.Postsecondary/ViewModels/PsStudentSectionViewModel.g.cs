//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentSectionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentSection file
/// </summary>
public partial class PsStudentSectionViewModel : ObservableValidator, IPsStudentSection
{
    #region "PsStudentSectionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsStudentSectionViewModel Constructor
    /// </summary>
    public PsStudentSectionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsStudentSectionViewModelConstruction();
    }

    /// <summary>
    /// PsStudentSectionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsStudentSectionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsStudentSection";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AcademicGrade -- (backing property for Course Academic Grade)
    private System.String academicGrade;

    // CourseOverrideSchool -- (backing property for Course Override School)
    private System.String courseOverrideSchool;

    // DegreeApplicability -- (backing property for Degree Applicability)
    private Boolean? degreeApplicability;

    // NumberOfCreditsAttempted -- (backing property for Number of Credits Attempted)
    private Decimal? numberOfCreditsAttempted;

    // NumberOfCreditsEarned -- (backing property for Number of Credits Earned)
    private Decimal? numberOfCreditsEarned;

    // QualityPointsEarned -- (backing property for Course Quality Points Earned)
    private Decimal? qualityPointsEarned;

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

    #region "IPsStudentSection Properties"
    /// <summary>
    /// Course Academic Grade
    /// <para>
    /// The final grade awarded for participation in the course. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19053">Course Academic Grade</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Academic Grade")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(15,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AcademicGrade { get => academicGrade; set => SetProperty(ref academicGrade, value, true); }

    /// <summary>
    /// Course Override School
    /// <para>
    /// The school where the credit was earned if different from the institution reporting. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19063">Course Override School</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Override School")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CourseOverrideSchool { get => courseOverrideSchool; set => SetProperty(ref courseOverrideSchool, value, true); }

    /// <summary>
    /// Degree Applicability
    /// <para>
    /// An indication that the course is a part of a degree program. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19077">Degree Applicability</a>
    /// </para>
    /// </summary>
    [DisplayName("Degree Applicability")]
    public Boolean? DegreeApplicability { get => degreeApplicability; set => SetProperty(ref degreeApplicability, value, false); }

    /// <summary>
    /// Number of Credits Attempted
    /// <para>
    /// The number of credits that a student can earn for enrolling in and completing a given course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19199">Number of Credits Attempted</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of Credits Attempted")]
    public Decimal? NumberOfCreditsAttempted { get => numberOfCreditsAttempted; set => SetProperty(ref numberOfCreditsAttempted, value, false); }

    /// <summary>
    /// Number of Credits Earned
    /// <para>
    /// The number of credits an individual earns by the successful completion of a course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19200">Number of Credits Earned</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of Credits Earned")]
    public Decimal? NumberOfCreditsEarned { get => numberOfCreditsEarned; set => SetProperty(ref numberOfCreditsEarned, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Course Quality Points Earned
    /// <para>
    /// The numerical value assigned to a letter grade to provide a basis of quantitative determination of an average. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19064">Course Quality Points Earned</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Quality Points Earned")]
    public Decimal? QualityPointsEarned { get => qualityPointsEarned; set => SetProperty(ref qualityPointsEarned, value, false); }

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
    /// Course Repeat Code
    /// <para>
    /// Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student's academic grade average.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19065">Course Repeat Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Repeat Code")]
    public Guid? RefCourseRepeatCodeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsStudentSection model)
    {
        IsBusy = true;
        Id = model.Id;
        AcademicGrade = model.AcademicGrade; // Course Academic Grade
        CourseOverrideSchool = model.CourseOverrideSchool; // Course Override School
        DegreeApplicability = model.DegreeApplicability; // Degree Applicability
        NumberOfCreditsAttempted = model.NumberOfCreditsAttempted; // Number of Credits Attempted
        NumberOfCreditsEarned = model.NumberOfCreditsEarned; // Number of Credits Earned
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        QualityPointsEarned = model.QualityPointsEarned; // Course Quality Points Earned
        RefCourseAcademicGradeStatusCodeId = model.RefCourseAcademicGradeStatusCodeId; // Course Academic Grade Status Code
        RefCourseRepeatCodeId = model.RefCourseRepeatCodeId; // Course Repeat Code
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
