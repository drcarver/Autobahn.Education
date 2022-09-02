//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourceAdaptation file
/// </summary>
[Table("LearningResourceAdaptation", Schema = "LearningResources")]
public partial class LearningResourceAdaptationEntity : EntityBase, ILearningResourceAdaptation
{
    #region "ILearningResourceAdaptation Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AdaptationUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResource")]
    public Guid LearningResourceId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> implementation
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual LearningResourceEntity LearningResourceEntity { get; set; }

    #endregion
}
