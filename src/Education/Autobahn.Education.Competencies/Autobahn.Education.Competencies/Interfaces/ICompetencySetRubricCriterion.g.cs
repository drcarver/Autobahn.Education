//***************************************************************************
//* DomainName: Competencies
//* FileName:   ICompetencySetRubricCriterion.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencySetRubricCriterion file
/// </summary>
public partial interface ICompetencySetRubricCriterion
{
    #region "ICompetencySetRubricCriterion Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    Guid CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterion"/> model
    /// </summary>
    Guid RubricCriterionId { get; set; }

    #endregion
}
