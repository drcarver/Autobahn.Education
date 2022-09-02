//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilitySite file
/// </summary>
[Table("FacilitySite", Schema = "Facilities")]
public partial class FacilitySiteEntity : EntityBase, IFacilitySite
{
    #region "IFacilitySite Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
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
    [Comment("The total number of acres in a continuous piece of land, to the nearest tenth, including undeveloped areas as well as areas occupied by buildings, walks, drives, parking facilities, and other improvements.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The lot and square number, or equivalent unique municipal number identification, of a parcel of land.")]
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
    [ForeignKey("RefBuildingSiteUseRestrictionsType")]
    [Comment("A characterization of a site that would define restrictions or opportunities.")]
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
    [ForeignKey("RefFacilitySiteOutdoorAreaType")]
    [Comment("The designated constructed outdoor area on a public school site.")]
    public Guid? RefFacilitySiteOutdoorAreaTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityEntity FacilityEntity { get; set; }

    /// <summary>
    /// A characterization of a site that would define restrictions or opportunities.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20841">Building Site Use Restrictions Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingSiteUseRestrictionsTypeEntity RefBuildingSiteUseRestrictionsTypeEntity { get; set; }

    /// <summary>
    /// The designated constructed outdoor area on a public school site.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20811">Facility Site Outdoor Area Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilitySiteOutdoorAreaTypeEntity RefFacilitySiteOutdoorAreaTypeEntity { get; set; }

    #endregion
}
