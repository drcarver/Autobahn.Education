//***************************************************************************
//* DomainName: Common Models
//* FileName:   IOrganizationFinancial.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationFinancial file
/// </summary>
public partial interface IOrganizationFinancial
{
    #region "IOrganizationFinancial Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Financial Accounting Period Actual Value
    /// <para>
    /// The actual value of a financial account for the specified accounting period or fiscal year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20317">Financial Accounting Period Actual Value</a>
    /// </para>
    /// </summary>
    Decimal? ActualValue { get; set; }

    /// <summary>
    /// Financial Accounting Period Budgeted Value
    /// <para>
    /// The budgeted value of a financial account for the specified accounting period or fiscal year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20318">Financial Accounting Period Budgeted Value</a>
    /// </para>
    /// </summary>
    Decimal? BudgetedValue { get; set; }

    /// <summary>
    /// Financial Accounting Date
    /// <para>
    /// The date of a financial transaction or when an account balance is reported.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20629">Financial Accounting Date</a>
    /// </para>
    /// </summary>
    DateTime? Date { get; set; }

    /// <summary>
    /// Financial Accounting Period Encumbered Value
    /// <para>
    /// The planned or obligated expense value of a financial account for the specified accounting period or fiscal year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20625">Financial Accounting Period Encumbered Value</a>
    /// </para>
    /// </summary>
    Decimal? EncumberedValue { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFinancialAccount"/> model
    /// </summary>
    Guid FinancialAccountId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFinancialAccountProgram"/> model
    /// </summary>
    Guid? FinancialAccountProgramId { get; set; }

    /// <summary>
    /// Fiscal Period Begin Date
    /// <para>
    /// The year, month and day on which an accounting period begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20623">Fiscal Period Begin Date</a>
    /// </para>
    /// </summary>
    DateTime? FiscalPeriodBeginDate { get; set; }

    /// <summary>
    /// Fiscal Period End Date
    /// <para>
    /// The year, month and day on which an accounting period ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20624">Fiscal Period End Date</a>
    /// </para>
    /// </summary>
    DateTime? FiscalPeriodEndDate { get; set; }

    /// <summary>
    /// Fiscal Year
    /// <para>
    /// The year a school uses for budgeting, accounting, and reporting financials.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20620">Fiscal Year</a>
    /// </para>
    /// </summary>
    System.String FiscalYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    Guid OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Financial Accounting Value
    /// <para>
    /// The value of a financial account balance or transaction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20628">Financial Accounting Value</a>
    /// </para>
    /// </summary>
    Decimal? Value { get; set; }

    #endregion
}
