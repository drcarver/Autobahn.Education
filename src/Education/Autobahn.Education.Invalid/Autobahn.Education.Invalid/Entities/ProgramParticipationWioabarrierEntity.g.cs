//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProgramParticipationWioabarrierEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationWioabarrier file
/// </summary>
[Table("ProgramParticipationWioabarrier", Schema = "Invalid")]
public partial class ProgramParticipationWioabarrierEntity : EntityBase, IProgramParticipationWioabarrier
{
    #region "IProgramParticipationWioabarrier Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProgramParticipationWioabarriers"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ProgramParticipationWioabarriers")]
    public Guid ProgramParticipationWioabarriersId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 ProgramParticipationWioaid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWioabarrierstoEmployment"/> model
    /// </summary>
    [ForeignKey("RefWioabarrierstoEmployment")]
    public Guid? RefWioabarrierstoEmploymentId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefWioabarrierstoEmployment"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefWioabarrierstoEmploymentEntity? RefWioabarrierstoEmploymentEntity { get; set; }

    #endregion
}
