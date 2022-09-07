//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentParticipantSessionAccommodation.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentParticipantSessionAccommodation file
/// </summary>
public partial interface IAssessmentParticipantSessionAccommodation
{
    #region "IAssessmentParticipantSessionAccommodation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
    /// </summary>
    Guid AssessmentAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
    /// </summary>
    Guid AssessmentParticipantSessionId { get; set; }

    #endregion
}
