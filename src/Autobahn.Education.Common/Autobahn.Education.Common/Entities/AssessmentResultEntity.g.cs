//***************************************************************************
//* DomainName: Common Models
//* FileName:   AssessmentResultEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentResult file
/// </summary>
[Table("AssessmentResult", Schema = "Common")]
public partial class AssessmentResultEntity : EntityBase, IAssessmentResult
{
    #region "IAssessmentResult Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentRegistration")]
    public Guid AssessmentRegistrationId { get; set; }

    /// <summary>
    /// Assessment Result Descriptive Feedback Date Time
    /// <para>
    /// The date and time the descriptive feedback was entered for a scored/evaluated portion of an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20520">Assessment Result Descriptive Feedback Date Time</a>
    /// </para>
    /// </summary>
    [Comment("The date and time the descriptive feedback was entered for a scored/evaluated portion of an assessment.")]
    public DateTime? AssessmentResultDescriptiveFeedbackDateTime { get; set; }

    /// <summary>
    /// Assessment Result Score Standard Error
    /// <para>
    /// The measure of sampling variability and measurement error for the score, the amount of error to be expected in the score.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20522">Assessment Result Score Standard Error</a>
    /// </para>
    /// </summary>
    [Comment("The measure of sampling variability and measurement error for the score, the amount of error to be expected in the score.")]
    public Decimal? AssessmentResultScoreStandardError { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentSubtest")]
    public Guid AssessmentSubtestId { get; set; }

    /// <summary>
    /// Assessment Result Date Created
    /// <para>
    /// The date on which the assessment result was generated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19972">Assessment Result Date Created</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the assessment result was generated.")]
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Assessment Result Date Updated
    /// <para>
    /// The most recent date that the result was calculated/updated.  The value should be the same as Assessment Result Date Created if the subtest has only been scored once, but may be different if the score was recalculated with a different result.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19971">Assessment Result Date Updated</a>
    /// </para>
    /// </summary>
    [Comment("The most recent date that the result was calculated/updated.  The value should be the same as Assessment Result Date Created if the subtest has only been scored once, but may be different if the score was recalculated with a different result.")]
    public DateTime? DateUpdated { get; set; }

    /// <summary>
    /// Assessment Result Descriptive Feedback
    /// <para>
    /// The formative descriptive feedback that was given to a learner based on a scored/evaluated portion of an assessment as recorded in the result entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19890">Assessment Result Descriptive Feedback</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The formative descriptive feedback that was given to a learner based on a scored/evaluated portion of an assessment as recorded in the result entity.")]
    public System.String DescriptiveFeedback { get; set; }

    /// <summary>
    /// Assessment Result Descriptive Feedback Source
    /// <para>
    /// Identifies the source of the descriptive feedback that was given to a learner based on a scored/evaluated portion of an assessment. May indicate if this is teacher, scorer, or system generated feedback. Values for this attribute would be determined by the assessment program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20076">Assessment Result Descriptive Feedback Source</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Identifies the source of the descriptive feedback that was given to a learner based on a scored/evaluated portion of an assessment. May indicate if this is teacher, scorer, or system generated feedback. Values for this attribute would be determined by the assessment program.")]
    public System.String DescriptiveFeedbackSource { get; set; }

    /// <summary>
    /// Assessment Result Diagnostic Statement
    /// <para>
    /// A statement intended for use by education professionals, using professional terminology, to interpret learner needs based on the scored/evaluated portion of an assessment.  This statement may inform Descriptive Feedback given to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20185">Assessment Result Diagnostic Statement</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("A statement intended for use by education professionals, using professional terminology, to interpret learner needs based on the scored/evaluated portion of an assessment.  This statement may inform Descriptive Feedback given to the learner.")]
    public System.String DiagnosticStatement { get; set; }

    /// <summary>
    /// Diagnostic Statement Source
    /// <para>
    /// Identifies the source of the Diagnostic Statement based on a scored/evaluated portion of an assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20011">Diagnostic Statement Source</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Identifies the source of the Diagnostic Statement based on a scored/evaluated portion of an assessment.")]
    public System.String DiagnosticStatementSource { get; set; }

    public Boolean? IncludedInAypCalculation { get; set; }

    /// <summary>
    /// Instructional Recommendation
    /// <para>
    /// This provides the next steps for instruction for the student based upon the assessment results and student characteristics.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19369">Instructional Recommendation</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("This provides the next steps for instruction for the student based upon the assessment results and student characteristics.")]
    public System.String InstructionalRecommendation { get; set; }

    /// <summary>
    /// Assessment Result Number of Responses
    /// <para>
    /// The number of responses that are included with the Student Score Set. Responses are those items that were attempted (partially or fully answered) by the student and not necessarily the number of items in the assessment (which can be determined from the assessment object).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20012">Assessment Result Number of Responses</a>
    /// </para>
    /// </summary>
    [Comment("The number of responses that are included with the Student Score Set. Responses are those items that were attempted (partially or fully answered) by the student and not necessarily the number of items in the assessment (which can be determined from the assessment object).")]
    public Int32? NumberOfResponses { get; set; }

    /// <summary>
    /// Assessment Result Preliminary Indicator
    /// <para>
    /// If this score is preliminary, then this attribute value should be set.  Preliminary scores may be provided for early use by the assessment program or user while final scoring is occurring.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20010">Assessment Result Preliminary Indicator</a>
    /// </para>
    /// </summary>
    [Comment("If this score is preliminary, then this attribute value should be set.  Preliminary scores may be provided for early use by the assessment program or user while final scoring is occurring.")]
    public Boolean? PreliminaryIndicator { get; set; }

    /// <summary>
    /// Assessment Result Pretest Outcome
    /// <para>
    /// The results of a pre-test in academic subjects.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19564">Assessment Result Pretest Outcome</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentPretestOutcome")]
    [Comment("The results of a pre-test in academic subjects.")]
    public Guid? RefAssessmentPretestOutcomeId { get; set; }

    /// <summary>
    /// Assessment Result Data Type
    /// <para>
    ///  The data type of the assessment result score value.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20518">Assessment Result Data Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentResultDataType")]
    [Comment(" The data type of the assessment result score value.")]
    public Guid? RefAssessmentResultDataTypeId { get; set; }

    /// <summary>
    /// Assessment Result Score Type
    /// <para>
    /// Indicates the purpose for which this assessment score instance was recorded.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20523">Assessment Result Score Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentResultScoreType")]
    [Comment("Indicates the purpose for which this assessment score instance was recorded.")]
    public Guid? RefAssessmentResultScoreTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEloutcomeMeasurementLevel"/> model
    /// </summary>
    [ForeignKey("RefEloutcomeMeasurementLevel")]
    public Guid? RefEloutcomeMeasurementLevelId { get; set; }

    /// <summary>
    /// Early Learning Outcome Time Point
    /// <para>
    /// The point in time for which the result is used for an outcome measure.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20475">Early Learning Outcome Time Point</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefOutcomeTimePoint")]
    [Comment("The point in time for which the result is used for an outcome measure.")]
    public Guid? RefOutcomeTimePointId { get; set; }

    /// <summary>
    /// Assessment Score Metric Type
    /// <para>
    /// The specific method used to report the performance and achievement of the assessment. This is the metric that is being used to derive the scores.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19368">Assessment Score Metric Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefScoreMetricType")]
    [Comment("The specific method used to report the performance and achievement of the assessment. This is the metric that is being used to derive the scores.")]
    public Guid? RefScoreMetricTypeId { get; set; }

    /// <summary>
    /// Assessment Result Score Value
    /// <para>
    /// A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19245">Assessment Result Score Value</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(35,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A meaningful raw score, derived score, or statistical expression of the performance of a person on an assessment. The type of result is indicated by the Assessment Score Metric Type element. The results can be expressed as a number, percentile, range, level, etc. The score relates to all scored items or a sub test scoring one aspect of performance on the test. This value may or may not correspond to one or more Performance Levels.")]
    public System.String ScoreValue { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The specific method used to report the performance and achievement of the assessment. This is the metric that is being used to derive the scores.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19368">Assessment Score Metric Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefScoreMetricTypeEntity RefScoreMetricTypeEntity { get; set; }

    /// <summary>
    /// The results of a pre-test in academic subjects.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19564">Assessment Result Pretest Outcome</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentPretestOutcomeEntity RefAssessmentPretestOutcomeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentSubtestEntity AssessmentSubtestEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentRegistrationEntity AssessmentRegistrationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEloutcomeMeasurementLevel"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefEloutcomeMeasurementLevelEntity RefEloutcomeMeasurementLevelEntity { get; set; }

    /// <summary>
    /// The point in time for which the result is used for an outcome measure.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20475">Early Learning Outcome Time Point</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefOutcomeTimePointEntity RefOutcomeTimePointEntity { get; set; }

    /// <summary>
    ///  The data type of the assessment result score value.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20518">Assessment Result Data Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentResultDataTypeEntity RefAssessmentResultDataTypeEntity { get; set; }

    /// <summary>
    /// Indicates the purpose for which this assessment score instance was recorded.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20523">Assessment Result Score Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentResultScoreTypeEntity RefAssessmentResultScoreTypeEntity { get; set; }

    #endregion
}
