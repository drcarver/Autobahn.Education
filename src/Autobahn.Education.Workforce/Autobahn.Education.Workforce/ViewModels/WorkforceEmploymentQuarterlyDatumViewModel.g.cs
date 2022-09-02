//***************************************************************************
//* DomainName: Workforce
//* FileName:   WorkforceEmploymentQuarterlyDatumViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IWorkforceEmploymentQuarterlyDatum file
/// </summary>
public partial class WorkforceEmploymentQuarterlyDatumViewModel : ObservableValidator, IWorkforceEmploymentQuarterlyDatum
{
    #region "WorkforceEmploymentQuarterlyDatumViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// WorkforceEmploymentQuarterlyDatumViewModel Constructor
    /// </summary>
    public WorkforceEmploymentQuarterlyDatumViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnWorkforceEmploymentQuarterlyDatumViewModelConstruction();
    }

    /// <summary>
    /// WorkforceEmploymentQuarterlyDatumViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnWorkforceEmploymentQuarterlyDatumViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from WorkforceEmploymentQuarterlyDatum";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the EmployedInMultipleJobsCount property
    private Decimal? employedInMultipleJobsCount;

    // member variable for the MilitaryEnlistmentAfterExit property
    private Boolean? militaryEnlistmentAfterExit;

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

    #region "IWorkforceEmploymentQuarterlyDatum Properties"
    public Decimal? EmployedInMultipleJobsCount { get => employedInMultipleJobsCount; set => SetProperty(ref employedInMultipleJobsCount, value, false); }

    public Boolean? MilitaryEnlistmentAfterExit { get => militaryEnlistmentAfterExit; set => SetProperty(ref militaryEnlistmentAfterExit, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
    /// </summary>
    public Guid? RefEmployedAfterExitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
    /// </summary>
    public Guid? RefEmployedWhileEnrolledId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IWorkforceEmploymentQuarterlyData"/> model
    /// </summary>
    public Guid WorkforceEmploymentQuarterlyDataId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IWorkforceEmploymentQuarterlyDatum model)
    {
        IsBusy = true;
        Id = model.Id;
        EmployedInMultipleJobsCount = model.EmployedInMultipleJobsCount; // 
        MilitaryEnlistmentAfterExit = model.MilitaryEnlistmentAfterExit; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefEmployedAfterExitId = model.RefEmployedAfterExitId; // 
        RefEmployedWhileEnrolledId = model.RefEmployedWhileEnrolledId; // 
        WorkforceEmploymentQuarterlyDataId = model.WorkforceEmploymentQuarterlyDataId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
