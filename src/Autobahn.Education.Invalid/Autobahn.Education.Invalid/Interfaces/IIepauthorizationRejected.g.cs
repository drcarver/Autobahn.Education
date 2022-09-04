//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IIepauthorizationRejected.g.cs
//***************************************************************************

/// <summary>
/// The IIepauthorizationRejected file
/// </summary>
public partial interface IIepauthorizationRejected
{
    #region "IIepauthorizationRejected Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIepauthorization"/> model
    /// </summary>
    Guid IepauthorizationId { get; set; }

    System.String PortionDescription { get; set; }

    System.String PortionExplanation { get; set; }

    #endregion
}
