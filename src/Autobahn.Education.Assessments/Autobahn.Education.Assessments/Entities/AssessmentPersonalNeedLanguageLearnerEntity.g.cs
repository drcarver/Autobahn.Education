//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedLanguageLearnerEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedLanguageLearner file
/// </summary>
[Table("AssessmentPersonalNeedLanguageLearner", Schema = "Assessments")]
public partial class AssessmentPersonalNeedLanguageLearnerEntity : EntityBase, IAssessmentPersonalNeedLanguageLearner
{
    #region "IAssessmentPersonalNeedLanguageLearner Properties"
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
    public Boolean? ActivateByDefault { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentNeedsProfileContent"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The AssessmentNeedsProfileContent property is obsolete and will be removed in a later version")]
    [ForeignKey("AssessmentNeedsProfileContent")]
    public Guid AssessmentNeedsProfileContentId { get; set; }

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
    public Boolean? AssignedSupport { get; set; }

    /// <summary>
    /// Assessment Need Language Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile a preference for the language of the user interface.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20025">Assessment Need Language Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefAssessmentNeedsProfileContentLanguageLearnerType property is obsolete and will be removed in a later version")]
    [ForeignKey("RefAssessmentNeedsProfileContentLanguageLearnerType")]
    [Comment("Defines as part of an Assessment Personal Needs Profile a preference for the language of the user interface.")]
    public Guid RefAssessmentNeedsProfileContentLanguageLearnerTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
