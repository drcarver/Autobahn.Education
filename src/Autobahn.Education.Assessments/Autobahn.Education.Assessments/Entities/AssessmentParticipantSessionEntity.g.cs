//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentParticipantSession file
/// </summary>
[Table("AssessmentParticipantSession", Schema = "Assessments")]
public partial class AssessmentParticipantSessionEntity : EntityBase, IAssessmentParticipantSession
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
    [Comment("Date and time the assessment actually ended.")]
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
    [Comment("Date and time the assessment actually began.")]
    public DateTime? ActualStartDateTime { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    [ForeignKey("AssessmentFormSection")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the database that was used to administer the test.")]
    public System.String AssessmentParticipantSessionDatabaseName { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentParticipantSessionGuid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
    /// </summary>
    [ForeignKey("AssessmentRegistration")]
    public Guid? AssessmentRegistrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSession"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentSession")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The details about the device or platform by with which the assessment was delivered to the learner.")]
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
    [ForeignKey("Location")]
    [Comment(" The description of the place where an assessment is administered.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment(" A list of product tokens (keywords) with optional comments that identifies the client hardware and software with which the assessment was delivered to the student during the assessment session.")]
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
    [ForeignKey("RefAssessmentPlatformType")]
    [Comment("The platform with which the assessment was delivered to the student during the assessment session.")]
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
    [ForeignKey("RefAssessmentSessionSpecialCircumstanceType")]
    [Comment("An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.")]
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
    [ForeignKey("RefLanguage")]
    [Comment("The language that the assessment is administered.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Describes an issue related to the security of a testing instrument identified during a specific instance of delivering an assessment to a specific person during a specific time period.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Describes special events that occur before during or after the assessment session that may impact use of results according to rules related to the Assessment Registration Testing Indicator.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The overall time a learner actually spent during the  assessment session.")]
    public System.String TimeAssessed { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The platform with which the assessment was delivered to the student during the assessment session.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19377">Assessment Participant Session Platform Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentPlatformTypeEntity RefAssessmentPlatformTypeEntity { get; set; }

    /// <summary>
    /// An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19380">Assessment Session Special Circumstance Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentSessionSpecialCircumstanceTypeEntity RefAssessmentSessionSpecialCircumstanceTypeEntity { get; set; }

    /// <summary>
    ///  The description of the place where an assessment is administered.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19590">Assessment Session Location</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual LocationEntity LocationEntity { get; set; }

    /// <summary>
    /// The language that the assessment is administered.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19370">Assessment Participant Session Language</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefLanguageEntity RefLanguageEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentFormSectionEntity AssessmentFormSectionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSession"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentSessionEntity AssessmentSessionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentRegistrationEntity AssessmentRegistrationEntity { get; set; }

    #endregion
}
