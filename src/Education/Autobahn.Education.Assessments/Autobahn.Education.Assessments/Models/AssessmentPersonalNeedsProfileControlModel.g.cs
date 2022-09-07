//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileControlEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileControl file
/// </summary>
public partial class AssessmentPersonalNeedsProfileControlModel : AutobahnBaseModel, IAssessmentPersonalNeedsProfileControl
{
    #region "IAssessmentPersonalNeedsProfileControl Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileId { get; set; }

    #endregion
}
