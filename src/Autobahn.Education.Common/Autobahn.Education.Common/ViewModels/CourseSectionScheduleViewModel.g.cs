//***************************************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionScheduleViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSectionSchedule file
/// </summary>
public partial class CourseSectionScheduleViewModel : ObservableValidator, ICourseSectionSchedule
{
    #region "CourseSectionScheduleViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CourseSectionScheduleViewModel Constructor
    /// </summary>
    public CourseSectionScheduleViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCourseSectionScheduleViewModelConstruction();
    }

    /// <summary>
    /// CourseSectionScheduleViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCourseSectionScheduleViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CourseSectionSchedule";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ClassBeginningTime -- (backing property for Class Beginning Time)
    private TimeSpan? classBeginningTime;

    // ClassEndingTime -- (backing property for Class Ending Time)
    private TimeSpan? classEndingTime;

    // ClassMeetingDays -- (backing property for Class Meeting Days)
    private System.String classMeetingDays;

    // ClassPeriod -- (backing property for Class Period)
    private System.String classPeriod;

    // TimeDayIdentifier -- (backing property for Timetable Day Identifier)
    private System.String timeDayIdentifier;

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

    #region "ICourseSectionSchedule Properties"
    /// <summary>
    /// Class Beginning Time
    /// <para>
    /// An indication of the time of day the class begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19510">Class Beginning Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Class Beginning Time")]
    public TimeSpan? ClassBeginningTime { get => classBeginningTime; set => SetProperty(ref classBeginningTime, value, false); }

    /// <summary>
    /// Class Ending Time
    /// <para>
    /// An indication of the time of day the class ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19511">Class Ending Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Class Ending Time")]
    public TimeSpan? ClassEndingTime { get => classEndingTime; set => SetProperty(ref classEndingTime, value, false); }

    /// <summary>
    /// Class Meeting Days
    /// <para>
    /// The day(s) of the week (e.g., Monday, Wednesday) that the class meets or an indication that a class meets "out-of-school" or "self-paced".
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19512">Class Meeting Days</a>
    /// </para>
    /// </summary>
    [DisplayName("Class Meeting Days")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ClassMeetingDays { get => classMeetingDays; set => SetProperty(ref classMeetingDays, value, true); }

    /// <summary>
    /// Class Period
    /// <para>
    /// An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19513">Class Period</a>
    /// </para>
    /// </summary>
    [DisplayName("Class Period")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ClassPeriod { get => classPeriod; set => SetProperty(ref classPeriod, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    public Guid CourseSectionId { get; set; }

    /// <summary>
    /// Timetable Day Identifier
    /// <para>
    /// The unique identifier for the locally defined rotation cycle date code when the class meets (e.g., in a two day schedule, valid values could be "A" and "B", or "1" and "2").
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19514">Timetable Day Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Timetable Day Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TimeDayIdentifier { get => timeDayIdentifier; set => SetProperty(ref timeDayIdentifier, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICourseSectionSchedule model)
    {
        IsBusy = true;
        Id = model.Id;
        ClassBeginningTime = model.ClassBeginningTime; // Class Beginning Time
        ClassEndingTime = model.ClassEndingTime; // Class Ending Time
        ClassMeetingDays = model.ClassMeetingDays; // Class Meeting Days
        ClassPeriod = model.ClassPeriod; // Class Period
        CourseSectionId = model.CourseSectionId; // 
        TimeDayIdentifier = model.TimeDayIdentifier; // Timetable Day Identifier
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
