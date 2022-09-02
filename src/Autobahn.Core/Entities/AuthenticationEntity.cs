//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   AuthenticationEntity.cs
//***************************************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// The Authentication Entity
/// </summary>
[Table("Authentication", Schema = "Core")]
public partial class AuthenticationEntity : EntityBase, IAuthentication
{
    #region "IAuthentication Properties"
    /// <summary>
    /// Authentication Identity Provider End Date
    /// <para>
    /// The date after which the  an associated person is no longer 
    /// allowed to use the specified Authentication Identity Provider 
    /// to authenticate identity.
    /// </para>
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Authentication Identity Provider Name
    /// <para>
    /// The name of a provider that can authenticate the identity of an person.
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IdentityProviderName { get; set; }

    /// <summary>
    /// Authentication Identity Provider URI
    /// <para>
    /// The Uniform Resource Identifier (URI) of the  Authentication Identity Provider.
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public Uri IdentityProviderUri { get; set; }

    /// <summary>
    /// Authentication Identity Provider Login Identifier
    /// <para>
    /// The login identifier for the person for the specified Authentication Identity Provider.
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LoginIdentifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> 
    /// Entity
    /// </summary>
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Authentication Identity Provider Start Date
    /// <para>
    /// The date on which the  an associated person may begin to use the specified Authentication Identity Provider to authenticate identity.
    /// </para>
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The encrypted password for the user
    /// </summary>
    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(40, ErrorMessage = "The {0} must be less then {1} characters.")]
    public string? Password { get; set; }
    #endregion

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> 
    /// Entity
    /// </summary>
    public virtual OrganizationPersonRoleEntity OrganizationPersonRole { get; set; }
}
