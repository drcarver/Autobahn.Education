//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaPreKeligibleAgesIdeaEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaPreKeligibleAgesIdea file
/// </summary>
[Table("K12leaPreKeligibleAgesIdea", Schema = "K12")]
public partial class K12leaPreKeligibleAgesIdeaEntity : EntityBase, IK12leaPreKeligibleAgesIdea
{
    #region "IK12leaPreKeligibleAgesIdea Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12lea")]
    public Guid K12leaId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 K12leapreKeligibleAgesIdeaid { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 RefPreKeligibleAgesNonIdeaid { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual K12leaEntity K12leaEntity { get; set; }

    #endregion
}
