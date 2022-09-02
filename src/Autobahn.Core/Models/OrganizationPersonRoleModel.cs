//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   OrganizationPersonRoleModel.cs
//**********************************************************

/// <summary>
/// The relation role a person plays in an organization and the 
/// dates of the relation ship is active
/// </summary>
public class OrganizationPersonRoleModel : AutobahnBaseModel, IOrganizationPersonRole
{
    /// <summary>
    /// Activity Involvement Begin Date
    /// <para>
    /// The year, month and day on which the person began
    /// to participate in the activity.
    /// </para>
    /// </summary>
    public DateTime? EntryDate { get; set; }

    /// <summary>
    /// Activity Involvement End Date
    /// <para>
    /// The year, month and day on which the person ceased 
    /// to participate in the activity.
    /// </para>
    /// </summary>
    public DateTime? ExitDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the 
    /// <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the 
    /// <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the 
    /// <see cref="IRole"/> model
    /// </summary>
    public Guid RoleId { get; set; }
}
