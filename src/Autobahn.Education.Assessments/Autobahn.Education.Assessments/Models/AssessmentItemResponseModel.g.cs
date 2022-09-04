//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemResponse file
/// </summary>
public partial class AssessmentItemResponseModel : AutobahnBaseModel, IAssessmentItemResponse
{
    #region "IAssessmentItemResponse Properties"
    /// <summary>
    /// Assessment Item Response Aid Set Used
    /// <para>
    /// A tool or aid set used while viewing the item. This can include things like a calculator, reference tools, etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19397">Assessment Item Response Aid Set Used</a>
    /// </para>
    /// </summary>
    public System.String AidSetUsed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Assessment Item Response Descriptive Feedback Date
    /// <para>
    /// The date and time the descriptive feedback was entered in response to the results from a scored/evaluated assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20512">Assessment Item Response Descriptive Feedback Date</a>
    /// </para>
    /// </summary>
    public DateTime? AssessmentItemResponseDescriptiveFeedbackDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
    /// </summary>
    public Guid AssessmentParticipantSessionId { get; set; }

    /// <summary>
    /// Assessment Item Response Descriptive Feedback
    /// <para>
    /// The formative descriptive feedback that was given to a learner in response to the results from a scored/evaluated assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19891">Assessment Item Response Descriptive Feedback</a>
    /// </para>
    /// </summary>
    public System.String DescriptiveFeedback { get; set; }

    /// <summary>
    /// Assessment Item Response Duration
    /// <para>
    /// The total amount of time in seconds or milliseconds  that a person spent responding to a given assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19394">Assessment Item Response Duration</a>
    /// </para>
    /// </summary>
    public TimeSpan? Duration { get; set; }

    /// <summary>
    /// Assessment Item Response First Attempt Duration
    /// <para>
    /// The amount of time in seconds or milliseconds that a person took to give an initial response, a first attempt to answer a formative assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19958">Assessment Item Response First Attempt Duration</a>
    /// </para>
    /// </summary>
    public TimeSpan? FirstAttemptDuration { get; set; }

    /// <summary>
    /// Assessment Item Response Hint Count
    /// <para>
    /// The total number of hints presented as the learner responded to a formative assessment item.  This may include hints requested by the learner or hints automatically presented such as in an online tutoring system. Presentation of a scaffolding item is a separate response record and not counted as a hint.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19956">Assessment Item Response Hint Count</a>
    /// </para>
    /// </summary>
    public Int32? HintCount { get; set; }

    /// <summary>
    /// Assessment Item Response Hint Included Answer
    /// <para>
    /// Indicates that one of the hints presented included the correct answer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19957">Assessment Item Response Hint Included Answer</a>
    /// </para>
    /// </summary>
    public Boolean? HintIncludedAnswer { get; set; }

    /// <summary>
    /// Assessment Item Response Score Status
    /// <para>
    /// The status of scoring a person's response to an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20513">Assessment Item Response Score Status</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentItemResponseScoreStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentItemResponseStatus"/> model
    /// </summary>
    public Guid? RefAssessmentItemResponseStatusId { get; set; }

    /// <summary>
    /// Proficiency Status
    /// <para>
    /// An indication of whether a student's scores were proficient.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19565">Proficiency Status</a>
    /// </para>
    /// </summary>
    public Guid? RefProficiencyStatusId { get; set; }

    public System.String ResultXml { get; set; }

    /// <summary>
    /// Assessment Item Response Scaffolding Item Flag
    /// <para>
    /// Indicates that the response is to a scaffolding problem rather than the main/assigned problem.  A scaffolding item is a follow-up formative assessment item used to assess prerequisite or component skills, presented immediately after a learner gives an incorrect answer on the previous item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19955">Assessment Item Response Scaffolding Item Flag</a>
    /// </para>
    /// </summary>
    public Boolean? ScaffoldingItemFlag { get; set; }

    /// <summary>
    /// Assessment Item Response Score Value
    /// <para>
    /// The score given to a person's response to an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19700">Assessment Item Response Score Value</a>
    /// </para>
    /// </summary>
    public System.String ScoreValue { get; set; }

    /// <summary>
    /// Assessment Item Response Security Issue
    /// <para>
    /// The description of security issue, if any, related to a learner's response to an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19970">Assessment Item Response Security Issue</a>
    /// </para>
    /// </summary>
    public System.String SecurityIssue { get; set; }

    /// <summary>
    /// Assessment Item Response Start Date
    /// <para>
    /// The date on which the assessment item was presented to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19960">Assessment Item Response Start Date</a>
    /// </para>
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Assessment Item Response Start Time
    /// <para>
    /// The time of day that the assessment item was presented to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19959">Assessment Item Response Start Time</a>
    /// </para>
    /// </summary>
    public TimeSpan? StartTime { get; set; }

    /// <summary>
    /// Assessment Item Response Value
    /// <para>
    /// �A specific response to an assessment item by the person being assessed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20069">Assessment Item Response Value</a>
    /// </para>
    /// </summary>
    public System.String Value { get; set; }

    #endregion
}
