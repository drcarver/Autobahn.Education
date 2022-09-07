//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationEmailEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationEmail file
/// </summary>
[Table("OrganizationEmail", Schema = "Organization")]
public partial class OrganizationEmailEntity : EntityBase, IOrganizationEmail
{
    #region "IOrganizationEmail Properties"
    /// <summary>
    /// Do Not Publish Indicator
    /// <para>
    /// An indication that the record should not be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
    /// </para>
    /// </summary>
    [Comment("An indication that the record should not be published.")]
    public Boolean? DoNotPublishIndicator { get; set; }

    /// <summary>
    /// Electronic Mail Address
    /// <para>
    /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19088">Electronic Mail Address</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(128,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.")]
    public System.String ElectronicMailAddress { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationEmailType"/> model
    /// </summary>
    [ForeignKey("RefOrganizationEmailType")]
    public Guid? RefOrganizationEmailTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefOrganizationEmailType"/> implementation
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefOrganizationEmailTypeEntity? RefOrganizationEmailTypeEntity { get; set; }

    #endregion
}
