//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationFinancialEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationFinancial file
/// </summary>
[Table("OrganizationFinancial", Schema = "Organization")]
public partial class OrganizationFinancialEntity : EntityBase, IOrganizationFinancial
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
    [Comment("The actual value of a financial account for the specified accounting period or fiscal year.")]
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
    [Comment("The budgeted value of a financial account for the specified accounting period or fiscal year.")]
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
    [Comment("The date of a financial transaction or when an account balance is reported.")]
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
    [Comment("The planned or obligated expense value of a financial account for the specified accounting period or fiscal year.")]
    public Decimal? EncumberedValue { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFinancialAccount"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("FinancialAccount")]
    public Guid FinancialAccountId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFinancialAccountProgram"/> model
    /// </summary>
    [ForeignKey("FinancialAccountProgram")]
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
    [Comment("The year, month and day on which an accounting period begins.")]
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
    [Comment("The year, month and day on which an accounting period ends.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The year a school uses for budgeting, accounting, and reporting financials.")]
    public System.String FiscalYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationCalendarSession")]
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
    [Comment("The value of a financial account balance or transaction.")]
    public Decimal? Value { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFinancialAccount"/> implementation
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual FinancialAccountEntity FinancialAccountEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> implementation
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual OrganizationCalendarSessionEntity OrganizationCalendarSessionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFinancialAccountProgram"/> implementation
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual FinancialAccountProgramEntity? FinancialAccountProgramEntity { get; set; }

    #endregion
}
