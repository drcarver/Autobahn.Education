//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentLanguage.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentLanguage file
/// </summary>
public partial interface IAssessmentLanguage
{
    #region "IAssessmentLanguage Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    Guid AssessmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLanguage"/> model
    /// </summary>
    Guid RefLanguageId { get; set; }

    #endregion
}
