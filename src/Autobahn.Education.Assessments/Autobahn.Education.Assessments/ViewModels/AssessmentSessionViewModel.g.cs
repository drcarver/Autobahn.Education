//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSession file
/// </summary>
public partial class AssessmentSessionViewModel : ObservableValidator, IAssessmentSession
{
    #region "AssessmentSessionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentSessionViewModel Constructor
    /// </summary>
    public AssessmentSessionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentSessionViewModelConstruction();
    }

    /// <summary>
    /// AssessmentSessionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentSessionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentSession";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ActualEndDateTime -- (backing property for Assessment Session Actual End Date Time)
    private DateTime? actualEndDateTime;

    // ActualStartDateTime -- (backing property for Assessment Session Actual Start Date Time)
    private DateTime? actualStartDateTime;

    // AllottedTime -- (backing property for Assessment Session Allotted Time)
    private TimeSpan? allottedTime;

    // Location -- (backing property for Assessment Session Location)
    private System.String location;

    // ScheduledEndDateTime -- (backing property for Assessment Session Scheduled End Date Time)
    private DateTime? scheduledEndDateTime;

    // ScheduledStartDateTime -- (backing property for Assessment Session Scheduled Start Date Time)
    private DateTime? scheduledStartDateTime;

    // SecurityIssue -- (backing property for Assessment Session Security Issue)
    private System.String securityIssue;

    // SpecialEventDescription -- (backing property for Assessment Session Special Event Description)
    private System.String specialEventDescription;

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

    #region "IAssessmentSession Properties"
    /// <summary>
    /// Assessment Session Actual End Date Time
    /// <para>
    /// Date and time the assessment actually ended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20024">Assessment Session Actual End Date Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Actual End Date Time")]
    public DateTime? ActualEndDateTime { get => actualEndDateTime; set => SetProperty(ref actualEndDateTime, value, false); }

    /// <summary>
    /// Assessment Session Actual Start Date Time
    /// <para>
    /// Date and time the assessment actually began.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20023">Assessment Session Actual Start Date Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Actual Start Date Time")]
    public DateTime? ActualStartDateTime { get => actualStartDateTime; set => SetProperty(ref actualStartDateTime, value, false); }

    /// <summary>
    /// Assessment Session Allotted Time
    /// <para>
    /// The duration of time allotted for the assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19399">Assessment Session Allotted Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Allotted Time")]
    public TimeSpan? AllottedTime { get => allottedTime; set => SetProperty(ref allottedTime, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    public Guid? AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILeaOrganization"/> model
    /// </summary>
    public Guid? LeaOrganizationId { get; set; }

    /// <summary>
    /// Assessment Session Location
    /// <para>
    ///  The description of the place where an assessment is administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19590">Assessment Session Location</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Location")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(45,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Location { get => location; set => SetProperty(ref location, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Assessment Session Special Circumstance Type
    /// <para>
    /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19380">Assessment Session Special Circumstance Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Special Circumstance Type")]
    public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

    /// <summary>
    /// Assessment Session Type
    /// <para>
    /// The type of session that is scheduled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20020">Assessment Session Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Type")]
    public Guid? RefAssessmentSessionTypeId { get; set; }

    /// <summary>
    /// Assessment Session Scheduled End Date Time
    /// <para>
    /// Date and time the assessment is scheduled to end.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20022">Assessment Session Scheduled End Date Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Scheduled End Date Time")]
    public DateTime? ScheduledEndDateTime { get => scheduledEndDateTime; set => SetProperty(ref scheduledEndDateTime, value, false); }

    /// <summary>
    /// Assessment Session Scheduled Start Date Time
    /// <para>
    /// Date and time the assessment is scheduled to begin.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20021">Assessment Session Scheduled Start Date Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Scheduled Start Date Time")]
    public DateTime? ScheduledStartDateTime { get => scheduledStartDateTime; set => SetProperty(ref scheduledStartDateTime, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ISchoolOrganization"/> model
    /// </summary>
    public Guid? SchoolOrganizationId { get; set; }

    /// <summary>
    /// Assessment Session Security Issue
    /// <para>
    /// The description of a security issue, if any, discovered for an administration of an assessment, such as suspected cheating by a student or a teacher changing answers after a student takes the test.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19969">Assessment Session Security Issue</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Security Issue")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SecurityIssue { get => securityIssue; set => SetProperty(ref securityIssue, value, true); }

    /// <summary>
    /// Assessment Session Special Event Description
    /// <para>
    /// Describes special events that occur before during or after the assessment session that may impact use of results according to rules related to the Assessment Registration Testing Indicator.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20077">Assessment Session Special Event Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Session Special Event Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SpecialEventDescription { get => specialEventDescription; set => SetProperty(ref specialEventDescription, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentSession model)
    {
        IsBusy = true;
        Id = model.Id;
        ActualEndDateTime = model.ActualEndDateTime; // Assessment Session Actual End Date Time
        ActualStartDateTime = model.ActualStartDateTime; // Assessment Session Actual Start Date Time
        AllottedTime = model.AllottedTime; // Assessment Session Allotted Time
        AssessmentAdministrationId = model.AssessmentAdministrationId; // 
        LeaOrganizationId = model.LeaOrganizationId; // 
        Location = model.Location; // Assessment Session Location
        OrganizationId = model.OrganizationId; // 
        RefAssessmentSessionSpecialCircumstanceTypeId = model.RefAssessmentSessionSpecialCircumstanceTypeId; // Assessment Session Special Circumstance Type
        RefAssessmentSessionTypeId = model.RefAssessmentSessionTypeId; // Assessment Session Type
        ScheduledEndDateTime = model.ScheduledEndDateTime; // Assessment Session Scheduled End Date Time
        ScheduledStartDateTime = model.ScheduledStartDateTime; // Assessment Session Scheduled Start Date Time
        SchoolOrganizationId = model.SchoolOrganizationId; // 
        SecurityIssue = model.SecurityIssue; // Assessment Session Security Issue
        SpecialEventDescription = model.SpecialEventDescription; // Assessment Session Special Event Description
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
