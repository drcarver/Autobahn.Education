//***************************************************************************
//* DomainName: Common Models
//* FileName:   IOrganizationPersonRoleRelationship.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPersonRoleRelationship file
/// </summary>
public partial interface IOrganizationPersonRoleRelationship
{
    #region "IOrganizationPersonRoleRelationship Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    System.Int32 OrganizationPersonRoleIdParent { get; set; }

    #endregion
}
