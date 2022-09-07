//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationAccommodationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentRegistrationAccommodation file
/// </summary>
public partial class AssessmentRegistrationAccommodationModel : AutobahnBaseModel, IAssessmentRegistrationAccommodation
{
    #region "IAssessmentRegistrationAccommodation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
    /// </summary>
    public Guid AssessmentAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
    /// </summary>
    public Guid AssessmentRegistrationId { get; set; }

    #endregion
}
