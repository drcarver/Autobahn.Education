//***************************************************************************
//* DomainName: Role Models
//* FileName:   RoleAttendanceEventViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IRoleAttendanceEvent file
/// </summary>
public partial class RoleAttendanceEventViewModel : ObservableValidator, IRoleAttendanceEvent
{
    #region "RoleAttendanceEventViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// RoleAttendanceEventViewModel Constructor
    /// </summary>
    public RoleAttendanceEventViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnRoleAttendanceEventViewModelConstruction();
    }

    /// <summary>
    /// RoleAttendanceEventViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnRoleAttendanceEventViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from RoleAttendanceEvent";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Date -- (backing property for Attendance Event Date)
    private System.DateTime date;

    // EndTime -- (backing property for End Time)
    private TimeSpan? endTime;

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

    #region "IRoleAttendanceEvent Properties"
    /// <summary>
    /// Attendance Event Date
    /// <para>
    /// The date on which an attendance event takes place.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20630">Attendance Event Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Attendance Event Date")]
    [Required(ErrorMessage="{0} is required.")]
    public System.DateTime Date { get => date; set => SetProperty(ref date, value, true); }

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
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Absent Attendance Category
    /// <para>
    ///  The category that describes how the student spends his or her time not physically present on school grounds and not participating in instruction or instruction-related activities at an approved off-grounds location.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19592">Absent Attendance Category</a>
    /// </para>
    /// </summary>
    [DisplayName("Absent Attendance Category")]
    public Guid? RefAbsentAttendanceCategoryId { get; set; }

    /// <summary>
    /// Attendance Event Type
    /// <para>
    /// The type of attendance event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19594">Attendance Event Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Attendance Event Type")]
    public Guid? RefAttendanceEventTypeId { get; set; }

    /// <summary>
    /// Attendance Status
    /// <para>
    /// The status of a person's attendance associated with an Attendance Event Type and Attendance Event Date in an organization-person-role context.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19076">Attendance Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Attendance Status")]
    public Guid? RefAttendanceStatusId { get; set; }

    /// <summary>
    /// Leave Event Type
    /// <para>
    /// The type of the leave event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19617">Leave Event Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Leave Event Type")]
    public Guid? RefLeaveEventTypeId { get; set; }

    /// <summary>
    /// Present Attendance Category
    /// <para>
    /// The category that describes how the student spends his or her time when attending an instructional program approved by the state and/or school.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19593">Present Attendance Category</a>
    /// </para>
    /// </summary>
    [DisplayName("Present Attendance Category")]
    public Guid? RefPresentAttendanceCategoryId { get; set; }

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
    public void Load(IRoleAttendanceEvent model)
    {
        IsBusy = true;
        Id = model.Id;
        Date = model.Date; // Attendance Event Date
        EndTime = model.EndTime; // End Time
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefAbsentAttendanceCategoryId = model.RefAbsentAttendanceCategoryId; // Absent Attendance Category
        RefAttendanceEventTypeId = model.RefAttendanceEventTypeId; // Attendance Event Type
        RefAttendanceStatusId = model.RefAttendanceStatusId; // Attendance Status
        RefLeaveEventTypeId = model.RefLeaveEventTypeId; // Leave Event Type
        RefPresentAttendanceCategoryId = model.RefPresentAttendanceCategoryId; // Present Attendance Category
        StartTime = model.StartTime; // Start Time
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
