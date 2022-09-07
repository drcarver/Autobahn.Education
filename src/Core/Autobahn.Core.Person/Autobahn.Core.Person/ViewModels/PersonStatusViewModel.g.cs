//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonStatusViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonStatus file
/// </summary>
public partial class PersonStatusViewModel : ObservableValidator, IPersonStatus
{
    #region "PersonStatusViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonStatusViewModel Constructor
    /// </summary>
    public PersonStatusViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonStatusViewModelConstruction();
    }

    /// <summary>
    /// PersonStatusViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonStatusViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonStatus";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // StatusEndDate -- (backing property for Status End Date)
    private DateTime? statusEndDate;

    // StatusStartDate -- (backing property for Status Start Date)
    private DateTime? statusStartDate;

    // member variable for the StatusValue property
    private System.Boolean statusValue;

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

    #region "IPersonStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Economic Disadvantage Status
    /// <para>
    /// An indication that the student met the State criteria for classification as having an economic disadvantage.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19086">Economic Disadvantage Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Economic Disadvantage Status")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefPersonStatusTypeId { get; set; }

    /// <summary>
    /// Status End Date
    /// <para>
    /// The last year, month and day when a status applied to an individual.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20193">Status End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Status End Date")]
    public DateTime? StatusEndDate { get => statusEndDate; set => SetProperty(ref statusEndDate, value, false); }

    /// <summary>
    /// Status Start Date
    /// <para>
    /// The year, month and day that a status became applicable to an individual.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20192">Status Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Status Start Date")]
    public DateTime? StatusStartDate { get => statusStartDate; set => SetProperty(ref statusStartDate, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    public System.Boolean StatusValue { get => statusValue; set => SetProperty(ref statusValue, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonStatus model)
    {
        IsBusy = true;
        Id = model.Id;
        PersonId = model.PersonId; // 
        RefPersonStatusTypeId = model.RefPersonStatusTypeId; // Economic Disadvantage Status
        StatusEndDate = model.StatusEndDate; // Status End Date
        StatusStartDate = model.StatusStartDate; // Status Start Date
        StatusValue = model.StatusValue; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
