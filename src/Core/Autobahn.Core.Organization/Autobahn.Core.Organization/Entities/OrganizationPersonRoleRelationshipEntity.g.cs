//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationPersonRoleRelationshipEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPersonRoleRelationship file
/// </summary>
[Table("OrganizationPersonRoleRelationship", Schema = "Organization")]
public partial class OrganizationPersonRoleRelationshipEntity : EntityBase, IOrganizationPersonRoleRelationship
{
    #region "IOrganizationPersonRoleRelationship Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 OrganizationPersonRoleIdParent { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
