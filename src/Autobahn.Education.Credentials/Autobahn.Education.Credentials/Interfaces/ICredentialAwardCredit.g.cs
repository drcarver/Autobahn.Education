//***************************************************************************
//* DomainName: Credentials
//* FileName:   ICredentialAwardCredit.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialAwardCredit file
/// </summary>
public partial interface ICredentialAwardCredit
{
    #region "ICredentialAwardCredit Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialAward"/> model
    /// </summary>
    Guid CredentialAwardId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialCriteriaCourse"/> model
    /// </summary>
    Guid? CredentialCriteriaCourseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid? OrganizationPersonRoleId { get; set; }

    #endregion
}
