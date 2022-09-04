//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IepauthorizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIepauthorization file
/// </summary>
public partial class IepauthorizationModel : AutobahnBaseModel, IIepauthorization
{
    #region "IIepauthorization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAuthorizationDocument"/> model
    /// </summary>
    public Guid AuthorizationDocumentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIepauthorizationDocumentType"/> model
    /// </summary>
    public Guid? RefIepauthorizationDocumentTypeId { get; set; }

    #endregion
}
