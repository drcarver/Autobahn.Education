//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaSafeDrugFreeViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaSafeDrugFree file
/// </summary>
public partial class K12leaSafeDrugFreeViewModel : ObservableValidator, IK12leaSafeDrugFree
{
    #region "K12leaSafeDrugFreeViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12leaSafeDrugFreeViewModel Constructor
    /// </summary>
    public K12leaSafeDrugFreeViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12leaSafeDrugFreeViewModelConstruction();
    }

    /// <summary>
    /// K12leaSafeDrugFreeViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12leaSafeDrugFreeViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12leaSafeDrugFree";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the Baseline property
    private System.String baseline;

    // member variable for the BaselineYear property
    private System.String baselineYear;

    // member variable for the CollectionFrequency property
    private System.String collectionFrequency;

    // member variable for the IndicatorName property
    private System.String indicatorName;

    // member variable for the Instrument property
    private System.String instrument;

    // member variable for the MostRecentCollection property
    private System.String mostRecentCollection;

    // member variable for the Performance property
    private System.String performance;

    // member variable for the Target property
    private System.String target;

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

    #region "IK12leaSafeDrugFree Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Baseline { get => baseline; set => SetProperty(ref baseline, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BaselineYear { get => baselineYear; set => SetProperty(ref baselineYear, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CollectionFrequency { get => collectionFrequency; set => SetProperty(ref collectionFrequency, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IndicatorName { get => indicatorName; set => SetProperty(ref indicatorName, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Instrument { get => instrument; set => SetProperty(ref instrument, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    public Guid K12leaId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MostRecentCollection { get => mostRecentCollection; set => SetProperty(ref mostRecentCollection, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Performance { get => performance; set => SetProperty(ref performance, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Target { get => target; set => SetProperty(ref target, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12leaSafeDrugFree model)
    {
        IsBusy = true;
        Id = model.Id;
        Baseline = model.Baseline; // 
        BaselineYear = model.BaselineYear; // 
        CollectionFrequency = model.CollectionFrequency; // 
        IndicatorName = model.IndicatorName; // 
        Instrument = model.Instrument; // 
        K12leaId = model.K12leaId; // 
        MostRecentCollection = model.MostRecentCollection; // 
        Performance = model.Performance; // 
        Target = model.Target; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
