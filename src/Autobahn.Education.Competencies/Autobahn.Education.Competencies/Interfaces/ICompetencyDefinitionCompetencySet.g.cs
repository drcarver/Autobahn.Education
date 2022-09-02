//***************************************************************************
//* DomainName: Competencies
//* FileName:   ICompetencyDefinitionCompetencySet.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefinitionCompetencySet file
/// </summary>
public partial interface ICompetencyDefinitionCompetencySet
{
    #region "ICompetencyDefinitionCompetencySet Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    Guid CompetencyDefinitionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    Guid CompetencySetId { get; set; }

    #endregion
}
