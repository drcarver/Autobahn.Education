//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsPriceOfAttendanceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsPriceOfAttendance file
/// </summary>
public partial class PsPriceOfAttendanceViewModel : ObservableValidator, IPsPriceOfAttendance
{
    #region "PsPriceOfAttendanceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsPriceOfAttendanceViewModel Constructor
    /// </summary>
    public PsPriceOfAttendanceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsPriceOfAttendanceViewModelConstruction();
    }

    /// <summary>
    /// PsPriceOfAttendanceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsPriceOfAttendanceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsPriceOfAttendance";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // BoardCharges -- (backing property for Board Charges)
    private Decimal? boardCharges;

    // BooksAndSuppliesCosts -- (backing property for Books and Supplies Costs)
    private Decimal? booksAndSuppliesCosts;

    // ComprehensiveFee -- (backing property for Comprehensive Fee)
    private Decimal? comprehensiveFee;

    // member variable for the IpedscollectionYearDesignator property
    private System.String ipedscollectionYearDesignator;

    // OtherStudentExpenses -- (backing property for Other Student Expenses)
    private Decimal? otherStudentExpenses;

    // PriceOfAttendance -- (backing property for Price of Attendance)
    private Decimal? priceOfAttendance;

    // RequiredStudentFees -- (backing property for Required Student Fees)
    private Decimal? requiredStudentFees;

    // RoomCharges -- (backing property for Room Charges)
    private Decimal? roomCharges;

    // SessionDesignator -- (backing property for Session Designator)
    private System.String sessionDesignator;

    // TuitionPublished -- (backing property for Tuition - Published)
    private Decimal? tuitionPublished;

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

    #region "IPsPriceOfAttendance Properties"
    /// <summary>
    /// Board Charges
    /// <para>
    /// The charges assessed students for an academic year for the maximum meal plan available.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19729">Board Charges</a>
    /// </para>
    /// </summary>
    [DisplayName("Board Charges")]
    public Decimal? BoardCharges { get => boardCharges; set => SetProperty(ref boardCharges, value, false); }

    /// <summary>
    /// Books and Supplies Costs
    /// <para>
    /// The average cost for books and supplies for a typical student for an entire academic year (or program). Does not include unusual costs for special groups of students (e.g., engineering or art majors) unless they constitute the majority of students at an institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19730">Books and Supplies Costs</a>
    /// </para>
    /// </summary>
    [DisplayName("Books and Supplies Costs")]
    public Decimal? BooksAndSuppliesCosts { get => booksAndSuppliesCosts; set => SetProperty(ref booksAndSuppliesCosts, value, false); }

    /// <summary>
    /// Comprehensive Fee
    /// <para>
    /// A single fixed amount of money charged by an institution that covers tuition, required fees, room, and board. For some institutions, this amount may also cover books and supplies.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19733">Comprehensive Fee</a>
    /// </para>
    /// </summary>
    [DisplayName("Comprehensive Fee")]
    public Decimal? ComprehensiveFee { get => comprehensiveFee; set => SetProperty(ref comprehensiveFee, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(9,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IpedscollectionYearDesignator { get => ipedscollectionYearDesignator; set => SetProperty(ref ipedscollectionYearDesignator, value, true); }

    /// <summary>
    /// Other Student Expenses
    /// <para>
    /// The amount of money (estimated by the financial aid office) needed by a person to cover expenses such as laundry, transportation, and entertainment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19731">Other Student Expenses</a>
    /// </para>
    /// </summary>
    [DisplayName("Other Student Expenses")]
    public Decimal? OtherStudentExpenses { get => otherStudentExpenses; set => SetProperty(ref otherStudentExpenses, value, false); }

    /// <summary>
    /// Price of Attendance
    /// <para>
    /// The total amount institutions estimate that undergraduate-level full-time, first-time degree-seeking students will pay to attend before financial aid is considered. This price includes tuition and fees, books and supplies, room and board, and certain other designated expenses such as transportation. These estimates are the average amounts used by the financial aid office to determine a student's financial aid.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19732">Price of Attendance</a>
    /// </para>
    /// </summary>
    [DisplayName("Price of Attendance")]
    public Decimal? PriceOfAttendance { get => priceOfAttendance; set => SetProperty(ref priceOfAttendance, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsInstitution"/> model
    /// </summary>
    public Guid PsInstitutionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPspriceOfAttendance"/> model
    /// </summary>
    public Guid PspriceOfAttendanceId { get; set; }

    /// <summary>
    /// Tuition Unit
    /// <para>
    /// The component for which tuition is being charged.  It might be a time period (term, quarter, year, etc.) or it might be an entity of education (course, credit hour, etc.).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19725">Tuition Unit</a>
    /// </para>
    /// </summary>
    [DisplayName("Tuition Unit")]
    public Guid? RefTuitionUnitId { get; set; }

    /// <summary>
    /// Required Student Fees
    /// <para>
    /// Fixed sum charged to persons for items not covered by tuition and required of such a large proportion of all students that the student who does not pay the charge is the exception.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19726">Required Student Fees</a>
    /// </para>
    /// </summary>
    [DisplayName("Required Student Fees")]
    public Decimal? RequiredStudentFees { get => requiredStudentFees; set => SetProperty(ref requiredStudentFees, value, false); }

    /// <summary>
    /// Room Charges
    /// <para>
    /// The charges for an academic year for rooming accommodations for a typical student sharing a room with one other student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19728">Room Charges</a>
    /// </para>
    /// </summary>
    [DisplayName("Room Charges")]
    public Decimal? RoomCharges { get => roomCharges; set => SetProperty(ref roomCharges, value, false); }

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
    public System.String SessionDesignator { get => sessionDesignator; set => SetProperty(ref sessionDesignator, value, true); }

    /// <summary>
    /// Tuition - Published
    /// <para>
    /// The published tuition for first time, full-time undergraduate students (lower of in-district or in-state for public institutions).  Tuition may be charged per term, per course, per credit or per program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19723">Tuition - Published</a>
    /// </para>
    /// </summary>
    [DisplayName("Tuition - Published")]
    public Decimal? TuitionPublished { get => tuitionPublished; set => SetProperty(ref tuitionPublished, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsPriceOfAttendance model)
    {
        IsBusy = true;
        Id = model.Id;
        BoardCharges = model.BoardCharges; // Board Charges
        BooksAndSuppliesCosts = model.BooksAndSuppliesCosts; // Books and Supplies Costs
        ComprehensiveFee = model.ComprehensiveFee; // Comprehensive Fee
        IpedscollectionYearDesignator = model.IpedscollectionYearDesignator; // 
        OtherStudentExpenses = model.OtherStudentExpenses; // Other Student Expenses
        PriceOfAttendance = model.PriceOfAttendance; // Price of Attendance
        PsInstitutionId = model.PsInstitutionId; // 
        PspriceOfAttendanceId = model.PspriceOfAttendanceId; // 
        RefTuitionUnitId = model.RefTuitionUnitId; // Tuition Unit
        RequiredStudentFees = model.RequiredStudentFees; // Required Student Fees
        RoomCharges = model.RoomCharges; // Room Charges
        SessionDesignator = model.SessionDesignator; // Session Designator
        TuitionPublished = model.TuitionPublished; // Tuition - Published
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
