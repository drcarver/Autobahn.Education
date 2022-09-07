//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemRubricCriterionResultEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemRubricCriterionResult file
/// </summary>
[Table("AssessmentItemRubricCriterionResult", Schema = "Assessments")]
public partial class AssessmentItemRubricCriterionResultEntity : EntityBase, IAssessmentItemRubricCriterionResult
{
    #region "IAssessmentItemRubricCriterionResult Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentItemResponse")]
    public Guid AssessmentItemResponseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RubricCriterionLevel")]
    public Guid RubricCriterionLevelId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentItemResponseEntity AssessmentItemResponseEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RubricCriterionLevelEntity RubricCriterionLevelEntity { get; set; }

    #endregion
}
