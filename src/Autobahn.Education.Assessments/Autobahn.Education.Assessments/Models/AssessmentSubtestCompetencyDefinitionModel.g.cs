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
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    public Guid AssessmentSubtestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    public Guid CompetencyDefinitionId { get; set; }

    #endregion
}
