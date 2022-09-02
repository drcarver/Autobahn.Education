//***************************************************************************
//* DomainName: Common Models
//* FileName:   FinancialAccountViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAccount file
/// </summary>
public partial class FinancialAccountViewModel : ObservableValidator, IFinancialAccount
{
    #region "FinancialAccountViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// FinancialAccountViewModel Constructor
    /// </summary>
    public FinancialAccountViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnFinancialAccountViewModelConstruction();
    }

    /// <summary>
    /// FinancialAccountViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnFinancialAccountViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from FinancialAccount";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AccountNumber -- (backing property for Financial Account Number)
    private System.String accountNumber;

    // member variable for the FederalProgramCode property
    private System.String federalProgramCode;

    // FinancialAccountNumber -- (backing property for Financial Account Number)
    private System.String financialAccountNumber;

    // FinancialExpenditureProjectReportingCode -- (backing property for Financial Expenditure K12 Project Reporting Code)
    private Decimal? financialExpenditureProjectReportingCode;

    // Name -- (backing property for Financial Account Name)
    private System.String name;

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

    #region "IFinancialAccount Properties"
    /// <summary>
    /// Financial Account Number
    /// <para>
    /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Account Number")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AccountNumber { get => accountNumber; set => SetProperty(ref accountNumber, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(10,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FederalProgramCode { get => federalProgramCode; set => SetProperty(ref federalProgramCode, value, true); }

    /// <summary>
    /// Financial Account Number
    /// <para>
    /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Account Number")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FinancialAccountNumber { get => financialAccountNumber; set => SetProperty(ref financialAccountNumber, value, true); }

    /// <summary>
    /// Financial Expenditure K12 Project Reporting Code
    /// <para>
    /// The project/reporting code permits school districts to accumulate expenditures to meet a variety of specialized reporting requirements at the local, state, and federal levels. It is a three-digit code with the format 00X.   The first two digits identify the particular funding source, authority, or expenditure purpose for which a special record or report is required. The third digit is available to identify particular projects and the fiscal year of the appropriation within that funding source. Each classification is presented by a code range followed by a description.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20532">Financial Expenditure K12 Project Reporting Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Expenditure K12 Project Reporting Code")]
    public Decimal? FinancialExpenditureProjectReportingCode { get => financialExpenditureProjectReportingCode; set => SetProperty(ref financialExpenditureProjectReportingCode, value, false); }

    /// <summary>
    /// Financial Account Name
    /// <para>
    /// The name given to the financial account in an educational institution's accounting system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20315">Financial Account Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Account Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get => name; set => SetProperty(ref name, value, true); }

    /// <summary>
    /// Financial Account K12 Balance Sheet Code
    /// <para>
    /// Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered "snapshots" of how these accounts stand as of a certain point in time.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20320">Financial Account K12 Balance Sheet Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Account K12 Balance Sheet Code")]
    public Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }

    /// <summary>
    /// Financial Account Category
    /// <para>
    /// A label for a grouping of financial accounts, based on type and purpose.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20312">Financial Account Category</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Account Category")]
    public Guid? RefFinancialAccountCategoryId { get; set; }

    /// <summary>
    /// Financial Account K12 Fund Classification
    /// <para>
    /// A fund is a separate fiscal and accounting entity with a self-balancing set of accounts recording cash and other financial resources, together with all related liabilities and residual equities or balances or changes therein.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20314">Financial Account K12 Fund Classification</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Account K12 Fund Classification")]
    public Guid? RefFinancialAccountFundClassificationId { get; set; }

    /// <summary>
    /// Financial Account K12 Program Code
    /// <para>
    /// A program is a plan of activities and procedures designed to accomplish a predetermined objective or set of objectives.  The program classification provides the school district with a framework to classify instructional and other expenditures by program to determine cost.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20316">Financial Account K12 Program Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Account K12 Program Code")]
    public Guid? RefFinancialAccountProgramCodeId { get; set; }

    /// <summary>
    /// Financial Account K12 Revenue Code
    /// <para>
    /// These codes are for recording revenue and other receivables by source.  Major revenue categories have codes ending in 00 and are further subdivided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20440">Financial Account K12 Revenue Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Account K12 Revenue Code")]
    public Guid? RefFinancialAccountRevenueCodeId { get; set; }

    /// <summary>
    /// Financial Expenditure K12 Function Code
    /// <para>
    /// The function describes the activity for which a service or material object is acquired. The functions of a school district are classified into five broad areas: instruction, support services, operation of noninstructional services, facilities acquisition and construction, and debt service. Functions are further classified into sub functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20321">Financial Expenditure K12 Function Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Expenditure K12 Function Code")]
    public Guid? RefFinancialExpenditureFunctionCodeId { get; set; }

    /// <summary>
    /// Financial Expenditure K12 Level of Instruction Code
    /// <para>
    /// This classification permits expenditures to be segregated by instructional level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20531">Financial Expenditure K12 Level of Instruction Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Expenditure K12 Level of Instruction Code")]
    public Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

    /// <summary>
    /// Financial Expenditure K12 Object Code
    /// <para>
    /// This classification is used to describe the service or commodity obtained as the result of a specific expenditure.  Nine major object categories have codes ending in 00 and are further subdivided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20322">Financial Expenditure K12 Object Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Financial Expenditure K12 Object Code")]
    public Guid? RefFinancialExpenditureObjectCodeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IFinancialAccount model)
    {
        IsBusy = true;
        Id = model.Id;
        AccountNumber = model.AccountNumber; // Financial Account Number
        FederalProgramCode = model.FederalProgramCode; // 
        FinancialAccountNumber = model.FinancialAccountNumber; // Financial Account Number
        FinancialExpenditureProjectReportingCode = model.FinancialExpenditureProjectReportingCode; // Financial Expenditure K12 Project Reporting Code
        Name = model.Name; // Financial Account Name
        RefFinancialAccountBalanceSheetCodeId = model.RefFinancialAccountBalanceSheetCodeId; // Financial Account K12 Balance Sheet Code
        RefFinancialAccountCategoryId = model.RefFinancialAccountCategoryId; // Financial Account Category
        RefFinancialAccountFundClassificationId = model.RefFinancialAccountFundClassificationId; // Financial Account K12 Fund Classification
        RefFinancialAccountProgramCodeId = model.RefFinancialAccountProgramCodeId; // Financial Account K12 Program Code
        RefFinancialAccountRevenueCodeId = model.RefFinancialAccountRevenueCodeId; // Financial Account K12 Revenue Code
        RefFinancialExpenditureFunctionCodeId = model.RefFinancialExpenditureFunctionCodeId; // Financial Expenditure K12 Function Code
        RefFinancialExpenditureLevelOfInstructionCodeId = model.RefFinancialExpenditureLevelOfInstructionCodeId; // Financial Expenditure K12 Level of Instruction Code
        RefFinancialExpenditureObjectCodeId = model.RefFinancialExpenditureObjectCodeId; // Financial Expenditure K12 Object Code
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
