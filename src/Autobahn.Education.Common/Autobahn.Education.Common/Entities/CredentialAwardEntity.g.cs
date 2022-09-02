//***************************************************************************
//* DomainName: Common Models
//* FileName:   CredentialAwardEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialAward file
/// </summary>
[Table("CredentialAward", Schema = "Common")]
public partial class CredentialAwardEntity : EntityBase, ICredentialAward
{
    #region "ICredentialAward Properties"
    /// <summary>
    /// Credential Advanced Standing Description
    /// <para>
    /// A description of a credential that reduced the time or cost of attaining this credential.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20715">Credential Advanced Standing Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("A description of a credential that reduced the time or cost of attaining this credential.")]
    public System.String AdvancedStandingDescription { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AdvancedStandingUrl { get; set; }

    /// <summary>
    /// Credential Award Approver Name
    /// <para>
    /// Pronouncement of a favorable judgment by the agent being referenced.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20718">Credential Award Approver Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Pronouncement of a favorable judgment by the agent being referenced.")]
    public System.String ApproverName { get; set; }

    /// <summary>
    /// Credential Completion Date
    /// <para>
    /// The date on which the person's requirements for earning a credential were met or completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20645">Credential Completion Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the person's requirements for earning a credential were met or completed.")]
    public DateTime? CompletionDate { get; set; }

    /// <summary>
    /// Credential Award End Date
    /// <para>
    /// The date, if any, on which the qualification, achievement, personal or organizational quality, or aspect of an identity expires or requires renewal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20121">Credential Award End Date</a>
    /// </para>
    /// </summary>
    [Comment("The date, if any, on which the qualification, achievement, personal or organizational quality, or aspect of an identity expires or requires renewal.")]
    public DateTime? CredentialAwardEndDate { get; set; }

    /// <summary>
    /// Credential Award Start Date
    /// <para>
    /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20120">Credential Award Start Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.")]
    public DateTime? CredentialAwardStartDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialDefinition")]
    public Guid CredentialDefinitionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialIssuer")]
    public Guid CredentialIssuerId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EvidenceUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [ForeignKey("Organization")]
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [ForeignKey("Person")]
    public Guid? PersonId { get; set; }

    /// <summary>
    /// Credential Revoked Date
    /// <para>
    /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was revoked.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20641">Credential Revoked Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was revoked.")]
    public DateTime? RevokedDate { get; set; }

    /// <summary>
    /// Credential Revoked Indicator
    /// <para>
    /// Indicates whether the credential has been revoked by the credential provider.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20732">Credential Revoked Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates whether the credential has been revoked by the credential provider.")]
    public Boolean? RevokedIndicator { get; set; }

    /// <summary>
    /// Credential Revoked Reason
    /// <para>
    /// Published reason for revocation of a credential award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20642">Credential Revoked Reason</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Published reason for revocation of a credential award.")]
    public System.String RevokedReason { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual CredentialDefinitionEntity CredentialDefinitionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual CredentialIssuerEntity CredentialIssuerEntity { get; set; }

    #endregion
}
