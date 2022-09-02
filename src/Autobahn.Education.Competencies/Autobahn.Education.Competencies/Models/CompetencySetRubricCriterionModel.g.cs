//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricCriterionEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencySetRubricCriterion file
/// </summary>
public partial class CompetencySetRubricCriterionModel : AutobahnBaseModel, ICompetencySetRubricCriterion
{
    #region "ICompetencySetRubricCriterion Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    public Guid CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterion"/> model
    /// </summary>
    public Guid RubricCriterionId { get; set; }

    #endregion
}
