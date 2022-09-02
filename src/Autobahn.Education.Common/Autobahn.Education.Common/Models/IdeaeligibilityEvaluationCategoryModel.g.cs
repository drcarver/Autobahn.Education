//***************************************************************************
//* DomainName: Common Models
//* FileName:   IdeaeligibilityEvaluationCategoryEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIdeaeligibilityEvaluationCategory file
/// </summary>
public partial class IdeaeligibilityEvaluationCategoryModel : AutobahnBaseModel, IIdeaeligibilityEvaluationCategory
{
    #region "IIdeaeligibilityEvaluationCategory Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
    /// </summary>
    public Guid EligibilityEvaluationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaeligibilityEvaluationCategory"/> model
    /// </summary>
    public Guid RefIdeaeligibilityEvaluationCategoryId { get; set; }

    #endregion
}
