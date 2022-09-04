//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramAssessmentAccommodationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAssessmentAccommodation file
/// </summary>
public partial class IndividualizedProgramAssessmentAccommodationModel : AutobahnBaseModel, IIndividualizedProgramAssessmentAccommodation
{
    #region "IIndividualizedProgramAssessmentAccommodation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
    /// </summary>
    public Guid AssessmentAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramAssessment"/> model
    /// </summary>
    public Guid IndividualizedProgramAssessmentId { get; set; }

    #endregion
}
