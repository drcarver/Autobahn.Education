//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFinancialEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationFinancial file
/// </summary>
public partial class OrganizationFinancialModel : AutobahnBaseModel, IOrganizationFinancial
{
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
    public Decimal? ActualValue { get; set; }

    /// <summary>
    /// Financial Accounting Period Budgeted Value
    /// <para>
    /// The budgeted value of a financial account for the specified accounting period or fiscal year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20318">Financial Accounting Period Budgeted Value</a>
    /// </para>
    /// </summary>
    public Decimal? BudgetedValue { get; set; }

    /// <summary>
    /// Financial Accounting Date
    /// <para>
    /// The date of a financial transaction or when an account balance is reported.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20629">Financial Accounting Date</a>
    /// </para>
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Financial Accounting Period Encumbered Value
    /// <para>
    /// The planned or obligated expense value of a financial account for the specified accounting period or fiscal year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20625">Financial Accounting Period Encumbered Value</a>
    /// </para>
    /// </summary>
    public Decimal? EncumberedValue { get; set; }

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
    public DateTime? FiscalPeriodBeginDate { get; set; }

    /// <summary>
    /// Fiscal Period End Date
    /// <para>
    /// The year, month and day on which an accounting period ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20624">Fiscal Period End Date</a>
    /// </para>
    /// </summary>
    public DateTime? FiscalPeriodEndDate { get; set; }

    /// <summary>
    /// Fiscal Year
    /// <para>
    /// The year a school uses for budgeting, accounting, and reporting financials.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20620">Fiscal Year</a>
    /// </para>
    /// </summary>
    public System.String FiscalYear { get; set; }

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
    public Decimal? Value { get; set; }

    #endregion
}
