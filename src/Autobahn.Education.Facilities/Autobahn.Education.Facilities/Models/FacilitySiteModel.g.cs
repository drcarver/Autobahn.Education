//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilitySite file
/// </summary>
public partial class FacilitySiteModel : AutobahnBaseModel, IFacilitySite
{
    #region "IFacilitySite Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Site Area
    /// <para>
    /// The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20754">Facility Site Area</a>
    /// </para>
    /// </summary>
    public Decimal? FacilitySiteArea { get; set; }

    /// <summary>
    /// Facility Site Identifier
    /// <para>
    /// The lot and square number, or equivalent unique municipal number identification, of a parcel of land.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20767">Facility Site Identifier</a>
    /// </para>
    /// </summary>
    public System.String FacilitySiteIdentifier { get; set; }

    /// <summary>
    /// Building Site Use Restrictions Type
    /// <para>
    /// A characterization of a site that would define restrictions or opportunities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20841">Building Site Use Restrictions Type</a>
    /// </para>
    /// </summary>
    public Guid? RefBuildingSiteUseRestrictionsTypeId { get; set; }

    /// <summary>
    /// Facility Site Outdoor Area Type
    /// <para>
    /// The designated constructed outdoor area on a public school site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20811">Facility Site Outdoor Area Type</a>
    /// </para>
    /// </summary>
    public Guid? RefFacilitySiteOutdoorAreaTypeId { get; set; }

    #endregion
}
