//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElprogramLicensingViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElprogramLicensing file
/// </summary>
public partial class ElprogramLicensingViewModel : ObservableValidator, IElprogramLicensing
{
    #region "ElprogramLicensingViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElprogramLicensingViewModel Constructor
    /// </summary>
    public ElprogramLicensingViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElprogramLicensingViewModelConstruction();
    }

    /// <summary>
    /// ElprogramLicensingViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElprogramLicensingViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElprogramLicensing";

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

    // member variable for the InitialLicenseDate property
    private DateTime? initialLicenseDate;

    // member variable for the LicenseRevocationStatus property
    private Boolean? licenseRevocationStatus;

    // member variable for the LicenseSuspensionStatus property
    private Boolean? licenseSuspensionStatus;

    // member variable for the NumberOfFatalities property
    private Int32? numberOfFatalities;

    // member variable for the NumberOfInjuries property
    private Int32? numberOfInjuries;

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

    #region "IElprogramLicensing Properties"
    public DateTime? ContinuingLicenseDate { get => continuingLicenseDate; set => SetProperty(ref continuingLicenseDate, value, false); }

    public DateTime? InitialLicenseDate { get => initialLicenseDate; set => SetProperty(ref initialLicenseDate, value, false); }

    public Boolean? LicenseRevocationStatus { get => licenseRevocationStatus; set => SetProperty(ref licenseRevocationStatus, value, false); }

    public Boolean? LicenseSuspensionStatus { get => licenseSuspensionStatus; set => SetProperty(ref licenseSuspensionStatus, value, false); }

    public Int32? NumberOfFatalities { get => numberOfFatalities; set => SetProperty(ref numberOfFatalities, value, false); }

    public Int32? NumberOfInjuries { get => numberOfInjuries; set => SetProperty(ref numberOfInjuries, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprogramLicenseStatus"/> model
    /// </summary>
    public Guid? RefElprogramLicenseStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
    /// </summary>
    public Guid? RefLicenseExemptId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElprogramLicensing model)
    {
        IsBusy = true;
        Id = model.Id;
        ContinuingLicenseDate = model.ContinuingLicenseDate; // 
        InitialLicenseDate = model.InitialLicenseDate; // 
        LicenseRevocationStatus = model.LicenseRevocationStatus; // 
        LicenseSuspensionStatus = model.LicenseSuspensionStatus; // 
        NumberOfFatalities = model.NumberOfFatalities; // 
        NumberOfInjuries = model.NumberOfInjuries; // 
        OrganizationId = model.OrganizationId; // 
        RefElprogramLicenseStatusId = model.RefElprogramLicenseStatusId; // 
        RefLicenseExemptId = model.RefLicenseExemptId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
