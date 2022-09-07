//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentCredentialEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefAgentCredential file
/// </summary>
[Table("CredentialDefAgentCredential", Schema = "Credentials")]
public partial class CredentialDefAgentCredentialEntity : EntityBase, ICredentialDefAgentCredential
{
    #region "ICredentialDefAgentCredential Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefAgent"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialDefAgent")]
    public Guid CredentialDefAgentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialDefinition")]
    public Guid CredentialDefinitionId { get; set; }

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
    /// Reference to an optional instance of the <see cref="ICredentialDefAgent"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual CredentialDefAgentEntity CredentialDefAgentEntity { get; set; }

    #endregion
}
