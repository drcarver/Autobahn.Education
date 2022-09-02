//***************************************************************************
//* DomainName: Common Models
//* FileName:   AssessmentRegistrationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentRegistration file
/// </summary>
public partial class AssessmentRegistrationViewModel : ObservableValidator, IAssessmentRegistration
{
    #region "AssessmentRegistrationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentRegistrationViewModel Constructor
    /// </summary>
    public AssessmentRegistrationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentRegistrationViewModelConstruction();
    }

    /// <summary>
    /// AssessmentRegistrationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentRegistrationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentRegistration";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AssessmentRegistrationCompletionStatusDateTime -- (backing property for Assessment Registration Completion Status Date Time)
    private DateTime? assessmentRegistrationCompletionStatusDateTime;

    // CreationDate -- (backing property for Assessment Registration Creation Date)
    private DateTime? creationDate;

    // DaysOfInstructionPriorToAssessment -- (backing property for Assessment Registration Days of Instruction)
    private Int32? daysOfInstructionPriorToAssessment;

    // member variable for the LeafullAcademicYear property
    private Boolean? leafullAcademicYear;

    // RetestIndicator -- (backing property for Assessment Registration Retest Indicator)
    private Boolean? retestIndicator;

    // SchoolFullAcademicYear -- (backing property for School Full Academic Year)
    private Boolean? schoolFullAcademicYear;

    // ScorePublishDate -- (backing property for Assessment Registration Score Publish Date)
    private DateTime? scorePublishDate;

    // StateFullAcademicYear -- (backing property for State Full Academic Year)
    private Boolean? stateFullAcademicYear;

    // TestAttemptIdentifier -- (backing property for Assessment Registration Test Attempt Identifier)
    private System.String testAttemptIdentifier;

    // TestingIndicator -- (backing property for Assessment Registration Testing Indicator)
    private System.String testingIndicator;

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

    #region "IAssessmentRegistration Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    public Guid? AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    public Guid AssessmentFormId { get; set; }

    /// <summary>
    /// Assessment Registration Completion Status Date Time
    /// <para>
    /// The date and time the completion and scoring status was changed for an instance of a person taking an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20517">Assessment Registration Completion Status Date Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Completion Status Date Time")]
    public DateTime? AssessmentRegistrationCompletionStatusDateTime { get => assessmentRegistrationCompletionStatusDateTime; set => SetProperty(ref assessmentRegistrationCompletionStatusDateTime, value, false); }

    /// <summary>
    /// Assessment Registration Assignor Identifier
    /// <para>
    /// The unique identifier of the person who assigned the assessment to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19889">Assessment Registration Assignor Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Assignor Identifier")]
    public Guid? AssignedByPersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    public Guid? CourseSectionId { get; set; }

    /// <summary>
    /// Assessment Registration Creation Date
    /// <para>
    /// Date/time assignment is made.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20019">Assessment Registration Creation Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Creation Date")]
    public DateTime? CreationDate { get => creationDate; set => SetProperty(ref creationDate, value, false); }

    /// <summary>
    /// Assessment Registration Days of Instruction
    /// <para>
    /// The number of days of instruction the student has taken prior to testing.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20017">Assessment Registration Days of Instruction</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Days of Instruction")]
    public Int32? DaysOfInstructionPriorToAssessment { get => daysOfInstructionPriorToAssessment; set => SetProperty(ref daysOfInstructionPriorToAssessment, value, false); }

    public Boolean? LeafullAcademicYear { get => leafullAcademicYear; set => SetProperty(ref leafullAcademicYear, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILeaOrganization"/> model
    /// </summary>
    public Guid? LeaOrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Assessment Registration Participation Indicator
    /// <para>
    /// An indication of whether a student participated in an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19025">Assessment Registration Participation Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Participation Indicator")]
    public Guid? RefAssessmentParticipationIndicatorId { get; set; }

    /// <summary>
    /// Assessment Purpose
    /// <para>
    /// The reason for which an assessment is designed or delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19026">Assessment Purpose</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Purpose")]
    public Guid? RefAssessmentPurposeId { get; set; }

    /// <summary>
    /// Assessment Registration Reason Not Completing
    /// <para>
    /// The primary reason a participant did not complete an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19531">Assessment Registration Reason Not Completing</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Reason Not Completing")]
    public Guid? RefAssessmentReasonNotCompletingId { get; set; }

    /// <summary>
    /// Reason Not Tested
    /// <para>
    /// The primary reason a student is not tested.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19228">Reason Not Tested</a>
    /// </para>
    /// </summary>
    [DisplayName("Reason Not Tested")]
    public Guid? RefAssessmentReasonNotTestedId { get; set; }

    /// <summary>
    /// Assessment Registration Completion Status
    /// <para>
    /// The completion and scoring status for an instance of a person taking an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20516">Assessment Registration Completion Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Completion Status")]
    public Guid? RefAssessmentRegistrationCompletionStatusId { get; set; }

    /// <summary>
    /// Grade Level When Assessed
    /// <para>
    /// The grade or developmental level of a student when assessed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19126">Grade Level When Assessed</a>
    /// </para>
    /// </summary>
    [DisplayName("Grade Level When Assessed")]
    public Guid? RefGradeLevelToBeAssessedId { get; set; }

    /// <summary>
    /// Grade Level When Assessed
    /// <para>
    /// The grade or developmental level of a student when assessed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19126">Grade Level When Assessed</a>
    /// </para>
    /// </summary>
    [DisplayName("Grade Level When Assessed")]
    public Guid? RefGradeLevelWhenAssessedId { get; set; }

    /// <summary>
    /// Assessment Registration Retest Indicator
    /// <para>
    /// Indicates if this registration is for a retest (retake). Retest can occur if a student failed a prior attempt and is eligible to retake. Other retest scenarios also can occur.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20018">Assessment Registration Retest Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Retest Indicator")]
    public Boolean? RetestIndicator { get => retestIndicator; set => SetProperty(ref retestIndicator, value, false); }

    /// <summary>
    /// School Full Academic Year
    /// <para>
    /// An indication of whether a student was in membership in the school education unit for a full academic year, according to the state's definition of Full Academic Year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20744">School Full Academic Year</a>
    /// </para>
    /// </summary>
    [DisplayName("School Full Academic Year")]
    public Boolean? SchoolFullAcademicYear { get => schoolFullAcademicYear; set => SetProperty(ref schoolFullAcademicYear, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ISchoolOrganization"/> model
    /// </summary>
    public Guid? SchoolOrganizationId { get; set; }

    /// <summary>
    /// Assessment Registration Score Publish Date
    /// <para>
    /// The date set by the testing program when the test scores are published.  For formative or classroom assessments, this will likely be the date when the scored the individual test.  For summative assessments, this date is likely set for a group of assessments when the processing system releases the scores.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20062">Assessment Registration Score Publish Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Score Publish Date")]
    public DateTime? ScorePublishDate { get => scorePublishDate; set => SetProperty(ref scorePublishDate, value, false); }

    /// <summary>
    /// State Full Academic Year
    /// <para>
    /// An indication of whether a student was in membership in the state education unit for a full academic year, according to the state's definition of Full Academic Year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20742">State Full Academic Year</a>
    /// </para>
    /// </summary>
    [DisplayName("State Full Academic Year")]
    public Boolean? StateFullAcademicYear { get => stateFullAcademicYear; set => SetProperty(ref stateFullAcademicYear, value, false); }

    /// <summary>
    /// Assessment Registration Test Attempt Identifier
    /// <para>
    /// A unique identifier for the test attempt assigned by the delivery system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20119">Assessment Registration Test Attempt Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Test Attempt Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TestAttemptIdentifier { get => testAttemptIdentifier; set => SetProperty(ref testAttemptIdentifier, value, true); }

    /// <summary>
    /// Assessment Registration Testing Indicator
    /// <para>
    /// Indicates rules about use of results based on Special Events before, during or after the test. The option set values are determined by the testing program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20061">Assessment Registration Testing Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Registration Testing Indicator")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TestingIndicator { get => testingIndicator; set => SetProperty(ref testingIndicator, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentRegistration model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentAdministrationId = model.AssessmentAdministrationId; // 
        AssessmentFormId = model.AssessmentFormId; // 
        AssessmentRegistrationCompletionStatusDateTime = model.AssessmentRegistrationCompletionStatusDateTime; // Assessment Registration Completion Status Date Time
        AssignedByPersonId = model.AssignedByPersonId; // Assessment Registration Assignor Identifier
        CourseSectionId = model.CourseSectionId; // 
        CreationDate = model.CreationDate; // Assessment Registration Creation Date
        DaysOfInstructionPriorToAssessment = model.DaysOfInstructionPriorToAssessment; // Assessment Registration Days of Instruction
        LeafullAcademicYear = model.LeafullAcademicYear; // 
        LeaOrganizationId = model.LeaOrganizationId; // 
        OrganizationId = model.OrganizationId; // 
        PersonId = model.PersonId; // 
        RefAssessmentParticipationIndicatorId = model.RefAssessmentParticipationIndicatorId; // Assessment Registration Participation Indicator
        RefAssessmentPurposeId = model.RefAssessmentPurposeId; // Assessment Purpose
        RefAssessmentReasonNotCompletingId = model.RefAssessmentReasonNotCompletingId; // Assessment Registration Reason Not Completing
        RefAssessmentReasonNotTestedId = model.RefAssessmentReasonNotTestedId; // Reason Not Tested
        RefAssessmentRegistrationCompletionStatusId = model.RefAssessmentRegistrationCompletionStatusId; // Assessment Registration Completion Status
        RefGradeLevelToBeAssessedId = model.RefGradeLevelToBeAssessedId; // Grade Level When Assessed
        RefGradeLevelWhenAssessedId = model.RefGradeLevelWhenAssessedId; // Grade Level When Assessed
        RetestIndicator = model.RetestIndicator; // Assessment Registration Retest Indicator
        SchoolFullAcademicYear = model.SchoolFullAcademicYear; // School Full Academic Year
        SchoolOrganizationId = model.SchoolOrganizationId; // 
        ScorePublishDate = model.ScorePublishDate; // Assessment Registration Score Publish Date
        StateFullAcademicYear = model.StateFullAcademicYear; // State Full Academic Year
        TestAttemptIdentifier = model.TestAttemptIdentifier; // Assessment Registration Test Attempt Identifier
        TestingIndicator = model.TestingIndicator; // Assessment Registration Testing Indicator
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
