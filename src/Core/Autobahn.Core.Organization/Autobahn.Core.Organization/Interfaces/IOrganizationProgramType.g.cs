//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationProgramType.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationProgramType file
/// </summary>
public partial interface IOrganizationProgramType
{
    #region "IOrganizationProgramType Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Program Type
    /// <para>
    /// The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19225">Program Type</a>
    /// </para>
    /// </summary>
    Guid RefProgramTypeId { get; set; }

    #endregion
}
