//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencySetRubric file
/// </summary>
public partial class CompetencySetRubricModel : AutobahnBaseModel, ICompetencySetRubric
{
    #region "ICompetencySetRubric Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    public Guid CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubric"/> model
    /// </summary>
    public Guid RubricId { get; set; }

    #endregion
}
