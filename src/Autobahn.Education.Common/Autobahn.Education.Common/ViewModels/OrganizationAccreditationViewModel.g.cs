//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationAccreditationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationAccreditation file
/// </summary>
public partial class OrganizationAccreditationViewModel : ObservableValidator, IOrganizationAccreditation
{
    #region "OrganizationAccreditationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationAccreditationViewModel Constructor
    /// </summary>
    public OrganizationAccreditationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationAccreditationViewModelConstruction();
    }

    /// <summary>
    /// OrganizationAccreditationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationAccreditationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationAccreditation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AccreditationAgencyName -- (backing property for Accreditation Agency Name)
    private System.String accreditationAgencyName;

    // AccreditationAwardDate -- (backing property for Accreditation Award Date)
    private DateTime? accreditationAwardDate;

    // AccreditationExpirationDate -- (backing property for Accreditation Expiration Date)
    private DateTime? accreditationExpirationDate;

    // member variable for the AccreditationStatus property
    private Boolean? accreditationStatus;

    // SeekingAccreditationDate -- (backing property for Organization Seeking Accreditation Date)
    private DateTime? seekingAccreditationDate;

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

    #region "IOrganizationAccreditation Properties"
    /// <summary>
    /// Accreditation Agency Name
    /// <para>
    /// The full name of an agency that accredited a school.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Accreditation Agency Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AccreditationAgencyName { get => accreditationAgencyName; set => SetProperty(ref accreditationAgencyName, value, true); }

    /// <summary>
    /// Accreditation Award Date
    /// <para>
    /// The year, month and day when an accreditation was awarded.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19840">Accreditation Award Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Accreditation Award Date")]
    public DateTime? AccreditationAwardDate { get => accreditationAwardDate; set => SetProperty(ref accreditationAwardDate, value, false); }

    /// <summary>
    /// Accreditation Expiration Date
    /// <para>
    /// The year, month and day when an accreditation expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19841">Accreditation Expiration Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Accreditation Expiration Date")]
    public DateTime? AccreditationExpirationDate { get => accreditationExpirationDate; set => SetProperty(ref accreditationExpirationDate, value, false); }

    public Boolean? AccreditationStatus { get => accreditationStatus; set => SetProperty(ref accreditationStatus, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Accreditation Agency
    /// <para>
    /// The agency that accredited a program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19983">Accreditation Agency</a>
    /// </para>
    /// </summary>
    [DisplayName("Accreditation Agency")]
    public Guid? RefAccreditationAgencyId { get; set; }

    /// <summary>
    /// Higher Education Institution Accreditation Status
    /// <para>
    /// An indication of the accreditation status of a higher education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19817">Higher Education Institution Accreditation Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Higher Education Institution Accreditation Status")]
    public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    /// <summary>
    /// Organization Seeking Accreditation Date
    /// <para>
    /// The date in which accreditation process was started (but not officially approved or denied)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20388">Organization Seeking Accreditation Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Organization Seeking Accreditation Date")]
    public DateTime? SeekingAccreditationDate { get => seekingAccreditationDate; set => SetProperty(ref seekingAccreditationDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationAccreditation model)
    {
        IsBusy = true;
        Id = model.Id;
        AccreditationAgencyName = model.AccreditationAgencyName; // Accreditation Agency Name
        AccreditationAwardDate = model.AccreditationAwardDate; // Accreditation Award Date
        AccreditationExpirationDate = model.AccreditationExpirationDate; // Accreditation Expiration Date
        AccreditationStatus = model.AccreditationStatus; // 
        OrganizationId = model.OrganizationId; // 
        RefAccreditationAgencyId = model.RefAccreditationAgencyId; // Accreditation Agency
        RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId; // Higher Education Institution Accreditation Status
        SeekingAccreditationDate = model.SeekingAccreditationDate; // Organization Seeking Accreditation Date
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
