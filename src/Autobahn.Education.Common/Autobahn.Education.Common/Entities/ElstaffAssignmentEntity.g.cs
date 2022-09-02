//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElstaffAssignmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffAssignment file
/// </summary>
[Table("ElstaffAssignment", Schema = "Common")]
public partial class ElstaffAssignmentEntity : EntityBase, IElstaffAssignment
{
    #region "IElstaffAssignment Properties"
    [Required(ErrorMessage="{0} is required.")]
    public System.Boolean ItinerantProvider { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
