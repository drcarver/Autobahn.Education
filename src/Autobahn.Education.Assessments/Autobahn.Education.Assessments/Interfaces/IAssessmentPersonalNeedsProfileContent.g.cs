//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentPersonalNeedsProfileContent.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileContent file
/// </summary>
public partial interface IAssessmentPersonalNeedsProfileContent
{
    #region "IAssessmentPersonalNeedsProfileContent Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    Guid AssessmentPersonalNeedsProfileId { get; set; }

    Boolean? ChunkingActivateByDefaultIndicator { get; set; }

    Boolean? ChunkingAssignedSupportIndicator { get; set; }

    Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

    Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

    Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

    Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

    Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

    Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

    Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

    Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

    Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

    Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

    /// <summary>
    /// Assessment Need Hazard Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile a characteristic of a digital resource that may be specified as being dangerous to a user.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20026">Assessment Need Hazard Type</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentNeedHazardTypeId { get; set; }

    /// <summary>
    /// Assessment Need Support Tool Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the electronic tool associated with a resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20027">Assessment Need Support Tool Type</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentNeedSupportToolId { get; set; }

    /// <summary>
    /// Assessment Need Keyword Translation Language Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the default language for the keyword translation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20043">Assessment Need Keyword Translation Language Type</a>
    /// </para>
    /// </summary>
    Guid? RefKeywordTranslationsLanguageId { get; set; }

    Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

    Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

    #endregion
}
