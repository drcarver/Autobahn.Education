//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   AuthorizationModel.cs
//***************************************************************************

/// <summary>
/// The Authorization Model
/// </summary>
public partial class AuthorizationModel : AutobahnBaseModel, IAuthorization
{
    #region "IAuthorization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAutobahnApplication"/> model
    /// </summary>
    public Guid AutobahnApplicationId { get; set; }

    /// <summary>
    /// Authorization Application Role Name
    /// <para>
    /// The user role for which the person is allowed.
    /// </para>
    /// </summary>
    public System.String ApplicationRoleName { get; set; }

    /// <summary>
    /// Authorization End Date
    /// <para>
    /// The date after which the  an associated person is no longer allowed to use the application with the specified role.
    /// </para>
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Authorization Start Date
    /// <para>
    /// The date on which the  an associated person  is authorized to start using the application with the specified role.
    /// </para>
    /// </summary>
    public DateTime? StartDate { get; set; }
    #endregion
}
