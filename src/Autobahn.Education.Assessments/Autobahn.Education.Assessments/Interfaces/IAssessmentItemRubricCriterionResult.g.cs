//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentItemRubricCriterionResult.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemRubricCriterionResult file
/// </summary>
public partial interface IAssessmentItemRubricCriterionResult
{
    #region "IAssessmentItemRubricCriterionResult Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> model
    /// </summary>
    Guid AssessmentItemResponseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
    /// </summary>
    Guid RubricCriterionLevelId { get; set; }

    #endregion
}
