//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileScreenEnhancementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileScreenEnhancement file
/// </summary>
public partial class AssessmentPersonalNeedsProfileScreenEnhancementModel : AutobahnBaseModel, IAssessmentPersonalNeedsProfileScreenEnhancement
{
    #region "IAssessmentPersonalNeedsProfileScreenEnhancement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileId { get; set; }

    #endregion
}
