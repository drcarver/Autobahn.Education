//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramEligibilityEvaluationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramEligibilityEvaluation file
/// </summary>
[Table("IndividualizedProgramEligibilityEvaluation", Schema = "Invalid")]
public partial class IndividualizedProgramEligibilityEvaluationEntity : EntityBase, IIndividualizedProgramEligibilityEvaluation
{
    #region "IIndividualizedProgramEligibilityEvaluation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("EligibilityEvaluation")]
    public Guid EligibilityEvaluationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramEligibility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgramEligibility")]
    public Guid IndividualizedProgramEligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIepeligibilityEvaluationType"/> model
    /// </summary>
    [ForeignKey("RefIepeligibilityEvaluationType")]
    public Guid? RefIepeligibilityEvaluationTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual EligibilityEvaluationEntity EligibilityEvaluationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramEligibility"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEligibilityEntity IndividualizedProgramEligibilityEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIepeligibilityEvaluationType"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefIepeligibilityEvaluationTypeEntity? RefIepeligibilityEvaluationTypeEntity { get; set; }

    #endregion
}
