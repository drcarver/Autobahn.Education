//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationIndicatorViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationIndicator file
/// </summary>
public partial class OrganizationIndicatorViewModel : ObservableValidator, IOrganizationIndicator
{
    #region "OrganizationIndicatorViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationIndicatorViewModel Constructor
    /// </summary>
    public OrganizationIndicatorViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationIndicatorViewModelConstruction();
    }

    /// <summary>
    /// OrganizationIndicatorViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationIndicatorViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationIndicator";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the IndicatorValue property
    private System.String indicatorValue;

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

    #region "IOrganizationIndicator Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IndicatorValue { get => indicatorValue; set => SetProperty(ref indicatorValue, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Ability Grouping Status
    /// <para>
    /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19000">Ability Grouping Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Ability Grouping Status")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefOrganizationIndicatorId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationIndicator model)
    {
        IsBusy = true;
        Id = model.Id;
        IndicatorValue = model.IndicatorValue; // 
        OrganizationId = model.OrganizationId; // 
        RefOrganizationIndicatorId = model.RefOrganizationIndicatorId; // Ability Grouping Status
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
