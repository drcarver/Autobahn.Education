//***************************************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IWorkforceProgramParticipation file
/// </summary>
[Table("WorkforceProgramParticipation", Schema = "Workforce")]
public partial class WorkforceProgramParticipationEntity : EntityBase, IWorkforceProgramParticipation
{
    #region "IWorkforceProgramParticipation Properties"
    /// <summary>
    /// Diploma or Credential Award Date
    /// <para>
    /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(7,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.")]
    public System.String DiplomaOrCredentialAwardDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Professional or Technical Credential Conferred
    /// <para>
    /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefProfessionalTechnicalCredentialType")]
    [Comment("An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.")]
    public Guid? RefProfessionalTechnicalCredentialTypeId { get; set; }

    /// <summary>
    /// Workforce Program Type
    /// <para>
    /// The type of workforce and employment development program that an individual is participating in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20000">Workforce Program Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefWfProgramParticipation")]
    [Comment("The type of workforce and employment development program that an individual is participating in.")]
    public Guid? RefWfProgramParticipationId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> implementation
    /// <remarks>
    /// This entity is in the Workforce domain
    /// </remarks>
    /// </summary>
    public virtual PersonProgramParticipationEntity PersonProgramParticipationEntity { get; set; }

    /// <summary>
    /// The type of workforce and employment development program that an individual is participating in.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20000">Workforce Program Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Workforce domain
    /// </remarks>
    /// </summary>
    public virtual RefWfProgramParticipationEntity RefWfProgramParticipationEntity { get; set; }

    /// <summary>
    /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Workforce domain
    /// </remarks>
    /// </summary>
    public virtual RefProfessionalTechnicalCredentialTypeEntity RefProfessionalTechnicalCredentialTypeEntity { get; set; }

    #endregion
}
