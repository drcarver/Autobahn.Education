//***************************************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipantCohortViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IWorkforceProgramParticipantCohort file
/// </summary>
public partial class WorkforceProgramParticipantCohortViewModel : ObservableValidator, IWorkforceProgramParticipantCohort
{
    #region "WorkforceProgramParticipantCohortViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// WorkforceProgramParticipantCohortViewModel Constructor
    /// </summary>
    public WorkforceProgramParticipantCohortViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnWorkforceProgramParticipantCohortViewModelConstruction();
    }

    /// <summary>
    /// WorkforceProgramParticipantCohortViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnWorkforceProgramParticipantCohortViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from WorkforceProgramParticipantCohort";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the CohortDescription property
    private System.String cohortDescription;

    // CohortMedianEarnings -- (backing property for Cohort Median Earnings)
    private Decimal? cohortMedianEarnings;

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

    #region "IWorkforceProgramParticipantCohort Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CohortDescription { get => cohortDescription; set => SetProperty(ref cohortDescription, value, true); }

    /// <summary>
    /// Cohort Median Earnings
    /// <para>
    /// The midpoint between the lowest and highest quarterly wage, in U.S. dollars, for the total number of persons included in the cohort for the period of time between the Employment Record Reference Period Start Date and Employment Record Reference Period End Date.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20918">Cohort Median Earnings</a>
    /// </para>
    /// </summary>
    [DisplayName("Cohort Median Earnings")]
    public Decimal? CohortMedianEarnings { get => cohortMedianEarnings; set => SetProperty(ref cohortMedianEarnings, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IWorkforceProgramParticipantCohort model)
    {
        IsBusy = true;
        Id = model.Id;
        CohortDescription = model.CohortDescription; // 
        CohortMedianEarnings = model.CohortMedianEarnings; // Cohort Median Earnings
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
