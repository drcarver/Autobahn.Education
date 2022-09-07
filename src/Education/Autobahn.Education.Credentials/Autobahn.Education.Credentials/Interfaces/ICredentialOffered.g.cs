//***************************************************************************
//* DomainName: Credentials
//* FileName:   ICredentialOffered.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialOffered file
/// </summary>
public partial interface ICredentialOffered
{
    #region "ICredentialOffered Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    Guid CredentialDefinitionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> model
    /// </summary>
    Guid CredentialIssuerId { get; set; }

    /// <summary>
    /// Credential Offered End Date
    /// <para>
    /// The last date a credential was offered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20893">Credential Offered End Date</a>
    /// </para>
    /// </summary>
    DateTime? CredentialOfferedEndDate { get; set; }

    /// <summary>
    /// Credential Offered Start Date
    /// <para>
    /// The first date a credential was offered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20892">Credential Offered Start Date</a>
    /// </para>
    /// </summary>
    DateTime? CredentialOfferedStartDate { get; set; }

    #endregion
}
