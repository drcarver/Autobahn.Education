//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefFinancialAccountBalanceSheetCodeEntity.g.cs
//* Name:       Financial Account K12 Balance Sheet Code
//* Definition: Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered "snapshots" of how these accounts stand as of a certain point in time.
//***************************************************************************

/// <summary>
/// Financial Account K12 Balance Sheet Code <see cref="RefFinancialAccountBalanceSheetCode"/>
/// <para>
/// Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered "snapshots" of how these accounts stand as of a certain point in time.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20320">Financial Account K12 Balance Sheet Code</a>
/// </para>
/// </summary>
[Table("RefFinancialAccountBalanceSheetCode", Schema = "Common")]
[Comment("Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered \u0022snapshots\u0022 of how these accounts stand as of a certain point in time.")]
public partial class RefFinancialAccountBalanceSheetCodeEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefFinancialAccountBalanceSheetCode Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFinancialBalanceSheetAccountCode"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefFinancialBalanceSheetAccountCode property is obsolete and will be removed in a later version")]
    [ForeignKey("RefFinancialBalanceSheetAccountCode")]
    public Guid RefFinancialBalanceSheetAccountCodeId { get; set; }

    #endregion
}
