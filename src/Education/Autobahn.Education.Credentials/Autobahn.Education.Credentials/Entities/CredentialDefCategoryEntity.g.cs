//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCategoryEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefCategory file
/// </summary>
[Table("CredentialDefCategory", Schema = "Credentials")]
public partial class CredentialDefCategoryEntity : EntityBase, ICredentialDefCategory
{
    #region "ICredentialDefCategory Properties"
    /// <summary>
    /// Credential Definition Category Type
    /// <para>
    /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19892">Credential Definition Category Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.")]
    public System.String Category { get; set; }

    /// <summary>
    /// Credential Definition Category System
    /// <para>
    /// The system that defines the categories of the qualification, achievement, personal or organizational quality, or aspect of an identity used in Credential Category Type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20211">Credential Definition Category System</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The system that defines the categories of the qualification, achievement, personal or organizational quality, or aspect of an identity used in Credential Category Type.")]
    public System.String CategorySystem { get; set; }

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

    #endregion
}
