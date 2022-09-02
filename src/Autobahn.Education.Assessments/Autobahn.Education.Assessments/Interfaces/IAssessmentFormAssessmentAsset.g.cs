//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentFormAssessmentAsset.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormAssessmentAsset file
/// </summary>
public partial interface IAssessmentFormAssessmentAsset
{
    #region "IAssessmentFormAssessmentAsset Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
    /// </summary>
    Guid AssessmentAssetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    Guid AssessmentFormId { get; set; }

    #endregion
}
