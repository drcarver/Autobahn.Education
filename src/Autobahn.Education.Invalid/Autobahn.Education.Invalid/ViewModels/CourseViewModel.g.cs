//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   CourseViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICourse file
/// </summary>
public partial class CourseViewModel : ObservableValidator, ICourse
{
    #region "CourseViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CourseViewModel Constructor
    /// </summary>
    public CourseViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCourseViewModelConstruction();
    }

    /// <summary>
    /// CourseViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCourseViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Course";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CertificationDescription -- (backing property for Course Certification Description)
    private System.String certificationDescription;

    // CreditValue -- (backing property for Credit Value)
    private Decimal? creditValue;

    // InstructionalMinutes -- (backing property for Instructional Minutes)
    private Int32? instructionalMinutes;

    // RepeatabilityMaximumNumber -- (backing property for Course Repeatability Maximum Number)
    private Int32? repeatabilityMaximumNumber;

    // member variable for the ScedsequenceOfCourse property
    private System.String scedsequenceOfCourse;

    // SubjectAbbreviation -- (backing property for Course Subject Abbreviation)
    private System.String subjectAbbreviation;

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

    #region "ICourse Properties"
    /// <summary>
    /// Course Certification Description
    /// <para>
    /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20268">Course Certification Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Certification Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CertificationDescription { get => certificationDescription; set => SetProperty(ref certificationDescription, value, true); }

    /// <summary>
    /// Credit Value
    /// <para>
    /// The amount of credit available to the student who successfully meets the objectives of the course or learning opportunity based on the units defined by Credit Unit Type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19058">Credit Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Credit Value")]
    public Decimal? CreditValue { get => creditValue; set => SetProperty(ref creditValue, value, false); }

    /// <summary>
    /// Instructional Minutes
    /// <para>
    /// The total number of instruction minutes in a given session, as determined by time in class, time on task (e.g., engaged in a class), or as estimated by a qualified course designer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19490">Instructional Minutes</a>
    /// </para>
    /// </summary>
    [DisplayName("Instructional Minutes")]
    public Int32? InstructionalMinutes { get => instructionalMinutes; set => SetProperty(ref instructionalMinutes, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Course Applicable Education Level
    /// <para>
    /// The education level, grade level or primary instructional level at which a course is intended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20267">Course Applicable Education Level</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Applicable Education Level")]
    public Guid? RefCourseApplicableEducationLevelId { get; set; }

    /// <summary>
    /// Course Credit Units
    /// <para>
    /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Credit Units")]
    public Guid? RefCourseCreditUnitId { get; set; }

    /// <summary>
    /// Course Level Characteristic
    /// <para>
    /// An indication of the general nature and difficulty of instruction provided throughout a course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19061">Course Level Characteristic</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Level Characteristic")]
    public Guid? RefCourseLevelCharacteristicsId { get; set; }

    /// <summary>
    /// Instruction Language
    /// <para>
    /// The language of instruction, other than English, used in the program or course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19438">Instruction Language</a>
    /// </para>
    /// </summary>
    [DisplayName("Instruction Language")]
    public Guid? RefInstructionLanguageId { get; set; }

    /// <summary>
    /// Course Repeatability Maximum Number
    /// <para>
    /// The maximum number of times the course may be taken or completed for credit.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20648">Course Repeatability Maximum Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Repeatability Maximum Number")]
    public Int32? RepeatabilityMaximumNumber { get => repeatabilityMaximumNumber; set => SetProperty(ref repeatabilityMaximumNumber, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScedsequenceOfCourse { get => scedsequenceOfCourse; set => SetProperty(ref scedsequenceOfCourse, value, true); }

    /// <summary>
    /// Course Subject Abbreviation
    /// <para>
    /// The alphabetic abbreviation of the academic department or discipline offering the course. It is one part of the total course identifier number. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19066">Course Subject Abbreviation</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Subject Abbreviation")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SubjectAbbreviation { get => subjectAbbreviation; set => SetProperty(ref subjectAbbreviation, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICourse model)
    {
        IsBusy = true;
        Id = model.Id;
        CertificationDescription = model.CertificationDescription; // Course Certification Description
        CreditValue = model.CreditValue; // Credit Value
        InstructionalMinutes = model.InstructionalMinutes; // Instructional Minutes
        OrganizationId = model.OrganizationId; // 
        RefCourseApplicableEducationLevelId = model.RefCourseApplicableEducationLevelId; // Course Applicable Education Level
        RefCourseCreditUnitId = model.RefCourseCreditUnitId; // Course Credit Units
        RefCourseLevelCharacteristicsId = model.RefCourseLevelCharacteristicsId; // Course Level Characteristic
        RefInstructionLanguageId = model.RefInstructionLanguageId; // Instruction Language
        RepeatabilityMaximumNumber = model.RepeatabilityMaximumNumber; // Course Repeatability Maximum Number
        ScedsequenceOfCourse = model.ScedsequenceOfCourse; // 
        SubjectAbbreviation = model.SubjectAbbreviation; // Course Subject Abbreviation
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
