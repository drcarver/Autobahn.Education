//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationDetailEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationDetail file
/// </summary>
[Table("OrganizationDetail", Schema = "Common")]
public partial class OrganizationDetailEntity : EntityBase, IOrganizationDetail
{
    #region "IOrganizationDetail Properties"
    /// <summary>
    /// Activity Title
    /// <para>
    /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19009">Activity Title</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(128,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The title for a particular activity, such as a co-curricular or extra-curricular activity.")]
    public System.String Name { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
    /// </summary>
    [ForeignKey("RefOrganizationType")]
    public Guid? RefOrganizationTypeId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2000,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RegionGeoJson { get; set; }

    /// <summary>
    /// Short Name of Institution
    /// <para>
    /// The name of the institution, which may be the abbreviated form of the full legally accepted name.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20459">Short Name of Institution</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the institution, which may be the abbreviated form of the full legally accepted name.")]
    public System.String ShortName { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefOrganizationType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefOrganizationTypeEntity RefOrganizationTypeEntity { get; set; }

    #endregion
}
