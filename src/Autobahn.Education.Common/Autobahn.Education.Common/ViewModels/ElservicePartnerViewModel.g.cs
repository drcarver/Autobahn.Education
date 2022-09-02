//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElservicePartnerViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElservicePartner file
/// </summary>
public partial class ElservicePartnerViewModel : ObservableValidator, IElservicePartner
{
    #region "ElservicePartnerViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElservicePartnerViewModel Constructor
    /// </summary>
    public ElservicePartnerViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElservicePartnerViewModelConstruction();
    }

    /// <summary>
    /// ElservicePartnerViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElservicePartnerViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElservicePartner";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the MemorandumOfUnderstandingEndDate property
    private DateTime? memorandumOfUnderstandingEndDate;

    // member variable for the MemorandumOfUnderstandingStartDate property
    private DateTime? memorandumOfUnderstandingStartDate;

    // member variable for the ServicePartnerDescription property
    private System.String servicePartnerDescription;

    // member variable for the ServicePartnerName property
    private System.String servicePartnerName;

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

    #region "IElservicePartner Properties"
    public DateTime? MemorandumOfUnderstandingEndDate { get => memorandumOfUnderstandingEndDate; set => SetProperty(ref memorandumOfUnderstandingEndDate, value, false); }

    public DateTime? MemorandumOfUnderstandingStartDate { get => memorandumOfUnderstandingStartDate; set => SetProperty(ref memorandumOfUnderstandingStartDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ServicePartnerDescription { get => servicePartnerDescription; set => SetProperty(ref servicePartnerDescription, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ServicePartnerName { get => servicePartnerName; set => SetProperty(ref servicePartnerName, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElservicePartner model)
    {
        IsBusy = true;
        Id = model.Id;
        MemorandumOfUnderstandingEndDate = model.MemorandumOfUnderstandingEndDate; // 
        MemorandumOfUnderstandingStartDate = model.MemorandumOfUnderstandingStartDate; // 
        OrganizationId = model.OrganizationId; // 
        ServicePartnerDescription = model.ServicePartnerDescription; // 
        ServicePartnerName = model.ServicePartnerName; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
