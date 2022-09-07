//***************************************************************************
//* DomainName: Credentials
//* FileName:   ICredentialDefAgentCredential.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefAgentCredential file
/// </summary>
public partial interface ICredentialDefAgentCredential
{
    #region "ICredentialDefAgentCredential Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefAgent"/> model
    /// </summary>
    Guid CredentialDefAgentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    Guid CredentialDefinitionId { get; set; }

    #endregion
}
