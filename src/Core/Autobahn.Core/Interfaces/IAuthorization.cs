//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   IAuthorization.cs
//***************************************************************************

/// <summary>
/// The Authorization Interface
/// </summary>
public partial interface IAuthorization
{
    #region "IAuthorization Properties"
    /// <summary>
    /// The primary key
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAutobahnApplication"/> 
    /// model
    /// </summary>
    Guid AutobahnApplicationId { get; set; }

    /// <summary>
    /// Authorization Application Role Name
    /// <para>
    /// The user role for which the person is allowed.
    /// </para>
    /// </summary>
    string ApplicationRoleName { get; set; }

    /// <summary>
    /// Authorization End Date
    /// <para>
    /// The date after which the  an associated person is no longer allowed to use the application with the specified role.
    /// </para>
    /// </summary>
    DateTime? EndDate { get; set; }

    /// <summary>
    /// Reference to a instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Authorization Start Date
    /// <para>
    /// The date on which the  an associated person  is authorized to start
    /// using the application with the specified role.
    /// </para>
    /// </summary>
    DateTime? StartDate { get; set; }
    #endregion
}
