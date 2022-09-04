//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   StaffProfessionalDevelopmentActivityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffProfessionalDevelopmentActivity file
/// </summary>
public partial class StaffProfessionalDevelopmentActivityModel : AutobahnBaseModel, IStaffProfessionalDevelopmentActivity
{
    #region "IStaffProfessionalDevelopmentActivity Properties"
    /// <summary>
    /// Staff Professional Development Activity Completion Date
    /// <para>
    /// The year, month and day on which an individual completed a course, an education program or a staff development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20068">Staff Professional Development Activity Completion Date</a>
    /// </para>
    /// </summary>
    public DateTime? ActivityCompletionDate { get; set; }

    /// <summary>
    /// Professional Development Activity Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to the Professional Development Activity as assigned by the organization offering the training.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19808">Professional Development Activity Identifier</a>
    /// </para>
    /// </summary>
    public System.String ActivityIdentifier { get; set; }

    /// <summary>
    /// Staff Professional Development Activity Start Date
    /// <para>
    /// The year, month and day on which an individual begins a course, an education program or a staff development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20067">Staff Professional Development Activity Start Date</a>
    /// </para>
    /// </summary>
    public DateTime? ActivityStartDate { get; set; }

    /// <summary>
    /// Professional Development Activity Title
    /// <para>
    /// The title of an activity designed for the purpose of developing someone professionally.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19809">Professional Development Activity Title</a>
    /// </para>
    /// </summary>
    public System.String ActivityTitle { get; set; }

    /// <summary>
    /// Number of Credits Earned
    /// <para>
    /// The number of credits an individual earns by the successful completion of a course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19200">Number of Credits Earned</a>
    /// </para>
    /// </summary>
    public Decimal? NumberOfCreditsEarned { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentRequirementId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentSession"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentSessionId { get; set; }

    /// <summary>
    /// Course Credit Units
    /// <para>
    /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
    /// </para>
    /// </summary>
    public Guid? RefCourseCreditUnitId { get; set; }

    /// <summary>
    /// Professional Development Financial Support Type
    /// <para>
    /// The type of financial assistance received in support of non-credit professional development activities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19811">Professional Development Financial Support Type</a>
    /// </para>
    /// </summary>
    public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

    /// <summary>
    /// Professional Development Scholarship Status
    /// <para>
    /// An indication of whether a scholarship was received for the person to participate in the professional development.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19810">Professional Development Scholarship Status</a>
    /// </para>
    /// </summary>
    public Boolean? ScholarshipStatus { get; set; }

    #endregion
}
