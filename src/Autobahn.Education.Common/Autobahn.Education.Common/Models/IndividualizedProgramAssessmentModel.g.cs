//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAssessmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAssessment file
/// </summary>
public partial class IndividualizedProgramAssessmentModel : AutobahnBaseModel, IIndividualizedProgramAssessment
{
    #region "IIndividualizedProgramAssessment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    public Guid AssessmentId { get; set; }

    public System.String IepalternativeAssessmentRationale { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    #endregion
}
