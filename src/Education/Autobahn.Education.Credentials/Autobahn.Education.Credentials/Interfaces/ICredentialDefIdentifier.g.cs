//***************************************************************************
//* DomainName: Credentials
//* FileName:   ICredentialDefIdentifier.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefIdentifier file
/// </summary>
public partial interface ICredentialDefIdentifier
{
    #region "ICredentialDefIdentifier Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    Guid CredentialDefinitionId { get; set; }

    /// <summary>
    /// Credential Definition Identifier
    /// <para>
    /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
    /// </para>
    /// <para>
    /// <a href="">Credential Definition Identifier</a>
    /// </para>
    /// </summary>
    System.String Identifier { get; set; }

    /// <summary>
    /// Credential Definition Identifier System
    /// <para>
    /// A coding scheme that is used for identification and record-keeping purposes by a credentialing organization to refer to a qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20720">Credential Definition Identifier System</a>
    /// </para>
    /// </summary>
    Guid? RefCredentialIdentifierSystemId { get; set; }

    #endregion
}
