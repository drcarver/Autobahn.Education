//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefEducationLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefEducationLevel file
/// </summary>
[Table("CompetencyDefEducationLevel", Schema = "Competencies")]
public partial class CompetencyDefEducationLevelEntity : EntityBase, ICompetencyDefEducationLevel
{
    #region "ICompetencyDefEducationLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CompetencyDefinition")]
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
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefEducationLevel")]
    [Comment("The education level, grade level or primary instructional level at which a Competency Definition is intended.")]
    public Guid RefEducationLevelId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> implementation
    /// <remarks>
    /// This entity is in the Competencies domain
    /// </remarks>
    /// </summary>
    public virtual CompetencyDefinitionEntity CompetencyDefinitionEntity { get; set; }

    /// <summary>
    /// The education level, grade level or primary instructional level at which a Competency Definition is intended.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19701">Competency Definition Education Level</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Competencies domain
    /// </remarks>
    /// </summary>
    public virtual RefEducationLevelEntity RefEducationLevelEntity { get; set; }

    #endregion
}
