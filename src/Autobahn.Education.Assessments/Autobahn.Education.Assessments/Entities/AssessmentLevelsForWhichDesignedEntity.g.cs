//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentLevelsForWhichDesignedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentLevelsForWhichDesigned file
/// </summary>
[Table("AssessmentLevelsForWhichDesigned", Schema = "Assessments")]
public partial class AssessmentLevelsForWhichDesignedEntity : EntityBase, IAssessmentLevelsForWhichDesigned
{
    #region "IAssessmentLevelsForWhichDesigned Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Assessment")]
    public Guid AssessmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefGradeLevel")]
    public Guid RefGradeLevelId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentEntity AssessmentEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefGradeLevel"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefGradeLevelEntity RefGradeLevelEntity { get; set; }

    #endregion
}
