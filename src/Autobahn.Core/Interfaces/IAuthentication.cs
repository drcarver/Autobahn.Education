//**********************************************************
//* DomainName: AUtobahn.Core
//* FileName:   IAuthentication.cs
//***************************************************************************

/// <summary>
/// The Authentication interface
/// </summary>
public partial interface IAuthentication
{
    #region "IAuthentication Properties"
    /// <summary>
    /// The primary key
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Authentication Identity Provider End Date
    /// <para>
    /// The date after which the  an associated person is no longer 
    /// allowed to use the specified Authentication Identity Provider 
    /// to authenticate identity.
    /// </para>
    /// </summary>
    DateTime? EndDate { get; set; }

    /// <summary>
    /// Authentication Identity Provider Name
    /// <para>
    /// The name of a provider that can authenticate the identity of 
    /// an person.
    /// </para>
    /// </summary>
    string IdentityProviderName { get; set; }

    /// <summary>
    /// Authentication Identity Provider URI
    /// <para>
    /// The Uniform Resource Identifier (URI) of the Authentication 
    /// Identity Provider.
    /// </para>
    /// </summary>
    Uri IdentityProviderUri { get; set; }

    /// <summary>
    /// Authentication Identity Provider Login Identifier
    /// <para>
    /// The login identifier for the person for the specified 
    /// Authentication Identity Provider.
    /// </para>
    /// </summary>
    string LoginIdentifier { get; set; }

    /// <summary>
    /// Authentication Identity Provider Encrypted password
    /// <para>
    /// The encrypted password for the person for the specified 
    /// Authentication Identity Provider.
    /// </para>
    /// </summary>
    string Password { get; set; }

    /// <summary>
    /// Reference to an instance of the 
    /// <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Authentication Identity Provider Start Date
    /// <para>
    /// The date on which the  an associated person may begin to use 
    /// the specified Authentication Identity Provider to authenticate 
    /// identity.
    /// </para>
    /// </summary>
    public DateTime? StartDate { get; set; }
    #endregion
}
