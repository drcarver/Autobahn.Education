//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialIssuer file
/// </summary>
public partial class CredentialIssuerModel : AutobahnBaseModel, ICredentialIssuer
{
    #region "ICredentialIssuer Properties"
    public System.String AwardIssuerOriginUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCtdlorganizationType"/> model
    /// </summary>
    public Guid? RefCtdlorganizationTypeId { get; set; }

    public System.String RevocationListUrl { get; set; }

    #endregion
}
