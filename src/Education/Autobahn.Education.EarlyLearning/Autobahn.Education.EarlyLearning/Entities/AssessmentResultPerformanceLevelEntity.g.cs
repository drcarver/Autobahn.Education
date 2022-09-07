//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   AssessmentResultPerformanceLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentResultPerformanceLevel file
/// </summary>
[Table("AssessmentResultPerformanceLevel", Schema = "EarlyLearning")]
public partial class AssessmentResultPerformanceLevelEntity : EntityBase, IAssessmentResultPerformanceLevel
{
    #region "IAssessmentResultPerformanceLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPerformanceLevel"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentPerformanceLevel")]
    public Guid AssessmentPerformanceLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentResult")]
    public Guid AssessmentResultId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentResultEntity AssessmentResultEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPerformanceLevel"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentPerformanceLevelEntity AssessmentPerformanceLevelEntity { get; set; }

    #endregion
}
