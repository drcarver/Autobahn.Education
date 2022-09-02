//***************************************************************************
//* DomainName: Common Models
//* FileName:   IIdeaeligibilityEvaluationCategory.g.cs
//***************************************************************************

/// <summary>
/// The IIdeaeligibilityEvaluationCategory file
/// </summary>
public partial interface IIdeaeligibilityEvaluationCategory
{
    #region "IIdeaeligibilityEvaluationCategory Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
    /// </summary>
    Guid EligibilityEvaluationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaeligibilityEvaluationCategory"/> model
    /// </summary>
    Guid RefIdeaeligibilityEvaluationCategoryId { get; set; }

    #endregion
}
