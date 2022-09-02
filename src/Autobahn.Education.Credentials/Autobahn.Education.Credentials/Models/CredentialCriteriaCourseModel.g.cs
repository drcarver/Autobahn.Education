//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialCriteriaCourseEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialCriteriaCourse file
/// </summary>
public partial class CredentialCriteriaCourseModel : AutobahnBaseModel, ICredentialCriteriaCourse
{
    #region "ICredentialCriteriaCourse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    public Guid CourseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
    /// </summary>
    public Guid CredentialDefCriteriaId { get; set; }

    #endregion
}
