//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleFteEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPersonRoleFte file
/// </summary>
[Table("OrganizationPersonRoleFte", Schema = "Common")]
public partial class OrganizationPersonRoleFteEntity : EntityBase, IOrganizationPersonRoleFte
{
    #region "IOrganizationPersonRoleFte Properties"
    [Required(ErrorMessage="{0} is required.")]
    public System.Decimal FullTimeEquivalency { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 OrganizationPersonRoleFteid { get; set; }

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
