//**********************************************************
//* DomainName: Common Interfaces used in multiple domains.
//* FileName:   IOrganizationPersonRole.cs
//***************************************************************************

public interface IOrganizationPersonRole
{
    /// <summary>
    /// The primary key of the model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Activity Involvement Begin Date
    /// <para>
    /// The year, month and day on which the person began
    /// to participate in the activity.
    /// </para>
    /// </summary>
    DateTime? EntryDate { get; set; }

    /// <summary>
    /// Activity Involvement End Date
    /// <para>
    /// The year, month and day on which the person ceased 
    /// to participate in the activity.
    /// </para>
    /// </summary>
    DateTime? ExitDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the 
    /// <see cref="EntityBase"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the 
    /// <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the 
    /// <see cref="IRole"/> model
    /// </summary>
    Guid RoleId { get; set; }
}