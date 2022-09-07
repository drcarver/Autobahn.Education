//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12seaAlternateFundUseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12seaAlternateFundUse file
/// </summary>
public partial class K12seaAlternateFundUseModel : AutobahnBaseModel, IK12seaAlternateFundUse
{
    #region "IK12seaAlternateFundUse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
    /// </summary>
    public Guid K12seaFederalFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAlternateFundUses"/> model
    /// </summary>
    public Guid RefAlternateFundUsesId { get; set; }

    #endregion
}
