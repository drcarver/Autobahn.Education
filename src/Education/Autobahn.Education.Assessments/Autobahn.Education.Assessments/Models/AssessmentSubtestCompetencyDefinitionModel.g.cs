//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestCompetencyDefinitionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestCompetencyDefinition file
/// </summary>
public partial class AssessmentSubtestCompetencyDefinitionModel : AutobahnBaseModel, IAssessmentSubtestCompetencyDefinition
{
    #region "IAssessmentSubtestCompetencyDefinition Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    public Guid AssessmentSubTestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    public Guid CompetencyDefinitionId { get; set; }

    #endregion
}
