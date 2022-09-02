//***************************************************************************
//* DomainName: Common Models
//* FileName:   CredentialAwardEvidenceEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialAwardEvidence file
/// </summary>
[Table("CredentialAwardEvidence", Schema = "Common")]
public partial class CredentialAwardEvidenceEntity : EntityBase, ICredentialAwardEvidence
{
    #region "ICredentialAwardEvidence Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
    /// </summary>
    [ForeignKey("AssessmentResult")]
    public Guid? AssessmentResultId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialAward"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialAward")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A statement or reference describing the evidence that the learner met the criteria for attainment of the qualification, achievement, personal or organizational quality, or aspect of an identity.")]
    public System.String Statement { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialAward"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual CredentialAwardEntity CredentialAwardEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentResultEntity AssessmentResultEntity { get; set; }

    #endregion
}
