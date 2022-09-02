//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildServiceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElchildService file
/// </summary>
public partial class ElchildServiceViewModel : ObservableValidator, IElchildService
{
    #region "ElchildServiceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElchildServiceViewModel Constructor
    /// </summary>
    public ElchildServiceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElchildServiceViewModelConstruction();
    }

    /// <summary>
    /// ElchildServiceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElchildServiceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElchildService";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the Eceapeligibility property
    private Boolean? eceapeligibility;

    // member variable for the EligibilityPriorityPoints property
    private System.String eligibilityPriorityPoints;

    // member variable for the ServiceDate property
    private DateTime? serviceDate;

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

    #region "IElchildService Properties"
    public Boolean? Eceapeligibility { get => eceapeligibility; set => SetProperty(ref eceapeligibility, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EligibilityPriorityPoints { get => eligibilityPriorityPoints; set => SetProperty(ref eligibilityPriorityPoints, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesOffered"/> model
    /// </summary>
    public Guid? RefEarlyChildhoodServicesOfferedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesReceived"/> model
    /// </summary>
    public Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElserviceType"/> model
    /// </summary>
    public Guid? RefElserviceTypeId { get; set; }

    public DateTime? ServiceDate { get => serviceDate; set => SetProperty(ref serviceDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElchildService model)
    {
        IsBusy = true;
        Id = model.Id;
        Eceapeligibility = model.Eceapeligibility; // 
        EligibilityPriorityPoints = model.EligibilityPriorityPoints; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefEarlyChildhoodServicesOfferedId = model.RefEarlyChildhoodServicesOfferedId; // 
        RefEarlyChildhoodServicesReceivedId = model.RefEarlyChildhoodServicesReceivedId; // 
        RefElserviceTypeId = model.RefElserviceTypeId; // 
        ServiceDate = model.ServiceDate; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
