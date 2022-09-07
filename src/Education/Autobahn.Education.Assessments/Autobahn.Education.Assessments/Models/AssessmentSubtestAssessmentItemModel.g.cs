//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestAssessmentItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestAssessmentItem file
/// </summary>
public partial class AssessmentSubtestAssessmentItemModel : AutobahnBaseModel, IAssessmentSubtestAssessmentItem
{
    #region "IAssessmentSubtestAssessmentItem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    public Guid AssessmentSubTestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtestItem"/> model
    /// </summary>
    public Guid AssessmentSubtestItemId { get; set; }

    public Decimal? ItemWeightCorrect { get; set; }

    public Decimal? ItemWeightIncorrect { get; set; }

    public Decimal? ItemWeightNotAttempted { get; set; }

    #endregion
}
