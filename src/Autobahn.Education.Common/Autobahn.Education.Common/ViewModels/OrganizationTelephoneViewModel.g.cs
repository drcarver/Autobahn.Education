//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTelephoneViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationTelephone file
/// </summary>
public partial class OrganizationTelephoneViewModel : ObservableValidator, IOrganizationTelephone
{
    #region "OrganizationTelephoneViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationTelephoneViewModel Constructor
    /// </summary>
    public OrganizationTelephoneViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationTelephoneViewModelConstruction();
    }

    /// <summary>
    /// OrganizationTelephoneViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationTelephoneViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationTelephone";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // DoNotPublishIndicator -- (backing property for Do Not Publish Indicator)
    private Boolean? doNotPublishIndicator;

    // PrimaryTelephoneNumberIndicator -- (backing property for Primary Telephone Number Indicator)
    private System.Boolean primaryTelephoneNumberIndicator;

    // TelephoneNumber -- (backing property for Telephone Number)
    private System.String telephoneNumber;

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

    #region "IOrganizationTelephone Properties"
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
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Primary Telephone Number Indicator
    /// <para>
    /// An indication that the telephone number should be used as the principal number for a person or organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19219">Primary Telephone Number Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Primary Telephone Number Indicator")]
    [Required(ErrorMessage="{0} is required.")]
    public System.Boolean PrimaryTelephoneNumberIndicator { get => primaryTelephoneNumberIndicator; set => SetProperty(ref primaryTelephoneNumberIndicator, value, true); }

    /// <summary>
    /// Institution Telephone Number Type
    /// <para>
    /// The type of communication number listed for an organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19167">Institution Telephone Number Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Institution Telephone Number Type")]
    public Guid? RefInstitutionTelephoneTypeId { get; set; }

    /// <summary>
    /// Telephone Number Listed Status
    /// <para>
    /// An indication of whether a telephone number is listed under a directory assistance service.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20911">Telephone Number Listed Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Telephone Number Listed Status")]
    public Guid? RefTelephoneNumberListedStatusId { get; set; }

    /// <summary>
    /// Telephone Number
    /// <para>
    /// The telephone number including the area code, and extension, if applicable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19279">Telephone Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Telephone Number")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(24,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TelephoneNumber { get => telephoneNumber; set => SetProperty(ref telephoneNumber, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationTelephone model)
    {
        IsBusy = true;
        Id = model.Id;
        DoNotPublishIndicator = model.DoNotPublishIndicator; // Do Not Publish Indicator
        OrganizationId = model.OrganizationId; // 
        PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator; // Primary Telephone Number Indicator
        RefInstitutionTelephoneTypeId = model.RefInstitutionTelephoneTypeId; // Institution Telephone Number Type
        RefTelephoneNumberListedStatusId = model.RefTelephoneNumberListedStatusId; // Telephone Number Listed Status
        TelephoneNumber = model.TelephoneNumber; // Telephone Number
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
