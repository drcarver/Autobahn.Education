//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileContentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileContent file
/// </summary>
public partial class AssessmentPersonalNeedsProfileContentModel : AutobahnBaseModel, IAssessmentPersonalNeedsProfileContent
{
    #region "IAssessmentPersonalNeedsProfileContent Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileId { get; set; }

    public Boolean? ChunkingActivateByDefaultIndicator { get; set; }

    public Boolean? ChunkingAssignedSupportIndicator { get; set; }

    public Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

    public Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

    public Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

    public Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

    public Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

    public Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

    public Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

    public Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

    public Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

    public Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

    /// <summary>
    /// Assessment Need Hazard Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20026">Assessment Need Hazard Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentNeedHazardTypeId { get; set; }

    /// <summary>
    /// Assessment Need Support Tool Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the electronic tool associated with a resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20027">Assessment Need Support Tool Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentNeedSupportToolId { get; set; }

    /// <summary>
    /// Assessment Need Keyword Translation Language Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the default language for the keyword translation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20043">Assessment Need Keyword Translation Language Type</a>
    /// </para>
    /// </summary>
    public Guid? RefKeywordTranslationsLanguageId { get; set; }

    public Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

    public Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

    #endregion
}
