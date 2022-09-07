//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IdsversionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIdsversion file
/// </summary>
public partial class IdsversionViewModel : ObservableValidator, IIdsversion
{
    #region "IdsversionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IdsversionViewModel Constructor
    /// </summary>
    public IdsversionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIdsversionViewModelConstruction();
    }

    /// <summary>
    /// IdsversionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIdsversionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Idsversion";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the CurrentVersion property
    private System.Boolean currentVersion;

    // member variable for the IdsversionDate property
    private System.DateTime idsversionDate;

    // member variable for the IdsversionNumber property
    private System.String idsversionNumber;

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

    #region "IIdsversion Properties"
    [Required(ErrorMessage="{0} is required.")]
    public System.Boolean CurrentVersion { get => currentVersion; set => SetProperty(ref currentVersion, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    public System.DateTime IdsversionDate { get => idsversionDate; set => SetProperty(ref idsversionDate, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(10,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IdsversionNumber { get => idsversionNumber; set => SetProperty(ref idsversionNumber, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIdsversion model)
    {
        IsBusy = true;
        Id = model.Id;
        CurrentVersion = model.CurrentVersion; // 
        IdsversionDate = model.IdsversionDate; // 
        IdsversionNumber = model.IdsversionNumber; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
