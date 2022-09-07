//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefIpedsfasbpellGrantTransactionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefIpedsfasbpellGrantTransaction file
/// </summary>
[Table("RefIpedsfasbpellGrantTransaction", Schema = "Invalid")]
public partial class RefIpedsfasbpellGrantTransactionEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefIpedsfasbpellGrantTransaction Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsfasbpellGrantTransactions"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefIpedsfasbpellGrantTransactions")]
    public Guid RefIpedsfasbpellGrantTransactionsId { get; set; }

    #endregion
}
