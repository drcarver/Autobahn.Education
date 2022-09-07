//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentPersonalNeedsProfileScreenEnhancement.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileScreenEnhancement file
/// </summary>
public partial interface IAssessmentPersonalNeedsProfileScreenEnhancement
{
    #region "IAssessmentPersonalNeedsProfileScreenEnhancement Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    Guid AssessmentPersonalNeedsProfileId { get; set; }

    #endregion
}
