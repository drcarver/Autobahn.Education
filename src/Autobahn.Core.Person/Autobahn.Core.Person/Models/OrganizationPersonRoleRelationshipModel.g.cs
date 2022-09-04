//***************************************************************************
//* DomainName: Person Models
//* FileName:   OrganizationPersonRoleRelationshipEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPersonRoleRelationship file
/// </summary>
public partial class OrganizationPersonRoleRelationshipModel : AutobahnBaseModel, IOrganizationPersonRoleRelationship
{
    #region "IOrganizationPersonRoleRelationship Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    public System.Int32 OrganizationPersonRoleIdParent { get; set; }

    #endregion
}
