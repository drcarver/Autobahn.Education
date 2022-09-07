//***************************************************************************
//* DomainName: Assessments
//* FileName:   GoalViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IGoal file
/// </summary>
public partial class GoalViewModel : ObservableValidator, IGoal
{
    #region "GoalViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// GoalViewModel Constructor
    /// </summary>
    public GoalViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnGoalViewModelConstruction();
    }

    /// <summary>
    /// GoalViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnGoalViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Goal";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // EndDate -- (backing property for Goal End Date)
    private DateTime? endDate;

    // StartDate -- (backing property for Goal Start Date)
    private DateTime? startDate;

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

    #region "IGoal Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    public Guid? CompetencySetId { get; set; }

    /// <summary>
    /// Goal End Date
    /// <para>
    /// The date on which the goal expires or has been achieved.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20170">Goal End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal End Date")]
    public DateTime? EndDate { get => endDate; set => SetProperty(ref endDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid? OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Goal Start Date
    /// <para>
    /// The date on which the goal becomes active.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20169">Goal Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Goal Start Date")]
    public DateTime? StartDate { get => startDate; set => SetProperty(ref startDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IGoal model)
    {
        IsBusy = true;
        Id = model.Id;
        CompetencySetId = model.CompetencySetId; // 
        EndDate = model.EndDate; // Goal End Date
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        StartDate = model.StartDate; // Goal Start Date
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
