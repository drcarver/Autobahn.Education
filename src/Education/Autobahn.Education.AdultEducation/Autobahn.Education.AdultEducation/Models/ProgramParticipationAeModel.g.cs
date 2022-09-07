//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationAe file
/// </summary>
public partial class ProgramParticipationAeModel : AutobahnBaseModel, IProgramParticipationAe
{
    #region "IProgramParticipationAe Properties"
    public Boolean? DisplacedHomemakerIndicator { get; set; }

    public Decimal? InstructionalActivityHoursCompleted { get; set; }

    public Boolean? OutOfWorkforceIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    public DateTime? PostsecondaryTransitionDate { get; set; }

    public System.Int32 ProgramParticipationAeid { get; set; }

    public Decimal? ProxyContactHours { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdultEducationProgramExitReason"/> model
    /// </summary>
    public Guid? RefAdultEducationProgramExitReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtIntake"/> model
    /// </summary>
    public Guid? RefAeFunctioningLevelAtIntakeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtPosttest"/> model
    /// </summary>
    public Guid? RefAeFunctioningLevelAtPosttestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeInstructionalProgramType"/> model
    /// </summary>
    public Guid? RefAeInstructionalProgramTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAePostsecondaryTransitionAction"/> model
    /// </summary>
    public Guid? RefAePostsecondaryTransitionActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeSpecialProgramType"/> model
    /// </summary>
    public Guid? RefAeSpecialProgramTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCorrectionalEducationFacilityType"/> model
    /// </summary>
    public Guid? RefCorrectionalEducationFacilityTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGoalsForAttendingAdultEducation"/> model
    /// </summary>
    public Guid? RefGoalsForAttendingAdultEducationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
    /// </summary>
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    #endregion
}
