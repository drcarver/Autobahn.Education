//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   IPeerRatingSystem.g.cs
//***************************************************************************

/// <summary>
/// The IPeerRatingSystem file
/// </summary>
public partial interface IPeerRatingSystem
{
    #region "IPeerRatingSystem Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Peer Rating System Maximum Value
    /// <para>
    ///  The maximum value allowed by the Peer Rating System.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20162">Peer Rating System Maximum Value</a>
    /// </para>
    /// </summary>
    Decimal? MaximumValue { get; set; }

    /// <summary>
    /// Peer Rating System Minimum Value
    /// <para>
    /// The minimum value allowed by the Peer Rating System.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20163">Peer Rating System Minimum Value</a>
    /// </para>
    /// </summary>
    System.Decimal MinimumValue { get; set; }

    /// <summary>
    /// Peer Rating System Name
    /// <para>
    /// The name of the scaling system used to specify the Peer Rating.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20160">Peer Rating System Name</a>
    /// </para>
    /// </summary>
    System.String Name { get; set; }

    /// <summary>
    /// Peer Rating System Optimum Value
    /// <para>
    /// The optimum value allowed by the Peer Rating System.  The optimum or best rating may be the maximum value, the minimum value, or something in between.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20164">Peer Rating System Optimum Value</a>
    /// </para>
    /// </summary>
    Decimal? OptimumValue { get; set; }

    #endregion
}
