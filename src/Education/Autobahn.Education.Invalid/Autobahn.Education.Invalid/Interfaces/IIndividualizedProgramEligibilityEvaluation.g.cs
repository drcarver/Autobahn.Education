//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IIndividualizedProgramEligibilityEvaluation.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramEligibilityEvaluation file
/// </summary>
public partial interface IIndividualizedProgramEligibilityEvaluation
{
    #region "IIndividualizedProgramEligibilityEvaluation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
    /// </summary>
    Guid EligibilityEvaluationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramEligibility"/> model
    /// </summary>
    Guid IndividualizedProgramEligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIepeligibilityEvaluationType"/> model
    /// </summary>
    Guid? RefIepeligibilityEvaluationTypeId { get; set; }

    #endregion
}
