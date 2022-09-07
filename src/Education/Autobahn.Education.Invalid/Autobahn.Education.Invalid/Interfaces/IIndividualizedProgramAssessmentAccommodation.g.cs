//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IIndividualizedProgramAssessmentAccommodation.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAssessmentAccommodation file
/// </summary>
public partial interface IIndividualizedProgramAssessmentAccommodation
{
    #region "IIndividualizedProgramAssessmentAccommodation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
    /// </summary>
    Guid AssessmentAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramAssessment"/> model
    /// </summary>
    Guid IndividualizedProgramAssessmentId { get; set; }

    #endregion
}
