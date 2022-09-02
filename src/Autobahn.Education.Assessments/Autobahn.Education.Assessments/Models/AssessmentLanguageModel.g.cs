//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLanguageEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentLanguage file
/// </summary>
public partial class AssessmentLanguageModel : AutobahnBaseModel, IAssessmentLanguage
{
    #region "IAssessmentLanguage Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    public Guid AssessmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLanguage"/> model
    /// </summary>
    public Guid RefLanguageId { get; set; }

    #endregion
}
