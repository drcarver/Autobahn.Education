//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildTransitionPlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildTransitionPlan file
/// </summary>
public partial class ElchildTransitionPlanModel : AutobahnBaseModel, IElchildTransitionPlan
{
    #region "IElchildTransitionPlan Properties"
    public DateTime? DateOfTransitionPlan { get; set; }

    public DateTime? IdeapartCtoPartBnotificationDate { get; set; }

    public DateTime? IdeapartCtoPartBnotificationOptOutDate { get; set; }

    public Boolean? IdeapartCtoPartBnotificationOptOutIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid? IndividualizedProgramId { get; set; }

    public Boolean? PartB619potentialEligibilityInd { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefReasonDelayTransitionConf"/> model
    /// </summary>
    public Guid? RefReasonDelayTransitionConfId { get; set; }

    public DateTime? TransitionConferenceDate { get; set; }

    public DateTime? TransitionConferenceDeclineDate { get; set; }

    #endregion
}
