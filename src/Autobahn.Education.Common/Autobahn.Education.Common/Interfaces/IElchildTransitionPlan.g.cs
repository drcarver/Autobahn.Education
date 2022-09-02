//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElchildTransitionPlan.g.cs
//***************************************************************************

/// <summary>
/// The IElchildTransitionPlan file
/// </summary>
public partial interface IElchildTransitionPlan
{
    #region "IElchildTransitionPlan Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? DateOfTransitionPlan { get; set; }

    DateTime? IdeapartCtoPartBnotificationDate { get; set; }

    DateTime? IdeapartCtoPartBnotificationOptOutDate { get; set; }

    Boolean? IdeapartCtoPartBnotificationOptOutIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid? IndividualizedProgramId { get; set; }

    Boolean? PartB619potentialEligibilityInd { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefReasonDelayTransitionConf"/> model
    /// </summary>
    Guid? RefReasonDelayTransitionConfId { get; set; }

    DateTime? TransitionConferenceDate { get; set; }

    DateTime? TransitionConferenceDeclineDate { get; set; }

    #endregion
}
