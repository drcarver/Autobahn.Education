//***************************************************************************
//* DomainName: Common Models
//* FileName:   IIepauthorization.g.cs
//***************************************************************************

/// <summary>
/// The IIepauthorization file
/// </summary>
public partial interface IIepauthorization
{
    #region "IIepauthorization Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAuthorizationDocument"/> model
    /// </summary>
    Guid AuthorizationDocumentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIepauthorizationDocumentType"/> model
    /// </summary>
    Guid? RefIepauthorizationDocumentTypeId { get; set; }

    #endregion
}
