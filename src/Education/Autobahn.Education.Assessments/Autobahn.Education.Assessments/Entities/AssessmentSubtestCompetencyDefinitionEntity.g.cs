//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestCompetencyDefinitionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestCompetencyDefinition file
/// </summary>
[Table("AssessmentSubtestCompetencyDefinition", Schema = "Assessments")]
public partial class AssessmentSubtestCompetencyDefinitionEntity : EntityBase, IAssessmentSubtestCompetencyDefinition
{
    #region "IAssessmentSubtestCompetencyDefinition Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentSubTest")]
    public Guid AssessmentSubTestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CompetencyDefinition")]
    public Guid CompetencyDefinitionId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentSubTestEntity AssessmentSubTestEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual CompetencyDefinitionEntity CompetencyDefinitionEntity { get; set; }

    #endregion
}
