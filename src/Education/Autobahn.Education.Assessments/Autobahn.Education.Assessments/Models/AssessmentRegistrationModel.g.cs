//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentRegistration file
/// </summary>
public partial class AssessmentRegistrationModel : AutobahnBaseModel, IAssessmentRegistration
{
    #region "IAssessmentRegistration Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    public Guid? AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    public Guid AssessmentFormId { get; set; }

    /// <summary>
    /// Assessment Registration Completion Status Date Time
    /// <para>
    /// The date and time the completion and scoring status was changed for an instance of a person taking an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20517">Assessment Registration Completion Status Date Time</a>
    /// </para>
    /// </summary>
    public DateTime? AssessmentRegistrationCompletionStatusDateTime { get; set; }

    /// <summary>
    /// Assessment Registration Assignor Identifier
    /// <para>
    /// The unique identifier of the person who assigned the assessment to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19889">Assessment Registration Assignor Identifier</a>
    /// </para>
    /// </summary>
    public Guid? AssignedByPersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    public Guid? CourseSectionId { get; set; }

    /// <summary>
    /// Assessment Registration Creation Date
    /// <para>
    /// Date/time assignment is made.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20019">Assessment Registration Creation Date</a>
    /// </para>
    /// </summary>
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Assessment Registration Days of Instruction
    /// <para>
    /// The number of days of instruction the student has taken prior to testing.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20017">Assessment Registration Days of Instruction</a>
    /// </para>
    /// </summary>
    public Int32? DaysOfInstructionPriorToAssessment { get; set; }

    public Boolean? LeafullAcademicYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILeaOrganization"/> model
    /// </summary>
    public Guid? LeaOrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Assessment Registration Participation Indicator
    /// <para>
    /// An indication of whether a student participated in an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19025">Assessment Registration Participation Indicator</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentParticipationIndicatorId { get; set; }

    /// <summary>
    /// Assessment Purpose
    /// <para>
    /// The reason for which an assessment is designed or delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19026">Assessment Purpose</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentPurposeId { get; set; }

    /// <summary>
    /// Assessment Registration Reason Not Completing
    /// <para>
    /// The primary reason a participant did not complete an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19531">Assessment Registration Reason Not Completing</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentReasonNotCompletingId { get; set; }

    /// <summary>
    /// Reason Not Tested
    /// <para>
    /// The primary reason a student is not tested.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19228">Reason Not Tested</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentReasonNotTestedId { get; set; }

    /// <summary>
    /// Assessment Registration Completion Status
    /// <para>
    /// The completion and scoring status for an instance of a person taking an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20516">Assessment Registration Completion Status</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentRegistrationCompletionStatusId { get; set; }

    /// <summary>
    /// Grade Level When Assessed
    /// <para>
    /// The grade or developmental level of a student when assessed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19126">Grade Level When Assessed</a>
    /// </para>
    /// </summary>
    public Guid? RefGradeLevelToBeAssessedId { get; set; }

    /// <summary>
    /// Grade Level When Assessed
    /// <para>
    /// The grade or developmental level of a student when assessed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19126">Grade Level When Assessed</a>
    /// </para>
    /// </summary>
    public Guid? RefGradeLevelWhenAssessedId { get; set; }

    /// <summary>
    /// Assessment Registration Retest Indicator
    /// <para>
    /// Indicates if this registration is for a retest (retake). Retest can occur if a student failed a prior attempt and is eligible to retake. Other retest scenarios also can occur.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20018">Assessment Registration Retest Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? RetestIndicator { get; set; }

    /// <summary>
    /// School Full Academic Year
    /// <para>
    /// An indication of whether a student was in membership in the school education unit for a full academic year, according to the state's definition of Full Academic Year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20744">School Full Academic Year</a>
    /// </para>
    /// </summary>
    public Boolean? SchoolFullAcademicYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ISchoolOrganization"/> model
    /// </summary>
    public Guid? SchoolOrganizationId { get; set; }

    /// <summary>
    /// Assessment Registration Score Publish Date
    /// <para>
    /// The date set by the testing program when the test scores are published.  For formative or classroom assessments, this will likely be the date when the scored the individual test.  For summative assessments, this date is likely set for a group of assessments when the processing system releases the scores.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20062">Assessment Registration Score Publish Date</a>
    /// </para>
    /// </summary>
    public DateTime? ScorePublishDate { get; set; }

    /// <summary>
    /// State Full Academic Year
    /// <para>
    /// An indication of whether a student was in membership in the state education unit for a full academic year, according to the state's definition of Full Academic Year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20742">State Full Academic Year</a>
    /// </para>
    /// </summary>
    public Boolean? StateFullAcademicYear { get; set; }

    /// <summary>
    /// Assessment Registration Test Attempt Identifier
    /// <para>
    /// A unique identifier for the test attempt assigned by the delivery system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20119">Assessment Registration Test Attempt Identifier</a>
    /// </para>
    /// </summary>
    public System.String TestAttemptIdentifier { get; set; }

    /// <summary>
    /// Assessment Registration Testing Indicator
    /// <para>
    /// Indicates rules about use of results based on Special Events before, during or after the test. The option set values are determined by the testing program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20061">Assessment Registration Testing Indicator</a>
    /// </para>
    /// </summary>
    public System.String TestingIndicator { get; set; }

    #endregion
}
