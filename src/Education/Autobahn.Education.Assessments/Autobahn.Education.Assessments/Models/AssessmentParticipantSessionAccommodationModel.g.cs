//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentParticipantSessionAccommodationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentParticipantSessionAccommodation file
/// </summary>
public partial class AssessmentParticipantSessionAccommodationModel : AutobahnBaseModel, IAssessmentParticipantSessionAccommodation
{
    #region "IAssessmentParticipantSessionAccommodation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
    /// </summary>
    public Guid AssessmentAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
    /// </summary>
    public Guid AssessmentParticipantSessionId { get; set; }

    #endregion
}
