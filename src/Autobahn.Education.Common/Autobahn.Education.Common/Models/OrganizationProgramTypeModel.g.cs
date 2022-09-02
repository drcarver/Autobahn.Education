//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationProgramTypeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationProgramType file
/// </summary>
public partial class OrganizationProgramTypeModel : AutobahnBaseModel, IOrganizationProgramType
{
    #region "IOrganizationProgramType Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
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
    public Guid RefProgramTypeId { get; set; }

    #endregion
}
