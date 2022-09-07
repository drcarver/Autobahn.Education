//***************************************************************************
//* DomainName: Common Models
//* FileName:   IFinancialAccount.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAccount file
/// </summary>
public partial interface IFinancialAccount
{
    #region "IFinancialAccount Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Financial Account Number
    /// <para>
    /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
    /// </para>
    /// </summary>
    System.String AccountNumber { get; set; }

    System.String FederalProgramCode { get; set; }

    /// <summary>
    /// Financial Account Number
    /// <para>
    /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
    /// </para>
    /// </summary>
    System.String FinancialAccountNumber { get; set; }

    /// <summary>
    /// Financial Expenditure K12 Project Reporting Code
    /// <para>
    /// The project/reporting code permits school districts to accumulate expenditures to meet a variety of specialized reporting requirements at the local, state, and federal levels. It is a three-digit code with the format 00X.   The first two digits identify the particular funding source, authority, or expenditure purpose for which a special record or report is required. The third digit is available to identify particular projects and the fiscal year of the appropriation within that funding source. Each classification is presented by a code range followed by a description.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20532">Financial Expenditure K12 Project Reporting Code</a>
    /// </para>
    /// </summary>
    Decimal? FinancialExpenditureProjectReportingCode { get; set; }

    /// <summary>
    /// Financial Account Name
    /// <para>
    /// The name given to the financial account in an educational institution's accounting system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20315">Financial Account Name</a>
    /// </para>
    /// </summary>
    System.String Name { get; set; }

    /// <summary>
    /// Financial Account K12 Balance Sheet Code
    /// <para>
    /// Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered "snapshots" of how these accounts stand as of a certain point in time.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20320">Financial Account K12 Balance Sheet Code</a>
    /// </para>
    /// </summary>
    Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }

    /// <summary>
    /// Financial Account Category
    /// <para>
    /// A label for a grouping of financial accounts, based on type and purpose.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20312">Financial Account Category</a>
    /// </para>
    /// </summary>
    Guid? RefFinancialAccountCategoryId { get; set; }

    /// <summary>
    /// Financial Account K12 Fund Classification
    /// <para>
    /// A fund is a separate fiscal and accounting entity with a self-balancing set of accounts recording cash and other financial resources, together with all related liabilities and residual equities or balances or changes therein.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20314">Financial Account K12 Fund Classification</a>
    /// </para>
    /// </summary>
    Guid? RefFinancialAccountFundClassificationId { get; set; }

    /// <summary>
    /// Financial Account K12 Program Code
    /// <para>
    /// A program is a plan of activities and procedures designed to accomplish a predetermined objective or set of objectives.  The program classification provides the school district with a framework to classify instructional and other expenditures by program to determine cost.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20316">Financial Account K12 Program Code</a>
    /// </para>
    /// </summary>
    Guid? RefFinancialAccountProgramCodeId { get; set; }

    /// <summary>
    /// Financial Account K12 Revenue Code
    /// <para>
    /// These codes are for recording revenue and other receivables by source.  Major revenue categories have codes ending in 00 and are further subdivided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20440">Financial Account K12 Revenue Code</a>
    /// </para>
    /// </summary>
    Guid? RefFinancialAccountRevenueCodeId { get; set; }

    /// <summary>
    /// Financial Expenditure K12 Function Code
    /// <para>
    /// The function describes the activity for which a service or material object is acquired. The functions of a school district are classified into five broad areas: instruction, support services, operation of noninstructional services, facilities acquisition and construction, and debt service. Functions are further classified into sub functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20321">Financial Expenditure K12 Function Code</a>
    /// </para>
    /// </summary>
    Guid? RefFinancialExpenditureFunctionCodeId { get; set; }

    /// <summary>
    /// Financial Expenditure K12 Level of Instruction Code
    /// <para>
    /// This classification permits expenditures to be segregated by instructional level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20531">Financial Expenditure K12 Level of Instruction Code</a>
    /// </para>
    /// </summary>
    Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

    /// <summary>
    /// Financial Expenditure K12 Object Code
    /// <para>
    /// This classification is used to describe the service or commodity obtained as the result of a specific expenditure.  Nine major object categories have codes ending in 00 and are further subdivided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20322">Financial Expenditure K12 Object Code</a>
    /// </para>
    /// </summary>
    Guid? RefFinancialExpenditureObjectCodeId { get; set; }

    #endregion
}
