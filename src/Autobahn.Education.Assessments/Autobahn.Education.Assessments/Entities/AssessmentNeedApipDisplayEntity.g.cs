//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipDisplayEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedApipDisplay file
/// </summary>
[Table("AssessmentNeedApipDisplay", Schema = "Assessments")]
public partial class AssessmentNeedApipDisplayEntity : EntityBase, IAssessmentNeedApipDisplay
{
    #region "IAssessmentNeedApipDisplay Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentPersonalNeedsProfileDisplay")]
    public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Activate by Default
    /// <para>
    /// Determines if the alternative accessible content is rendered as the default content for the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20008">Assessment Personal Needs Profile Activate by Default</a>
    /// </para>
    /// </summary>
    [Comment("Determines if the alternative accessible content is rendered as the default content for the learner.")]
    public Boolean? EncouragementActivateByDefaultIndicator { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Assigned Support
    /// <para>
    /// Defines whether or not the individual needs the kind of support defined by the entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
    /// </para>
    /// </summary>
    [Comment("Defines whether or not the individual needs the kind of support defined by the entity.")]
    public Boolean? EncouragementAssignedSupportIndicator { get; set; }

    /// <summary>
    /// Assessment Need Sound File URL
    /// <para>
    /// The URI of the sound file that is to be played to the user as an expression of encouragement when Masking is specified as part of an Assessment Personal Needs Profile. It is left to the system to determine when to play this audio file.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20053">Assessment Need Sound File URL</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The URI of the sound file that is to be played to the user as an expression of encouragement when Masking is specified as part of an Assessment Personal Needs Profile. It is left to the system to determine when to play this audio file.")]
    public System.String EncouragementSoundFileUrl { get; set; }

    /// <summary>
    /// Assessment Need Text Messaging String
    /// <para>
    /// The text string that is to be displayed to the user as an expression of encouragement when Masking is specified as part of an Assessment Personal Needs Profile.  It is left to the system to determine when to display this string.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20052">Assessment Need Text Messaging String</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4000,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The text string that is to be displayed to the user as an expression of encouragement when Masking is specified as part of an Assessment Personal Needs Profile.  It is left to the system to determine when to display this string.")]
    public System.String EncouragementTextMessagingString { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Activate by Default
    /// <para>
    /// Determines if the alternative accessible content is rendered as the default content for the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20008">Assessment Personal Needs Profile Activate by Default</a>
    /// </para>
    /// </summary>
    [Comment("Determines if the alternative accessible content is rendered as the default content for the learner.")]
    public Boolean? MaskingActivateByDefaultIndicator { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Assigned Support
    /// <para>
    /// Defines whether or not the individual needs the kind of support defined by the entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
    /// </para>
    /// </summary>
    [Comment("Defines whether or not the individual needs the kind of support defined by the entity.")]
    public Boolean? MaskingAssignedSupportIndicator { get; set; }

    /// <summary>
    /// Assessment Need Masking Type
    /// <para>
    /// Specifies as part of an Assessment Personal Needs Profile the type of masks the user is able to create  to cover portions of the question until needed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20051">Assessment Need Masking Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentNeedMaskingType")]
    [Comment("Specifies as part of an Assessment Personal Needs Profile the type of masks the user is able to create  to cover portions of the question until needed.")]
    public Guid? RefAssessmentNeedMaskingTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentPersonalNeedsProfileDisplayEntity AssessmentPersonalNeedsProfileDisplayEntity { get; set; }

    /// <summary>
    /// Specifies as part of an Assessment Personal Needs Profile the type of masks the user is able to create  to cover portions of the question until needed.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20051">Assessment Need Masking Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentNeedMaskingTypeEntity RefAssessmentNeedMaskingTypeEntity { get; set; }

    #endregion
}
