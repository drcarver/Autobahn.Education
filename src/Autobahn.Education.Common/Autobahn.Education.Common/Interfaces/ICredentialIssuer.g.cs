//***************************************************************************
//* DomainName: Common Models
//* FileName:   ICredentialIssuer.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialIssuer file
/// </summary>
public partial interface ICredentialIssuer
{
    #region "ICredentialIssuer Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String AwardIssuerOriginUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCtdlorganizationType"/> model
    /// </summary>
    Guid? RefCtdlorganizationTypeId { get; set; }

    System.String RevocationListUrl { get; set; }

    #endregion
}
