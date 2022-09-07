//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationAe file
/// </summary>
[Table("ProgramParticipationAe", Schema = "AdultEducation")]
public partial class ProgramParticipationAeEntity : EntityBase, IProgramParticipationAe
{
    #region "IProgramParticipationAe Properties"
    public Boolean? DisplacedHomemakerIndicator { get; set; }

    public Decimal? InstructionalActivityHoursCompleted { get; set; }

    public Boolean? OutOfWorkforceIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
    public Guid PersonProgramParticipationId { get; set; }

    public DateTime? PostsecondaryTransitionDate { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 ProgramParticipationAeid { get; set; }

    public Decimal? ProxyContactHours { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdultEducationProgramExitReason"/> model
    /// </summary>
    [ForeignKey("RefAdultEducationProgramExitReason")]
    public Guid? RefAdultEducationProgramExitReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtIntake"/> model
    /// </summary>
    [ForeignKey("RefAeFunctioningLevelAtIntake")]
    public Guid? RefAeFunctioningLevelAtIntakeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeFunctioningLevelAtPosttest"/> model
    /// </summary>
    [ForeignKey("RefAeFunctioningLevelAtPosttest")]
    public Guid? RefAeFunctioningLevelAtPosttestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeInstructionalProgramType"/> model
    /// </summary>
    [ForeignKey("RefAeInstructionalProgramType")]
    public Guid? RefAeInstructionalProgramTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAePostsecondaryTransitionAction"/> model
    /// </summary>
    [ForeignKey("RefAePostsecondaryTransitionAction")]
    public Guid? RefAePostsecondaryTransitionActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAeSpecialProgramType"/> model
    /// </summary>
    [ForeignKey("RefAeSpecialProgramType")]
    public Guid? RefAeSpecialProgramTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCorrectionalEducationFacilityType"/> model
    /// </summary>
    [ForeignKey("RefCorrectionalEducationFacilityType")]
    public Guid? RefCorrectionalEducationFacilityTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGoalsForAttendingAdultEducation"/> model
    /// </summary>
    [ForeignKey("RefGoalsForAttendingAdultEducation")]
    public Guid? RefGoalsForAttendingAdultEducationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
    /// </summary>
    [ForeignKey("RefWorkbasedLearningOpportunityType")]
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> implementation
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual PersonProgramParticipationEntity PersonProgramParticipationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAeInstructionalProgramType"/> implementation
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefAeInstructionalProgramTypeEntity? RefAeInstructionalProgramTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAePostsecondaryTransitionAction"/> implementation
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefAePostsecondaryTransitionActionEntity? RefAePostsecondaryTransitionActionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAeSpecialProgramType"/> implementation
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefAeSpecialProgramTypeEntity? RefAeSpecialProgramTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAeFunctioningLevelAtIntake"/> implementation
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefAeFunctioningLevelAtIntakeEntity? RefAeFunctioningLevelAtIntakeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAeFunctioningLevelAtPosttest"/> implementation
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefAeFunctioningLevelAtPosttestEntity? RefAeFunctioningLevelAtPosttestEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefGoalsForAttendingAdultEducation"/> implementation
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefGoalsForAttendingAdultEducationEntity? RefGoalsForAttendingAdultEducationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCorrectionalEducationFacilityType"/> implementation
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefCorrectionalEducationFacilityTypeEntity? RefCorrectionalEducationFacilityTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefWorkbasedLearningOpportunityType"/> implementation
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefWorkbasedLearningOpportunityTypeEntity? RefWorkbasedLearningOpportunityTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAdultEducationProgramExitReason"/> implementation
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefAdultEducationProgramExitReasonEntity? RefAdultEducationProgramExitReasonEntity { get; set; }

    #endregion
}
