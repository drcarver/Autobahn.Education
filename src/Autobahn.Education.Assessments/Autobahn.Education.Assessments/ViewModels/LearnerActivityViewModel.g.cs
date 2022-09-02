//***************************************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ILearnerActivity file
/// </summary>
public partial class LearnerActivityViewModel : ObservableValidator, ILearnerActivity
{
    #region "LearnerActivityViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// LearnerActivityViewModel Constructor
    /// </summary>
    public LearnerActivityViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnLearnerActivityViewModelConstruction();
    }

    /// <summary>
    /// LearnerActivityViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnLearnerActivityViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from LearnerActivity";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CreationDate -- (backing property for Learner Activity Creation Date)
    private DateTime? creationDate;

    // DueDate -- (backing property for Learner Activity Due Date)
    private DateTime? dueDate;

    // DueTime -- (backing property for Learner Activity Due Time)
    private TimeSpan? dueTime;

    // MaximumAttemptsAllowed -- (backing property for Learner Activity Maximum Attempts Allowed)
    private Decimal? maximumAttemptsAllowed;

    // MaximumTimeAllowed -- (backing property for Learner Activity Maximum Time Allowed)
    private Decimal? maximumTimeAllowed;

    // PossiblePoints -- (backing property for Learner Activity Possible Points)
    private Decimal? possiblePoints;

    // Prerequisite -- (backing property for Learner Activity Prerequisite)
    private System.String prerequisite;

    // ReleaseDate -- (backing property for Learner Activity Release Date)
    private DateTime? releaseDate;

    // RubricUrl -- (backing property for Learner Activity Rubric URL)
    private System.String rubricUrl;

    // Title -- (backing property for Learner Activity Title)
    private System.String title;

    // Weight -- (backing property for Learner Activity Weight)
    private Decimal? weight;

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

    #region "ILearnerActivity Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
    /// </summary>
    public Guid? AssessmentRegistrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssignedByPerson"/> model
    /// </summary>
    public Guid? AssignedByPersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    public Guid? CourseSectionId { get; set; }

    /// <summary>
    /// Learner Activity Creation Date
    /// <para>
    /// The creation date of the assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19944">Learner Activity Creation Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Creation Date")]
    public DateTime? CreationDate { get => creationDate; set => SetProperty(ref creationDate, value, false); }

    /// <summary>
    /// Learner Activity Due Date
    /// <para>
    /// The date assignment is due.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19947">Learner Activity Due Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Due Date")]
    public DateTime? DueDate { get => dueDate; set => SetProperty(ref dueDate, value, false); }

    /// <summary>
    /// Learner Activity Due Time
    /// <para>
    /// The time the assignment is due.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19948">Learner Activity Due Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Due Time")]
    public TimeSpan? DueTime { get => dueTime; set => SetProperty(ref dueTime, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILeaOrganization"/> model
    /// </summary>
    public Guid? LeaOrganizationId { get; set; }

    /// <summary>
    /// Learner Activity Maximum Attempts Allowed
    /// <para>
    /// The number attempts a student may make on this assignment. Assumed to be unlimited if zero or omitted.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19949">Learner Activity Maximum Attempts Allowed</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Maximum Attempts Allowed")]
    public Decimal? MaximumAttemptsAllowed { get => maximumAttemptsAllowed; set => SetProperty(ref maximumAttemptsAllowed, value, false); }

    /// <summary>
    /// Learner Activity Maximum Time Allowed
    /// <para>
    /// The time required to complete the assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19945">Learner Activity Maximum Time Allowed</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Maximum Time Allowed")]
    public Decimal? MaximumTimeAllowed { get => maximumTimeAllowed; set => SetProperty(ref maximumTimeAllowed, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    public Guid? OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Learner Activity Possible Points
    /// <para>
    /// The number of possible points for an assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19953">Learner Activity Possible Points</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Possible Points")]
    public Decimal? PossiblePoints { get => possiblePoints; set => SetProperty(ref possiblePoints, value, false); }

    /// <summary>
    /// Learner Activity Prerequisite
    /// <para>
    /// The description of the skills or competencies the student must have to engage in assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19942">Learner Activity Prerequisite</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Prerequisite")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Prerequisite { get => prerequisite; set => SetProperty(ref prerequisite, value, true); }

    /// <summary>
    /// Learner Activity Language
    /// <para>
    /// The default language used for the assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19939">Learner Activity Language</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Language")]
    public Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Learner Activity Add to Grade Book Flag
    /// <para>
    /// Identifies the assignment as one that is graded.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19950">Learner Activity Add to Grade Book Flag</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Add to Grade Book Flag")]
    public Guid? RefLearnerActivityAddToGradeBookFlagId { get; set; }

    /// <summary>
    /// Learner Activity Maximum Time Allowed Unit
    /// <para>
    /// The unit of time of the�Maximum Time Allowed�value.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19946">Learner Activity Maximum Time Allowed Unit</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Maximum Time Allowed Unit")]
    public Guid? RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

    /// <summary>
    /// Learner Activity Type
    /// <para>
    /// The type of work assigned to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19943">Learner Activity Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Type")]
    public Guid? RefLearnerActivityTypeId { get; set; }

    /// <summary>
    /// Learner Activity Release Date
    /// <para>
    /// The date the student was informed about an assignment or that an automated system displays the assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19951">Learner Activity Release Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Release Date")]
    public DateTime? ReleaseDate { get => releaseDate; set => SetProperty(ref releaseDate, value, false); }

    /// <summary>
    /// Learner Activity Rubric URL
    /// <para>
    /// The Uniform Resource Locator pointing to a rubric that may be used to evaluate learner performance on the assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19954">Learner Activity Rubric URL</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Rubric URL")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RubricUrl { get => rubricUrl; set => SetProperty(ref rubricUrl, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ISchoolOrganization"/> model
    /// </summary>
    public Guid? SchoolOrganizationId { get; set; }

    /// <summary>
    /// Learner Activity Title
    /// <para>
    /// The title�for work assigned to the learner, which can comprise of learning resources, activities, and assessments.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19940">Learner Activity Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get => title; set => SetProperty(ref title, value, true); }

    /// <summary>
    /// Learner Activity Weight
    /// <para>
    /// The percentage weight of the assignment during the particular course or term.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19952">Learner Activity Weight</a>
    /// </para>
    /// </summary>
    [DisplayName("Learner Activity Weight")]
    public Decimal? Weight { get => weight; set => SetProperty(ref weight, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ILearnerActivity model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentRegistrationId = model.AssessmentRegistrationId; // 
        AssignedByPersonId = model.AssignedByPersonId; // 
        CourseSectionId = model.CourseSectionId; // 
        CreationDate = model.CreationDate; // Learner Activity Creation Date
        DueDate = model.DueDate; // Learner Activity Due Date
        DueTime = model.DueTime; // Learner Activity Due Time
        LeaOrganizationId = model.LeaOrganizationId; // 
        MaximumAttemptsAllowed = model.MaximumAttemptsAllowed; // Learner Activity Maximum Attempts Allowed
        MaximumTimeAllowed = model.MaximumTimeAllowed; // Learner Activity Maximum Time Allowed
        OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // 
        PersonId = model.PersonId; // 
        PossiblePoints = model.PossiblePoints; // Learner Activity Possible Points
        Prerequisite = model.Prerequisite; // Learner Activity Prerequisite
        RefLanguageId = model.RefLanguageId; // Learner Activity Language
        RefLearnerActivityAddToGradeBookFlagId = model.RefLearnerActivityAddToGradeBookFlagId; // Learner Activity Add to Grade Book Flag
        RefLearnerActivityMaximumTimeAllowedUnitsId = model.RefLearnerActivityMaximumTimeAllowedUnitsId; // Learner Activity Maximum Time Allowed Unit
        RefLearnerActivityTypeId = model.RefLearnerActivityTypeId; // Learner Activity Type
        ReleaseDate = model.ReleaseDate; // Learner Activity Release Date
        RubricUrl = model.RubricUrl; // Learner Activity Rubric URL
        SchoolOrganizationId = model.SchoolOrganizationId; // 
        Title = model.Title; // Learner Activity Title
        Weight = model.Weight; // Learner Activity Weight
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
