//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   IRole.cs
//***************************************************************************

public interface IRole
{
    /// <summary>
    /// The primary key of the model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Role
    /// <para>
    /// A description of the way in which a person relates 
    /// to an organization.
    /// </para>
    /// </summary>
    System.String Name { get; set; }

    /// <summary>
    /// Role Type
    /// <para>
    /// A description of the way in which a person relates to an organization.
    /// </para>
    /// </summary>
    Guid? RefRoleId { get; set; }
}