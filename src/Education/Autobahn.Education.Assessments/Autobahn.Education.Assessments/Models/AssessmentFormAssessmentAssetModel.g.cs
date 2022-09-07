//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentAssetEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormAssessmentAsset file
/// </summary>
public partial class AssessmentFormAssessmentAssetModel : AutobahnBaseModel, IAssessmentFormAssessmentAsset
{
    #region "IAssessmentFormAssessmentAsset Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
    /// </summary>
    public Guid AssessmentAssetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    public Guid AssessmentFormId { get; set; }

    #endregion
}
