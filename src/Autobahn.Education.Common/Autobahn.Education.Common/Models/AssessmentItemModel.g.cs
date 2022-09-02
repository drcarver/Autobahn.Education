//***************************************************************************
//* DomainName: Common Models
//* FileName:   AssessmentItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItem file
/// </summary>
public partial class AssessmentItemModel : AutobahnBaseModel, IAssessmentItem
{
    #region "IAssessmentItem Properties"
    /// <summary>
    /// Assessment Item Adaptive Indicator
    /// <para>
    /// This indicator determines whether an assessment item is an adaptive item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20111">Assessment Item Adaptive Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? AdaptiveIndicator { get; set; }

    /// <summary>
    /// Assessment Item Allotted Time
    /// <para>
    /// The amount of time allotted for a specific item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19395">Assessment Item Allotted Time</a>
    /// </para>
    /// </summary>
    public TimeSpan? AllottedTime { get; set; }

    /// <summary>
    /// Assessment Form Section Item Field Test Indicator
    /// <para>
    /// Indicates that the assessment item is being field tested on this form of the test, and is not to be included for scoring.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20511">Assessment Form Section Item Field Test Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? AssessmentFormSectionItemFieldTestIndicator { get; set; }

    /// <summary>
    /// Assessment Item Bank Identifier
    /// <para>
    /// If the assessment is provided with an item bank, then this identifies the item bank: a unique code or number used by the item banking system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20132">Assessment Item Bank Identifier</a>
    /// </para>
    /// </summary>
    public System.String AssessmentItemBankIdentifier { get; set; }

    /// <summary>
    /// Assessment Item Bank Name
    /// <para>
    /// If the assessment is provided with an item bank, then this is the name of the item bank.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20133">Assessment Item Bank Name</a>
    /// </para>
    /// </summary>
    public System.String AssessmentItemBankName { get; set; }

    /// <summary>
    /// Assessment Item Body Text
    /// <para>
    /// The complete text of an assessment item including all applicable parts such as stimulus, stem, and possible response options presented.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20233">Assessment Item Body Text</a>
    /// </para>
    /// </summary>
    public System.String BodyText { get; set; }

    /// <summary>
    /// Assessment Item Difficulty
    /// <para>
    /// The percentage of students who answered the item correctly during trial testing of the item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19383">Assessment Item Difficulty</a>
    /// </para>
    /// </summary>
    public Decimal? Difficulty { get; set; }

    /// <summary>
    /// Assessment Item Distractor Analysis
    /// <para>
    /// The analysis of the distractors provided for a specific assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19390">Assessment Item Distractor Analysis</a>
    /// </para>
    /// </summary>
    public System.String DistractorAnalysis { get; set; }

    /// <summary>
    /// Assessment Item Identifier
    /// <para>
    /// The identifier that uniquely identifies an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19623">Assessment Item Identifier</a>
    /// </para>
    /// </summary>
    public System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid? LearningResourceId { get; set; }

    /// <summary>
    /// Assessment Item Linking Item Indicator
    /// <para>
    /// Indicates that the item is intended to be administered in two different grades for the goal of establishing cross grade comparison.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20227">Assessment Item Linking Item Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? LinkingItemIndicator { get; set; }

    /// <summary>
    /// Assessment Item Maximum Score
    /// <para>
    /// The maximum number of points possible for the assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19683">Assessment Item Maximum Score</a>
    /// </para>
    /// </summary>
    public System.String MaximumScore { get; set; }

    /// <summary>
    /// Assessment Item Minimum Score
    /// <para>
    /// The minimum number of points possible for the assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19684">Assessment Item Minimum Score</a>
    /// </para>
    /// </summary>
    public System.String MinimumScore { get; set; }

    /// <summary>
    /// Assessment Item Type
    /// <para>
    /// The specific type of assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19382">Assessment Item Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentItemTypeId { get; set; }

    /// <summary>
    /// NAEP Aspects of Reading
    /// <para>
    /// Aspects of reading defined by the National Assessment of Educational Progress (NAEP 2005b Framework).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20166">NAEP Aspects of Reading</a>
    /// </para>
    /// </summary>
    public Guid? RefNaepAspectsOfReadingId { get; set; }

    /// <summary>
    /// NAEP Mathematical Complexity Level
    /// <para>
    /// Complexity levels defined by the National Assessment of Educational Progress (NAEP 2005a Framework).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20072">NAEP Mathematical Complexity Level</a>
    /// </para>
    /// </summary>
    public Guid? RefNaepMathComplexityLevelId { get; set; }

    /// <summary>
    /// Assessment Item Text Complexity System
    /// <para>
    /// The scaling system used to specify the text complexity of an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19907">Assessment Item Text Complexity System</a>
    /// </para>
    /// </summary>
    public Guid? RefTextComplexitySystemId { get; set; }

    /// <summary>
    /// Assessment Item Release Status
    /// <para>
    /// Indicates that the assessment item has been released to the public.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20229">Assessment Item Release Status</a>
    /// </para>
    /// </summary>
    public Boolean? ReleaseStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubric"/> model
    /// </summary>
    public Guid? RubricId { get; set; }

    /// <summary>
    /// Assessment Item Stem
    /// <para>
    /// The statement of the question or prompt for an Assessment Item to which the student responds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19392">Assessment Item Stem</a>
    /// </para>
    /// </summary>
    public System.String Stem { get; set; }

    /// <summary>
    /// Assessment Item Stimulus
    /// <para>
    ///  The text, source (e.g., video clip), and/or graphic about which the assessment item is written. The stimulus provides the context of the item/task to which the student must respond.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20234">Assessment Item Stimulus</a>
    /// </para>
    /// </summary>
    public System.String Stimulus { get; set; }

    /// <summary>
    /// Assessment Item Text Complexity Value
    /// <para>
    /// The complexity of the text using the scaling system defined by Text Complexity System, e.g. LexileT for assessment items with a reading passage.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19906">Assessment Item Text Complexity Value</a>
    /// </para>
    /// </summary>
    public System.String TextComplexityValue { get; set; }

    #endregion
}
