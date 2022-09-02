//***************************************************************************
//* DomainName: Common Models
//* FileName:   ICredentialAward.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialAward file
/// </summary>
public partial interface ICredentialAward
{
    #region "ICredentialAward Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Credential Advanced Standing Description
    /// <para>
    /// A description of a credential that reduced the time or cost of attaining this credential.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20715">Credential Advanced Standing Description</a>
    /// </para>
    /// </summary>
    System.String AdvancedStandingDescription { get; set; }

    System.String AdvancedStandingUrl { get; set; }

    /// <summary>
    /// Credential Award Approver Name
    /// <para>
    /// Pronouncement of a favorable judgment by the agent being referenced.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20718">Credential Award Approver Name</a>
    /// </para>
    /// </summary>
    System.String ApproverName { get; set; }

    /// <summary>
    /// Credential Completion Date
    /// <para>
    /// The date on which the person's requirements for earning a credential were met or completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20645">Credential Completion Date</a>
    /// </para>
    /// </summary>
    DateTime? CompletionDate { get; set; }

    /// <summary>
    /// Credential Award End Date
    /// <para>
    /// The date, if any, on which the qualification, achievement, personal or organizational quality, or aspect of an identity expires or requires renewal.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20121">Credential Award End Date</a>
    /// </para>
    /// </summary>
    DateTime? CredentialAwardEndDate { get; set; }

    /// <summary>
    /// Credential Award Start Date
    /// <para>
    /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was conferred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20120">Credential Award Start Date</a>
    /// </para>
    /// </summary>
    DateTime? CredentialAwardStartDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    Guid CredentialDefinitionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> model
    /// </summary>
    Guid CredentialIssuerId { get; set; }

    System.String EvidenceUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid? PersonId { get; set; }

    /// <summary>
    /// Credential Revoked Date
    /// <para>
    /// The date on which the qualification, achievement, personal or organizational quality, or aspect of an identity was revoked.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20641">Credential Revoked Date</a>
    /// </para>
    /// </summary>
    DateTime? RevokedDate { get; set; }

    /// <summary>
    /// Credential Revoked Indicator
    /// <para>
    /// Indicates whether the credential has been revoked by the credential provider.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20732">Credential Revoked Indicator</a>
    /// </para>
    /// </summary>
    Boolean? RevokedIndicator { get; set; }

    /// <summary>
    /// Credential Revoked Reason
    /// <para>
    /// Published reason for revocation of a credential award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20642">Credential Revoked Reason</a>
    /// </para>
    /// </summary>
    System.String RevokedReason { get; set; }

    #endregion
}
