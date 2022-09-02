//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   RefRoleEntity.cs
//***************************************************************************

using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// A description of the way in which a person relates to an organization.
/// </summary>
[Table("RefRole", Schema = "Core")]
public class RefRoleEntity : ReferenceBaseEntity
{
}
