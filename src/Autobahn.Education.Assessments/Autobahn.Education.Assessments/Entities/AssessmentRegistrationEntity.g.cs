//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentRegistration file
/// </summary>
[Table("AssessmentRegistration", Schema = "Assessments")]
public partial class AssessmentRegistrationEntity : EntityBase, IAssessmentRegistration
{
    #region "IAssessmentRegistration Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    [ForeignKey("AssessmentAdministration")]
    public Guid? AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentForm")]
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
    [Comment("The date and time the completion and scoring status was changed for an instance of a person taking an assessment.")]
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
    [ForeignKey("AssignedByPerson")]
    [Comment("The unique identifier of the person who assigned the assessment to the learner.")]
    public Guid? AssignedByPersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    [ForeignKey("CourseSection")]
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
    [Comment("Date/time assignment is made.")]
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
    [Comment("The number of days of instruction the student has taken prior to testing.")]
    public Int32? DaysOfInstructionPriorToAssessment { get; set; }

    public Boolean? LeafullAcademicYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILeaOrganization"/> model
    /// </summary>
    [ForeignKey("LeaOrganization")]
    public Guid? LeaOrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [ForeignKey("Organization")]
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
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
    [ForeignKey("RefAssessmentParticipationIndicator")]
    [Comment("An indication of whether a student participated in an assessment.")]
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
    [ForeignKey("RefAssessmentPurpose")]
    [Comment("The reason for which an assessment is designed or delivered.")]
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
    [ForeignKey("RefAssessmentReasonNotCompleting")]
    [Comment("The primary reason a participant did not complete an assessment.")]
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
    [ForeignKey("RefAssessmentReasonNotTested")]
    [Comment("The primary reason a student is not tested.")]
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
    [ForeignKey("RefAssessmentRegistrationCompletionStatus")]
    [Comment("The completion and scoring status for an instance of a person taking an assessment.")]
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
    [ForeignKey("RefGradeLevelToBeAssessed")]
    [Comment("The grade or developmental level of a student when assessed.")]
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
    [ForeignKey("RefGradeLevelWhenAssessed")]
    [Comment("The grade or developmental level of a student when assessed.")]
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
    [Comment("Indicates if this registration is for a retest (retake). Retest can occur if a student failed a prior attempt and is eligible to retake. Other retest scenarios also can occur.")]
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
    [Comment("An indication of whether a student was in membership in the school education unit for a full academic year, according to the state's definition of Full Academic Year.")]
    public Boolean? SchoolFullAcademicYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ISchoolOrganization"/> model
    /// </summary>
    [ForeignKey("SchoolOrganization")]
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
    [Comment("The date set by the testing program when the test scores are published.  For formative or classroom assessments, this will likely be the date when the scored the individual test.  For summative assessments, this date is likely set for a group of assessments when the processing system releases the scores.")]
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
    [Comment("An indication of whether a student was in membership in the state education unit for a full academic year, according to the state's definition of Full Academic Year.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A unique identifier for the test attempt assigned by the delivery system.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Indicates rules about use of results based on Special Events before, during or after the test. The option set values are determined by the testing program.")]
    public System.String TestingIndicator { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentFormEntity AssessmentFormEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual CourseSectionEntity? CourseSectionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentAdministrationEntity? AssessmentAdministrationEntity { get; set; }

    /// <summary>
    /// An indication of whether a student participated in an assessment.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19025">Assessment Registration Participation Indicator</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentParticipationIndicatorEntity? RefAssessmentParticipationIndicatorEntity { get; set; }

    /// <summary>
    /// The reason for which an assessment is designed or delivered.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19026">Assessment Purpose</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentPurposeEntity? RefAssessmentPurposeEntity { get; set; }

    /// <summary>
    /// The primary reason a student is not tested.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19228">Reason Not Tested</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentReasonNotTestedEntity? RefAssessmentReasonNotTestedEntity { get; set; }

    /// <summary>
    /// The primary reason a participant did not complete an assessment.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19531">Assessment Registration Reason Not Completing</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentReasonNotCompletingEntity? RefAssessmentReasonNotCompletingEntity { get; set; }

    /// <summary>
    /// The completion and scoring status for an instance of a person taking an assessment.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20516">Assessment Registration Completion Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentRegistrationCompletionStatusEntity? RefAssessmentRegistrationCompletionStatusEntity { get; set; }

    #endregion
}
