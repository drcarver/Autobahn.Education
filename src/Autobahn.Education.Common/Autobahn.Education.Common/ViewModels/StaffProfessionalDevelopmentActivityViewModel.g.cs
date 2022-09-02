//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IStaffProfessionalDevelopmentActivity file
/// </summary>
public partial class StaffProfessionalDevelopmentActivityViewModel : ObservableValidator, IStaffProfessionalDevelopmentActivity
{
    #region "StaffProfessionalDevelopmentActivityViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// StaffProfessionalDevelopmentActivityViewModel Constructor
    /// </summary>
    public StaffProfessionalDevelopmentActivityViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnStaffProfessionalDevelopmentActivityViewModelConstruction();
    }

    /// <summary>
    /// StaffProfessionalDevelopmentActivityViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnStaffProfessionalDevelopmentActivityViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from StaffProfessionalDevelopmentActivity";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ActivityCompletionDate -- (backing property for Staff Professional Development Activity Completion Date)
    private DateTime? activityCompletionDate;

    // ActivityIdentifier -- (backing property for Professional Development Activity Identifier)
    private System.String activityIdentifier;

    // ActivityStartDate -- (backing property for Staff Professional Development Activity Start Date)
    private DateTime? activityStartDate;

    // ActivityTitle -- (backing property for Professional Development Activity Title)
    private System.String activityTitle;

    // NumberOfCreditsEarned -- (backing property for Number of Credits Earned)
    private Decimal? numberOfCreditsEarned;

    // ScholarshipStatus -- (backing property for Professional Development Scholarship Status)
    private Boolean? scholarshipStatus;

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

    #region "IStaffProfessionalDevelopmentActivity Properties"
    /// <summary>
    /// Staff Professional Development Activity Completion Date
    /// <para>
    /// The year, month and day on which an individual completed a course, an education program or a staff development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20068">Staff Professional Development Activity Completion Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Professional Development Activity Completion Date")]
    public DateTime? ActivityCompletionDate { get => activityCompletionDate; set => SetProperty(ref activityCompletionDate, value, false); }

    /// <summary>
    /// Professional Development Activity Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to the Professional Development Activity as assigned by the organization offering the training.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19808">Professional Development Activity Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Activity Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ActivityIdentifier { get => activityIdentifier; set => SetProperty(ref activityIdentifier, value, true); }

    /// <summary>
    /// Staff Professional Development Activity Start Date
    /// <para>
    /// The year, month and day on which an individual begins a course, an education program or a staff development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20067">Staff Professional Development Activity Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Professional Development Activity Start Date")]
    public DateTime? ActivityStartDate { get => activityStartDate; set => SetProperty(ref activityStartDate, value, false); }

    /// <summary>
    /// Professional Development Activity Title
    /// <para>
    /// The title of an activity designed for the purpose of developing someone professionally.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19809">Professional Development Activity Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Activity Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ActivityTitle { get => activityTitle; set => SetProperty(ref activityTitle, value, true); }

    /// <summary>
    /// Number of Credits Earned
    /// <para>
    /// The number of credits an individual earns by the successful completion of a course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19200">Number of Credits Earned</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of Credits Earned")]
    public Decimal? NumberOfCreditsEarned { get => numberOfCreditsEarned; set => SetProperty(ref numberOfCreditsEarned, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentRequirementId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentSession"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentSessionId { get; set; }

    /// <summary>
    /// Course Credit Units
    /// <para>
    /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Credit Units")]
    public Guid? RefCourseCreditUnitId { get; set; }

    /// <summary>
    /// Professional Development Financial Support Type
    /// <para>
    /// The type of financial assistance received in support of non-credit professional development activities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19811">Professional Development Financial Support Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Financial Support Type")]
    public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

    /// <summary>
    /// Professional Development Scholarship Status
    /// <para>
    /// An indication of whether a scholarship was received for the person to participate in the professional development.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19810">Professional Development Scholarship Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Scholarship Status")]
    public Boolean? ScholarshipStatus { get => scholarshipStatus; set => SetProperty(ref scholarshipStatus, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IStaffProfessionalDevelopmentActivity model)
    {
        IsBusy = true;
        Id = model.Id;
        ActivityCompletionDate = model.ActivityCompletionDate; // Staff Professional Development Activity Completion Date
        ActivityIdentifier = model.ActivityIdentifier; // Professional Development Activity Identifier
        ActivityStartDate = model.ActivityStartDate; // Staff Professional Development Activity Start Date
        ActivityTitle = model.ActivityTitle; // Professional Development Activity Title
        NumberOfCreditsEarned = model.NumberOfCreditsEarned; // Number of Credits Earned
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId; // 
        ProfessionalDevelopmentRequirementId = model.ProfessionalDevelopmentRequirementId; // 
        ProfessionalDevelopmentSessionId = model.ProfessionalDevelopmentSessionId; // 
        RefCourseCreditUnitId = model.RefCourseCreditUnitId; // Course Credit Units
        RefProfessionalDevelopmentFinancialSupportId = model.RefProfessionalDevelopmentFinancialSupportId; // Professional Development Financial Support Type
        ScholarshipStatus = model.ScholarshipStatus; // Professional Development Scholarship Status
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
