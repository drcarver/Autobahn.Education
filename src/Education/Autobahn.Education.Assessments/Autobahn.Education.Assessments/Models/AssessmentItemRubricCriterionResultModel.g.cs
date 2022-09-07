//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemRubricCriterionResultEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemRubricCriterionResult file
/// </summary>
public partial class AssessmentItemRubricCriterionResultModel : AutobahnBaseModel, IAssessmentItemRubricCriterionResult
{
    #region "IAssessmentItemRubricCriterionResult Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> model
    /// </summary>
    public Guid AssessmentItemResponseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
    /// </summary>
    public Guid RubricCriterionLevelId { get; set; }

    #endregion
}
