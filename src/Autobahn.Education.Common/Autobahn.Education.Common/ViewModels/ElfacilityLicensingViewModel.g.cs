//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElfacilityLicensingViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElfacilityLicensing file
/// </summary>
public partial class ElfacilityLicensingViewModel : ObservableValidator, IElfacilityLicensing
{
    #region "ElfacilityLicensingViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElfacilityLicensingViewModel Constructor
    /// </summary>
    public ElfacilityLicensingViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElfacilityLicensingViewModelConstruction();
    }

    /// <summary>
    /// ElfacilityLicensingViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElfacilityLicensingViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElfacilityLicensing";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ContinuingLicenseDate property
    private DateTime? continuingLicenseDate;

    // member variable for the InitialLicensingDate property
    private DateTime? initialLicensingDate;

    // member variable for the StateLicensedFacilityCapacity property
    private Int32? stateLicensedFacilityCapacity;

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

    #region "IElfacilityLicensing Properties"
    public DateTime? ContinuingLicenseDate { get => continuingLicenseDate; set => SetProperty(ref continuingLicenseDate, value, false); }

    public DateTime? InitialLicensingDate { get => initialLicensingDate; set => SetProperty(ref initialLicensingDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfacilityLicensingStatus"/> model
    /// </summary>
    public Guid? RefElfacilityLicensingStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
    /// </summary>
    public Guid? RefLicenseExemptId { get; set; }

    public Int32? StateLicensedFacilityCapacity { get => stateLicensedFacilityCapacity; set => SetProperty(ref stateLicensedFacilityCapacity, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElfacilityLicensing model)
    {
        IsBusy = true;
        Id = model.Id;
        ContinuingLicenseDate = model.ContinuingLicenseDate; // 
        InitialLicensingDate = model.InitialLicensingDate; // 
        OrganizationId = model.OrganizationId; // 
        RefElfacilityLicensingStatusId = model.RefElfacilityLicensingStatusId; // 
        RefLicenseExemptId = model.RefLicenseExemptId; // 
        StateLicensedFacilityCapacity = model.StateLicensedFacilityCapacity; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
