//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProgramParticipationWioaViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationWioa file
/// </summary>
public partial class ProgramParticipationWioaViewModel : ObservableValidator, IProgramParticipationWioa
{
    #region "ProgramParticipationWioaViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProgramParticipationWioaViewModel Constructor
    /// </summary>
    public ProgramParticipationWioaViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProgramParticipationWioaViewModelConstruction();
    }

    /// <summary>
    /// ProgramParticipationWioaViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProgramParticipationWioaViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProgramParticipationWioa";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the ProgramParticipationWioaid property
    private System.Int32 programParticipationWioaid;

    // member variable for the WioacareerServices property
    private Boolean? wioacareerServices;

    // member variable for the WioatrainingServices property
    private Boolean? wioatrainingServices;

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

    #region "IProgramParticipationWioa Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 ProgramParticipationWioaid { get => programParticipationWioaid; set => SetProperty(ref programParticipationWioaid, value, true); }

    public Boolean? WioacareerServices { get => wioacareerServices; set => SetProperty(ref wioacareerServices, value, false); }

    public Boolean? WioatrainingServices { get => wioatrainingServices; set => SetProperty(ref wioatrainingServices, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProgramParticipationWioa model)
    {
        IsBusy = true;
        Id = model.Id;
        PersonProgramParticipationId = model.PersonProgramParticipationId; // 
        ProgramParticipationWioaid = model.ProgramParticipationWioaid; // 
        WioacareerServices = model.WioacareerServices; // 
        WioatrainingServices = model.WioatrainingServices; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
