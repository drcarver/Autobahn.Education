//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentResultRubricCriterionResult.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentResultRubricCriterionResult file
/// </summary>
public partial interface IAssessmentResultRubricCriterionResult
{
    #region "IAssessmentResultRubricCriterionResult Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
    /// </summary>
    Guid AssessmentResultId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
    /// </summary>
    Guid RubricCriterionLevelId { get; set; }

    #endregion
}
