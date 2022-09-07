//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationPopulationServedViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPopulationServed file
/// </summary>
public partial class OrganizationPopulationServedViewModel : ObservableValidator, IOrganizationPopulationServed
{
    #region "OrganizationPopulationServedViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationPopulationServedViewModel Constructor
    /// </summary>
    public OrganizationPopulationServedViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationPopulationServedViewModelConstruction();
    }

    /// <summary>
    /// OrganizationPopulationServedViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationPopulationServedViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationPopulationServed";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the AgeUnit property
    private System.String ageUnit;

    // OldestAgeServed -- (backing property for Early Learning Oldest Age Authorized to Serve)
    private Int32? oldestAgeServed;

    // YoungestAgeServed -- (backing property for Early Learning Youngest Age Authorized to Serve)
    private Int32? youngestAgeServed;

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

    #region "IOrganizationPopulationServed Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(10,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AgeUnit { get => ageUnit; set => SetProperty(ref ageUnit, value, true); }

    /// <summary>
    /// Early Learning Oldest Age Authorized to Serve
    /// <para>
    /// The oldest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20189">Early Learning Oldest Age Authorized to Serve</a>
    /// </para>
    /// </summary>
    [DisplayName("Early Learning Oldest Age Authorized to Serve")]
    public Int32? OldestAgeServed { get => oldestAgeServed; set => SetProperty(ref oldestAgeServed, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Special Circumstances Population Served
    /// <para>
    /// Program provides services to meet the needs of children in special circumstances.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19852">Special Circumstances Population Served</a>
    /// </para>
    /// </summary>
    [DisplayName("Special Circumstances Population Served")]
    public Guid? RefPopulationServedId { get; set; }

    /// <summary>
    /// Early Learning Youngest Age Authorized to Serve
    /// <para>
    /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19626">Early Learning Youngest Age Authorized to Serve</a>
    /// </para>
    /// </summary>
    [DisplayName("Early Learning Youngest Age Authorized to Serve")]
    public Int32? YoungestAgeServed { get => youngestAgeServed; set => SetProperty(ref youngestAgeServed, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationPopulationServed model)
    {
        IsBusy = true;
        Id = model.Id;
        AgeUnit = model.AgeUnit; // 
        OldestAgeServed = model.OldestAgeServed; // Early Learning Oldest Age Authorized to Serve
        OrganizationId = model.OrganizationId; // 
        RefPopulationServedId = model.RefPopulationServedId; // Special Circumstances Population Served
        YoungestAgeServed = model.YoungestAgeServed; // Early Learning Youngest Age Authorized to Serve
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
