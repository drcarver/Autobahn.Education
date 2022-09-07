//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePeerRatingViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourcePeerRating file
/// </summary>
public partial class LearningResourcePeerRatingViewModel : ObservableValidator, ILearningResourcePeerRating
{
    #region "LearningResourcePeerRatingViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// LearningResourcePeerRatingViewModel Constructor
    /// </summary>
    public LearningResourcePeerRatingViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnLearningResourcePeerRatingViewModelConstruction();
    }

    /// <summary>
    /// LearningResourcePeerRatingViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnLearningResourcePeerRatingViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from LearningResourcePeerRating";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Date -- (backing property for Peer Rating Date)
    private DateTime? date;

    // Value -- (backing property for Learning Resource Peer Rating Value)
    private Decimal? value;

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

    #region "ILearningResourcePeerRating Properties"
    /// <summary>
    /// Peer Rating Date
    /// <para>
    /// The date on which the Peer Rating was entered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20171">Peer Rating Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Peer Rating Date")]
    public DateTime? Date { get => date; set => SetProperty(ref date, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPeerRatingSystem"/> model
    /// </summary>
    public Guid PeerRatingSystemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Learning Resource Peer Rating Value
    /// <para>
    /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20161">Learning Resource Peer Rating Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Peer Rating Value")]
    public Decimal? Value { get => value; set => SetProperty(ref value, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ILearningResourcePeerRating model)
    {
        IsBusy = true;
        Id = model.Id;
        Date = model.Date; // Peer Rating Date
        LearningResourceId = model.LearningResourceId; // 
        PeerRatingSystemId = model.PeerRatingSystemId; // 
        PersonId = model.PersonId; // 
        Value = model.Value; // Learning Resource Peer Rating Value
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
