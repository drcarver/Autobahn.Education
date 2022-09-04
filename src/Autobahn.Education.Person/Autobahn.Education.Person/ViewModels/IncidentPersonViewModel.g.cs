//***************************************************************************
//* DomainName: Person Models
//* FileName:   IncidentPersonViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIncidentPerson file
/// </summary>
public partial class IncidentPersonViewModel : ObservableValidator, IIncidentPerson
{
    #region "IncidentPersonViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IncidentPersonViewModel Constructor
    /// </summary>
    public IncidentPersonViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIncidentPersonViewModelConstruction();
    }

    /// <summary>
    /// IncidentPersonViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIncidentPersonViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from IncidentPerson";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Identifier -- (backing property for Incident Perpetrator Identifier)
    private System.String identifier;

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

    #region "IIncidentPerson Properties"
    /// <summary>
    /// Incident Perpetrator Identifier
    /// <para>
    /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20338">Incident Perpetrator Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Perpetrator Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIncident"/> model
    /// </summary>
    public Guid IncidentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Incident Person Role Type
    /// <para>
    /// The role or type of participation of a person in a discipline incident.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20341">Incident Person Role Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Person Role Type")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefIncidentPersonRoleTypeId { get; set; }

    /// <summary>
    /// Incident Perpetrator Type
    /// <para>
    /// Information on the type of individual who committed an incident. A "perpetrator" is an individual involved in an incident as an offender (the person who committed the infraction constituting the incident).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20340">Incident Perpetrator Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Incident Perpetrator Type")]
    public Guid? RefIncidentPersonTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIncidentPerson model)
    {
        IsBusy = true;
        Id = model.Id;
        Identifier = model.Identifier; // Incident Perpetrator Identifier
        IncidentId = model.IncidentId; // 
        PersonId = model.PersonId; // 
        RefIncidentPersonRoleTypeId = model.RefIncidentPersonRoleTypeId; // Incident Person Role Type
        RefIncidentPersonTypeId = model.RefIncidentPersonTypeId; // Incident Perpetrator Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
