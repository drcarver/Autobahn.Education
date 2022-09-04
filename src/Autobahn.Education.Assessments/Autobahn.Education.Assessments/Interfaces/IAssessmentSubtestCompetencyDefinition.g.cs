//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentSubtestCompetencyDefinition.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestCompetencyDefinition file
/// </summary>
public partial interface IAssessmentSubtestCompetencyDefinition
{
    #region "IAssessmentSubtestCompetencyDefinition Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    Guid AssessmentSubTestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    Guid CompetencyDefinitionId { get; set; }

    #endregion
}
