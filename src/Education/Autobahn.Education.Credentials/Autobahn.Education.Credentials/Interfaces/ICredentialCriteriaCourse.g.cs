//***************************************************************************
//* DomainName: Credentials
//* FileName:   ICredentialCriteriaCourse.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialCriteriaCourse file
/// </summary>
public partial interface ICredentialCriteriaCourse
{
    #region "ICredentialCriteriaCourse Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    Guid CourseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
    /// </summary>
    Guid CredentialDefCriteriaId { get; set; }

    #endregion
}
