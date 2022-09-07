//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationFinancialViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationFinancial file
/// </summary>
public partial class OrganizationFinancialViewModel : ObservableValidator, IOrganizationFinancial
{
    #region "OrganizationFinancialViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// OrganizationFinancialViewModel Constructor
    /// </summary>
    public OrganizationFinancialViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationFinancialViewModelConstruction();
    }

    /// <summary>
    /// OrganizationFinancialViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationFinancialViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from OrganizationFinancial";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ActualValue -- (backing property for Financial Accounting Period Actual Value)
    private Decimal? actualValue;

    // BudgetedValue -- (backing property for Financial Accounting Period Budgeted Value)
    private Decimal? budgetedValue;

    // Date -- (backing property for Financial Accounting Date)
    private DateTime? date;

    // EncumberedValue -- (backing property for Financial Accounting Period Encumbered Value)
    private Decimal? encumberedValue;

    // FiscalPeriodBeginDate -- (backing property for Fiscal Period Begin Date)
    private DateTime? fiscalPeriodBeginDate;

    // FiscalPeriodEndDate -- (backing property for Fiscal Period End Date)
    private DateTime? fiscalPeriodEndDate;

    // FiscalYear -- (backing property for Fiscal Year)
    private System.String fiscalYear;

    // Value -- (backing property for Financial Accounting Value)
    private Decimal? value;

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

    #region "IOrganizationFinancial Properties"
    /// <summary>
    /// Financial Accounting Period Actual Value
    /// <para>
    /// The actual value of a financial account for the specified accounting period or fiscal year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20317">Financial Accounting Period Actual Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Accounting Period Actual Value")]
    public Decimal? ActualValue { get => actualValue; set => SetProperty(ref actualValue, value, false); }

    /// <summary>
    /// Financial Accounting Period Budgeted Value
    /// <para>
    /// The budgeted value of a financial account for the specified accounting period or fiscal year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20318">Financial Accounting Period Budgeted Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Accounting Period Budgeted Value")]
    public Decimal? BudgetedValue { get => budgetedValue; set => SetProperty(ref budgetedValue, value, false); }

    /// <summary>
    /// Financial Accounting Date
    /// <para>
    /// The date of a financial transaction or when an account balance is reported.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20629">Financial Accounting Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Accounting Date")]
    public DateTime? Date { get => date; set => SetProperty(ref date, value, false); }

    /// <summary>
    /// Financial Accounting Period Encumbered Value
    /// <para>
    /// The planned or obligated expense value of a financial account for the specified accounting period or fiscal year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20625">Financial Accounting Period Encumbered Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Accounting Period Encumbered Value")]
    public Decimal? EncumberedValue { get => encumberedValue; set => SetProperty(ref encumberedValue, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFinancialAccount"/> model
    /// </summary>
    public Guid FinancialAccountId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFinancialAccountProgram"/> model
    /// </summary>
    public Guid? FinancialAccountProgramId { get; set; }

    /// <summary>
    /// Fiscal Period Begin Date
    /// <para>
    /// The year, month and day on which an accounting period begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20623">Fiscal Period Begin Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Fiscal Period Begin Date")]
    public DateTime? FiscalPeriodBeginDate { get => fiscalPeriodBeginDate; set => SetProperty(ref fiscalPeriodBeginDate, value, false); }

    /// <summary>
    /// Fiscal Period End Date
    /// <para>
    /// The year, month and day on which an accounting period ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20624">Fiscal Period End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Fiscal Period End Date")]
    public DateTime? FiscalPeriodEndDate { get => fiscalPeriodEndDate; set => SetProperty(ref fiscalPeriodEndDate, value, false); }

    /// <summary>
    /// Fiscal Year
    /// <para>
    /// The year a school uses for budgeting, accounting, and reporting financials.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20620">Fiscal Year</a>
    /// </para>
    /// </summary>
    [DisplayName("Fiscal Year")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FiscalYear { get => fiscalYear; set => SetProperty(ref fiscalYear, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    public Guid OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Financial Accounting Value
    /// <para>
    /// The value of a financial account balance or transaction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20628">Financial Accounting Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Accounting Value")]
    public Decimal? Value { get => value; set => SetProperty(ref value, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganizationFinancial model)
    {
        IsBusy = true;
        Id = model.Id;
        ActualValue = model.ActualValue; // Financial Accounting Period Actual Value
        BudgetedValue = model.BudgetedValue; // Financial Accounting Period Budgeted Value
        Date = model.Date; // Financial Accounting Date
        EncumberedValue = model.EncumberedValue; // Financial Accounting Period Encumbered Value
        FinancialAccountId = model.FinancialAccountId; // 
        FinancialAccountProgramId = model.FinancialAccountProgramId; // 
        FiscalPeriodBeginDate = model.FiscalPeriodBeginDate; // Fiscal Period Begin Date
        FiscalPeriodEndDate = model.FiscalPeriodEndDate; // Fiscal Period End Date
        FiscalYear = model.FiscalYear; // Fiscal Year
        OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // 
        Value = model.Value; // Financial Accounting Value
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
