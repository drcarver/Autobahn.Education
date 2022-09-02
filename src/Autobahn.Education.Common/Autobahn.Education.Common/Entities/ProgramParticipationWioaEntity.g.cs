//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationWioaEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationWioa file
/// </summary>
[Table("ProgramParticipationWioa", Schema = "Common")]
public partial class ProgramParticipationWioaEntity : EntityBase, IProgramParticipationWioa
{
    #region "IProgramParticipationWioa Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
    public Guid PersonProgramParticipationId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 ProgramParticipationWioaid { get; set; }

    public Boolean? WioacareerServices { get; set; }

    public Boolean? WioatrainingServices { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual PersonProgramParticipationEntity PersonProgramParticipationEntity { get; set; }

    #endregion
}
