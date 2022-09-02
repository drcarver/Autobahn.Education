//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefIpedsfasbpellGrantTransactionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefIpedsfasbpellGrantTransaction file
/// </summary>
[Table("RefIpedsfasbpellGrantTransaction", Schema = "Common")]
public partial class RefIpedsfasbpellGrantTransactionEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefIpedsfasbpellGrantTransaction Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbpellGrantTransactions"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefIpedsfasbpellGrantTransactions property is obsolete and will be removed in a later version")]
    [ForeignKey("RefIpedsfasbpellGrantTransactions")]
    public Guid RefIpedsfasbpellGrantTransactionsId { get; set; }

    #endregion
}
