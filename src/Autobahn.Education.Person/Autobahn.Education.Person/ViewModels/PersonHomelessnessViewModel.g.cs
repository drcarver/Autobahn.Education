//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonHomelessnessViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonHomelessness file
/// </summary>
public partial class PersonHomelessnessViewModel : ObservableValidator, IPersonHomelessness
{
    #region "PersonHomelessnessViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonHomelessnessViewModel Constructor
    /// </summary>
    public PersonHomelessnessViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonHomelessnessViewModelConstruction();
    }

    /// <summary>
    /// PersonHomelessnessViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonHomelessnessViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonHomelessness";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // HomelessnessStatus -- (backing property for Homelessness Status)
    private System.Boolean homelessnessStatus;

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

    #region "IPersonHomelessness Properties"
    /// <summary>
    /// Homelessness Status
    /// <para>
    /// Children and youth who lack a fixed, regular, and adequate nighttime residence. Homeless children and youth include: 1) children and youth who are sharing the housing of other persons due to loss of housing, economic hardship, or a similar reason; are living in motels, hotels, trailer parks, or camping grounds due to the lack of alternative adequate accommodations; are living in emergency or transitional shelters; are abandoned in hospitals; or are awaiting foster care placement; 2) children and youth who have a primary nighttime residence that is a public or private place not designed for or originally used as a regular sleeping accommodation for human beings; or 3) children and youths who are living in cars, parks, public spaces, abandoned buildings, substandard housing, bus or train stations, or similar settings. 4) migratory children who qualify as homeless because the children are living in circumstances described in the above. (See Section 103 of the McKinney Act for a more detailed description of this data element).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19149">Homelessness Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Homelessness Status")]
    [Required(ErrorMessage="{0} is required.")]
    public System.Boolean HomelessnessStatus { get => homelessnessStatus; set => SetProperty(ref homelessnessStatus, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Homeless Primary Nighttime Residence
    /// <para>
    /// The primary nighttime residence of the person at the time the person was identified as homeless.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19146">Homeless Primary Nighttime Residence</a>
    /// </para>
    /// </summary>
    [DisplayName("Homeless Primary Nighttime Residence")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefHomelessNighttimeResidenceId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonHomelessness model)
    {
        IsBusy = true;
        Id = model.Id;
        HomelessnessStatus = model.HomelessnessStatus; // Homelessness Status
        PersonId = model.PersonId; // 
        RefHomelessNighttimeResidenceId = model.RefHomelessNighttimeResidenceId; // Homeless Primary Nighttime Residence
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
