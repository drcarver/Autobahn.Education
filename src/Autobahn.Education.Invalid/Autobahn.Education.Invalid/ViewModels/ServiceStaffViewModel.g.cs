//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ServiceStaffViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IServiceStaff file
/// </summary>
public partial class ServiceStaffViewModel : ObservableValidator, IServiceStaff
{
    #region "ServiceStaffViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ServiceStaffViewModel Constructor
    /// </summary>
    public ServiceStaffViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnServiceStaffViewModelConstruction();
    }

    /// <summary>
    /// ServiceStaffViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnServiceStaffViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ServiceStaff";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

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

    #region "IServiceStaff Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Special Education Support Services Category
    /// <para>
    /// Titles of personnel employed and contracted to provide special education and related services for children with disabilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19549">Special Education Support Services Category</a>
    /// </para>
    /// </summary>
    [DisplayName("Special Education Support Services Category")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefSpecialEducationStaffCategoryId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IServiceStaff model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefSpecialEducationStaffCategoryId = model.RefSpecialEducationStaffCategoryId; // Special Education Support Services Category
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
