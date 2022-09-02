//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElstaffEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElstaff file
/// </summary>
[Table("Elstaff", Schema = "Common")]
public partial class ElstaffEntity : EntityBase, IElstaff
{
    #region "IElstaff Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefChildDevelopmentAssociateType"/> model
    /// </summary>
    [ForeignKey("RefChildDevelopmentAssociateType")]
    public Guid? RefChildDevelopmentAssociateTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefChildDevelopmentAssociateType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefChildDevelopmentAssociateTypeEntity RefChildDevelopmentAssociateTypeEntity { get; set; }

    #endregion
}
