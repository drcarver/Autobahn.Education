//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAddress file
/// </summary>
public partial class PersonAddressViewModel : ObservableValidator, IPersonAddress
{
    #region "PersonAddressViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonAddressViewModel Constructor
    /// </summary>
    public PersonAddressViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonAddressViewModelConstruction();
    }

    /// <summary>
    /// PersonAddressViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonAddressViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonAddress";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AddressCountyName -- (backing property for Address County Name)
    private System.String addressCountyName;

    // ApartmentRoomOrSuiteNumber -- (backing property for Address Apartment Room or Suite Number)
    private System.String apartmentRoomOrSuiteNumber;

    // City -- (backing property for Address City)
    private System.String city;

    // DoNotPublishIndicator -- (backing property for Do Not Publish Indicator)
    private Boolean? doNotPublishIndicator;

    // Latitude -- (backing property for Latitude)
    private System.String latitude;

    // Longitude -- (backing property for Longitude)
    private System.String longitude;

    // PostalCode -- (backing property for Address Postal Code)
    private System.String postalCode;

    // StreetNumberAndName -- (backing property for Address Street Number and Name)
    private System.String streetNumberAndName;

    #endregion

    #region "IAutobahnBase Properties"
    /// <summary>
    /// The title of the View Model
    /// </summary>
    public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

    /// <summary>
    /// The IsNew property is set if the view model has been created but not saved to the database
    /// </summary>
    public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

    /// <summary>
    /// The IsDeleted property is set if the view model is to be delted from the database
    /// </summary>
    public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

    /// <summary>
    /// The primary key of the view model
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The view model is changed and needs to be save to the database.
    /// </summary>
    public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

    /// <summary>
    /// The view model is performing a long running task
    /// </summary>
    public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

    /// <summary>
    /// The view model's changes have been save so update its tracking properties
    /// </summary>
    public void AcceptChanges()
    {
        IsNew = false;
        IsChanged = false;
    }
    #endregion

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
    [DisplayName("Address County Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AddressCountyName { get => addressCountyName; set => SetProperty(ref addressCountyName, value, true); }

    /// <summary>
    /// Address Apartment Room or Suite Number
    /// <para>
    /// The apartment, room, or suite number of an address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19019">Address Apartment Room or Suite Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Address Apartment Room or Suite Number")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ApartmentRoomOrSuiteNumber { get => apartmentRoomOrSuiteNumber; set => SetProperty(ref apartmentRoomOrSuiteNumber, value, true); }

    /// <summary>
    /// Address City
    /// <para>
    /// The name of the city in which an address is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19040">Address City</a>
    /// </para>
    /// </summary>
    [DisplayName("Address City")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String City { get => city; set => SetProperty(ref city, value, true); }

    /// <summary>
    /// Do Not Publish Indicator
    /// <para>
    /// An indication that the record should not be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Do Not Publish Indicator")]
    public Boolean? DoNotPublishIndicator { get => doNotPublishIndicator; set => SetProperty(ref doNotPublishIndicator, value, false); }

    /// <summary>
    /// Latitude
    /// <para>
    /// The north or south angular distance from the equator that, when combined with longitude, reflects an estimation of where the address is physically situated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19599">Latitude</a>
    /// </para>
    /// </summary>
    [DisplayName("Latitude")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Latitude { get => latitude; set => SetProperty(ref latitude, value, true); }

    /// <summary>
    /// Longitude
    /// <para>
    /// The east or west angular distance from the prime meridian that, when combined with latitude, reflects an estimation of where the address is physically situated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19600">Longitude</a>
    /// </para>
    /// </summary>
    [DisplayName("Longitude")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Longitude { get => longitude; set => SetProperty(ref longitude, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
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
    [DisplayName("Address Postal Code")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(17,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String PostalCode { get => postalCode; set => SetProperty(ref postalCode, value, true); }

    /// <summary>
    /// Country Code
    /// <para>
    /// The unique two character International Organization for Standardization (ISO) code for the country in which an address is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19050">Country Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Country Code")]
    public Guid? RefCountryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCounty"/> model
    /// </summary>
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
    [DisplayName("Personal Information Verification")]
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
    [DisplayName("Address Type for Learner or Family")]
    [Required(ErrorMessage="{0} is required.")]
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
    [DisplayName("State Abbreviation")]
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
    [DisplayName("Address Street Number and Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(150,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String StreetNumberAndName { get => streetNumberAndName; set => SetProperty(ref streetNumberAndName, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonAddress model)
    {
        IsBusy = true;
        Id = model.Id;
        AddressCountyName = model.AddressCountyName; // Address County Name
        ApartmentRoomOrSuiteNumber = model.ApartmentRoomOrSuiteNumber; // Address Apartment Room or Suite Number
        City = model.City; // Address City
        DoNotPublishIndicator = model.DoNotPublishIndicator; // Do Not Publish Indicator
        Latitude = model.Latitude; // Latitude
        Longitude = model.Longitude; // Longitude
        PersonId = model.PersonId; // 
        PostalCode = model.PostalCode; // Address Postal Code
        RefCountryId = model.RefCountryId; // Country Code
        RefCountyId = model.RefCountyId; // 
        RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId; // Personal Information Verification
        RefPersonLocationTypeId = model.RefPersonLocationTypeId; // Address Type for Learner or Family
        RefStateId = model.RefStateId; // State Abbreviation
        StreetNumberAndName = model.StreetNumberAndName; // Address Street Number and Name
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
