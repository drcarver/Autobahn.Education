//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   PeerRatingSystemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPeerRatingSystem file
/// </summary>
[Table("PeerRatingSystem", Schema = "LearningResources")]
public partial class PeerRatingSystemEntity : EntityBase, IPeerRatingSystem
{
    #region "IPeerRatingSystem Properties"
    /// <summary>
    /// Peer Rating System Maximum Value
    /// <para>
    ///  The maximum value allowed by the Peer Rating System.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20162">Peer Rating System Maximum Value</a>
    /// </para>
    /// </summary>
    [Comment(" The maximum value allowed by the Peer Rating System.")]
    public Decimal? MaximumValue { get; set; }

    /// <summary>
    /// Peer Rating System Minimum Value
    /// <para>
    /// The minimum value allowed by the Peer Rating System.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20163">Peer Rating System Minimum Value</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The minimum value allowed by the Peer Rating System.")]
    public System.Decimal MinimumValue { get; set; }

    /// <summary>
    /// Peer Rating System Name
    /// <para>
    /// The name of the scaling system used to specify the Peer Rating.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20160">Peer Rating System Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the scaling system used to specify the Peer Rating.")]
    public System.String Name { get; set; }

    /// <summary>
    /// Peer Rating System Optimum Value
    /// <para>
    /// The optimum value allowed by the Peer Rating System.  The optimum or best rating may be the maximum value, the minimum value, or something in between.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20164">Peer Rating System Optimum Value</a>
    /// </para>
    /// </summary>
    [Comment("The optimum value allowed by the Peer Rating System.  The optimum or best rating may be the maximum value, the minimum value, or something in between.")]
    public Decimal? OptimumValue { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
