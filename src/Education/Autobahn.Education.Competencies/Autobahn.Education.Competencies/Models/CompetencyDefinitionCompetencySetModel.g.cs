//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionCompetencySetEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefinitionCompetencySet file
/// </summary>
public partial class CompetencyDefinitionCompetencySetModel : AutobahnBaseModel, ICompetencyDefinitionCompetencySet
{
    #region "ICompetencyDefinitionCompetencySet Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    public Guid CompetencyDefinitionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    public Guid CompetencySetId { get; set; }

    #endregion
}
