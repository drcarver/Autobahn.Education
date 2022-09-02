//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAddress file
/// </summary>
[Table("PersonAddress", Schema = "Common")]
public partial class PersonAddressEntity : EntityBase, IPersonAddress
{
    #region "IPersonAddress Properties"
    /// <summary>
    /// Address County Name
    /// <para>
    /// The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19190">Address County Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the county, parish, borough, or comparable unit (within a state) in which an address is located.")]
    public System.String AddressCountyName { get; set; }

    /// <summary>
    /// Address Apartment Room or Suite Number
    /// <para>
    /// The apartment, room, or suite number of an address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19019">Address Apartment Room or Suite Number</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The apartment, room, or suite number of an address.")]
    public System.String ApartmentRoomOrSuiteNumber { get; set; }

    /// <summary>
    /// Address City
    /// <para>
    /// The name of the city in which an address is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19040">Address City</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the city in which an address is located.")]
    public System.String City { get; set; }

    /// <summary>
    /// Do Not Publish Indicator
    /// <para>
    /// An indication that the record should not be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
    /// </para>
    /// </summary>
    [Comment("An indication that the record should not be published.")]
    public Boolean? DoNotPublishIndicator { get; set; }

    /// <summary>
    /// Latitude
    /// <para>
    /// The north or south angular distance from the equator that, when combined with longitude, reflects an estimation of where the address is physically situated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19599">Latitude</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The north or south angular distance from the equator that, when combined with longitude, reflects an estimation of where the address is physically situated.")]
    public System.String Latitude { get; set; }

    /// <summary>
    /// Longitude
    /// <para>
    /// The east or west angular distance from the prime meridian that, when combined with latitude, reflects an estimation of where the address is physically situated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19600">Longitude</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The east or west angular distance from the prime meridian that, when combined with latitude, reflects an estimation of where the address is physically situated.")]
    public System.String Longitude { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Address Postal Code
    /// <para>
    /// A number that identifies each postal delivery area in the United States used as a portion of an address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19214">Address Postal Code</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(17,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A number that identifies each postal delivery area in the United States used as a portion of an address.")]
    public System.String PostalCode { get; set; }

    /// <summary>
    /// Country Code
    /// <para>
    /// The unique two character International Organization for Standardization (ISO) code for the country in which an address is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19050">Country Code</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCountry")]
    [Comment("The unique two character International Organization for Standardization (ISO) code for the country in which an address is located.")]
    public Guid? RefCountryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCounty"/> model
    /// </summary>
    [ForeignKey("RefCounty")]
    public Guid? RefCountyId { get; set; }

    /// <summary>
    /// Personal Information Verification
    /// <para>
    /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPersonalInformationVerification")]
    [Comment("The evidence by which a persons name, address, date of birth, etc. is confirmed.")]
    public Guid? RefPersonalInformationVerificationId { get; set; }

    /// <summary>
    /// Address Type for Learner or Family
    /// <para>
    /// The type of address listed for a learner or a parent, guardian, family member or related person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19358">Address Type for Learner or Family</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefPersonLocationType")]
    [Comment("The type of address listed for a learner or a parent, guardian, family member or related person.")]
    public Guid RefPersonLocationTypeId { get; set; }

    /// <summary>
    /// State Abbreviation
    /// <para>
    /// The abbreviation for the state (within the United States) or outlying area in which an address is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19267">State Abbreviation</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefState")]
    [Comment("The abbreviation for the state (within the United States) or outlying area in which an address is located.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(150,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The street number and street name or post office box number of an address.")]
    public System.String StreetNumberAndName { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The type of address listed for a learner or a parent, guardian, family member or related person.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19358">Address Type for Learner or Family</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefPersonLocationTypeEntity RefPersonLocationTypeEntity { get; set; }

    /// <summary>
    /// The abbreviation for the state (within the United States) or outlying area in which an address is located.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19267">State Abbreviation</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefStateEntity RefStateEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCounty"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCountyEntity RefCountyEntity { get; set; }

    /// <summary>
    /// The unique two character International Organization for Standardization (ISO) code for the country in which an address is located.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19050">Country Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCountryEntity RefCountryEntity { get; set; }

    /// <summary>
    /// The evidence by which a persons name, address, date of birth, etc. is confirmed.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefPersonalInformationVerificationEntity RefPersonalInformationVerificationEntity { get; set; }

    #endregion
}
