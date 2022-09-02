//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   RefAuthorizerTypeEntity.cs
//***************************************************************************

using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Type of person who authorized the decision or document.
/// </summary>
[Table("RefAuthorizerType", Schema = "Core")]
public class RefAuthorizerTypeEntity : ReferenceBaseEntity
{
}
