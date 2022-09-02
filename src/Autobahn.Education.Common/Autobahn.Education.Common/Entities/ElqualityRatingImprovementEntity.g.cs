//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElqualityRatingImprovementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElqualityRatingImprovement file
/// </summary>
[Table("ElqualityRatingImprovement", Schema = "Common")]
public partial class ElqualityRatingImprovementEntity : EntityBase, IElqualityRatingImprovement
{
    #region "IElqualityRatingImprovement Properties"
    public Int32? NumberQrisLevels { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    public DateTime? QrisAwardDate { get; set; }

    public DateTime? QrisexpirationDate { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(45,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String QrisScore { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefQrisParticipation"/> model
    /// </summary>
    [ForeignKey("RefQrisParticipation")]
    public Guid? RefQrisParticipationId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefQrisParticipation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefQrisParticipationEntity RefQrisParticipationEntity { get; set; }

    #endregion
}
