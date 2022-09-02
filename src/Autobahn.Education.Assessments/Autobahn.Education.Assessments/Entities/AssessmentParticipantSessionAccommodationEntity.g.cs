//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionAccommodationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentParticipantSessionAccommodation file
/// </summary>
[Table("AssessmentParticipantSessionAccommodation", Schema = "Assessments")]
public partial class AssessmentParticipantSessionAccommodationEntity : EntityBase, IAssessmentParticipantSessionAccommodation
{
    #region "IAssessmentParticipantSessionAccommodation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentAccommodation")]
    public Guid AssessmentAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentParticipantSession")]
    public Guid AssessmentParticipantSessionId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentParticipantSessionEntity AssessmentParticipantSessionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentAccommodationEntity AssessmentAccommodationEntity { get; set; }

    #endregion
}
