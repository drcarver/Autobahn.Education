//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   QuarterlyEmploymentRecordEntity.g.cs
//***************************************************************************

/// <summary>
/// The IQuarterlyEmploymentRecord file
/// </summary>
[Table("QuarterlyEmploymentRecord", Schema = "Invalid")]
public partial class QuarterlyEmploymentRecordEntity : EntityBase, IQuarterlyEmploymentRecord
{
    #region "IQuarterlyEmploymentRecord Properties"
    /// <summary>
    /// Quarterly Earnings
    /// <para>
    /// The quarterly amount paid to individuals found employed during the reference period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19991">Quarterly Earnings</a>
    /// </para>
    /// </summary>
    [Comment("The quarterly amount paid to individuals found employed during the reference period.")]
    public Decimal? Earnings { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EmploymentNaicscode { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Employed Prior to Enrollment
    /// <para>
    /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, before enrolling in secondary, postsecondary, or adult education or workforce programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20309">Employed Prior to Enrollment</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefEmployedPriorToEnrollment")]
    [Comment("An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, before enrolling in secondary, postsecondary, or adult education or workforce programs.")]
    public Guid? RefEmployedPriorToEnrollmentId { get; set; }

    /// <summary>
    /// Employment Location
    /// <para>
    /// The state or other location in which an individual is found employed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19992">Employment Location</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefEmploymentLocation")]
    [Comment("The state or other location in which an individual is found employed.")]
    public Guid? RefEmploymentLocationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEradministrativeDataSource"/> model
    /// </summary>
    [ForeignKey("RefEradministrativeDataSource")]
    public Guid? RefEradministrativeDataSourceId { get; set; }

    /// <summary>
    /// Employment Record Reference Period End Date
    /// <para>
    /// The year, month, and day of the last day of the employment record reference period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19995">Employment Record Reference Period End Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month, and day of the last day of the employment record reference period.")]
    public DateTime? ReferencePeriodEndDate { get; set; }

    /// <summary>
    /// Employment Record Reference Period Start Date
    /// <para>
    /// The year, month, and day of the first day of the employment record reference period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19994">Employment Record Reference Period Start Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month, and day of the first day of the employment record reference period.")]
    public DateTime? ReferencePeriodStartDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEradministrativeDataSource"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefEradministrativeDataSourceEntity? RefEradministrativeDataSourceEntity { get; set; }

    /// <summary>
    /// The state or other location in which an individual is found employed.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19992">Employment Location</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefEmploymentLocationEntity? RefEmploymentLocationEntity { get; set; }

    /// <summary>
    /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, before enrolling in secondary, postsecondary, or adult education or workforce programs.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20309">Employed Prior to Enrollment</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefEmployedPriorToEnrollmentEntity? RefEmployedPriorToEnrollmentEntity { get; set; }

    #endregion
}
