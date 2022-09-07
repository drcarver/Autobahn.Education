//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationWebsiteEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationWebsite file
/// </summary>
[Table("OrganizationWebsite", Schema = "Organization")]
public partial class OrganizationWebsiteEntity : EntityBase, IOrganizationWebsite
{
    #region "IOrganizationWebsite Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Web Site Address
    /// <para>
    /// The Uniform Resource Locator (URL) for the unique address of a Web page.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19300">Web Site Address</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The Uniform Resource Locator (URL) for the unique address of a Web page.")]
    public System.String Website { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
