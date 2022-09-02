//***************************************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IRoleAttendance file
/// </summary>
public partial class RoleAttendanceViewModel : ObservableValidator, IRoleAttendance
{
    #region "RoleAttendanceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// RoleAttendanceViewModel Constructor
    /// </summary>
    public RoleAttendanceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnRoleAttendanceViewModelConstruction();
    }

    /// <summary>
    /// RoleAttendanceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnRoleAttendanceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from RoleAttendance";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AttendanceRate -- (backing property for Student Attendance Rate)
    private Decimal? attendanceRate;

    // NumberOfDaysAbsent -- (backing property for Number of Days Absent)
    private Decimal? numberOfDaysAbsent;

    // NumberOfDaysInAttendance -- (backing property for Number of Days in Attendance)
    private Decimal? numberOfDaysInAttendance;

    // NumberOfDaysTardy -- (backing property for Number of Days Tardy)
    private Decimal? numberOfDaysTardy;

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

    #region "IRoleAttendance Properties"
    /// <summary>
    /// Student Attendance Rate
    /// <para>
    /// The number of school days during the regular school year (plus summer, if applicable, if part of implementing the restart, transformation, or turnaround model) the student attended school divided by the maximum number of days the student could have attended school during the regular school year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19271">Student Attendance Rate</a>
    /// </para>
    /// </summary>
    [DisplayName("Student Attendance Rate")]
    public Decimal? AttendanceRate { get => attendanceRate; set => SetProperty(ref attendanceRate, value, false); }

    /// <summary>
    /// Number of Days Absent
    /// <para>
    /// The number of days a person is absent when school is in session during a given reporting period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19201">Number of Days Absent</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of Days Absent")]
    public Decimal? NumberOfDaysAbsent { get => numberOfDaysAbsent; set => SetProperty(ref numberOfDaysAbsent, value, false); }

    /// <summary>
    /// Number of Days in Attendance
    /// <para>
    /// The number of days a person is present when school is in session during a given reporting period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19202">Number of Days in Attendance</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of Days in Attendance")]
    public Decimal? NumberOfDaysInAttendance { get => numberOfDaysInAttendance; set => SetProperty(ref numberOfDaysInAttendance, value, false); }

    /// <summary>
    /// Number of Days Tardy
    /// <para>
    /// The number of days a person is tardy when school is in session during a given reporting period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20948">Number of Days Tardy</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of Days Tardy")]
    public Decimal? NumberOfDaysTardy { get => numberOfDaysTardy; set => SetProperty(ref numberOfDaysTardy, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IRoleAttendance model)
    {
        IsBusy = true;
        Id = model.Id;
        AttendanceRate = model.AttendanceRate; // Student Attendance Rate
        NumberOfDaysAbsent = model.NumberOfDaysAbsent; // Number of Days Absent
        NumberOfDaysInAttendance = model.NumberOfDaysInAttendance; // Number of Days in Attendance
        NumberOfDaysTardy = model.NumberOfDaysTardy; // Number of Days Tardy
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
