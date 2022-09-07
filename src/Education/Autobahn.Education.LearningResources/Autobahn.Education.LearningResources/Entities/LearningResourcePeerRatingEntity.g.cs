//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePeerRatingEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourcePeerRating file
/// </summary>
[Table("LearningResourcePeerRating", Schema = "LearningResources")]
public partial class LearningResourcePeerRatingEntity : EntityBase, ILearningResourcePeerRating
{
    #region "ILearningResourcePeerRating Properties"
    /// <summary>
    /// Peer Rating Date
    /// <para>
    /// The date on which the Peer Rating was entered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20171">Peer Rating Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the Peer Rating was entered.")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResource")]
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPeerRatingSystem"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PeerRatingSystem")]
    public Guid PeerRatingSystemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Learning Resource Peer Rating Value
    /// <para>
    /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20161">Learning Resource Peer Rating Value</a>
    /// </para>
    /// </summary>
    [Comment("An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.")]
    public Decimal? Value { get; set; }

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
    /// Reference to an optional instance of the <see cref="IPeerRatingSystem"/> implementation
    /// <remarks>
    /// This entity is in the LearningResources domain
    /// </remarks>
    /// </summary>
    public virtual PeerRatingSystemEntity PeerRatingSystemEntity { get; set; }

    #endregion
}
