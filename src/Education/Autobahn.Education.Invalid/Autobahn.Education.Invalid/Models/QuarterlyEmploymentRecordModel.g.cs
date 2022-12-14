//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   QuarterlyEmploymentRecordEntity.g.cs
//***************************************************************************

/// <summary>
/// The IQuarterlyEmploymentRecord file
/// </summary>
public partial class QuarterlyEmploymentRecordModel : AutobahnBaseModel, IQuarterlyEmploymentRecord
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
    public Decimal? Earnings { get; set; }

    public System.String EmploymentNaicscode { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
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
    public Guid? RefEmploymentLocationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEradministrativeDataSource"/> model
    /// </summary>
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
    public DateTime? ReferencePeriodStartDate { get; set; }

    #endregion
}
