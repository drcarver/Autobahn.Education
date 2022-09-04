//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   LocationAddressEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILocationAddress file
/// </summary>
public partial class LocationAddressModel : AutobahnBaseModel, ILocationAddress
{
    #region "ILocationAddress Properties"
    /// <summary>
    /// Address Apartment Room or Suite Number
    /// <para>
    /// The apartment, room, or suite number of an address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19019">Address Apartment Room or Suite Number</a>
    /// </para>
    /// </summary>
    public System.String ApartmentRoomOrSuiteNumber { get; set; }

    /// <summary>
    /// Building Site Number
    /// <para>
    /// The number of the building on the site, if more than one building shares the same address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19595">Building Site Number</a>
    /// </para>
    /// </summary>
    public System.String BuildingSiteNumber { get; set; }

    /// <summary>
    /// Address City
    /// <para>
    /// The name of the city in which an address is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19040">Address City</a>
    /// </para>
    /// </summary>
    public System.String City { get; set; }

    /// <summary>
    /// Address County Name
    /// <para>
    /// The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19190">Address County Name</a>
    /// </para>
    /// </summary>
    public System.String CountyName { get; set; }

    /// <summary>
    /// Do Not Publish Indicator
    /// <para>
    /// An indication that the record should not be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? DoNotPublishIndicator { get; set; }

    /// <summary>
    /// Facility Block Number Area
    /// <para>
    /// The informal description of location sometimes used in rural areas, for example, "from the highway to the railroad tracks."
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20755">Facility Block Number Area</a>
    /// </para>
    /// </summary>
    public System.String FacilityBlockNumberArea { get; set; }

    /// <summary>
    /// Facility Census Tract
    /// <para>
    /// The census tract number of the school site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20760">Facility Census Tract</a>
    /// </para>
    /// </summary>
    public System.String FacilityCensusTract { get; set; }

    /// <summary>
    /// Latitude
    /// <para>
    /// The north or south angular distance from the equator that, when combined with longitude, reflects an estimation of where the address is physically situated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19599">Latitude</a>
    /// </para>
    /// </summary>
    public System.String Latitude { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    public Guid LocationId { get; set; }

    /// <summary>
    /// Longitude
    /// <para>
    /// The east or west angular distance from the prime meridian that, when combined with latitude, reflects an estimation of where the address is physically situated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19600">Longitude</a>
    /// </para>
    /// </summary>
    public System.String Longitude { get; set; }

    /// <summary>
    /// Address Postal Code
    /// <para>
    /// A number that identifies each postal delivery area in the United States used as a portion of an address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19214">Address Postal Code</a>
    /// </para>
    /// </summary>
    public System.String PostalCode { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCountry"/> model
    /// </summary>
    public Guid? RefCountryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCounty"/> model
    /// </summary>
    public Guid? RefCountyId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefErsruralUrbanContinuumCode"/> model
    /// </summary>
    public Guid? RefErsruralUrbanContinuumCodeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefState"/> model
    /// </summary>
    public Guid? RefStateId { get; set; }

    /// <summary>
    /// Address Street Number and Name
    /// <para>
    /// The street number and street name or post office box number of an address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19269">Address Street Number and Name</a>
    /// </para>
    /// </summary>
    public System.String StreetNumberAndName { get; set; }

    #endregion
}
