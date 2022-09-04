//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationImageEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationImage file
/// </summary>
[Table("OrganizationImage", Schema = "Autobahn.Core.Organization")]
public partial class OrganizationImageEntity : EntityBase, IOrganizationImage
{
    #region "IOrganizationImage Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Url { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
