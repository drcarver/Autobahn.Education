//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramMeetingViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramMeeting file
/// </summary>
public partial class IndividualizedProgramMeetingViewModel : ObservableValidator, IIndividualizedProgramMeeting
{
    #region "IndividualizedProgramMeetingViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IndividualizedProgramMeetingViewModel Constructor
    /// </summary>
    public IndividualizedProgramMeetingViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIndividualizedProgramMeetingViewModelConstruction();
    }

    /// <summary>
    /// IndividualizedProgramMeetingViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIndividualizedProgramMeetingViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from IndividualizedProgramMeeting";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // MeetingDate -- (backing property for Individualized Program Service Plan Meeting Date)
    private DateTime? meetingDate;

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

    #region "IIndividualizedProgramMeeting Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Meeting Date
    /// <para>
    /// The date on which a child's service plan meeting is held.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20665">Individualized Program Service Plan Meeting Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Meeting Date")]
    public DateTime? MeetingDate { get => meetingDate; set => SetProperty(ref meetingDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIndividualizedProgramMeeting model)
    {
        IsBusy = true;
        Id = model.Id;
        IndividualizedProgramId = model.IndividualizedProgramId; // 
        MeetingDate = model.MeetingDate; // Individualized Program Service Plan Meeting Date
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
