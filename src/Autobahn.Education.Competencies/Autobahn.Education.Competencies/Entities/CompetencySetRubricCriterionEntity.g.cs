//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricCriterionEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencySetRubricCriterion file
/// </summary>
[Table("CompetencySetRubricCriterion", Schema = "Competencies")]
public partial class CompetencySetRubricCriterionEntity : EntityBase, ICompetencySetRubricCriterion
{
    #region "ICompetencySetRubricCriterion Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CompetencySet")]
    public Guid CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterion"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RubricCriterion")]
    public Guid RubricCriterionId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> implementation
    /// <remarks>
    /// This entity is in the Competencies domain
    /// </remarks>
    /// </summary>
    public virtual CompetencySetEntity CompetencySetEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterion"/> implementation
    /// <remarks>
    /// This entity is in the Competencies domain
    /// </remarks>
    /// </summary>
    public virtual RubricCriterionEntity RubricCriterionEntity { get; set; }

    #endregion
}
