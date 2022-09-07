//***************************************************************************
//* DomainName: Competencies
//* FileName:   ICompetencySetRubric.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencySetRubric file
/// </summary>
public partial interface ICompetencySetRubric
{
    #region "ICompetencySetRubric Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    Guid CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubric"/> model
    /// </summary>
    Guid RubricId { get; set; }

    #endregion
}
