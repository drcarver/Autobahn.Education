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
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileContent"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentPersonalNeedsProfileContent")]
    public Guid AssessmentPersonalNeedsProfileContentId { get; set; }

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
    /// Reference to an optional instance of the <see cref="RefAssessmentNeedLanguageLearnerType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefAssessmentNeedLanguageLearnerType")]
    public Guid RefAssessmentNeedLanguageLearnerTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileContent"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentPersonalNeedsProfileContentEntity AssessmentPersonalNeedsProfileContentEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAssessmentNeedLanguageLearnerType"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentNeedLanguageLearnerTypeEntity RefAssessmentNeedLanguageLearnerTypeEntity { get; set; }

    #endregion
}
