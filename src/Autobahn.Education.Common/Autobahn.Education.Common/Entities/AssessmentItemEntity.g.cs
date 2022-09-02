//***************************************************************************
//* DomainName: Common Models
//* FileName:   AssessmentItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItem file
/// </summary>
[Table("AssessmentItem", Schema = "Common")]
public partial class AssessmentItemEntity : EntityBase, IAssessmentItem
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
    [Comment("This indicator determines whether an assessment item is an adaptive item.")]
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
    [Comment("The amount of time allotted for a specific item.")]
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
    [Comment("Indicates that the assessment item is being field tested on this form of the test, and is not to be included for scoring.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("If the assessment is provided with an item bank, then this identifies the item bank: a unique code or number used by the item banking system.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("If the assessment is provided with an item bank, then this is the name of the item bank.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The complete text of an assessment item including all applicable parts such as stimulus, stem, and possible response options presented.")]
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
    [Comment("The percentage of students who answered the item correctly during trial testing of the item.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The analysis of the distractors provided for a specific assessment.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The identifier that uniquely identifies an assessment item.")]
    public System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [ForeignKey("LearningResource")]
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
    [Comment("Indicates that the item is intended to be administered in two different grades for the goal of establishing cross grade comparison.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The maximum number of points possible for the assessment item.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The minimum number of points possible for the assessment item.")]
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
    [ForeignKey("RefAssessmentItemType")]
    [Comment("The specific type of assessment item.")]
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
    [ForeignKey("RefNaepAspectsOfReading")]
    [Comment("Aspects of reading defined by the National Assessment of Educational Progress (NAEP 2005b Framework).")]
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
    [ForeignKey("RefNaepMathComplexityLevel")]
    [Comment("Complexity levels defined by the National Assessment of Educational Progress (NAEP 2005a Framework).")]
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
    [ForeignKey("RefTextComplexitySystem")]
    [Comment("The scaling system used to specify the text complexity of an assessment item.")]
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
    [Comment("Indicates that the assessment item has been released to the public.")]
    public Boolean? ReleaseStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubric"/> model
    /// </summary>
    [ForeignKey("Rubric")]
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
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The statement of the question or prompt for an Assessment Item to which the student responds.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [Comment(" The text, source (e.g., video clip), and/or graphic about which the assessment item is written. The stimulus provides the context of the item/task to which the student must respond.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The complexity of the text using the scaling system defined by Text Complexity System, e.g. LexileT for assessment items with a reading passage.")]
    public System.String TextComplexityValue { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The specific type of assessment item.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19382">Assessment Item Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentItemTypeEntity RefAssessmentItemTypeEntity { get; set; }

    /// <summary>
    /// Complexity levels defined by the National Assessment of Educational Progress (NAEP 2005a Framework).
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20072">NAEP Mathematical Complexity Level</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefNaepMathComplexityLevelEntity RefNaepMathComplexityLevelEntity { get; set; }

    /// <summary>
    /// Aspects of reading defined by the National Assessment of Educational Progress (NAEP 2005b Framework).
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20166">NAEP Aspects of Reading</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefNaepAspectsOfReadingEntity RefNaepAspectsOfReadingEntity { get; set; }

    /// <summary>
    /// The scaling system used to specify the text complexity of an assessment item.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19907">Assessment Item Text Complexity System</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTextComplexitySystemEntity RefTextComplexitySystemEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubric"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RubricEntity RubricEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual LearningResourceEntity LearningResourceEntity { get; set; }

    #endregion
}
