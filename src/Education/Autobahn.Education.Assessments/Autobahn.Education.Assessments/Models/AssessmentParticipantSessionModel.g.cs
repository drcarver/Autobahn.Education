//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentParticipantSession file
/// </summary>
public partial class AssessmentParticipantSessionModel : AutobahnBaseModel, IAssessmentParticipantSession
{
    #region "IAssessmentParticipantSession Properties"
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
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    public Guid? AssessmentFormSectionId { get; set; }

    /// <summary>
    /// Assessment Participant Session Database Name
    /// <para>
    /// The name of the database that was used to administer the test.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20514">Assessment Participant Session Database Name</a>
    /// </para>
    /// </summary>
    public System.String AssessmentParticipantSessionDatabaseName { get; set; }

    public System.String AssessmentParticipantSessionGuid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
    /// </summary>
    public Guid? AssessmentRegistrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSession"/> model
    /// </summary>
    public Guid AssessmentSessionId { get; set; }

    /// <summary>
    /// Assessment Participant Session Delivery Device Details
    /// <para>
    /// The details about the device or platform by with which the assessment was delivered to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20006">Assessment Participant Session Delivery Device Details</a>
    /// </para>
    /// </summary>
    public System.String DeliveryDeviceDetails { get; set; }

    /// <summary>
    /// Assessment Session Location
    /// <para>
    ///  The description of the place where an assessment is administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19590">Assessment Session Location</a>
    /// </para>
    /// </summary>
    public Guid? LocationId { get; set; }

    /// <summary>
    /// Assessment Participant Session Platform User Agent
    /// <para>
    ///  A list of product tokens (keywords) with optional comments that identifies the client hardware and software with which the assessment was delivered to the student during the assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20112">Assessment Participant Session Platform User Agent</a>
    /// </para>
    /// </summary>
    public System.String PlatformUserAgent { get; set; }

    /// <summary>
    /// Assessment Participant Session Platform Type
    /// <para>
    /// The platform with which the assessment was delivered to the student during the assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19377">Assessment Participant Session Platform Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentPlatformTypeId { get; set; }

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
    /// Assessment Participant Session Language
    /// <para>
    /// The language that the assessment is administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19370">Assessment Participant Session Language</a>
    /// </para>
    /// </summary>
    public Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Assessment Participant Session Security Issue
    /// <para>
    /// Describes an issue related to the security of a testing instrument identified during a specific instance of delivering an assessment to a specific person during a specific time period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20102">Assessment Participant Session Security Issue</a>
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

    /// <summary>
    /// Assessment Participant Session Time Assessed
    /// <para>
    /// The overall time a learner actually spent during the  assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19398">Assessment Participant Session Time Assessed</a>
    /// </para>
    /// </summary>
    public System.String TimeAssessed { get; set; }

    #endregion
}
