//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarSessionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendarSession file
/// </summary>
public partial class OrganizationCalendarSessionViewModel : ObservableValidator, IOrganizationCalendarSession
{
    #region "OrganizationCalendarSessionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationCalendarSessionViewModel Constructor
    /// </summary>
    public OrganizationCalendarSessionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationCalendarSessionViewModelConstruction();
    }

    /// <summary>
    /// OrganizationCalendarSessionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationCalendarSessionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationCalendarSession";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AttendanceTermIndicator -- (backing property for Session Attendance Term Indicator)
    private Boolean? attendanceTermIndicator;

    // BeginDate -- (backing property for Course Begin Date)
    private DateTime? beginDate;

    // DaysInSession -- (backing property for Days in Session)
    private Int32? daysInSession;

    // Designator -- (backing property for Session Designator)
    private System.String designator;

    // EndDate -- (backing property for Course End Date)
    private DateTime? endDate;

    // FirstInstructionDate -- (backing property for First Instruction Date)
    private DateTime? firstInstructionDate;

    // InstructionalMinutes -- (backing property for School Year Minutes)
    private Decimal? instructionalMinutes;

    // LastInstructionDate -- (backing property for Last Instruction Date)
    private DateTime? lastInstructionDate;

    // MarkingTermIndicator -- (backing property for Session Marking Term Indicator)
    private Boolean? markingTermIndicator;

    // MinutesPerDay -- (backing property for Minutes Per Day)
    private Int32? minutesPerDay;

    // SchedulingTermIndicator -- (backing property for Session Scheduling Term Indicator)
    private Boolean? schedulingTermIndicator;

    // SessionEndTime -- (backing property for Session End Time)
    private TimeSpan? sessionEndTime;

    // SessionStartTime -- (backing property for Session Start Time)
    private TimeSpan? sessionStartTime;

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

    #region "IOrganizationCalendarSession Properties"
    /// <summary>
    /// Session Attendance Term Indicator
    /// <para>
    /// Indicates that the session is an attendance term.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20240">Session Attendance Term Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Session Attendance Term Indicator")]
    public Boolean? AttendanceTermIndicator { get => attendanceTermIndicator; set => SetProperty(ref attendanceTermIndicator, value, false); }

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
    public DateTime? BeginDate { get => beginDate; set => SetProperty(ref beginDate, value, false); }

    /// <summary>
    /// Days in Session
    /// <para>
    /// The total number of days that the school was or is anticipated to be in session during the school year. Also included are days on which the education institution facility is closed and the student body as a whole is engaged in planned activities off-campus under the guidance and direction of staff members.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19487">Days in Session</a>
    /// </para>
    /// </summary>
    [DisplayName("Days in Session")]
    public Int32? DaysInSession { get => daysInSession; set => SetProperty(ref daysInSession, value, false); }

    /// <summary>
    /// Session Designator
    /// <para>
    /// The academic session for which the data are recorded and applicable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19252">Session Designator</a>
    /// </para>
    /// </summary>
    [DisplayName("Session Designator")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(7,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Designator { get => designator; set => SetProperty(ref designator, value, true); }

    /// <summary>
    /// Course End Date
    /// <para>
    /// The year, month and day an instance of a course ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19059">Course End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Course End Date")]
    public DateTime? EndDate { get => endDate; set => SetProperty(ref endDate, value, false); }

    /// <summary>
    /// First Instruction Date
    /// <para>
    /// The year, month and day of the first day of student instruction for the school year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19488">First Instruction Date</a>
    /// </para>
    /// </summary>
    [DisplayName("First Instruction Date")]
    public DateTime? FirstInstructionDate { get => firstInstructionDate; set => SetProperty(ref firstInstructionDate, value, false); }

    /// <summary>
    /// School Year Minutes
    /// <para>
    /// The number of minutes that all students were required to be at school and any additional learning time (e.g., before or after school, weekend school, summer school) for which all students had the opportunity to participate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19244">School Year Minutes</a>
    /// </para>
    /// </summary>
    [DisplayName("School Year Minutes")]
    public Decimal? InstructionalMinutes { get => instructionalMinutes; set => SetProperty(ref instructionalMinutes, value, false); }

    /// <summary>
    /// Last Instruction Date
    /// <para>
    /// The year, month and day of the last day of student instruction (including days or times that students are present for purposes of testing and/or evaluation, but not including whole or part-days whose sole purposes is for distribution of report cards).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19489">Last Instruction Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Last Instruction Date")]
    public DateTime? LastInstructionDate { get => lastInstructionDate; set => SetProperty(ref lastInstructionDate, value, false); }

    /// <summary>
    /// Session Marking Term Indicator
    /// <para>
    /// Indicates that the session is a marking term.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20238">Session Marking Term Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Session Marking Term Indicator")]
    public Boolean? MarkingTermIndicator { get => markingTermIndicator; set => SetProperty(ref markingTermIndicator, value, false); }

    /// <summary>
    /// Minutes Per Day
    /// <para>
    /// The number of minutes in the day in which the school is normally in session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19491">Minutes Per Day</a>
    /// </para>
    /// </summary>
    [DisplayName("Minutes Per Day")]
    public Int32? MinutesPerDay { get => minutesPerDay; set => SetProperty(ref minutesPerDay, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
    /// </summary>
    public Guid? OrganizationCalendarId { get; set; }

    /// <summary>
    /// Academic Term Designator
    /// <para>
    /// The academic term for which the data apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19703">Academic Term Designator</a>
    /// </para>
    /// </summary>
    [DisplayName("Academic Term Designator")]
    public Guid? RefAcademicTermDesignatorId { get; set; }

    /// <summary>
    /// Session Type
    /// <para>
    /// A prescribed span of time when an education institution is open, instruction is provided, and students are under the direction and guidance of teachers and/or education institution administration. A session may be interrupted by one or more vacations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19254">Session Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Session Type")]
    public Guid? RefSessionTypeId { get; set; }

    /// <summary>
    /// Session Scheduling Term Indicator
    /// <para>
    /// Indicates that the session is a scheduling term.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20239">Session Scheduling Term Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Session Scheduling Term Indicator")]
    public Boolean? SchedulingTermIndicator { get => schedulingTermIndicator; set => SetProperty(ref schedulingTermIndicator, value, false); }

    /// <summary>
    /// Session End Time
    /// <para>
    /// The hour, minute and second on which a session ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19988">Session End Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Session End Time")]
    public TimeSpan? SessionEndTime { get => sessionEndTime; set => SetProperty(ref sessionEndTime, value, false); }

    /// <summary>
    /// Session Start Time
    /// <para>
    /// The hour, minute and second on which a session begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19986">Session Start Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Session Start Time")]
    public TimeSpan? SessionStartTime { get => sessionStartTime; set => SetProperty(ref sessionStartTime, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationCalendarSession model)
    {
        IsBusy = true;
        Id = model.Id;
        AttendanceTermIndicator = model.AttendanceTermIndicator; // Session Attendance Term Indicator
        BeginDate = model.BeginDate; // Course Begin Date
        DaysInSession = model.DaysInSession; // Days in Session
        Designator = model.Designator; // Session Designator
        EndDate = model.EndDate; // Course End Date
        FirstInstructionDate = model.FirstInstructionDate; // First Instruction Date
        InstructionalMinutes = model.InstructionalMinutes; // School Year Minutes
        LastInstructionDate = model.LastInstructionDate; // Last Instruction Date
        MarkingTermIndicator = model.MarkingTermIndicator; // Session Marking Term Indicator
        MinutesPerDay = model.MinutesPerDay; // Minutes Per Day
        OrganizationCalendarId = model.OrganizationCalendarId; // 
        RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId; // Academic Term Designator
        RefSessionTypeId = model.RefSessionTypeId; // Session Type
        SchedulingTermIndicator = model.SchedulingTermIndicator; // Session Scheduling Term Indicator
        SessionEndTime = model.SessionEndTime; // Session End Time
        SessionStartTime = model.SessionStartTime; // Session Start Time
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
