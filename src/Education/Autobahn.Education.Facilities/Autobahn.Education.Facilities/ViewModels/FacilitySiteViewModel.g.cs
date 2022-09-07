//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFacilitySite file
/// </summary>
public partial class FacilitySiteViewModel : ObservableValidator, IFacilitySite
{
    #region "FacilitySiteViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FacilitySiteViewModel Constructor
    /// </summary>
    public FacilitySiteViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFacilitySiteViewModelConstruction();
    }

    /// <summary>
    /// FacilitySiteViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFacilitySiteViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FacilitySite";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FacilitySiteArea -- (backing property for Facility Site Area)
    private Decimal? facilitySiteArea;

    // FacilitySiteIdentifier -- (backing property for Facility Site Identifier)
    private System.String facilitySiteIdentifier;

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
    [DisplayName("Facility Site Area")]
    public Decimal? FacilitySiteArea { get => facilitySiteArea; set => SetProperty(ref facilitySiteArea, value, false); }

    /// <summary>
    /// Facility Site Identifier
    /// <para>
    /// The lot and square number, or equivalent unique municipal number identification, of a parcel of land.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20767">Facility Site Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Facility Site Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FacilitySiteIdentifier { get => facilitySiteIdentifier; set => SetProperty(ref facilitySiteIdentifier, value, true); }

    /// <summary>
    /// Building Site Use Restrictions Type
    /// <para>
    /// A characterization of a site that would define restrictions or opportunities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20841">Building Site Use Restrictions Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Building Site Use Restrictions Type")]
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
    [DisplayName("Facility Site Outdoor Area Type")]
    public Guid? RefFacilitySiteOutdoorAreaTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFacilitySite model)
    {
        IsBusy = true;
        Id = model.Id;
        FacilityId = model.FacilityId; // 
        FacilitySiteArea = model.FacilitySiteArea; // Facility Site Area
        FacilitySiteIdentifier = model.FacilitySiteIdentifier; // Facility Site Identifier
        RefBuildingSiteUseRestrictionsTypeId = model.RefBuildingSiteUseRestrictionsTypeId; // Building Site Use Restrictions Type
        RefFacilitySiteOutdoorAreaTypeId = model.RefFacilitySiteOutdoorAreaTypeId; // Facility Site Outdoor Area Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
