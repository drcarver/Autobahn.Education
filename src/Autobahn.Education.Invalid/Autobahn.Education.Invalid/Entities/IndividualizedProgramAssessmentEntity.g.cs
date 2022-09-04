//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramAssessmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAssessment file
/// </summary>
[Table("IndividualizedProgramAssessment", Schema = "Invalid")]
public partial class IndividualizedProgramAssessmentEntity : EntityBase, IIndividualizedProgramAssessment
{
    #region "IIndividualizedProgramAssessment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Assessment")]
    public Guid AssessmentId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String IepalternativeAssessmentRationale { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentEntity AssessmentEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    #endregion
}
