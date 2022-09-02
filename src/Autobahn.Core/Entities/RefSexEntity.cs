//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   RefSexEntity.cs
//***************************************************************************

using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Sex
/// <para>
/// The concept describing the biological traits that distinguish the males and females of a species.
/// </para>
/// </summary>
[Table("RefSex", Schema = "Core")]
public class RefSexEntity : ReferenceBaseEntity
{
}
