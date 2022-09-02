//***************************************************************************
//* DomainName: Common Models
//* FileName:   IIpedsfinance.g.cs
//***************************************************************************

/// <summary>
/// The IIpedsfinance file
/// </summary>
public partial interface IIpedsfinance
{
    #region "IIpedsfinance Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> model
    /// </summary>
    Guid OrganizationFinancialId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbfinancialPosition"/> model
    /// </summary>
    Guid? RefIpedsfasbfinancialPositionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbfunctionalExpense"/> model
    /// </summary>
    Guid? RefIpedsfasbfunctionalExpenseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbpellGrantTransactions"/> model
    /// </summary>
    Guid? RefIpedsfasbpellGrantTransactionsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbrevenue"/> model
    /// </summary>
    Guid? RefIpedsfasbrevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbrevenueRestriction"/> model
    /// </summary>
    Guid? RefIpedsfasbrevenueRestrictionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbscholarshipsandFellowshipsRevenue"/> model
    /// </summary>
    Guid? RefIpedsfasbscholarshipsandFellowshipsRevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbfinancialPosition"/> model
    /// </summary>
    Guid? RefIpedsgasbfinancialPositionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbfunctionalExpense"/> model
    /// </summary>
    Guid? RefIpedsgasbfunctionalExpenseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbrevenue"/> model
    /// </summary>
    Guid? RefIpedsgasbrevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbscholarshipsandFellowshipsRevenue"/> model
    /// </summary>
    Guid? RefIpedsgasbscholarshipsandFellowshipsRevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsintercollegiateAthleticsExpenses"/> model
    /// </summary>
    Guid? RefIpedsintercollegiateAthleticsExpensesId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsnaturalExpense"/> model
    /// </summary>
    Guid? RefIpedsnaturalExpenseId { get; set; }

    #endregion
}
