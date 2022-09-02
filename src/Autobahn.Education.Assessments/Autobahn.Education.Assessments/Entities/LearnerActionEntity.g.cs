//***************************************************************************
//* DomainName: Assessments
//* FileName:   LearnerActionEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearnerAction file
/// </summary>
[Table("LearnerAction", Schema = "Assessments")]
public partial class LearnerActionEntity : EntityBase, ILearnerAction
{
    #region "ILearnerAction Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> model
    /// </summary>
    [ForeignKey("AssessmentItemResponse")]
    public Guid? AssessmentItemResponseId { get; set; }

    /// <summary>
    /// Learner Action Actor Identifier
    /// <para>
    ///  A unique identifier for the person performing the learner action.  The identifier should be encrypted when integrating learning experience data across systems to secure the privacy of the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20533">Learner Action Actor Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment(" A unique identifier for the person performing the learner action.  The identifier should be encrypted when integrating learning experience data across systems to secure the privacy of the learner.")]
    public System.String LearnerActionActorIdentifier { get; set; }

    /// <summary>
    /// Learner Action Date Time
    /// <para>
    /// The date and time at which the action was taken.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19938">Learner Action Date Time</a>
    /// </para>
    /// </summary>
    [Comment("The date and time at which the action was taken.")]
    public DateTime? LearnerActionDateTime { get; set; }

    /// <summary>
    /// Learner Action Object Description
    /// <para>
    /// A description of the object upon which the person has performed the Learner Action.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20534">Learner Action Object Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A description of the object upon which the person has performed the Learner Action.")]
    public System.String LearnerActionObjectDescription { get; set; }

    /// <summary>
    /// Learner Action Object Identifier
    /// <para>
    /// A globally unique identifier for the object upon which the learning has performed the Learner Action which may be a URL with information about a learning resource or to launch the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20535">Learner Action Object Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A globally unique identifier for the object upon which the learning has performed the Learner Action which may be a URL with information about a learning resource or to launch the resource.")]
    public System.String LearnerActionObjectIdentifier { get; set; }

    /// <summary>
    /// Learner Action Object Type
    /// <para>
    /// The type of object upon which a person has performed the Learner Action.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20536">Learner Action Object Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The type of object upon which a person has performed the Learner Action.")]
    public System.String LearnerActionObjectType { get; set; }

    /// <summary>
    /// Learner Action Type
    /// <para>
    /// The type of action taken by the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19935">Learner Action Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearnerActionType")]
    [Comment("The type of action taken by the learner.")]
    public Guid? RefLearnerActionTypeId { get; set; }

    /// <summary>
    /// Learner Action Value
    /// <para>
    /// The value representing input by the learner using an online system, such as a value entered in response to an assessment question, or the URL of a learning resource link clicked.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19936">Learner Action Value</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The value representing input by the learner using an online system, such as a value entered in response to an assessment question, or the URL of a learning resource link clicked.")]
    public System.String Value { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentItemResponseEntity AssessmentItemResponseEntity { get; set; }

    /// <summary>
    /// The type of action taken by the learner.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19935">Learner Action Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefLearnerActionTypeEntity RefLearnerActionTypeEntity { get; set; }

    #endregion
}
