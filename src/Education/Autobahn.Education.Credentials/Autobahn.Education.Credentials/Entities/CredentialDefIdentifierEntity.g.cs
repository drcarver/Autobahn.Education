//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefIdentifierEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefIdentifier file
/// </summary>
[Table("CredentialDefIdentifier", Schema = "Credentials")]
public partial class CredentialDefIdentifierEntity : EntityBase, ICredentialDefIdentifier
{
    #region "ICredentialDefIdentifier Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialDefinition")]
    public Guid CredentialDefinitionId { get; set; }

    /// <summary>
    /// Credential Definition Identifier
    /// <para>
    /// A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.
    /// </para>
    /// <para>
    /// <a href="">Credential Definition Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A globally unique identifier by which the creator/owner/provider of a credential recognizes the qualification, achievement, personal or organizational quality, or aspect of an identity in transactions with the external environment.")]
    public System.String Identifier { get; set; }

    /// <summary>
    /// Credential Definition Identifier System
    /// <para>
    /// A coding scheme that is used for identification and record-keeping purposes by a credentialing organization to refer to a qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20720">Credential Definition Identifier System</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCredentialentifierSystem")]
    [Comment("A coding scheme that is used for identification and record-keeping purposes by a credentialing organization to refer to a qualification, achievement, personal or organizational quality, or aspect of an identity.")]
    public Guid? RefCredentialIdentifierSystemId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual CredentialDefinitionEntity CredentialDefinitionEntity { get; set; }

    #endregion
}
