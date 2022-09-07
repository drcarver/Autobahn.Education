//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemPossibleResponseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemPossibleResponse file
/// </summary>
[Table("AssessmentItemPossibleResponse", Schema = "Assessments")]
public partial class AssessmentItemPossibleResponseEntity : EntityBase, IAssessmentItemPossibleResponse
{
    #region "IAssessmentItemPossibleResponse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentItem")]
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Assessment Item Possible Response Correct Indicator
    /// <para>
    /// Indicates that the possible response is the correct response.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20183">Assessment Item Possible Response Correct Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates that the possible response is the correct response.")]
    public Boolean? CorrectIndicator { get; set; }

    /// <summary>
    /// Assessment Item Possible Response Feedback Message
    /// <para>
    /// A message provided to the person being assessed after giving a response that matches the possible response.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19904">Assessment Item Possible Response Feedback Message</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A message provided to the person being assessed after giving a response that matches the possible response.")]
    public System.String FeedbackMessage { get; set; }

    /// <summary>
    /// Assessment Item Possible Response Option
    /// <para>
    /// The possible response presented to the participant within a selected-response/multiple-choice assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20235">Assessment Item Possible Response Option</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The possible response presented to the participant within a selected-response/multiple-choice assessment item.")]
    public System.String PossibleResponseOption { get; set; }

    /// <summary>
    /// Assessment Item Possible Response Sequence Number
    /// <para>
    /// The position of this response in the list of responses displayed, such as for a multiple choice item type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19905">Assessment Item Possible Response Sequence Number</a>
    /// </para>
    /// </summary>
    [Comment("The position of this response in the list of responses displayed, such as for a multiple choice item type.")]
    public Int32? SequenceNumber { get; set; }

    /// <summary>
    /// Assessment Item Possible Response Value
    /// <para>
    /// The description of each distracter on an assessment item, explaining why it is there, what misunderstandings it exposes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19908">Assessment Item Possible Response Value</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The description of each distracter on an assessment item, explaining why it is there, what misunderstandings it exposes.")]
    public System.String Value { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentItemEntity AssessmentItemEntity { get; set; }

    #endregion
}
