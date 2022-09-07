//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramProgressReportViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramProgressReport file
/// </summary>
public partial class IndividualizedProgramProgressReportViewModel : ObservableValidator, IIndividualizedProgramProgressReport
{
    #region "IndividualizedProgramProgressReportViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// IndividualizedProgramProgressReportViewModel Constructor
    /// </summary>
    public IndividualizedProgramProgressReportViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnIndividualizedProgramProgressReportViewModelConstruction();
    }

    /// <summary>
    /// IndividualizedProgramProgressReportViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnIndividualizedProgramProgressReportViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from IndividualizedProgramProgressReport";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ProgressDescription -- (backing property for Individualized Program Service Plan Progress Report Description)
    private System.String progressDescription;

    // ProgressReportDate -- (backing property for Individualized Program Service Plan Progress Report Date)
    private DateTime? progressReportDate;

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

    #region "IIndividualizedProgramProgressReport Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReportPlan"/> model
    /// </summary>
    public Guid IndividualizedProgramProgressReportPlanId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Progress Report Description
    /// <para>
    /// A description of the progress report used to notify parents of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20681">Individualized Program Service Plan Progress Report Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Progress Report Description")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String ProgressDescription { get => progressDescription; set => SetProperty(ref progressDescription, value, true); }

    /// <summary>
    /// Individualized Program Service Plan Progress Report Date
    /// <para>
    /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20680">Individualized Program Service Plan Progress Report Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Individualized Program Service Plan Progress Report Date")]
    public DateTime? ProgressReportDate { get => progressReportDate; set => SetProperty(ref progressReportDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpspprogressReportType"/> model
    /// </summary>
    public Guid? RefIpspprogressReportTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IIndividualizedProgramProgressReport model)
    {
        IsBusy = true;
        Id = model.Id;
        IndividualizedProgramId = model.IndividualizedProgramId; // 
        IndividualizedProgramProgressReportPlanId = model.IndividualizedProgramProgressReportPlanId; // 
        ProgressDescription = model.ProgressDescription; // Individualized Program Service Plan Progress Report Description
        ProgressReportDate = model.ProgressReportDate; // Individualized Program Service Plan Progress Report Date
        RefIpspprogressReportTypeId = model.RefIpspprogressReportTypeId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
