//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentActivityViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentActivity file
/// </summary>
public partial class K12studentActivityViewModel : ObservableValidator, IK12studentActivity
{
    #region "K12studentActivityViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12studentActivityViewModel Constructor
    /// </summary>
    public K12studentActivityViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12studentActivityViewModelConstruction();
    }

    /// <summary>
    /// K12studentActivityViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12studentActivityViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12studentActivity";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ActivityTimeInvolved property
    private Decimal? activityTimeInvolved;

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

    #region "IK12studentActivity Properties"
    public Decimal? ActivityTimeInvolved { get => activityTimeInvolved; set => SetProperty(ref activityTimeInvolved, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefActivityTimeMeasurementType"/> model
    /// </summary>
    public Guid? RefActivityTimeMeasurementTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12studentActivity model)
    {
        IsBusy = true;
        Id = model.Id;
        ActivityTimeInvolved = model.ActivityTimeInvolved; // 
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefActivityTimeMeasurementTypeId = model.RefActivityTimeMeasurementTypeId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
