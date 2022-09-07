//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   AuthorizationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The Authorization View Model
/// </summary>
public partial class AuthorizationViewModel : ObservableValidator, IAuthorization
{
    #region "AuthorizationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider serviceProvider;

    /// <summary>
    /// AuthorizationViewModel Constructor
    /// </summary>
    public AuthorizationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAuthorizationViewModelConstruction();
    }

    /// <summary>
    /// AuthorizationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAuthorizationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Authorization";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ApplicationRoleName -- (backing property for Authorization Application Role Name)
    private System.String applicationRoleName;

    // EndDate -- (backing property for Authorization End Date)
    private DateTime? endDate;

    // StartDate -- (backing property for Authorization Start Date)
    private DateTime? startDate;

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

    #region "IAuthorization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IApplication"/> model
    /// </summary>
    public Guid AutobahnApplicationId { get; set; }

    /// <summary>
    /// Authorization Application Role Name
    /// <para>
    /// The user role for which the person is allowed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20129">Authorization Application Role Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Authorization Application Role Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ApplicationRoleName { get => applicationRoleName; set => SetProperty(ref applicationRoleName, value, true); }

    /// <summary>
    /// Authorization End Date
    /// <para>
    /// The date after which the  an associated person is no longer allowed to use the application with the specified role.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20131">Authorization End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Authorization End Date")]
    public DateTime? EndDate { get => endDate; set => SetProperty(ref endDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Authorization Start Date
    /// <para>
    /// The date on which the  an associated person  is authorized to start using the application with the specified role.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20130">Authorization Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Authorization Start Date")]
    public DateTime? StartDate { get => startDate; set => SetProperty(ref startDate, value, false); }
    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAuthorization model)
    {
        IsBusy = true;
        Id = model.Id;
        AutobahnApplicationId = model.AutobahnApplicationId; // 
        ApplicationRoleName = model.ApplicationRoleName; // Authorization Application Role Name
        EndDate = model.EndDate; // Authorization End Date
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        StartDate = model.StartDate; // Authorization Start Date
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
