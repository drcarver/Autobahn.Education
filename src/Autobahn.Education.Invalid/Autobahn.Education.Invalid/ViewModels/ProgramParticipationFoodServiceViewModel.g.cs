//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProgramParticipationFoodServiceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationFoodService file
/// </summary>
public partial class ProgramParticipationFoodServiceViewModel : ObservableValidator, IProgramParticipationFoodService
{
    #region "ProgramParticipationFoodServiceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProgramParticipationFoodServiceViewModel Constructor
    /// </summary>
    public ProgramParticipationFoodServiceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProgramParticipationFoodServiceViewModelConstruction();
    }

    /// <summary>
    /// ProgramParticipationFoodServiceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProgramParticipationFoodServiceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProgramParticipationFoodService";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

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

    #region "IProgramParticipationFoodService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Participation in School Food Service Programs
    /// <para>
    /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19325">Participation in School Food Service Programs</a>
    /// </para>
    /// </summary>
    [DisplayName("Participation in School Food Service Programs")]
    [Required(ErrorMessage="{0} is required.")]
    public Guid RefSchoolFoodServiceProgramId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProgramParticipationFoodService model)
    {
        IsBusy = true;
        Id = model.Id;
        PersonProgramParticipationId = model.PersonProgramParticipationId; // 
        RefSchoolFoodServiceProgramId = model.RefSchoolFoodServiceProgramId; // Participation in School Food Service Programs
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
