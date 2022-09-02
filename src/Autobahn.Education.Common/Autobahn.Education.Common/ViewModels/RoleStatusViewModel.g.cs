//***************************************************************************
//* DomainName: Common Models
//* FileName:   RoleStatusViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IRoleStatus file
/// </summary>
public partial class RoleStatusViewModel : ObservableValidator, IRoleStatus
{
    #region "RoleStatusViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// RoleStatusViewModel Constructor
    /// </summary>
    public RoleStatusViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnRoleStatusViewModelConstruction();
    }

    /// <summary>
    /// RoleStatusViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnRoleStatusViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from RoleStatus";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // StatusEndDate -- (backing property for Employment End Date)
    private DateTime? statusEndDate;

    // StatusStartDate -- (backing property for Employment Start Date)
    private System.DateTime statusStartDate;

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

    #region "IRoleStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Enrollment Status
    /// <para>
    /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19094">Enrollment Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Enrollment Status")]
    public Guid? RefRoleStatusId { get; set; }

    /// <summary>
    /// Employment End Date
    /// <para>
    /// The year, month and day on which a person ended self-employment or employment with an organization or institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19794">Employment End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Employment End Date")]
    public DateTime? StatusEndDate { get => statusEndDate; set => SetProperty(ref statusEndDate, value, false); }

    /// <summary>
    /// Employment Start Date
    /// <para>
    /// The year, month and day on which a person began self-employment or employment with an organization or institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19345">Employment Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Employment Start Date")]
    [Required(ErrorMessage="{0} is required.")]
    public System.DateTime StatusStartDate { get => statusStartDate; set => SetProperty(ref statusStartDate, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IRoleStatus model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefRoleStatusId = model.RefRoleStatusId; // Enrollment Status
        StatusEndDate = model.StatusEndDate; // Employment End Date
        StatusStartDate = model.StatusStartDate; // Employment Start Date
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
