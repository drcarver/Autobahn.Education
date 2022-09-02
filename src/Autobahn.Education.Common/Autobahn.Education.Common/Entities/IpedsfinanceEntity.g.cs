//***************************************************************************
//* DomainName: Common Models
//* FileName:   IpedsfinanceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIpedsfinance file
/// </summary>
[Table("Ipedsfinance", Schema = "Common")]
public partial class IpedsfinanceEntity : EntityBase, IIpedsfinance
{
    #region "IIpedsfinance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationFinancial")]
    public Guid OrganizationFinancialId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbfinancialPosition"/> model
    /// </summary>
    [ForeignKey("RefIpedsfasbfinancialPosition")]
    public Guid? RefIpedsfasbfinancialPositionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbfunctionalExpense"/> model
    /// </summary>
    [ForeignKey("RefIpedsfasbfunctionalExpense")]
    public Guid? RefIpedsfasbfunctionalExpenseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbpellGrantTransactions"/> model
    /// </summary>
    [Obsolete("The RefIpedsfasbpellGrantTransactions property is obsolete and will be removed in a later version")]
    [ForeignKey("RefIpedsfasbpellGrantTransactions")]
    public Guid? RefIpedsfasbpellGrantTransactionsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbrevenue"/> model
    /// </summary>
    [ForeignKey("RefIpedsfasbrevenue")]
    public Guid? RefIpedsfasbrevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbrevenueRestriction"/> model
    /// </summary>
    [ForeignKey("RefIpedsfasbrevenueRestriction")]
    public Guid? RefIpedsfasbrevenueRestrictionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbscholarshipsandFellowshipsRevenue"/> model
    /// </summary>
    [ForeignKey("RefIpedsfasbscholarshipsandFellowshipsRevenue")]
    public Guid? RefIpedsfasbscholarshipsandFellowshipsRevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbfinancialPosition"/> model
    /// </summary>
    [ForeignKey("RefIpedsgasbfinancialPosition")]
    public Guid? RefIpedsgasbfinancialPositionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbfunctionalExpense"/> model
    /// </summary>
    [ForeignKey("RefIpedsgasbfunctionalExpense")]
    public Guid? RefIpedsgasbfunctionalExpenseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbrevenue"/> model
    /// </summary>
    [ForeignKey("RefIpedsgasbrevenue")]
    public Guid? RefIpedsgasbrevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsgasbscholarshipsandFellowshipsRevenue"/> model
    /// </summary>
    [ForeignKey("RefIpedsgasbscholarshipsandFellowshipsRevenue")]
    public Guid? RefIpedsgasbscholarshipsandFellowshipsRevenueId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsintercollegiateAthleticsExpenses"/> model
    /// </summary>
    [Obsolete("The RefIpedsintercollegiateAthleticsExpenses property is obsolete and will be removed in a later version")]
    [ForeignKey("RefIpedsintercollegiateAthleticsExpenses")]
    public Guid? RefIpedsintercollegiateAthleticsExpensesId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsnaturalExpense"/> model
    /// </summary>
    [ForeignKey("RefIpedsnaturalExpense")]
    public Guid? RefIpedsnaturalExpenseId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual OrganizationFinancialEntity OrganizationFinancialEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpedsfasbfinancialPosition"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpedsfasbfinancialPositionEntity RefIpedsfasbfinancialPositionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpedsfasbfunctionalExpense"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpedsfasbfunctionalExpenseEntity RefIpedsfasbfunctionalExpenseEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpedsfasbrevenue"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpedsfasbrevenueEntity RefIpedsfasbrevenueEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpedsfasbrevenueRestriction"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpedsfasbrevenueRestrictionEntity RefIpedsfasbrevenueRestrictionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpedsfasbscholarshipsandFellowshipsRevenue"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpedsfasbscholarshipsandFellowshipsRevenueEntity RefIpedsfasbscholarshipsandFellowshipsRevenueEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpedsgasbfinancialPosition"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpedsgasbfinancialPositionEntity RefIpedsgasbfinancialPositionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpedsgasbfunctionalExpense"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpedsgasbfunctionalExpenseEntity RefIpedsgasbfunctionalExpenseEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpedsgasbrevenue"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpedsgasbrevenueEntity RefIpedsgasbrevenueEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpedsgasbscholarshipsandFellowshipsRevenue"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpedsgasbscholarshipsandFellowshipsRevenueEntity RefIpedsgasbscholarshipsandFellowshipsRevenueEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpedsnaturalExpense"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpedsnaturalExpenseEntity RefIpedsnaturalExpenseEntity { get; set; }

    #endregion
}
