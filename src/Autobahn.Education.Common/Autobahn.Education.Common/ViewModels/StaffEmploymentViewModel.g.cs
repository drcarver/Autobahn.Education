//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffEmploymentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IStaffEmployment file
/// </summary>
public partial class StaffEmploymentViewModel : ObservableValidator, IStaffEmployment
{
    #region "StaffEmploymentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// StaffEmploymentViewModel Constructor
    /// </summary>
    public StaffEmploymentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnStaffEmploymentViewModelConstruction();
    }

    /// <summary>
    /// StaffEmploymentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnStaffEmploymentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from StaffEmployment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // FullTimeEquivalency -- (backing property for Staff Full Time Equivalency)
    private Decimal? fullTimeEquivalency;

    // HireDate -- (backing property for Hire Date)
    private DateTime? hireDate;

    // PositionTitle -- (backing property for Position Title)
    private System.String positionTitle;

    // StandardOccupationalClassification -- (backing property for Standard Occupational Classification)
    private System.String standardOccupationalClassification;

    // UnionMembershipName -- (backing property for Union Membership Name)
    private System.String unionMembershipName;

    // WeeksEmployedPerYear -- (backing property for Weeks Employed Per Year)
    private Int32? weeksEmployedPerYear;

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

    #region "IStaffEmployment Properties"
    /// <summary>
    /// Staff Full Time Equivalency
    /// <para>
    /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19118">Staff Full Time Equivalency</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Full Time Equivalency")]
    public Decimal? FullTimeEquivalency { get => fullTimeEquivalency; set => SetProperty(ref fullTimeEquivalency, value, false); }

    /// <summary>
    /// Hire Date
    /// <para>
    /// The year, month and day on which a person was hired for a position, or consecutive positions within the same organization and job classification.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19143">Hire Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Hire Date")]
    public DateTime? HireDate { get => hireDate; set => SetProperty(ref hireDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Position Title
    /// <para>
    /// The descriptive name of a person's position.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19213">Position Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Position Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(45,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String PositionTitle { get => positionTitle; set => SetProperty(ref positionTitle, value, true); }

    /// <summary>
    /// Employment Separation Reason
    /// <para>
    /// The primary reason for the termination of the employment relationship.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19613">Employment Separation Reason</a>
    /// </para>
    /// </summary>
    [DisplayName("Employment Separation Reason")]
    public Guid? RefEmploymentSeparationReasonId { get; set; }

    /// <summary>
    /// Employment Separation Type
    /// <para>
    /// A designation of the type of separation occurring between a person and the organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19614">Employment Separation Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Employment Separation Type")]
    public Guid? RefEmploymentSeparationTypeId { get; set; }

    /// <summary>
    /// Standard Occupational Classification
    /// <para>
    /// A Bureau of Labor Statistics coding system for classifying occupations by work performed and, in some cases, on the skills, education and training needed to perform the work at a competent level.  See https://www.bls.gov/soc/2018/major_groups.htm.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19707">Standard Occupational Classification</a>
    /// </para>
    /// </summary>
    [DisplayName("Standard Occupational Classification")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(7,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String StandardOccupationalClassification { get => standardOccupationalClassification; set => SetProperty(ref standardOccupationalClassification, value, true); }

    /// <summary>
    /// Union Membership Name
    /// <para>
    /// The name of the labor organization of which the person is a member.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20469">Union Membership Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Union Membership Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(200,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String UnionMembershipName { get => unionMembershipName; set => SetProperty(ref unionMembershipName, value, true); }

    /// <summary>
    /// Weeks Employed Per Year
    /// <para>
    /// The number of weeks employed by year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20470">Weeks Employed Per Year</a>
    /// </para>
    /// </summary>
    [DisplayName("Weeks Employed Per Year")]
    public Int32? WeeksEmployedPerYear { get => weeksEmployedPerYear; set => SetProperty(ref weeksEmployedPerYear, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IStaffEmployment model)
    {
        IsBusy = true;
        Id = model.Id;
        FullTimeEquivalency = model.FullTimeEquivalency; // Staff Full Time Equivalency
        HireDate = model.HireDate; // Hire Date
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        PositionTitle = model.PositionTitle; // Position Title
        RefEmploymentSeparationReasonId = model.RefEmploymentSeparationReasonId; // Employment Separation Reason
        RefEmploymentSeparationTypeId = model.RefEmploymentSeparationTypeId; // Employment Separation Type
        StandardOccupationalClassification = model.StandardOccupationalClassification; // Standard Occupational Classification
        UnionMembershipName = model.UnionMembershipName; // Union Membership Name
        WeeksEmployedPerYear = model.WeeksEmployedPerYear; // Weeks Employed Per Year
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
