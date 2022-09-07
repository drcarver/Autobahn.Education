//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestItem file
/// </summary>
[Table("AssessmentSubtestItem", Schema = "Assessments")]
public partial class AssessmentSubtestItemEntity : EntityBase, IAssessmentSubtestItem
{
    #region "IAssessmentSubtestItem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentItem")]
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentSubTest")]
    public Guid AssessmentSubTestId { get; set; }

    public Decimal? ItemWeightCorrect { get; set; }

    public Decimal? ItemWeightIncorrect { get; set; }

    public Decimal? ItemWeightNotAttempted { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentSubTestEntity AssessmentSubTestEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentItemEntity AssessmentItemEntity { get; set; }

    #endregion
}
