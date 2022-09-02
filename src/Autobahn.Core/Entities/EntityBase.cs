//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   EntityBaseModel.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// The base model for autobahn Entites.  All entites inherit from 
/// this
/// </summary>
public class EntityBase
{
    /// <summary>
    /// The Id of the item
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Is it a deleted item?
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// Date the entity was last updated
    /// </summary>
    public DateTime UpdatedOn { get; set; }

    /// <summary>
    /// Date the person who last updated the entity
    /// </summary>
    [ForeignKey("Person")]
    public Guid UpdatedBy { get; set; }
}