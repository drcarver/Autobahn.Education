//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentCredentialEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefAgentCredential file
/// </summary>
public partial class CredentialDefAgentCredentialModel : AutobahnBaseModel, ICredentialDefAgentCredential
{
    #region "ICredentialDefAgentCredential Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefAgent"/> model
    /// </summary>
    public Guid CredentialDefAgentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    public Guid CredentialDefinitionId { get; set; }

    #endregion
}
