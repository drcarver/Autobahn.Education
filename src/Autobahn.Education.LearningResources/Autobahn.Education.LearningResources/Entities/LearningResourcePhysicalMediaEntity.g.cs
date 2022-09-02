//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediaEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourcePhysicalMedia file
/// </summary>
[Table("LearningResourcePhysicalMedia", Schema = "LearningResources")]
public partial class LearningResourcePhysicalMediaEntity : EntityBase, ILearningResourcePhysicalMedia
{
    #region "ILearningResourcePhysicalMedia Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResource")]
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Learning Resource Physical Media Type
    /// <para>
    /// A type of physical media on which the Learning Resource is delivered or available.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20370">Learning Resource Physical Media Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefLearningResourcePhysicalMediaType")]
    [Comment("A type of physical media on which the Learning Resource is delivered or available.")]
    public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> implementation
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual LearningResourceEntity LearningResourceEntity { get; set; }

    /// <summary>
    /// A type of physical media on which the Learning Resource is delivered or available.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20370">Learning Resource Physical Media Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual RefLearningResourcePhysicalMediaTypeEntity RefLearningResourcePhysicalMediaTypeEntity { get; set; }

    #endregion
}
