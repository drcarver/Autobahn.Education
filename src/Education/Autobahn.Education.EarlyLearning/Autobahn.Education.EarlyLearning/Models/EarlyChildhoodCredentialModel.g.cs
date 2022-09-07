//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodCredentialEntity.g.cs
//***************************************************************************

/// <summary>
/// The IEarlyChildhoodCredential file
/// </summary>
public partial class EarlyChildhoodCredentialModel : AutobahnBaseModel, IEarlyChildhoodCredential
{
    #region "IEarlyChildhoodCredential Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
    /// </summary>
    public Guid PersonCredentialId { get; set; }

    /// <summary>
    /// Early Childhood Credential
    /// <para>
    /// The credential related to early childhood education or development held by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19344">Early Childhood Credential</a>
    /// </para>
    /// </summary>
    public Guid RefEarlyChildhoodCredentialId { get; set; }

    #endregion
}
