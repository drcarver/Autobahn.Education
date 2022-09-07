//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12seaAlternateFundUseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12seaAlternateFundUse file
/// </summary>
[Table("K12seaAlternateFundUse", Schema = "K12")]
public partial class K12seaAlternateFundUseEntity : EntityBase, IK12seaAlternateFundUse
{
    #region "IK12seaAlternateFundUse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12seaFederalFunds")]
    public Guid K12seaFederalFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAlternateFundUses"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefAlternateFundUses")]
    public Guid RefAlternateFundUsesId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
