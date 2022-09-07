//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentFormSectionAssessmentAsset.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSectionAssessmentAsset file
/// </summary>
public partial interface IAssessmentFormSectionAssessmentAsset
{
    #region "IAssessmentFormSectionAssessmentAsset Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
    /// </summary>
    Guid AssessmentAssetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    Guid AssessmentFormSectionId { get; set; }

    #endregion
}
