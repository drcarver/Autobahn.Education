//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialOfferedEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialOffered file
/// </summary>
[Table("CredentialOffered", Schema = "Credentials")]
public partial class CredentialOfferedEntity : EntityBase, ICredentialOffered
{
    #region "ICredentialOffered Properties"
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

    /// <summary>
    /// Credential Offered End Date
    /// <para>
    /// The last date a credential was offered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20893">Credential Offered End Date</a>
    /// </para>
    /// </summary>
    [Comment("The last date a credential was offered.")]
    public DateTime? CredentialOfferedEndDate { get; set; }

    /// <summary>
    /// Credential Offered Start Date
    /// <para>
    /// The first date a credential was offered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20892">Credential Offered Start Date</a>
    /// </para>
    /// </summary>
    [Comment("The first date a credential was offered.")]
    public DateTime? CredentialOfferedStartDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual CredentialDefinitionEntity CredentialDefinitionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialIssuer"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual CredentialIssuerEntity CredentialIssuerEntity { get; set; }

    #endregion
}
