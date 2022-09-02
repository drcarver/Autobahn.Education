//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSession file
/// </summary>
public partial class AssessmentSessionModel : AutobahnBaseModel, IAssessmentSession
{
    #region "IAssessmentSession Properties"
    /// <summary>
    /// Assessment Session Actual End Date Time
    /// <para>
    /// Date and time the assessment actually ended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20024">Assessment Session Actual End Date Time</a>
    /// </para>
    /// </summary>
    public DateTime? ActualEndDateTime { get; set; }

    /// <summary>
    /// Assessment Session Actual Start Date Time
    /// <para>
    /// Date and time the assessment actually began.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20023">Assessment Session Actual Start Date Time</a>
    /// </para>
    /// </summary>
    public DateTime? ActualStartDateTime { get; set; }

    /// <summary>
    /// Assessment Session Allotted Time
    /// <para>
    /// The duration of time allotted for the assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19399">Assessment Session Allotted Time</a>
    /// </para>
    /// </summary>
    public TimeSpan? AllottedTime { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    public Guid? AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILeaOrganization"/> model
    /// </summary>
    public Guid? LeaOrganizationId { get; set; }

    /// <summary>
    /// Assessment Session Location
    /// <para>
    ///  The description of the place where an assessment is administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19590">Assessment Session Location</a>
    /// </para>
    /// </summary>
    public System.String Location { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Assessment Session Special Circumstance Type
    /// <para>
    /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19380">Assessment Session Special Circumstance Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentSessionSpecialCircumstanceTypeId { get; set; }

    /// <summary>
    /// Assessment Session Type
    /// <para>
    /// The type of session that is scheduled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20020">Assessment Session Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentSessionTypeId { get; set; }

    /// <summary>
    /// Assessment Session Scheduled End Date Time
    /// <para>
    /// Date and time the assessment is scheduled to end.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20022">Assessment Session Scheduled End Date Time</a>
    /// </para>
    /// </summary>
    public DateTime? ScheduledEndDateTime { get; set; }

    /// <summary>
    /// Assessment Session Scheduled Start Date Time
    /// <para>
    /// Date and time the assessment is scheduled to begin.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20021">Assessment Session Scheduled Start Date Time</a>
    /// </para>
    /// </summary>
    public DateTime? ScheduledStartDateTime { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ISchoolOrganization"/> model
    /// </summary>
    public Guid? SchoolOrganizationId { get; set; }

    /// <summary>
    /// Assessment Session Security Issue
    /// <para>
    /// The description of a security issue, if any, discovered for an administration of an assessment, such as suspected cheating by a student or a teacher changing answers after a student takes the test.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19969">Assessment Session Security Issue</a>
    /// </para>
    /// </summary>
    public System.String SecurityIssue { get; set; }

    /// <summary>
    /// Assessment Session Special Event Description
    /// <para>
    /// Describes special events that occur before during or after the assessment session that may impact use of results according to rules related to the Assessment Registration Testing Indicator.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20077">Assessment Session Special Event Description</a>
    /// </para>
    /// </summary>
    public System.String SpecialEventDescription { get; set; }

    #endregion
}
