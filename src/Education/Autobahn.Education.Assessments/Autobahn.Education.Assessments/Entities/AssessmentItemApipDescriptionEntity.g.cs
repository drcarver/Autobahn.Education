//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemApipDescriptionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemApipDescription file
/// </summary>
[Table("AssessmentItemApipDescription", Schema = "Assessments")]
public partial class AssessmentItemApipDescriptionEntity : EntityBase, IAssessmentItemApipDescription
{
    #region "IAssessmentItemApipDescription Properties"
    public Boolean? AslIndicator { get; set; }

    public Boolean? AslOnDemandIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemApip"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentItemApip")]
    public Guid AssessmentItemApipId { get; set; }

    public Boolean? BrailleIndicator { get; set; }

    public Boolean? ChunkingActivateByDefaultIndicator { get; set; }

    public Boolean? ChunkingAssignedSupportIndicator { get; set; }

    public Boolean? CognitiveGuidanceActivateByDefaultIndicator { get; set; }

    public Boolean? CognitiveGuidanceAssignedSupportIndicator { get; set; }

    public Boolean? GraphicsOnlyIndicator { get; set; }

    public Boolean? KeywordEmphasisActivateByDefaultIndicator { get; set; }

    public Boolean? KeywordEmphasisAssignedSupportIndicator { get; set; }

    public Boolean? KeywordTranslationsActivateByDefaultIndicator { get; set; }

    public Boolean? KeywordTranslationsAssignedSupportIndicator { get; set; }

    public Boolean? NegativesRemovedActivateByDefaultIndicator { get; set; }

    public Boolean? NegativesRemovedAssignedSupportIndicator { get; set; }

    public Boolean? NonVisualIndicator { get; set; }

    public Boolean? ReducedAnswersActivateByDefaultIndicator { get; set; }

    public Boolean? ReducedAnswersAssignedSupportIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefKeywordTranslationLanguage"/> model
    /// </summary>
    [ForeignKey("RefKeywordTranslationLanguage")]
    public Guid? RefKeywordTranslationLanguageId { get; set; }

    public Boolean? ScaffoldingActivateByDefaultIndicator { get; set; }

    public Boolean? ScaffoldingAssignedSupportIndicator { get; set; }

    public Boolean? SignedEnglishIndicator { get; set; }

    public Boolean? SignedEnglishOnDemandIndicator { get; set; }

    public Boolean? TextGraphicsIndicator { get; set; }

    public Boolean? TextOnlyIndicator { get; set; }

    public Boolean? TextOnlyOnDemandIndicator { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemApip"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentItemApipEntity AssessmentItemApipEntity { get; set; }

    #endregion
}
