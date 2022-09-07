//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationProgramTypeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationProgramType file
/// </summary>
[Table("OrganizationProgramType", Schema = "Organization")]
public partial class OrganizationProgramTypeEntity : EntityBase, IOrganizationProgramType
{
    #region "IOrganizationProgramType Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Program Type
    /// <para>
    /// The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19225">Program Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefProgramType")]
    [Comment("The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.")]
    public Guid RefProgramTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19225">Program Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefProgramTypeEntity RefProgramTypeEntity { get; set; }

    #endregion
}
