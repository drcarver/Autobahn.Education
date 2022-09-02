//***************************************************************************
//* DomainName: Common Models
//* FileName:   CredentialAwardEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialAward file
/// </summary>
public partial class CredentialAwardModel : AutobahnBaseModel, ICredentialAward
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
    public System.String AdvancedStandingDescription { get; set; }

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
    public DateTime? CredentialAwardStartDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    public Guid CredentialDefinitionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> model
    /// </summary>
    public Guid CredentialIssuerId { get; set; }

    public System.String EvidenceUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
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
    public System.String RevokedReason { get; set; }

    #endregion
}
