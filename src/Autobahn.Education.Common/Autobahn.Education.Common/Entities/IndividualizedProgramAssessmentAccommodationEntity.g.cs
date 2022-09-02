//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAssessmentAccommodationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAssessmentAccommodation file
/// </summary>
[Table("IndividualizedProgramAssessmentAccommodation", Schema = "Common")]
public partial class IndividualizedProgramAssessmentAccommodationEntity : EntityBase, IIndividualizedProgramAssessmentAccommodation
{
    #region "IIndividualizedProgramAssessmentAccommodation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentAccommodation")]
    public Guid AssessmentAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramAssessment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgramAssessment")]
    public Guid IndividualizedProgramAssessmentId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentAccommodationEntity AssessmentAccommodationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramAssessment"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramAssessmentEntity IndividualizedProgramAssessmentEntity { get; set; }

    #endregion
}
