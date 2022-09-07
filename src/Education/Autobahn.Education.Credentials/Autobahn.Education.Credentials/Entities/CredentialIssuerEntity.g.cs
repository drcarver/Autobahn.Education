//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialIssuerEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialIssuer file
/// </summary>
[Table("CredentialIssuer", Schema = "Credentials")]
public partial class CredentialIssuerEntity : EntityBase, ICredentialIssuer
{
    #region "ICredentialIssuer Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AwardIssuerOriginUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCtdlorganizationType"/> model
    /// </summary>
    [ForeignKey("RefCtdlorganizationType")]
    public Guid? RefCtdlorganizationTypeId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RevocationListUrl { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCtdlorganizationType"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual RefCtdlorganizationTypeEntity? RefCtdlorganizationTypeEntity { get; set; }

    #endregion
}
