//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediumEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourcePhysicalMedium file
/// </summary>
[Table("LearningResourcePhysicalMedium", Schema = "LearningResources")]
public partial class LearningResourcePhysicalMediumEntity : EntityBase, ILearningResourcePhysicalMedium
{
    #region "ILearningResourcePhysicalMedium Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResource")]
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResourcePhysicalMedia"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResourcePhysicalMedia")]
    public Guid LearningResourcePhysicalMediaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefLearningResourcePhysicalMediaType")]
    public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResourcePhysicalMedia"/> implementation
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual LearningResourcePhysicalMediaEntity LearningResourcePhysicalMediaEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> implementation
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual LearningResourceEntity LearningResourceEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefLearningResourcePhysicalMediaType"/> implementation
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourcePhysicalMediaTypeEntity RefLearningResourcePhysicalMediaTypeEntity { get; set; }

    #endregion
}
