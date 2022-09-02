//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentAssetEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSectionAssessmentAsset file
/// </summary>
public partial class AssessmentFormSectionAssessmentAssetModel : AutobahnBaseModel, IAssessmentFormSectionAssessmentAsset
{
    #region "IAssessmentFormSectionAssessmentAsset Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
    /// </summary>
    public Guid AssessmentAssetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    public Guid AssessmentFormSectionId { get; set; }

    #endregion
}
