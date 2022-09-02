//***************************************************************************
//* DomainName: Common Models
//* FileName:   QuarterlyEmploymentRecordViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IQuarterlyEmploymentRecord file
/// </summary>
public partial class QuarterlyEmploymentRecordViewModel : ObservableValidator, IQuarterlyEmploymentRecord
{
    #region "QuarterlyEmploymentRecordViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// QuarterlyEmploymentRecordViewModel Constructor
    /// </summary>
    public QuarterlyEmploymentRecordViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnQuarterlyEmploymentRecordViewModelConstruction();
    }

    /// <summary>
    /// QuarterlyEmploymentRecordViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnQuarterlyEmploymentRecordViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from QuarterlyEmploymentRecord";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // Earnings -- (backing property for Quarterly Earnings)
    private Decimal? earnings;

    // member variable for the EmploymentNaicscode property
    private System.String employmentNaicscode;

    // ReferencePeriodEndDate -- (backing property for Employment Record Reference Period End Date)
    private DateTime? referencePeriodEndDate;

    // ReferencePeriodStartDate -- (backing property for Employment Record Reference Period Start Date)
    private DateTime? referencePeriodStartDate;

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

    #region "IQuarterlyEmploymentRecord Properties"
    /// <summary>
    /// Quarterly Earnings
    /// <para>
    /// The quarterly amount paid to individuals found employed during the reference period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19991">Quarterly Earnings</a>
    /// </para>
    /// </summary>
    [DisplayName("Quarterly Earnings")]
    public Decimal? Earnings { get => earnings; set => SetProperty(ref earnings, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EmploymentNaicscode { get => employmentNaicscode; set => SetProperty(ref employmentNaicscode, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Employed Prior to Enrollment
    /// <para>
    /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, before enrolling in secondary, postsecondary, or adult education or workforce programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20309">Employed Prior to Enrollment</a>
    /// </para>
    /// </summary>
    [DisplayName("Employed Prior to Enrollment")]
    public Guid? RefEmployedPriorToEnrollmentId { get; set; }

    /// <summary>
    /// Employment Location
    /// <para>
    /// The state or other location in which an individual is found employed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19992">Employment Location</a>
    /// </para>
    /// </summary>
    [DisplayName("Employment Location")]
    public Guid? RefEmploymentLocationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEradministrativeDataSource"/> model
    /// </summary>
    public Guid? RefEradministrativeDataSourceId { get; set; }

    /// <summary>
    /// Employment Record Reference Period End Date
    /// <para>
    /// The year, month, and day of the last day of the employment record reference period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19995">Employment Record Reference Period End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Employment Record Reference Period End Date")]
    public DateTime? ReferencePeriodEndDate { get => referencePeriodEndDate; set => SetProperty(ref referencePeriodEndDate, value, false); }

    /// <summary>
    /// Employment Record Reference Period Start Date
    /// <para>
    /// The year, month, and day of the first day of the employment record reference period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19994">Employment Record Reference Period Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Employment Record Reference Period Start Date")]
    public DateTime? ReferencePeriodStartDate { get => referencePeriodStartDate; set => SetProperty(ref referencePeriodStartDate, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IQuarterlyEmploymentRecord model)
    {
        IsBusy = true;
        Id = model.Id;
        Earnings = model.Earnings; // Quarterly Earnings
        EmploymentNaicscode = model.EmploymentNaicscode; // 
        PersonId = model.PersonId; // 
        RefEmployedPriorToEnrollmentId = model.RefEmployedPriorToEnrollmentId; // Employed Prior to Enrollment
        RefEmploymentLocationId = model.RefEmploymentLocationId; // Employment Location
        RefEradministrativeDataSourceId = model.RefEradministrativeDataSourceId; // 
        ReferencePeriodEndDate = model.ReferencePeriodEndDate; // Employment Record Reference Period End Date
        ReferencePeriodStartDate = model.ReferencePeriodStartDate; // Employment Record Reference Period Start Date
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
