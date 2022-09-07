//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12seaAlternateFundUse.g.cs
//***************************************************************************

/// <summary>
/// The IK12seaAlternateFundUse file
/// </summary>
public partial interface IK12seaAlternateFundUse
{
    #region "IK12seaAlternateFundUse Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12seaFederalFunds"/> model
    /// </summary>
    Guid K12seaFederalFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAlternateFundUses"/> model
    /// </summary>
    Guid RefAlternateFundUsesId { get; set; }

    #endregion
}
