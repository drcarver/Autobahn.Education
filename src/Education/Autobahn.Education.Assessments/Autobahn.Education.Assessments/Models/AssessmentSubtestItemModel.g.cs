//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestItem file
/// </summary>
public partial class AssessmentSubtestItemModel : AutobahnBaseModel, IAssessmentSubtestItem
{
    #region "IAssessmentSubtestItem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    public Guid AssessmentSubTestId { get; set; }

    public Decimal? ItemWeightCorrect { get; set; }

    public Decimal? ItemWeightIncorrect { get; set; }

    public Decimal? ItemWeightNotAttempted { get; set; }

    #endregion
}
