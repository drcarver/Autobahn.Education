//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonProgramParticipationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPersonProgramParticipation file
/// </summary>
public partial class PersonProgramParticipationViewModel : ObservableValidator, IPersonProgramParticipation
{
    #region "PersonProgramParticipationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PersonProgramParticipationViewModel Constructor
    /// </summary>
    public PersonProgramParticipationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPersonProgramParticipationViewModelConstruction();
    }

    /// <summary>
    /// PersonProgramParticipationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPersonProgramParticipationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PersonProgramParticipation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ParticipationStatus -- (backing property for Gifted and Talented Indicator)
    private System.String participationStatus;

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

    #region "IPersonProgramParticipation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Gifted and Talented Indicator
    /// <para>
    /// An indication that the student is participating in and served by a Gifted/Talented program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19122">Gifted and Talented Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Gifted and Talented Indicator")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ParticipationStatus { get => participationStatus; set => SetProperty(ref participationStatus, value, true); }

    /// <summary>
    /// GED Preparation Program Participation Status
    /// <para>
    /// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19120">GED Preparation Program Participation Status</a>
    /// </para>
    /// </summary>
    [DisplayName("GED Preparation Program Participation Status")]
    public Guid? RefParticipationTypeId { get; set; }

    /// <summary>
    /// Program Entry Reason
    /// <para>
    /// The documented or assumed reason a person is being served by a program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20909">Program Entry Reason</a>
    /// </para>
    /// </summary>
    [DisplayName("Program Entry Reason")]
    public Guid? RefProgramEntryReasonId { get; set; }

    /// <summary>
    /// Exit Reason
    /// <para>
    /// The documented or assumed reason a student is no longer being served by a special program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19222">Exit Reason</a>
    /// </para>
    /// </summary>
    [DisplayName("Exit Reason")]
    public Guid? RefProgramExitReasonId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPersonProgramParticipation model)
    {
        IsBusy = true;
        Id = model.Id;
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        ParticipationStatus = model.ParticipationStatus; // Gifted and Talented Indicator
        RefParticipationTypeId = model.RefParticipationTypeId; // GED Preparation Program Participation Status
        RefProgramEntryReasonId = model.RefProgramEntryReasonId; // Program Entry Reason
        RefProgramExitReasonId = model.RefProgramExitReasonId; // Exit Reason
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
