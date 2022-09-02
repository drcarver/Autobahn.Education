//**********************************************************
//* DomainName: Autobahn.Core.
//* FileName:   OrganizationPersonRoleEntity.cs
//***************************************************************************

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// The relation role a person plays in an organization and the 
/// dates of the relation ship is active
/// </summary>
[Table("OrganizationPersonRole", Schema = "Core")]
public partial class OrganizationPersonRoleEntity : EntityBase, IOrganizationPersonRole
{
    #region "IOrganizationPersonRole Properties"
    /// <summary>
    /// Activity Involvement Begin Date
    /// <para>
    /// The year, month and day on which the person began to participate in the activity.
    /// </para>
    /// </summary>
    public DateTime? EntryDate { get; set; }

    /// <summary>
    /// Activity Involvement End Date
    /// <para>
    /// The year, month and day on which the person ceased to participate in the activity.
    /// </para>
    /// </summary>
    public DateTime? ExitDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of an <see cref="IOrganization"/>
    /// </summary>
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRole"/> model
    /// </summary>
    [ForeignKey("Role")]
    public Guid RoleId { get; set; }
    #endregion

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRole"/> entity
    /// </summary>
    public virtual RoleEntity Role { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public virtual OrganizationEntity Organization { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public virtual PersonEntity Person { get; set; }

}
