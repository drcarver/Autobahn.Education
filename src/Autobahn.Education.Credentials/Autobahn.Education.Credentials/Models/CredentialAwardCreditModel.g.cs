//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardCreditEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialAwardCredit file
/// </summary>
public partial class CredentialAwardCreditModel : AutobahnBaseModel, ICredentialAwardCredit
{
    #region "ICredentialAwardCredit Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialAward"/> model
    /// </summary>
    public Guid CredentialAwardId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialCriteriaCourse"/> model
    /// </summary>
    public Guid? CredentialCriteriaCourseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid? OrganizationPersonRoleId { get; set; }

    #endregion
}
