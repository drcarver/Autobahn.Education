//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramEligibilityEvaluationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramEligibilityEvaluation file
/// </summary>
public partial class IndividualizedProgramEligibilityEvaluationModel : AutobahnBaseModel, IIndividualizedProgramEligibilityEvaluation
{
    #region "IIndividualizedProgramEligibilityEvaluation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
    /// </summary>
    public Guid EligibilityEvaluationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramEligibility"/> model
    /// </summary>
    public Guid IndividualizedProgramEligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIepeligibilityEvaluationType"/> model
    /// </summary>
    public Guid? RefIepeligibilityEvaluationTypeId { get; set; }

    #endregion
}
