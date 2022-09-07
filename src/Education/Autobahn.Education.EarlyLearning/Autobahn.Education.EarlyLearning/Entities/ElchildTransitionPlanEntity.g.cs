//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildTransitionPlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildTransitionPlan file
/// </summary>
[Table("ElchildTransitionPlan", Schema = "EarlyLearning")]
public partial class ElchildTransitionPlanEntity : EntityBase, IElchildTransitionPlan
{
    #region "IElchildTransitionPlan Properties"
    public DateTime? DateOfTransitionPlan { get; set; }

    public DateTime? IdeapartCtoPartBnotificationDate { get; set; }

    public DateTime? IdeapartCtoPartBnotificationOptOutDate { get; set; }

    public Boolean? IdeapartCtoPartBnotificationOptOutIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [ForeignKey("IndividualizedProgram")]
    public Guid? IndividualizedProgramId { get; set; }

    public Boolean? PartB619potentialEligibilityInd { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefReasonDelayTransitionConf"/> model
    /// </summary>
    [ForeignKey("RefReasonDelayTransitionConf")]
    public Guid? RefReasonDelayTransitionConfId { get; set; }

    public DateTime? TransitionConferenceDate { get; set; }

    public DateTime? TransitionConferenceDeclineDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity? IndividualizedProgramEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefReasonDelayTransitionConf"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefReasonDelayTransitionConfEntity? RefReasonDelayTransitionConfEntity { get; set; }

    #endregion
}
