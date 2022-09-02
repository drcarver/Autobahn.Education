//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   PeerRatingSystemViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPeerRatingSystem file
/// </summary>
public partial class PeerRatingSystemViewModel : ObservableValidator, IPeerRatingSystem
{
    #region "PeerRatingSystemViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PeerRatingSystemViewModel Constructor
    /// </summary>
    public PeerRatingSystemViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPeerRatingSystemViewModelConstruction();
    }

    /// <summary>
    /// PeerRatingSystemViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPeerRatingSystemViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PeerRatingSystem";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // MaximumValue -- (backing property for Peer Rating System Maximum Value)
    private Decimal? maximumValue;

    // MinimumValue -- (backing property for Peer Rating System Minimum Value)
    private System.Decimal minimumValue;

    // Name -- (backing property for Peer Rating System Name)
    private System.String name;

    // OptimumValue -- (backing property for Peer Rating System Optimum Value)
    private Decimal? optimumValue;

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

    #region "IPeerRatingSystem Properties"
    /// <summary>
    /// Peer Rating System Maximum Value
    /// <para>
    ///  The maximum value allowed by the Peer Rating System.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20162">Peer Rating System Maximum Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Peer Rating System Maximum Value")]
    public Decimal? MaximumValue { get => maximumValue; set => SetProperty(ref maximumValue, value, false); }

    /// <summary>
    /// Peer Rating System Minimum Value
    /// <para>
    /// The minimum value allowed by the Peer Rating System.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20163">Peer Rating System Minimum Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Peer Rating System Minimum Value")]
    [Required(ErrorMessage="{0} is required.")]
    public System.Decimal MinimumValue { get => minimumValue; set => SetProperty(ref minimumValue, value, true); }

    /// <summary>
    /// Peer Rating System Name
    /// <para>
    /// The name of the scaling system used to specify the Peer Rating.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20160">Peer Rating System Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Peer Rating System Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get => name; set => SetProperty(ref name, value, true); }

    /// <summary>
    /// Peer Rating System Optimum Value
    /// <para>
    /// The optimum value allowed by the Peer Rating System.  The optimum or best rating may be the maximum value, the minimum value, or something in between.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20164">Peer Rating System Optimum Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Peer Rating System Optimum Value")]
    public Decimal? OptimumValue { get => optimumValue; set => SetProperty(ref optimumValue, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPeerRatingSystem model)
    {
        IsBusy = true;
        Id = model.Id;
        MaximumValue = model.MaximumValue; // Peer Rating System Maximum Value
        MinimumValue = model.MinimumValue; // Peer Rating System Minimum Value
        Name = model.Name; // Peer Rating System Name
        OptimumValue = model.OptimumValue; // Peer Rating System Optimum Value
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
