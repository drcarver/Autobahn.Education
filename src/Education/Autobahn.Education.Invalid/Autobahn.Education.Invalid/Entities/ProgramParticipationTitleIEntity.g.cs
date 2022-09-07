//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProgramParticipationTitleIEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationTitleI file
/// </summary>
[Table("ProgramParticipationTitleI", Schema = "Invalid")]
public partial class ProgramParticipationTitleIEntity : EntityBase, IProgramParticipationTitleI
{
    #region "IProgramParticipationTitleI Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
    public Guid PersonProgramParticipationId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 ProgramParticipationTitleIid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIindicator"/> model
    /// </summary>
    [ForeignKey("RefTitleIindicator")]
    public Guid? RefTitleIindicatorId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual PersonProgramParticipationEntity PersonProgramParticipationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefTitleIindicator"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefTitleIindicatorEntity? RefTitleIindicatorEntity { get; set; }

    #endregion
}
