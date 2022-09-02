//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentActivityViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentActivity file
/// </summary>
public partial class ProfessionalDevelopmentActivityViewModel : ObservableValidator, IProfessionalDevelopmentActivity
{
    #region "ProfessionalDevelopmentActivityViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ProfessionalDevelopmentActivityViewModel Constructor
    /// </summary>
    public ProfessionalDevelopmentActivityViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnProfessionalDevelopmentActivityViewModelConstruction();
    }

    /// <summary>
    /// ProfessionalDevelopmentActivityViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnProfessionalDevelopmentActivityViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ProfessionalDevelopmentActivity";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ActivityCode -- (backing property for Professional Development Activity Code)
    private System.String activityCode;

    // ActivityIdentifier -- (backing property for Professional Development Activity Identifier)
    private System.String activityIdentifier;

    // ApprovalCode -- (backing property for Professional Development Activity Approval Code)
    private System.String approvalCode;

    // Cost -- (backing property for Professional Development Activity Cost)
    private Decimal? cost;

    // Credits -- (backing property for Professional Development Activity Credits)
    private Decimal? credits;

    // Objective -- (backing property for Professional Development Activity Objective)
    private System.String objective;

    // ProfessionalDevelopmentActivityStateApprovedStatus -- (backing property for Professional Development Activity State Approved Status)
    private Boolean? professionalDevelopmentActivityStateApprovedStatus;

    // PublishIndicator -- (backing property for Professional Development Publish Activity Indicator)
    private Boolean? publishIndicator;

    // ScholarshipStatus -- (backing property for Professional Development Scholarship Status)
    private Boolean? scholarshipStatus;

    // Title -- (backing property for Professional Development Activity Title)
    private System.String title;

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

    #region "IProfessionalDevelopmentActivity Properties"
    /// <summary>
    /// Professional Development Activity Code
    /// <para>
    /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20404">Professional Development Activity Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Activity Code")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ActivityCode { get => activityCode; set => SetProperty(ref activityCode, value, true); }

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
    /// Professional Development Activity Approval Code
    /// <para>
    /// A code given to an activity by an approval organization to designate it as an approved activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20402">Professional Development Activity Approval Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Activity Approval Code")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ApprovalCode { get => approvalCode; set => SetProperty(ref approvalCode, value, true); }

    /// <summary>
    /// Professional Development Activity Cost
    /// <para>
    /// The cost for an attendee to participate in a professional development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20405">Professional Development Activity Cost</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Activity Cost")]
    public Decimal? Cost { get => cost; set => SetProperty(ref cost, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    public Guid? CourseId { get; set; }

    /// <summary>
    /// Professional Development Activity Credits
    /// <para>
    /// The number of credits a professional development activity provides.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20407">Professional Development Activity Credits</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Activity Credits")]
    public Decimal? Credits { get => credits; set => SetProperty(ref credits, value, false); }

    /// <summary>
    /// Professional Development Activity Objective
    /// <para>
    /// The expected outcomes of a participant in an activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20410">Professional Development Activity Objective</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Activity Objective")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2000,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Objective { get => objective; set => SetProperty(ref objective, value, true); }

    /// <summary>
    /// Professional Development Activity State Approved Status
    /// <para>
    /// An indication of whether a training activity has been approved through a state process.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20598">Professional Development Activity State Approved Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Activity State Approved Status")]
    public Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get => professionalDevelopmentActivityStateApprovedStatus; set => SetProperty(ref professionalDevelopmentActivityStateApprovedStatus, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentRequirementId { get; set; }

    /// <summary>
    /// Professional Development Publish Activity Indicator
    /// <para>
    /// An indicator of whether the professional development activity should be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20415">Professional Development Publish Activity Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional Development Publish Activity Indicator")]
    public Boolean? PublishIndicator { get => publishIndicator; set => SetProperty(ref publishIndicator, value, false); }

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
    /// Reference to an optional instance of the <see cref="RefPdactivityApprovedPurpose"/> model
    /// </summary>
    public Guid? RefPdactivityApprovedPurposeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityCreditType"/> model
    /// </summary>
    public Guid? RefPdactivityCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityLevel"/> model
    /// </summary>
    public Guid? RefPdactivityLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityType"/> model
    /// </summary>
    public Guid? RefPdactivityTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdaudienceType"/> model
    /// </summary>
    public Guid? RefPdaudienceTypeId { get; set; }

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
    public System.String Title { get => title; set => SetProperty(ref title, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IProfessionalDevelopmentActivity model)
    {
        IsBusy = true;
        Id = model.Id;
        ActivityCode = model.ActivityCode; // Professional Development Activity Code
        ActivityIdentifier = model.ActivityIdentifier; // Professional Development Activity Identifier
        ApprovalCode = model.ApprovalCode; // Professional Development Activity Approval Code
        Cost = model.Cost; // Professional Development Activity Cost
        CourseId = model.CourseId; // 
        Credits = model.Credits; // Professional Development Activity Credits
        Objective = model.Objective; // Professional Development Activity Objective
        ProfessionalDevelopmentActivityStateApprovedStatus = model.ProfessionalDevelopmentActivityStateApprovedStatus; // Professional Development Activity State Approved Status
        ProfessionalDevelopmentRequirementId = model.ProfessionalDevelopmentRequirementId; // 
        PublishIndicator = model.PublishIndicator; // Professional Development Publish Activity Indicator
        RefCourseCreditUnitId = model.RefCourseCreditUnitId; // Course Credit Units
        RefPdactivityApprovedPurposeId = model.RefPdactivityApprovedPurposeId; // 
        RefPdactivityCreditTypeId = model.RefPdactivityCreditTypeId; // 
        RefPdactivityLevelId = model.RefPdactivityLevelId; // 
        RefPdactivityTypeId = model.RefPdactivityTypeId; // 
        RefPdaudienceTypeId = model.RefPdaudienceTypeId; // 
        RefProfessionalDevelopmentFinancialSupportId = model.RefProfessionalDevelopmentFinancialSupportId; // Professional Development Financial Support Type
        ScholarshipStatus = model.ScholarshipStatus; // Professional Development Scholarship Status
        Title = model.Title; // Professional Development Activity Title
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
