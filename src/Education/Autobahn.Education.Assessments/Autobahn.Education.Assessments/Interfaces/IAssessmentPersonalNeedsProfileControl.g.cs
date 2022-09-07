//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentPersonalNeedsProfileControl.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileControl file
/// </summary>
public partial interface IAssessmentPersonalNeedsProfileControl
{
    #region "IAssessmentPersonalNeedsProfileControl Properties"
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
