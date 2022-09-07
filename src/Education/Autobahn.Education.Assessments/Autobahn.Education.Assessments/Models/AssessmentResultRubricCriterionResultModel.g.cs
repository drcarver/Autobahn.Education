//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultRubricCriterionResultEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentResultRubricCriterionResult file
/// </summary>
public partial class AssessmentResultRubricCriterionResultModel : AutobahnBaseModel, IAssessmentResultRubricCriterionResult
{
    #region "IAssessmentResultRubricCriterionResult Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
    /// </summary>
    public Guid AssessmentResultId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
    /// </summary>
    public Guid RubricCriterionLevelId { get; set; }

    #endregion
}
