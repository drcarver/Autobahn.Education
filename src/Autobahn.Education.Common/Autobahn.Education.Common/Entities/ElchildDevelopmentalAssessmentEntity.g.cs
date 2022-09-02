//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildDevelopmentalAssessmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildDevelopmentalAssessment file
/// </summary>
[Table("ElchildDevelopmentalAssessment", Schema = "Common")]
public partial class ElchildDevelopmentalAssessmentEntity : EntityBase, IElchildDevelopmentalAssessment
{
    #region "IElchildDevelopmentalAssessment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefChildDevelopmentalScreeningStatus"/> model
    /// </summary>
    [ForeignKey("RefChildDevelopmentalScreeningStatus")]
    public Guid? RefChildDevelopmentalScreeningStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDevelopmentalEvaluationFinding"/> model
    /// </summary>
    [ForeignKey("RefDevelopmentalEvaluationFinding")]
    public Guid? RefDevelopmentalEvaluationFindingId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefChildDevelopmentalScreeningStatus"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefChildDevelopmentalScreeningStatusEntity RefChildDevelopmentalScreeningStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefDevelopmentalEvaluationFinding"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefDevelopmentalEvaluationFindingEntity RefDevelopmentalEvaluationFindingEntity { get; set; }

    #endregion
}
