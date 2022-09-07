//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   CompetencyDefEducationLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefEducationLevel file
/// </summary>
public partial class CompetencyDefEducationLevelModel : AutobahnBaseModel, ICompetencyDefEducationLevel
{
    #region "ICompetencyDefEducationLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    public Guid CompetencyDefinitionId { get; set; }

    /// <summary>
    /// Competency Definition Education Level
    /// <para>
    /// The education level, grade level or primary instructional level at which a Competency Definition is intended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19701">Competency Definition Education Level</a>
    /// </para>
    /// </summary>
    public Guid RefEducationLevelId { get; set; }

    #endregion
}
