//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentRegistrationAccommodation.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentRegistrationAccommodation file
/// </summary>
public partial interface IAssessmentRegistrationAccommodation
{
    #region "IAssessmentRegistrationAccommodation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
    /// </summary>
    Guid AssessmentAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
    /// </summary>
    Guid AssessmentRegistrationId { get; set; }

    #endregion
}
