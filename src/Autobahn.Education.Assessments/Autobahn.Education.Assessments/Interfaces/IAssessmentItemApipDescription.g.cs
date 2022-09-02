//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentItemApipDescription.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemApipDescription file
/// </summary>
public partial interface IAssessmentItemApipDescription
{
    #region "IAssessmentItemApipDescription Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? AslIndicator { get; set; }

    Boolean? AslOnDemandIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemApip"/> model
    /// </summary>
    Guid AssessmentItemApipId { get; set; }

    Boolean? BrailleIndicator { get; set; }

    Boolean? ChunkingActivateByDefaultIndicator { get; set; }

    Boolean? ChunkingAssignedSupportIndicator { get; set; }

    Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

    Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

    Boolean? GraphicsOnlyIndicator { get; set; }

    Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

    Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

    Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

    Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

    Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

    Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

    Boolean? NonVisualIndicator { get; set; }

    Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

    Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefHazardType"/> model
    /// </summary>
    Guid? RefHazardTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefKeywordTranslationLanguage"/> model
    /// </summary>
    Guid? RefKeywordTranslationLanguageId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSupportToolType"/> model
    /// </summary>
    Guid? RefSupportToolTypeId { get; set; }

    Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

    Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

    Boolean? SignedEnglishIndicator { get; set; }

    Boolean? SignedEnglishOnDemandIndicator { get; set; }

    Boolean? TextGraphicsIndicator { get; set; }

    Boolean? TextOnlyIndicator { get; set; }

    Boolean? TextOnlyOnDemandIndicator { get; set; }

    #endregion
}
