//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEventViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendarEvent file
/// </summary>
public partial class OrganizationCalendarEventViewModel : ObservableValidator, IOrganizationCalendarEvent
{
    #region "OrganizationCalendarEventViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationCalendarEventViewModel Constructor
    /// </summary>
    public OrganizationCalendarEventViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationCalendarEventViewModelConstruction();
    }

    /// <summary>
    /// OrganizationCalendarEventViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationCalendarEventViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationCalendarEvent";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // EndTime -- (backing property for End Time)
    private TimeSpan? endTime;

    // EventDate -- (backing property for Calendar Event Date)
    private System.DateTime eventDate;

    // Name -- (backing property for Calendar Event Day Name)
    private System.String name;

    // RefCalendarEventType -- (backing property for Calendar Event Type)
    private Int32? refCalendarEventType;

    // StartTime -- (backing property for Start Time)
    private TimeSpan? startTime;

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

    #region "IOrganizationCalendarEvent Properties"
    /// <summary>
    /// End Time
    /// <para>
    /// The ending hour, minute and second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20901">End Time</a>
    /// </para>
    /// </summary>
    [DisplayName("End Time")]
    public TimeSpan? EndTime { get => endTime; set => SetProperty(ref endTime, value, false); }

    /// <summary>
    /// Calendar Event Date
    /// <para>
    /// The date of the scheduled or unscheduled calendar event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20241">Calendar Event Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Calendar Event Date")]
    [Required(ErrorMessage="{0} is required.")]
    public System.DateTime EventDate { get => eventDate; set => SetProperty(ref eventDate, value, true); }

    /// <summary>
    /// Calendar Event Day Name
    /// <para>
    /// A name used for the day of the calendar event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20242">Calendar Event Day Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Calendar Event Day Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get => name; set => SetProperty(ref name, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
    /// </summary>
    public Guid OrganizationCalendarId { get; set; }

    /// <summary>
    /// Calendar Event Type
    /// <para>
    /// A type of scheduled or unscheduled calendar event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19596">Calendar Event Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Calendar Event Type")]
    public Int32? RefCalendarEventType { get => refCalendarEventType; set => SetProperty(ref refCalendarEventType, value, false); }

    /// <summary>
    /// Start Time
    /// <para>
    /// The starting hour, minute and second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Start Time")]
    public TimeSpan? StartTime { get => startTime; set => SetProperty(ref startTime, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationCalendarEvent model)
    {
        IsBusy = true;
        Id = model.Id;
        EndTime = model.EndTime; // End Time
        EventDate = model.EventDate; // Calendar Event Date
        Name = model.Name; // Calendar Event Day Name
        OrganizationCalendarId = model.OrganizationCalendarId; // 
        RefCalendarEventType = model.RefCalendarEventType; // Calendar Event Type
        StartTime = model.StartTime; // Start Time
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
