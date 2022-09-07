//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ServicesReceivedViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IServicesReceived file
/// </summary>
public partial class ServicesReceivedViewModel : ObservableValidator, IServicesReceived
{
    #region "ServicesReceivedViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ServicesReceivedViewModel Constructor
    /// </summary>
    public ServicesReceivedViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnServicesReceivedViewModelConstruction();
    }

    /// <summary>
    /// ServicesReceivedViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnServicesReceivedViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ServicesReceived";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FullTimeEquivalency -- (backing property for Special Education Full Time Equivalency)
    private Decimal? fullTimeEquivalency;

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

    #region "IServicesReceived Properties"
    /// <summary>
    /// Special Education Full Time Equivalency
    /// <para>
    /// Calculated ratio of time the student is in a special education setting. Values range from 0.00 to 1.00. If the student is in a special education setting 25% of the time, the value is .25; if 100% of the time, the value is 1.00.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20208">Special Education Full Time Equivalency</a>
    /// </para>
    /// </summary>
    [DisplayName("Special Education Full Time Equivalency")]
    public Decimal? FullTimeEquivalency { get => fullTimeEquivalency; set => SetProperty(ref fullTimeEquivalency, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicePlan"/> model
    /// </summary>
    public Guid ServicePlanId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IServicesReceived model)
    {
        IsBusy = true;
        Id = model.Id;
        FullTimeEquivalency = model.FullTimeEquivalency; // Special Education Full Time Equivalency
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        ServicePlanId = model.ServicePlanId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
