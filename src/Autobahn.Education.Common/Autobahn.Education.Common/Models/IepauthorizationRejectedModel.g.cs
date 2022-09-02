//***************************************************************************
//* DomainName: Common Models
//* FileName:   IepauthorizationRejectedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIepauthorizationRejected file
/// </summary>
public partial class IepauthorizationRejectedModel : AutobahnBaseModel, IIepauthorizationRejected
{
    #region "IIepauthorizationRejected Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIepauthorization"/> model
    /// </summary>
    public Guid IepauthorizationId { get; set; }

    public System.String PortionDescription { get; set; }

    public System.String PortionExplanation { get; set; }

    #endregion
}
