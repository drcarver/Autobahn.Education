//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElqualityRatingImprovementViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IElqualityRatingImprovement file
/// </summary>
public partial class ElqualityRatingImprovementViewModel : ObservableValidator, IElqualityRatingImprovement
{
    #region "ElqualityRatingImprovementViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ElqualityRatingImprovementViewModel Constructor
    /// </summary>
    public ElqualityRatingImprovementViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnElqualityRatingImprovementViewModelConstruction();
    }

    /// <summary>
    /// ElqualityRatingImprovementViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnElqualityRatingImprovementViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ElqualityRatingImprovement";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the NumberQrisLevels property
    private Int32? numberQrisLevels;

    // member variable for the QrisAwardDate property
    private DateTime? qrisAwardDate;

    // member variable for the QrisexpirationDate property
    private DateTime? qrisexpirationDate;

    // member variable for the QrisScore property
    private System.String qrisScore;

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

    #region "IElqualityRatingImprovement Properties"
    public Int32? NumberQrisLevels { get => numberQrisLevels; set => SetProperty(ref numberQrisLevels, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    public DateTime? QrisAwardDate { get => qrisAwardDate; set => SetProperty(ref qrisAwardDate, value, false); }

    public DateTime? QrisexpirationDate { get => qrisexpirationDate; set => SetProperty(ref qrisexpirationDate, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(45,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String QrisScore { get => qrisScore; set => SetProperty(ref qrisScore, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefQrisParticipation"/> model
    /// </summary>
    public Guid? RefQrisParticipationId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IElqualityRatingImprovement model)
    {
        IsBusy = true;
        Id = model.Id;
        NumberQrisLevels = model.NumberQrisLevels; // 
        OrganizationId = model.OrganizationId; // 
        QrisAwardDate = model.QrisAwardDate; // 
        QrisexpirationDate = model.QrisexpirationDate; // 
        QrisScore = model.QrisScore; // 
        RefQrisParticipationId = model.RefQrisParticipationId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
