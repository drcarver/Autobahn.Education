//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationPolicyEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPolicy file
/// </summary>
[Table("OrganizationPolicy", Schema = "Organization")]
public partial class OrganizationPolicyEntity : EntityBase, IOrganizationPolicy
{
    #region "IOrganizationPolicy Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Personnel Policy Type
    /// <para>
    /// Policies related to personnel in the organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19842">Personnel Policy Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Policies related to personnel in the organization.")]
    public System.String PolicyType { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Value { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
