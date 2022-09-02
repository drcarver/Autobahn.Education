//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationOperationalStatusViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationOperationalStatus file
/// </summary>
public partial class OrganizationOperationalStatusViewModel : ObservableValidator, IOrganizationOperationalStatus
{
    #region "OrganizationOperationalStatusViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationOperationalStatusViewModel Constructor
    /// </summary>
    public OrganizationOperationalStatusViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationOperationalStatusViewModelConstruction();
    }

    /// <summary>
    /// OrganizationOperationalStatusViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationOperationalStatusViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationOperationalStatus";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // OperationalStatusEffectiveDate -- (backing property for Operation Date)
    private DateTime? operationalStatusEffectiveDate;

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

    #region "IOrganizationOperationalStatus Properties"
    /// <summary>
    /// Operation Date
    /// <para>
    /// The year, month and day on which a program or center began operation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19350">Operation Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Operation Date")]
    public DateTime? OperationalStatusEffectiveDate { get => operationalStatusEffectiveDate; set => SetProperty(ref operationalStatusEffectiveDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Local Education Agency Operational Status
    /// <para>
    /// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19174">Local Education Agency Operational Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Local Education Agency Operational Status")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefOperationalStatusId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationOperationalStatus model)
    {
        IsBusy = true;
        Id = model.Id;
        OperationalStatusEffectiveDate = model.OperationalStatusEffectiveDate; // Operation Date
        OrganizationId = model.OrganizationId; // 
        RefOperationalStatusId = model.RefOperationalStatusId; // Local Education Agency Operational Status
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
