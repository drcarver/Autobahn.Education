//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAdministration file
/// </summary>
public partial class AssessmentAdministrationViewModel : ObservableValidator, IAssessmentAdministration
{
    #region "AssessmentAdministrationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentAdministrationViewModel Constructor
    /// </summary>
    public AssessmentAdministrationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentAdministrationViewModelConstruction();
    }

    /// <summary>
    /// AssessmentAdministrationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentAdministrationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentAdministration";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AssessmentAdministrationPeriodDescription -- (backing property for Assessment Administration Period Description)
    private System.String assessmentAdministrationPeriodDescription;

    // AssessmentSecureIndicator -- (backing property for Assessment Secure Indicator)
    private Boolean? assessmentSecureIndicator;

    // FinishDate -- (backing property for Assessment Administration Finish Date)
    private DateTime? finishDate;

    // FinishTime -- (backing property for Assessment Administration Finish Time)
    private TimeSpan? finishTime;

    // Name -- (backing property for Assessment Administration Name)
    private System.String name;

    // StartDate -- (backing property for Assessment Administration Start Date)
    private DateTime? startDate;

    // StartTime -- (backing property for Assessment Administration Start Time)
    private TimeSpan? startTime;

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

    #region "IAssessmentAdministration Properties"
    /// <summary>
    /// Assessment Administration Period Description
    /// <para>
    /// The period or window in which an assessment is supposed to be administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20506">Assessment Administration Period Description</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Administration Period Description")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentAdministrationPeriodDescription { get => assessmentAdministrationPeriodDescription; set => SetProperty(ref assessmentAdministrationPeriodDescription, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    public Guid? AssessmentId { get; set; }

    /// <summary>
    /// Assessment Secure Indicator
    /// <para>
    /// Indicates whether or not the assessment is a secure assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19375">Assessment Secure Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Secure Indicator")]
    public Boolean? AssessmentSecureIndicator { get => assessmentSecureIndicator; set => SetProperty(ref assessmentSecureIndicator, value, false); }

    /// <summary>
    /// Assessment Administration Finish Date
    /// <para>
    /// The finish date of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19965">Assessment Administration Finish Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Administration Finish Date")]
    public DateTime? FinishDate { get => finishDate; set => SetProperty(ref finishDate, value, false); }

    /// <summary>
    /// Assessment Administration Finish Time
    /// <para>
    /// The finish time of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19966">Assessment Administration Finish Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Administration Finish Time")]
    public TimeSpan? FinishTime { get => finishTime; set => SetProperty(ref finishTime, value, false); }

    /// <summary>
    /// Assessment Administration Name
    /// <para>
    /// The name given to an assessment event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19978">Assessment Administration Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Administration Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get => name; set => SetProperty(ref name, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentReportingMethod"/> model
    /// </summary>
    public Guid? RefAssessmentReportingMethodId { get; set; }

    /// <summary>
    /// Assessment Administration Start Date
    /// <para>
    /// The start date of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19963">Assessment Administration Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Administration Start Date")]
    public DateTime? StartDate { get => startDate; set => SetProperty(ref startDate, value, false); }

    /// <summary>
    /// Assessment Administration Start Time
    /// <para>
    /// The start time of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19964">Assessment Administration Start Time</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Administration Start Time")]
    public TimeSpan? StartTime { get => startTime; set => SetProperty(ref startTime, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentAdministration model)
    {
        IsBusy = true;
        Id = model.Id;
        AssessmentAdministrationPeriodDescription = model.AssessmentAdministrationPeriodDescription; // Assessment Administration Period Description
        AssessmentId = model.AssessmentId; // 
        AssessmentSecureIndicator = model.AssessmentSecureIndicator; // Assessment Secure Indicator
        FinishDate = model.FinishDate; // Assessment Administration Finish Date
        FinishTime = model.FinishTime; // Assessment Administration Finish Time
        Name = model.Name; // Assessment Administration Name
        RefAssessmentReportingMethodId = model.RefAssessmentReportingMethodId; // 
        StartDate = model.StartDate; // Assessment Administration Start Date
        StartTime = model.StartTime; // Assessment Administration Start Time
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
