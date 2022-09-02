//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildOutcomeSummaryViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElchildOutcomeSummary file
/// </summary>
public partial class ElchildOutcomeSummaryViewModel : ObservableValidator, IElchildOutcomeSummary
{
    #region "ElchildOutcomeSummaryViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElchildOutcomeSummaryViewModel Constructor
    /// </summary>
    public ElchildOutcomeSummaryViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElchildOutcomeSummaryViewModelConstruction();
    }

    /// <summary>
    /// ElchildOutcomeSummaryViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElchildOutcomeSummaryViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElchildOutcomeSummary";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the CosprogressAindicator property
    private Boolean? cosprogressAindicator;

    // member variable for the CosprogressBindicator property
    private Boolean? cosprogressBindicator;

    // member variable for the CosprogressCindicator property
    private Boolean? cosprogressCindicator;

    // member variable for the CosratingAid property
    private Int32? cosratingAid;

    // member variable for the CosratingBid property
    private Int32? cosratingBid;

    // member variable for the CosratingCid property
    private Int32? cosratingCid;

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

    #region "IElchildOutcomeSummary Properties"
    public Boolean? CosprogressAindicator { get => cosprogressAindicator; set => SetProperty(ref cosprogressAindicator, value, false); }

    public Boolean? CosprogressBindicator { get => cosprogressBindicator; set => SetProperty(ref cosprogressBindicator, value, false); }

    public Boolean? CosprogressCindicator { get => cosprogressCindicator; set => SetProperty(ref cosprogressCindicator, value, false); }

    public Int32? CosratingAid { get => cosratingAid; set => SetProperty(ref cosratingAid, value, false); }

    public Int32? CosratingBid { get => cosratingBid; set => SetProperty(ref cosratingBid, value, false); }

    public Int32? CosratingCid { get => cosratingCid; set => SetProperty(ref cosratingCid, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElchildOutcomeSummary model)
    {
        IsBusy = true;
        Id = model.Id;
        CosprogressAindicator = model.CosprogressAindicator; // 
        CosprogressBindicator = model.CosprogressBindicator; // 
        CosprogressCindicator = model.CosprogressCindicator; // 
        CosratingAid = model.CosratingAid; // 
        CosratingBid = model.CosratingBid; // 
        CosratingCid = model.CosratingCid; // 
        PersonId = model.PersonId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
