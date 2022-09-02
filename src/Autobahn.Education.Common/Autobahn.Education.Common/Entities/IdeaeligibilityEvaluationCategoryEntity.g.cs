//***************************************************************************
//* DomainName: Common Models
//* FileName:   IdeaeligibilityEvaluationCategoryEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIdeaeligibilityEvaluationCategory file
/// </summary>
[Table("IdeaeligibilityEvaluationCategory", Schema = "Common")]
public partial class IdeaeligibilityEvaluationCategoryEntity : EntityBase, IIdeaeligibilityEvaluationCategory
{
    #region "IIdeaeligibilityEvaluationCategory Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("EligibilityEvaluation")]
    public Guid EligibilityEvaluationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaeligibilityEvaluationCategory"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefeaeligibilityEvaluationCategory property is obsolete and will be removed in a later version")]
    [ForeignKey("RefeaeligibilityEvaluationCategory")]
    public Guid RefIdeaeligibilityEvaluationCategoryId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual EligibilityEvaluationEntity EligibilityEvaluationEntity { get; set; }

    #endregion
}
