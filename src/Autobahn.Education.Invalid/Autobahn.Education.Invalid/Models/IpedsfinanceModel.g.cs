//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IpedsfinanceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIpedsfinance file
/// </summary>
public partial class IpedsfinanceModel : AutobahnBaseModel, IIpedsfinance
{
    #region "IIpedsfinance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> model
    /// </summary>
    public Guid OrganizationFinancialId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbfinancialPosition"/> model
    /// </summary>
    public Guid? RefIpedsfasbfinancialPositionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbfunctionalExpense"/> model
    /// </summary>
    public Guid? RefIpedsfasbfunctionalExpenseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbpellGrantTransactions"/> model
    /// </summary>
    public Guid? RefIpedsfasbpellGrantTransactionsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbrevenue"/> model
    /// </summary>
    public Guid? RefIpedsfasbrevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbrevenueRestriction"/> model
    /// </summary>
    public Guid? RefIpedsfasbrevenueRestrictionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbscholarshipsandFellowshipsRevenue"/> model
    /// </summary>
    public Guid? RefIpedsfasbscholarshipsandFellowshipsRevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbfinancialPosition"/> model
    /// </summary>
    public Guid? RefIpedsgasbfinancialPositionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbfunctionalExpense"/> model
    /// </summary>
    public Guid? RefIpedsgasbfunctionalExpenseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbrevenue"/> model
    /// </summary>
    public Guid? RefIpedsgasbrevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbscholarshipsandFellowshipsRevenue"/> model
    /// </summary>
    public Guid? RefIpedsgasbscholarshipsandFellowshipsRevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsintercollegiateAthleticsExpenses"/> model
    /// </summary>
    public Guid? RefIpedsintercollegiateAthleticsExpensesId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsnaturalExpense"/> model
    /// </summary>
    public Guid? RefIpedsnaturalExpenseId { get; set; }

    #endregion
}
