//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IEarlyChildhoodCredential.g.cs
//***************************************************************************

/// <summary>
/// The IEarlyChildhoodCredential file
/// </summary>
public partial interface IEarlyChildhoodCredential
{
    #region "IEarlyChildhoodCredential Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
    /// </summary>
    Guid PersonCredentialId { get; set; }

    /// <summary>
    /// Early Childhood Credential
    /// <para>
    /// The credential related to early childhood education or development held by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19344">Early Childhood Credential</a>
    /// </para>
    /// </summary>
    Guid RefEarlyChildhoodCredentialId { get; set; }

    #endregion
}
