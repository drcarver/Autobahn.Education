//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationIdentifierViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationIdentifier file
/// </summary>
public partial class OrganizationIdentifierViewModel : ObservableValidator, IOrganizationIdentifier
{
    #region "OrganizationIdentifierViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationIdentifierViewModel Constructor
    /// </summary>
    public OrganizationIdentifierViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationIdentifierViewModelConstruction();
    }

    /// <summary>
    /// OrganizationIdentifierViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationIdentifierViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationIdentifier";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Identifier -- (backing property for Course Identifier)
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

    #region "IOrganizationIdentifier Properties"
    /// <summary>
    /// Course Identifier
    /// <para>
    /// The actual code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19055">Course Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Course Code System
    /// <para>
    /// A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19056">Course Code System</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Code System")]
    public Guid? RefOrganizationIdentificationSystemId { get; set; }

    /// <summary>
    /// Activity Identifier
    /// <para>
    /// A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19006">Activity Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Activity Identifier")]
    public Guid? RefOrganizationIdentifierTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationIdentifier model)
    {
        IsBusy = true;
        Id = model.Id;
        Identifier = model.Identifier; // Course Identifier
        OrganizationId = model.OrganizationId; // 
        RefOrganizationIdentificationSystemId = model.RefOrganizationIdentificationSystemId; // Course Code System
        RefOrganizationIdentifierTypeId = model.RefOrganizationIdentifierTypeId; // Activity Identifier
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
