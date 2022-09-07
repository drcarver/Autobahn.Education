//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildHealthEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildHealth file
/// </summary>
[Table("ElchildHealth", Schema = "EarlyLearning")]
public partial class ElchildHealthEntity : EntityBase, IElchildHealth
{
    #region "IElchildHealth Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScheduledWellChildScreening"/> model
    /// </summary>
    [ForeignKey("RefScheduledWellChildScreening")]
    public Guid? RefScheduledWellChildScreeningId { get; set; }

    public DateTime? WellChildScreeningReceivedDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefScheduledWellChildScreening"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefScheduledWellChildScreeningEntity? RefScheduledWellChildScreeningEntity { get; set; }

    #endregion
}
