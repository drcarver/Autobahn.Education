//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisisViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendarCrisis file
/// </summary>
public partial class OrganizationCalendarCrisisViewModel : ObservableValidator, IOrganizationCalendarCrisis
{
    #region "OrganizationCalendarCrisisViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationCalendarCrisisViewModel Constructor
    /// </summary>
    public OrganizationCalendarCrisisViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationCalendarCrisisViewModelConstruction();
    }

    /// <summary>
    /// OrganizationCalendarCrisisViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationCalendarCrisisViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationCalendarCrisis";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CrisisDescription -- (backing property for Crisis Description)
    private System.String crisisDescription;

    // CrisisEndDate -- (backing property for Crisis End Date)
    private DateTime? crisisEndDate;

    // EndDate -- (backing property for Crisis End Date)
    private DateTime? endDate;

    // Name -- (backing property for Crisis Name)
    private System.String name;

    // StartDate -- (backing property for Crisis Start Date)
    private DateTime? startDate;

    // Type -- (backing property for Crisis Type)
    private System.String type;

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

    #region "IOrganizationCalendarCrisis Properties"
    /// <summary>
    /// Crisis Description
    /// <para>
    /// A description of the crisis that caused the displacement of students.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20526">Crisis Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Crisis Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CrisisDescription { get => crisisDescription; set => SetProperty(ref crisisDescription, value, true); }

    /// <summary>
    /// Crisis End Date
    /// <para>
    /// The date on which the crisis ceased to affect the agency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20528">Crisis End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Crisis End Date")]
    public DateTime? CrisisEndDate { get => crisisEndDate; set => SetProperty(ref crisisEndDate, value, false); }

    /// <summary>
    /// Crisis End Date
    /// <para>
    /// The date on which the crisis ceased to affect the agency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20528">Crisis End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Crisis End Date")]
    public DateTime? EndDate { get => endDate; set => SetProperty(ref endDate, value, false); }

    /// <summary>
    /// Crisis Name
    /// <para>
    /// The name of the crisis that caused the displacement of students.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19605">Crisis Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Crisis Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get => name; set => SetProperty(ref name, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Crisis Start Date
    /// <para>
    /// The year, month and day on which the crisis affected the agency. This date may not be the same as the date the crisis occurred if evacuation orders are implemented in anticipation of a crisis.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19607">Crisis Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Crisis Start Date")]
    public DateTime? StartDate { get => startDate; set => SetProperty(ref startDate, value, false); }

    /// <summary>
    /// Crisis Type
    /// <para>
    /// The type or category of crisis (ex., chemical, earthquake, flood, wildfire, etc.).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19606">Crisis Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Crisis Type")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Type { get => type; set => SetProperty(ref type, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationCalendarCrisis model)
    {
        IsBusy = true;
        Id = model.Id;
        CrisisDescription = model.CrisisDescription; // Crisis Description
        CrisisEndDate = model.CrisisEndDate; // Crisis End Date
        EndDate = model.EndDate; // Crisis End Date
        Name = model.Name; // Crisis Name
        OrganizationId = model.OrganizationId; // 
        StartDate = model.StartDate; // Crisis Start Date
        Type = model.Type; // Crisis Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
