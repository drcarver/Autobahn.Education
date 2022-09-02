//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentSubtestAssessmentItem.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestAssessmentItem file
/// </summary>
public partial interface IAssessmentSubtestAssessmentItem
{
    #region "IAssessmentSubtestAssessmentItem Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    Guid AssessmentSubtestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtestItem"/> model
    /// </summary>
    Guid AssessmentSubtestItemId { get; set; }

    Decimal? ItemWeightCorrect { get; set; }

    Decimal? ItemWeightIncorrect { get; set; }

    Decimal? ItemWeightNotAttempted { get; set; }

    #endregion
}
