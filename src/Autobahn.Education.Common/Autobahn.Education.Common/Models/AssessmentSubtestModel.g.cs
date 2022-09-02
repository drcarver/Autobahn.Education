//***************************************************************************
//* DomainName: Common Models
//* FileName:   AssessmentSubtestEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtest file
/// </summary>
public partial class AssessmentSubtestModel : AutobahnBaseModel, IAssessmentSubtest
{
    #region "IAssessmentSubtest Properties"
    /// <summary>
    /// Assessment Subtest Abbreviation
    /// <para>
    /// The shortened name identifying the assessment for use in reference and/or reports.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19367">Assessment Subtest Abbreviation</a>
    /// </para>
    /// </summary>
    public System.String Abbreviation { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    public Guid? AssessmentFormId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IChildOfAssessmentSubtest"/> model
    /// </summary>
    public Guid? ChildOfAssessmentSubtestId { get; set; }

    /// <summary>
    /// Assessment Form Subtest Container Only
    /// <para>
    /// In a hierarchy of subtests, this indicates that this tier is only used as a level in the hierarchy and does not represent a scoring model.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20181">Assessment Form Subtest Container Only</a>
    /// </para>
    /// </summary>
    public System.String ContainerOnly { get; set; }

    /// <summary>
    /// Assessment Subtest Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to an assessment subtest.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19366">Assessment Subtest Identifier</a>
    /// </para>
    /// </summary>
    public System.String Identifier { get; set; }

    /// <summary>
    /// Assessment Subtest Minimum Value
    /// <para>
    /// The minimum value possible for the measurement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19387">Assessment Subtest Minimum Value</a>
    /// </para>
    /// </summary>
    public System.String MaximumValue { get; set; }

    /// <summary>
    /// Assessment Subtest Maximum Value
    /// <para>
    /// The maximum value for the measurement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19388">Assessment Subtest Maximum Value</a>
    /// </para>
    /// </summary>
    public System.String MinimumValue { get; set; }

    /// <summary>
    /// Assessment Subtest Optimal Value
    /// <para>
    /// The optimal value for this measurement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19389">Assessment Subtest Optimal Value</a>
    /// </para>
    /// </summary>
    public System.String OptimalValue { get; set; }

    /// <summary>
    /// Assessment Subtest Published Date
    /// <para>
    /// The date on which the Subtest was published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20075">Assessment Subtest Published Date</a>
    /// </para>
    /// </summary>
    public DateTime? PublishedDate { get; set; }

    /// <summary>
    /// Assessment Academic Subject
    /// <para>
    /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19021">Assessment Academic Subject</a>
    /// </para>
    /// </summary>
    public Guid? RefAcademicSubjectId { get; set; }

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
    /// Assessment Subtest Identifier Type
    /// <para>
    /// The type of identifier that is provided for a Subtest.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20016">Assessment Subtest Identifier Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentSubtestIdentifierTypeId { get; set; }

    /// <summary>
    /// Assessment Content Standard Type
    /// <para>
    /// An indication as to whether an assessment conforms to a standard.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19598">Assessment Content Standard Type</a>
    /// </para>
    /// </summary>
    public Guid? RefContentStandardTypeId { get; set; }

    /// <summary>
    /// Assessment Score Metric Type
    /// <para>
    /// The specific method used to report the performance and achievement of the assessment. This is the metric that is being used to derive the scores.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19368">Assessment Score Metric Type</a>
    /// </para>
    /// </summary>
    public Guid? RefScoreMetricTypeId { get; set; }

    /// <summary>
    /// Assessment Subtest Rules
    /// <para>
    /// A description of the rules to produce a student test/subtest score from for a grouping of student item scores.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19695">Assessment Subtest Rules</a>
    /// </para>
    /// </summary>
    public System.String Rules { get; set; }

    /// <summary>
    /// Assessment Form Subtest Tier
    /// <para>
    /// In a hierarchy of subtests, this element represents the level of the sub test in the hierarchy.  The top tier and default is zero.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20180">Assessment Form Subtest Tier</a>
    /// </para>
    /// </summary>
    public Int32? Tier { get; set; }

    /// <summary>
    /// Assessment Subtest Title
    /// <para>
    /// The name or title of the subtest.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19275">Assessment Subtest Title</a>
    /// </para>
    /// </summary>
    public System.String Title { get; set; }

    /// <summary>
    /// Assessment Subtest Version
    /// <para>
    /// The version of the subtest that is included for the assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19379">Assessment Subtest Version</a>
    /// </para>
    /// </summary>
    public System.String Version { get; set; }

    #endregion
}
