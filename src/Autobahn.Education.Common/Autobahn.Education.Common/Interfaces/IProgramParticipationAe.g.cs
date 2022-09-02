//***************************************************************************
//* DomainName: Common Models
//* FileName:   IProgramParticipationAe.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationAe file
/// </summary>
public partial interface IProgramParticipationAe
{
    #region "IProgramParticipationAe Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? DisplacedHomemakerIndicator { get; set; }

    Decimal? InstructionalActivityHoursCompleted { get; set; }

    Boolean? OutOfWorkforceIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

    DateTime? PostsecondaryTransitionDate { get; set; }

    System.Int32 ProgramParticipationAeid { get; set; }

    Decimal? ProxyContactHours { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdultEducationProgramExitReason"/> model
    /// </summary>
    Guid? RefAdultEducationProgramExitReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtIntake"/> model
    /// </summary>
    Guid? RefAeFunctioningLevelAtIntakeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtPosttest"/> model
    /// </summary>
    Guid? RefAeFunctioningLevelAtPosttestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeInstructionalProgramType"/> model
    /// </summary>
    Guid? RefAeInstructionalProgramTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAePostsecondaryTransitionAction"/> model
    /// </summary>
    Guid? RefAePostsecondaryTransitionActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeSpecialProgramType"/> model
    /// </summary>
    Guid? RefAeSpecialProgramTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCorrectionalEducationFacilityType"/> model
    /// </summary>
    Guid? RefCorrectionalEducationFacilityTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGoalsForAttendingAdultEducation"/> model
    /// </summary>
    Guid? RefGoalsForAttendingAdultEducationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
    /// </summary>
    Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    #endregion
}
