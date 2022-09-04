//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   StaffCompensationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IStaffCompensation file
/// </summary>
public partial class StaffCompensationViewModel : ObservableValidator, IStaffCompensation
{
    #region "StaffCompensationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// StaffCompensationViewModel Constructor
    /// </summary>
    public StaffCompensationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnStaffCompensationViewModelConstruction();
    }

    /// <summary>
    /// StaffCompensationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnStaffCompensationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from StaffCompensation";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // StaffCompensationAnnualSupplement -- (backing property for Staff Compensation Annual Supplement)
    private Decimal? staffCompensationAnnualSupplement;

    // StaffCompensationBaseSalary -- (backing property for Staff Compensation Base Salary)
    private Decimal? staffCompensationBaseSalary;

    // StaffCompensationHealthBenefits -- (backing property for Staff Compensation Health Benefits)
    private Decimal? staffCompensationHealthBenefits;

    // StaffCompensationLongevity -- (backing property for Staff Compensation Longevity)
    private Decimal? staffCompensationLongevity;

    // StaffCompensationOtherBenefits -- (backing property for Staff Compensation Other Benefits)
    private Decimal? staffCompensationOtherBenefits;

    // StaffCompensationRetirementBenefits -- (backing property for Staff Compensation Retirement Benefits)
    private Decimal? staffCompensationRetirementBenefits;

    // StaffCompensationTotalBenefits -- (backing property for Staff Compensation Total Benefits)
    private Decimal? staffCompensationTotalBenefits;

    // StaffCompensationTotalSalary -- (backing property for Staff Compensation Total Salary)
    private Decimal? staffCompensationTotalSalary;

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

    #region "IStaffCompensation Properties"
    /// <summary>
    /// Staff Compensation Source Type
    /// <para>
    /// The source for the staff compensation a person receives.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20964">Staff Compensation Source Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Compensation Source Type")]
    public Guid? RefStaffCompensationSourceTypeId { get; set; }

    /// <summary>
    /// Staff Compensation Annual Supplement
    /// <para>
    /// The annual sum of payments given to staff in addition to their regular wages.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20962">Staff Compensation Annual Supplement</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Compensation Annual Supplement")]
    public Decimal? StaffCompensationAnnualSupplement { get => staffCompensationAnnualSupplement; set => SetProperty(ref staffCompensationAnnualSupplement, value, false); }

    /// <summary>
    /// Staff Compensation Base Salary
    /// <para>
    /// The salary or wage a person is paid before deductions (excluding differentials) but including annuities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19032">Staff Compensation Base Salary</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Compensation Base Salary")]
    public Decimal? StaffCompensationBaseSalary { get => staffCompensationBaseSalary; set => SetProperty(ref staffCompensationBaseSalary, value, false); }

    /// <summary>
    /// Staff Compensation Health Benefits
    /// <para>
    /// Contributions made by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19136">Staff Compensation Health Benefits</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Compensation Health Benefits")]
    public Decimal? StaffCompensationHealthBenefits { get => staffCompensationHealthBenefits; set => SetProperty(ref staffCompensationHealthBenefits, value, false); }

    /// <summary>
    /// Staff Compensation Longevity
    /// <para>
    /// Compensation paid to a staff member based on their years of service.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20963">Staff Compensation Longevity</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Compensation Longevity")]
    public Decimal? StaffCompensationLongevity { get => staffCompensationLongevity; set => SetProperty(ref staffCompensationLongevity, value, false); }

    /// <summary>
    /// Staff Compensation Other Benefits
    /// <para>
    /// All other benefits paid by the school district, municipal, state, federal, and other government agencies for the teacher or early learning provider, prorated to the specific school or local provider agency indicated on the record, not including retirement and health insurance benefits or contributions made by the teacher or early learning provider.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19205">Staff Compensation Other Benefits</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Compensation Other Benefits")]
    public Decimal? StaffCompensationOtherBenefits { get => staffCompensationOtherBenefits; set => SetProperty(ref staffCompensationOtherBenefits, value, false); }

    /// <summary>
    /// Staff Compensation Retirement Benefits
    /// <para>
    /// Contributions made by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19233">Staff Compensation Retirement Benefits</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Compensation Retirement Benefits")]
    public Decimal? StaffCompensationRetirementBenefits { get => staffCompensationRetirementBenefits; set => SetProperty(ref staffCompensationRetirementBenefits, value, false); }

    /// <summary>
    /// Staff Compensation Total Benefits
    /// <para>
    /// Sum of retirement, health, and all other benefits, or total benefits paid by the school district, municipal, state, federal and other government agencies for the teacher's or early learning provider's health insurance, prorated to the specific school or local provider agency indicated on the record, not including contributions made by the teacher or early learning provider.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19293">Staff Compensation Total Benefits</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Compensation Total Benefits")]
    public Decimal? StaffCompensationTotalBenefits { get => staffCompensationTotalBenefits; set => SetProperty(ref staffCompensationTotalBenefits, value, false); }

    /// <summary>
    /// Staff Compensation Total Salary
    /// <para>
    /// Total annualized salary of staff at the specific school/program indicated on the record in the school/program year  specified on the record.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19295">Staff Compensation Total Salary</a>
    /// </para>
    /// </summary>
    [DisplayName("Staff Compensation Total Salary")]
    public Decimal? StaffCompensationTotalSalary { get => staffCompensationTotalSalary; set => SetProperty(ref staffCompensationTotalSalary, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
    /// </summary>
    public Guid StaffEmploymentId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IStaffCompensation model)
    {
        IsBusy = true;
        Id = model.Id;
        RefStaffCompensationSourceTypeId = model.RefStaffCompensationSourceTypeId; // Staff Compensation Source Type
        StaffCompensationAnnualSupplement = model.StaffCompensationAnnualSupplement; // Staff Compensation Annual Supplement
        StaffCompensationBaseSalary = model.StaffCompensationBaseSalary; // Staff Compensation Base Salary
        StaffCompensationHealthBenefits = model.StaffCompensationHealthBenefits; // Staff Compensation Health Benefits
        StaffCompensationLongevity = model.StaffCompensationLongevity; // Staff Compensation Longevity
        StaffCompensationOtherBenefits = model.StaffCompensationOtherBenefits; // Staff Compensation Other Benefits
        StaffCompensationRetirementBenefits = model.StaffCompensationRetirementBenefits; // Staff Compensation Retirement Benefits
        StaffCompensationTotalBenefits = model.StaffCompensationTotalBenefits; // Staff Compensation Total Benefits
        StaffCompensationTotalSalary = model.StaffCompensationTotalSalary; // Staff Compensation Total Salary
        StaffEmploymentId = model.StaffEmploymentId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
