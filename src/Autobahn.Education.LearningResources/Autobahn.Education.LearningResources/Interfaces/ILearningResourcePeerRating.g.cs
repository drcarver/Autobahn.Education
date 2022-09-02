//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   ILearningResourcePeerRating.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourcePeerRating file
/// </summary>
public partial interface ILearningResourcePeerRating
{
    #region "ILearningResourcePeerRating Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Peer Rating Date
    /// <para>
    /// The date on which the Peer Rating was entered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20171">Peer Rating Date</a>
    /// </para>
    /// </summary>
    DateTime? Date { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    Guid LearningResourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPeerRatingSystem"/> model
    /// </summary>
    Guid PeerRatingSystemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Learning Resource Peer Rating Value
    /// <para>
    /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20161">Learning Resource Peer Rating Value</a>
    /// </para>
    /// </summary>
    Decimal? Value { get; set; }

    #endregion
}
