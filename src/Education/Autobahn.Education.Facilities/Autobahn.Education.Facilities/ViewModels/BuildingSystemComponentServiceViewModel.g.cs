//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentServiceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSystemComponentService file
/// </summary>
public partial class BuildingSystemComponentServiceViewModel : ObservableValidator, IBuildingSystemComponentService
{
    #region "BuildingSystemComponentServiceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// BuildingSystemComponentServiceViewModel Constructor
    /// </summary>
    public BuildingSystemComponentServiceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnBuildingSystemComponentServiceViewModelConstruction();
    }

    /// <summary>
    /// BuildingSystemComponentServiceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnBuildingSystemComponentServiceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from BuildingSystemComponentService";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ComponentOrFixtureScheduledServicedDate -- (backing property for Component or Fixture Scheduled Serviced Date)
    private DateTime? componentOrFixtureScheduledServicedDate;

    // ComponentOrFixtureServicedDate -- (backing property for Component or Fixture Serviced Date)
    private DateTime? componentOrFixtureServicedDate;

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

    #region "IBuildingSystemComponentService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
    /// </summary>
    public Guid BuildingSystemComponentId { get; set; }

    /// <summary>
    /// Component or Fixture Scheduled Serviced Date
    /// <para>
    /// The month, day, and year a major component, system, equipment, or fixture is scheduled to be serviced for preventive or routine maintenance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20881">Component or Fixture Scheduled Serviced Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Component or Fixture Scheduled Serviced Date")]
    public DateTime? ComponentOrFixtureScheduledServicedDate { get => componentOrFixtureScheduledServicedDate; set => SetProperty(ref componentOrFixtureScheduledServicedDate, value, false); }

    /// <summary>
    /// Component or Fixture Serviced Date
    /// <para>
    /// The month, day, and year a system, component, equipment, or fixture was serviced for repair or routine maintenance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20880">Component or Fixture Serviced Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Component or Fixture Serviced Date")]
    public DateTime? ComponentOrFixtureServicedDate { get => componentOrFixtureServicedDate; set => SetProperty(ref componentOrFixtureServicedDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IBuildingSystemComponentService model)
    {
        IsBusy = true;
        Id = model.Id;
        BuildingSystemComponentId = model.BuildingSystemComponentId; // 
        ComponentOrFixtureScheduledServicedDate = model.ComponentOrFixtureScheduledServicedDate; // Component or Fixture Scheduled Serviced Date
        ComponentOrFixtureServicedDate = model.ComponentOrFixtureServicedDate; // Component or Fixture Serviced Date
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
