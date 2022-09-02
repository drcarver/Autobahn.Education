//***************************************************************************
//* DomainName: Common Models
//* FileName:   FinancialAccountEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAccount file
/// </summary>
[Table("FinancialAccount", Schema = "Common")]
public partial class FinancialAccountEntity : EntityBase, IFinancialAccount
{
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.")]
    public System.String AccountNumber { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(10,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FederalProgramCode { get; set; }

    /// <summary>
    /// Financial Account Number
    /// <para>
    /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.")]
    public System.String FinancialAccountNumber { get; set; }

    /// <summary>
    /// Financial Expenditure K12 Project Reporting Code
    /// <para>
    /// The project/reporting code permits school districts to accumulate expenditures to meet a variety of specialized reporting requirements at the local, state, and federal levels. It is a three-digit code with the format 00X.   The first two digits identify the particular funding source, authority, or expenditure purpose for which a special record or report is required. The third digit is available to identify particular projects and the fiscal year of the appropriation within that funding source. Each classification is presented by a code range followed by a description.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20532">Financial Expenditure K12 Project Reporting Code</a>
    /// </para>
    /// </summary>
    [Comment("The project/reporting code permits school districts to accumulate expenditures to meet a variety of specialized reporting requirements at the local, state, and federal levels. It is a three-digit code with the format 00X.   The first two digits identify the particular funding source, authority, or expenditure purpose for which a special record or report is required. The third digit is available to identify particular projects and the fiscal year of the appropriation within that funding source. Each classification is presented by a code range followed by a description.")]
    public Decimal? FinancialExpenditureProjectReportingCode { get; set; }

    /// <summary>
    /// Financial Account Name
    /// <para>
    /// The name given to the financial account in an educational institution's accounting system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20315">Financial Account Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name given to the financial account in an educational institution's accounting system.")]
    public System.String Name { get; set; }

    /// <summary>
    /// Financial Account K12 Balance Sheet Code
    /// <para>
    /// Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered "snapshots" of how these accounts stand as of a certain point in time.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20320">Financial Account K12 Balance Sheet Code</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFinancialAccountBalanceSheetCode")]
    [Comment("Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered \u0022snapshots\u0022 of how these accounts stand as of a certain point in time.")]
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
    [ForeignKey("RefFinancialAccountCategory")]
    [Comment("A label for a grouping of financial accounts, based on type and purpose.")]
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
    [ForeignKey("RefFinancialAccountFundClassification")]
    [Comment("A fund is a separate fiscal and accounting entity with a self-balancing set of accounts recording cash and other financial resources, together with all related liabilities and residual equities or balances or changes therein.")]
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
    [ForeignKey("RefFinancialAccountProgramCode")]
    [Comment("A program is a plan of activities and procedures designed to accomplish a predetermined objective or set of objectives.  The program classification provides the school district with a framework to classify instructional and other expenditures by program to determine cost.")]
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
    [ForeignKey("RefFinancialAccountRevenueCode")]
    [Comment("These codes are for recording revenue and other receivables by source.  Major revenue categories have codes ending in 00 and are further subdivided.")]
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
    [ForeignKey("RefFinancialExpenditureFunctionCode")]
    [Comment("The function describes the activity for which a service or material object is acquired. The functions of a school district are classified into five broad areas: instruction, support services, operation of noninstructional services, facilities acquisition and construction, and debt service. Functions are further classified into sub functions.")]
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
    [ForeignKey("RefFinancialExpenditureLevelOfInstructionCode")]
    [Comment("This classification permits expenditures to be segregated by instructional level.")]
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
    [ForeignKey("RefFinancialExpenditureObjectCode")]
    [Comment("This classification is used to describe the service or commodity obtained as the result of a specific expenditure.  Nine major object categories have codes ending in 00 and are further subdivided.")]
    public Guid? RefFinancialExpenditureObjectCodeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// A label for a grouping of financial accounts, based on type and purpose.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20312">Financial Account Category</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialAccountCategoryEntity RefFinancialAccountCategoryEntity { get; set; }

    /// <summary>
    /// A fund is a separate fiscal and accounting entity with a self-balancing set of accounts recording cash and other financial resources, together with all related liabilities and residual equities or balances or changes therein.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20314">Financial Account K12 Fund Classification</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialAccountFundClassificationEntity RefFinancialAccountFundClassificationEntity { get; set; }

    /// <summary>
    /// A program is a plan of activities and procedures designed to accomplish a predetermined objective or set of objectives.  The program classification provides the school district with a framework to classify instructional and other expenditures by program to determine cost.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20316">Financial Account K12 Program Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialAccountProgramCodeEntity RefFinancialAccountProgramCodeEntity { get; set; }

    /// <summary>
    /// Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered "snapshots" of how these accounts stand as of a certain point in time.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20320">Financial Account K12 Balance Sheet Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialAccountBalanceSheetCodeEntity RefFinancialAccountBalanceSheetCodeEntity { get; set; }

    /// <summary>
    /// The function describes the activity for which a service or material object is acquired. The functions of a school district are classified into five broad areas: instruction, support services, operation of noninstructional services, facilities acquisition and construction, and debt service. Functions are further classified into sub functions.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20321">Financial Expenditure K12 Function Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialExpenditureFunctionCodeEntity RefFinancialExpenditureFunctionCodeEntity { get; set; }

    /// <summary>
    /// This classification is used to describe the service or commodity obtained as the result of a specific expenditure.  Nine major object categories have codes ending in 00 and are further subdivided.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20322">Financial Expenditure K12 Object Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialExpenditureObjectCodeEntity RefFinancialExpenditureObjectCodeEntity { get; set; }

    /// <summary>
    /// This classification permits expenditures to be segregated by instructional level.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20531">Financial Expenditure K12 Level of Instruction Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialExpenditureLevelOfInstructionCodeEntity RefFinancialExpenditureLevelOfInstructionCodeEntity { get; set; }

    /// <summary>
    /// These codes are for recording revenue and other receivables by source.  Major revenue categories have codes ending in 00 and are further subdivided.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20440">Financial Account K12 Revenue Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefFinancialAccountRevenueCodeEntity RefFinancialAccountRevenueCodeEntity { get; set; }

    #endregion
}
