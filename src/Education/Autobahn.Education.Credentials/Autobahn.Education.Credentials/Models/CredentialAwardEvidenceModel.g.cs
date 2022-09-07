//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardEvidenceEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialAwardEvidence file
/// </summary>
public partial class CredentialAwardEvidenceModel : AutobahnBaseModel, ICredentialAwardEvidence
{
    #region "ICredentialAwardEvidence Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
    /// </summary>
    public Guid? AssessmentResultId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialAward"/> model
    /// </summary>
    public Guid CredentialAwardId { get; set; }

    /// <summary>
    /// Credential Evidence Statement
    /// <para>
    /// A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19901">Credential Evidence Statement</a>
    /// </para>
    /// </summary>
    public System.String Statement { get; set; }

    #endregion
}
