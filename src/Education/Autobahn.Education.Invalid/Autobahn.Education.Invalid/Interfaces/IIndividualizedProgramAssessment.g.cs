//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IIndividualizedProgramAssessment.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAssessment file
/// </summary>
public partial interface IIndividualizedProgramAssessment
{
    #region "IIndividualizedProgramAssessment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    Guid AssessmentId { get; set; }

    System.String IepalternativeAssessmentRationale { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    #endregion
}
