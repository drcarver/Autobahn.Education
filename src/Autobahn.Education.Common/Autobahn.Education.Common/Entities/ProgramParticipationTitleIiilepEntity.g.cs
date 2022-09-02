//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTitleIiilepEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationTitleIiilep file
/// </summary>
[Table("ProgramParticipationTitleIiilep", Schema = "Common")]
public partial class ProgramParticipationTitleIiilepEntity : EntityBase, IProgramParticipationTitleIiilep
{
    #region "IProgramParticipationTitleIiilep Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProgramParticipationTitleIiiLep"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The ProgramParticipationTitleIiiLep property is obsolete and will be removed in a later version")]
    [ForeignKey("ProgramParticipationTitleIiiLep")]
    public Guid ProgramParticipationTitleIiiLepId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiiaccountability"/> model
    /// </summary>
    [ForeignKey("RefTitleIiiaccountability")]
    public Guid? RefTitleIiiaccountabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiilanguageInstructionProgramType"/> model
    /// </summary>
    [ForeignKey("RefTitleIiilanguageInstructionProgramType")]
    public Guid? RefTitleIiilanguageInstructionProgramTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefTitleIiiaccountability"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTitleIiiaccountabilityEntity RefTitleIiiaccountabilityEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefTitleIiilanguageInstructionProgramType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTitleIiilanguageInstructionProgramTypeEntity RefTitleIiilanguageInstructionProgramTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual PersonProgramParticipationEntity PersonProgramParticipationEntity { get; set; }

    #endregion
}
