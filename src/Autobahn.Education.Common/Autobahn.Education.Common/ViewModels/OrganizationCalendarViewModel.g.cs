//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendar file
/// </summary>
public partial class OrganizationCalendarViewModel : ObservableValidator, IOrganizationCalendar
{
    #region "OrganizationCalendarViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationCalendarViewModel Constructor
    /// </summary>
    public OrganizationCalendarViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationCalendarViewModelConstruction();
    }

    /// <summary>
    /// OrganizationCalendarViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationCalendarViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationCalendar";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CalendarCode -- (backing property for Calendar Code)
    private System.String calendarCode;

    // CalendarDescription -- (backing property for Calendar Description)
    private System.String calendarDescription;

    // CalendarYear -- (backing property for School Year)
    private System.String calendarYear;

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

    #region "IOrganizationCalendar Properties"
    /// <summary>
    /// Calendar Code
    /// <para>
    /// A unique number assigned by a school district to a school calendar.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19485">Calendar Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Calendar Code")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CalendarCode { get => calendarCode; set => SetProperty(ref calendarCode, value, true); }

    /// <summary>
    /// Calendar Description
    /// <para>
    /// A description or identification of the calendar.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19486">Calendar Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Calendar Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CalendarDescription { get => calendarDescription; set => SetProperty(ref calendarDescription, value, true); }

    /// <summary>
    /// School Year
    /// <para>
    /// The year for a reported school session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19243">School Year</a>
    /// </para>
    /// </summary>
    [DisplayName("School Year")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CalendarYear { get => calendarYear; set => SetProperty(ref calendarYear, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationCalendar model)
    {
        IsBusy = true;
        Id = model.Id;
        CalendarCode = model.CalendarCode; // Calendar Code
        CalendarDescription = model.CalendarDescription; // Calendar Description
        CalendarYear = model.CalendarYear; // School Year
        OrganizationId = model.OrganizationId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
