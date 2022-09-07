//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentPersonalNeedsProfileDisplay.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileDisplay file
/// </summary>
public partial interface IAssessmentPersonalNeedsProfileDisplay
{
    #region "IAssessmentPersonalNeedsProfileDisplay Properties"
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
