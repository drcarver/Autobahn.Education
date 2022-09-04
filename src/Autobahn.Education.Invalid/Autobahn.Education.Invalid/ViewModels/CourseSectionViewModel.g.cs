//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   CourseSectionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSection file
/// </summary>
public partial class CourseSectionViewModel : ObservableValidator, ICourseSection
{
    #region "CourseSectionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CourseSectionViewModel Constructor
    /// </summary>
    public CourseSectionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCourseSectionViewModelConstruction();
    }

    /// <summary>
    /// CourseSectionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCourseSectionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CourseSection";

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

    // MaximumCapacity -- (backing property for Course Section Maximum Capacity)
    private Int32? maximumCapacity;

    // RelatedCompetencyDefinitions -- (backing property for Related Competency Definitions)
    private System.String relatedCompetencyDefinitions;

    // TimeRequiredForCompletion -- (backing property for Course Section Time Required for Completion)
    private Decimal? timeRequiredForCompletion;

    // VirtualIndicator -- (backing property for Virtual Indicator)
    private Boolean? virtualIndicator;

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

    #region "ICourseSection Properties"
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
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    public Guid CourseId { get; set; }

    /// <summary>
    /// Course Section Maximum Capacity
    /// <para>
    /// The maximum number of students the Course Section can maintain.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20636">Course Section Maximum Capacity</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Section Maximum Capacity")]
    public Int32? MaximumCapacity { get => maximumCapacity; set => SetProperty(ref maximumCapacity, value, false); }

    /// <summary>
    /// Course Begin Date
    /// <para>
    /// The year, month and day an instance of a course officially began.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19054">Course Begin Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Begin Date")]
    public Guid? OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

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
    /// Advanced Placement Course Code
    /// <para>
    /// Course areas for advanced placement or credit.  For a list of codes see http://apcentral.collegeboard.com/apc/public/courses/teachers_corner/index.html .
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20244">Advanced Placement Course Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Advanced Placement Course Code")]
    public Guid? RefAdvancedPlacementCourseCodeId { get; set; }

    /// <summary>
    /// Course Section Instructional Delivery Mode
    /// <para>
    /// The primary setting or medium of delivery for the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20168">Course Section Instructional Delivery Mode</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Section Instructional Delivery Mode")]
    public Guid? RefCourseSectionDeliveryModeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
    /// </summary>
    public Guid? RefCreditTypeEarnedId { get; set; }

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
    /// Course Section Single Sex Class Status
    /// <para>
    /// Section in a co-educational school where only male or only female students are permitted to take the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19258">Course Section Single Sex Class Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Section Single Sex Class Status")]
    public Guid? RefSingleSexClassStatusId { get; set; }

    /// <summary>
    /// Related Competency Definitions
    /// <para>
    /// An indication of the competency definition(s) addressed in the Course Section.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19231">Related Competency Definitions</a>
    /// </para>
    /// </summary>
    [DisplayName("Related Competency Definitions")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RelatedCompetencyDefinitions { get => relatedCompetencyDefinitions; set => SetProperty(ref relatedCompetencyDefinitions, value, true); }

    /// <summary>
    /// Course Section Time Required for Completion
    /// <para>
    /// The actual or estimated number of clock minutes required for course completion. This number is especially important for career and technical education course and may represent (in minutes) the clock hour requirement of the course, the number of minutes (or clock hours) of class time per week, times the number of equivalent weeks the class typically meets.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19101">Course Section Time Required for Completion</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Section Time Required for Completion")]
    public Decimal? TimeRequiredForCompletion { get => timeRequiredForCompletion; set => SetProperty(ref timeRequiredForCompletion, value, false); }

    /// <summary>
    /// Virtual Indicator
    /// <para>
    /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20167">Virtual Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Virtual Indicator")]
    public Boolean? VirtualIndicator { get => virtualIndicator; set => SetProperty(ref virtualIndicator, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICourseSection model)
    {
        IsBusy = true;
        Id = model.Id;
        AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit; // Available Carnegie Unit Credit
        CourseId = model.CourseId; // 
        MaximumCapacity = model.MaximumCapacity; // Course Section Maximum Capacity
        OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // Course Begin Date
        OrganizationId = model.OrganizationId; // 
        RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // Additional Credit Type
        RefAdvancedPlacementCourseCodeId = model.RefAdvancedPlacementCourseCodeId; // Advanced Placement Course Code
        RefCourseSectionDeliveryModeId = model.RefCourseSectionDeliveryModeId; // Course Section Instructional Delivery Mode
        RefCreditTypeEarnedId = model.RefCreditTypeEarnedId; // 
        RefInstructionLanguageId = model.RefInstructionLanguageId; // Instruction Language
        RefSingleSexClassStatusId = model.RefSingleSexClassStatusId; // Course Section Single Sex Class Status
        RelatedCompetencyDefinitions = model.RelatedCompetencyDefinitions; // Related Competency Definitions
        TimeRequiredForCompletion = model.TimeRequiredForCompletion; // Course Section Time Required for Completion
        VirtualIndicator = model.VirtualIndicator; // Virtual Indicator
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
