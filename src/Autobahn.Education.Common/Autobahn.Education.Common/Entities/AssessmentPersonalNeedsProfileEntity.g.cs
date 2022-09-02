//***************************************************************************
//* DomainName: Common Models
//* FileName:   AssessmentPersonalNeedsProfileEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfile file
/// </summary>
[Table("AssessmentPersonalNeedsProfile", Schema = "Common")]
public partial class AssessmentPersonalNeedsProfileEntity : EntityBase, IAssessmentPersonalNeedsProfile
{
    #region "IAssessmentPersonalNeedsProfile Properties"
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
    /// Assessment Need Type
    /// <para>
    /// A type of need identified for a learner as part of an assessment need profile.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20101">Assessment Need Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("A type of need identified for a learner as part of an assessment need profile.")]
    public System.String AssessmentNeedType { get; set; }

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
    public Boolean? AssignedSupportFlag { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
