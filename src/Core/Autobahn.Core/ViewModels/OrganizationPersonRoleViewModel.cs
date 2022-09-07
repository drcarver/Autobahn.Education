//**********************************************************
//* DomainName: Autobahn.Core.
//* FileName:   OrganizationPersonRoleViewModel.cs
//***************************************************************************

/// <summary>
/// The relation role a person plays in an organization and the 
/// dates of the relation ship is active
/// </summary>
public partial class OrganizationPersonRoleViewModel : ObservableValidator, IOrganizationPersonRole
{
    #region "OrganizationPersonRoleViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider serviceProvider;

    /// <summary>
    /// OrganizationPersonRoleViewModel Constructor
    /// </summary>
    public OrganizationPersonRoleViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationPersonRoleViewModelConstruction();
    }

    /// <summary>
    /// OrganizationPersonRoleViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationPersonRoleViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Organization Person Role";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // EntryDate -- (backing property for Activity Involvement Begin Date)
    private DateTime? entryDate;

    // ExitDate -- (backing property for Activity Involvement End Date)
    private DateTime? exitDate;

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
    [Key]
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

    #region "IOrganizationPersonRole Properties"
    /// <summary>
    /// Activity Involvement Begin Date
    /// <para>
    /// The year, month and day on which the person began to participate in the activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19007">Activity Involvement Begin Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Activity Involvement Begin Date")]
    public DateTime? EntryDate { get => entryDate; set => SetProperty(ref entryDate, value, false); }

    /// <summary>
    /// Activity Involvement End Date
    /// <para>
    /// The year, month and day on which the person ceased to participate in the activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19008">Activity Involvement End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Activity Involvement End Date")]
    public DateTime? ExitDate { get => exitDate; set => SetProperty(ref exitDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="EntityBase"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRole"/> model
    /// </summary>
    public Guid RoleId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationPersonRole model)
    {
        IsBusy = true;
        Id = model.Id;
        EntryDate = model.EntryDate; // Activity Involvement Begin Date
        ExitDate = model.ExitDate; // Activity Involvement End Date
        OrganizationId = model.OrganizationId; // 
        PersonId = model.PersonId; // 
        RoleId = model.RoleId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
