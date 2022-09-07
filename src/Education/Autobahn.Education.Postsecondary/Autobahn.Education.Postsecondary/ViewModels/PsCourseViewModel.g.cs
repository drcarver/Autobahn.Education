//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsCourseViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsCourse file
/// </summary>
public partial class PsCourseViewModel : ObservableValidator, IPsCourse
{
    #region "PsCourseViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsCourseViewModel Constructor
    /// </summary>
    public PsCourseViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsCourseViewModelConstruction();
    }

    /// <summary>
    /// PsCourseViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsCourseViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsCourse";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CourseNumber -- (backing property for Course Number)
    private System.String courseNumber;

    // member variable for the NcaaeligibilityInd property
    private Int32? ncaaeligibilityInd;

    // OriginalCourseIdentifier -- (backing property for Original Course Identifier)
    private System.String originalCourseIdentifier;

    // OverrideSchoolCourseNumber -- (backing property for Override School Course Number)
    private System.String overrideSchoolCourseNumber;

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

    #region "IPsCourse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    public Guid CourseId { get; set; }

    /// <summary>
    /// Course Number
    /// <para>
    /// The official reference number portion of a course identifier.  This number normally designates the level of the course as well as the level of the individual expected to enroll in the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20280">Course Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Number")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CourseNumber { get => courseNumber; set => SetProperty(ref courseNumber, value, true); }

    public Int32? NcaaeligibilityInd { get => ncaaeligibilityInd; set => SetProperty(ref ncaaeligibilityInd, value, false); }

    /// <summary>
    /// Original Course Identifier
    /// <para>
    /// The course identifier as it was listed when the credit was earned (e.g. before a system conversion) to show consistency between present transcripts and older ones.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20389">Original Course Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Original Course Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OriginalCourseIdentifier { get => originalCourseIdentifier; set => SetProperty(ref originalCourseIdentifier, value, true); }

    /// <summary>
    /// Override School Course Number
    /// <para>
    /// An indication of the way an academic course was identified at an educational institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20391">Override School Course Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Override School Course Number")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OverrideSchoolCourseNumber { get => overrideSchoolCourseNumber; set => SetProperty(ref overrideSchoolCourseNumber, value, true); }

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
    /// Course Credit Basis Type
    /// <para>
    /// The type of enrollment associated with the credit hours for the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20269">Course Credit Basis Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Credit Basis Type")]
    public Guid? RefCourseCreditBasisTypeId { get; set; }

    /// <summary>
    /// Course Credit Level Type
    /// <para>
    /// The level of credit associated with the credit hours earned for the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20270">Course Credit Level Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Credit Level Type")]
    public Guid? RefCourseCreditLevelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNcescollegeCourseMapCode"/> model
    /// </summary>
    public Guid? RefNcescollegeCourseMapCodeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsCourse model)
    {
        IsBusy = true;
        Id = model.Id;
        CourseId = model.CourseId; // 
        CourseNumber = model.CourseNumber; // Course Number
        NcaaeligibilityInd = model.NcaaeligibilityInd; // 
        OriginalCourseIdentifier = model.OriginalCourseIdentifier; // Original Course Identifier
        OverrideSchoolCourseNumber = model.OverrideSchoolCourseNumber; // Override School Course Number
        RefCipCodeId = model.RefCipCodeId; // Classification of Instructional Program Code
        RefCourseCreditBasisTypeId = model.RefCourseCreditBasisTypeId; // Course Credit Basis Type
        RefCourseCreditLevelTypeId = model.RefCourseCreditLevelTypeId; // Course Credit Level Type
        RefNcescollegeCourseMapCodeId = model.RefNcescollegeCourseMapCodeId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
