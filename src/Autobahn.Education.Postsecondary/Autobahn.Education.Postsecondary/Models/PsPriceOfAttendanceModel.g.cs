//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsPriceOfAttendanceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsPriceOfAttendance file
/// </summary>
public partial class PsPriceOfAttendanceModel : AutobahnBaseModel, IPsPriceOfAttendance
{
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
    public Decimal? BoardCharges { get; set; }

    /// <summary>
    /// Books and Supplies Costs
    /// <para>
    /// The average cost for books and supplies for a typical student for an entire academic year (or program). Does not include unusual costs for special groups of students (e.g., engineering or art majors) unless they constitute the majority of students at an institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19730">Books and Supplies Costs</a>
    /// </para>
    /// </summary>
    public Decimal? BooksAndSuppliesCosts { get; set; }

    /// <summary>
    /// Comprehensive Fee
    /// <para>
    /// A single fixed amount of money charged by an institution that covers tuition, required fees, room, and board. For some institutions, this amount may also cover books and supplies.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19733">Comprehensive Fee</a>
    /// </para>
    /// </summary>
    public Decimal? ComprehensiveFee { get; set; }

    public System.String IpedscollectionYearDesignator { get; set; }

    /// <summary>
    /// Other Student Expenses
    /// <para>
    /// The amount of money (estimated by the financial aid office) needed by a person to cover expenses such as laundry, transportation, and entertainment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19731">Other Student Expenses</a>
    /// </para>
    /// </summary>
    public Decimal? OtherStudentExpenses { get; set; }

    /// <summary>
    /// Price of Attendance
    /// <para>
    /// The total amount institutions estimate that undergraduate-level full-time, first-time degree-seeking students will pay to attend before financial aid is considered. This price includes tuition and fees, books and supplies, room and board, and certain other designated expenses such as transportation. These estimates are the average amounts used by the financial aid office to determine a student's financial aid.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19732">Price of Attendance</a>
    /// </para>
    /// </summary>
    public Decimal? PriceOfAttendance { get; set; }

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
    public Decimal? RequiredStudentFees { get; set; }

    /// <summary>
    /// Room Charges
    /// <para>
    /// The charges for an academic year for rooming accommodations for a typical student sharing a room with one other student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19728">Room Charges</a>
    /// </para>
    /// </summary>
    public Decimal? RoomCharges { get; set; }

    /// <summary>
    /// Session Designator
    /// <para>
    /// The academic session for which the data are recorded and applicable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19252">Session Designator</a>
    /// </para>
    /// </summary>
    public System.String SessionDesignator { get; set; }

    /// <summary>
    /// Tuition - Published
    /// <para>
    /// The published tuition for first time, full-time undergraduate students (lower of in-district or in-state for public institutions).  Tuition may be charged per term, per course, per credit or per program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19723">Tuition - Published</a>
    /// </para>
    /// </summary>
    public Decimal? TuitionPublished { get; set; }

    #endregion
}
