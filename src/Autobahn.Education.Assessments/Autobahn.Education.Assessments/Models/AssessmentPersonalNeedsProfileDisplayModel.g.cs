//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileDisplayEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileDisplay file
/// </summary>
public partial class AssessmentPersonalNeedsProfileDisplayModel : AutobahnBaseModel, IAssessmentPersonalNeedsProfileDisplay
{
    #region "IAssessmentPersonalNeedsProfileDisplay Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileId { get; set; }

    #endregion
}
