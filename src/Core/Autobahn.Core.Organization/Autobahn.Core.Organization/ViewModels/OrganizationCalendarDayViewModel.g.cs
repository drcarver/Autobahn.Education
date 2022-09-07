//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationCalendarDayViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendarDay file
/// </summary>
public partial class OrganizationCalendarDayViewModel : ObservableValidator, IOrganizationCalendarDay
{
    #region "OrganizationCalendarDayViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationCalendarDayViewModel Constructor
    /// </summary>
    public OrganizationCalendarDayViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationCalendarDayViewModelConstruction();
    }

    /// <summary>
    /// OrganizationCalendarDayViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationCalendarDayViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationCalendarDay";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AlternateDayName -- (backing property for Alternate Day Name)
    private System.String alternateDayName;

    // member variable for the DayName property
    private System.String dayName;

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

    #region "IOrganizationCalendarDay Properties"
    /// <summary>
    /// Alternate Day Name
    /// <para>
    /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19591">Alternate Day Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Alternate Day Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AlternateDayName { get => alternateDayName; set => SetProperty(ref alternateDayName, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DayName { get => dayName; set => SetProperty(ref dayName, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
    /// </summary>
    public Guid OrganizationCalendarId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationCalendarDay model)
    {
        IsBusy = true;
        Id = model.Id;
        AlternateDayName = model.AlternateDayName; // Alternate Day Name
        DayName = model.DayName; // 
        OrganizationCalendarId = model.OrganizationCalendarId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
