//***************************************************************************
//* DomainName: Credentials
//* FileName:   ICredentialDefCategory.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefCategory file
/// </summary>
public partial interface ICredentialDefCategory
{
    #region "ICredentialDefCategory Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Credential Definition Category Type
    /// <para>
    /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19892">Credential Definition Category Type</a>
    /// </para>
    /// </summary>
    System.String Category { get; set; }

    /// <summary>
    /// Credential Definition Category System
    /// <para>
    /// The system that defines the categories of the qualification, achievement, personal or organizational quality, or aspect of an identity used in Credential Category Type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20211">Credential Definition Category System</a>
    /// </para>
    /// </summary>
    System.String CategorySystem { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    Guid CredentialDefinitionId { get; set; }

    #endregion
}
