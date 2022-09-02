//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   ReferenceBaseEntity.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// The base abstract reference Entity
/// </summary>
public class ReferenceBaseEntity : EntityBase, IReferenceBase
{
    /// <summary>
    /// Defines the Code non nullable property
    /// </summary>
    [Required(ErrorMessage = "{0} is required")]
    [StringLength(50)]
    public string? Code { get; set; }

    /// <summary>
    /// Defines the Description non nullable property
    /// </summary>
    [Required(ErrorMessage = "{0} is required")]
    [StringLength(150)]
    public string? Description { get; set; }

    /// <summary>
    /// Defines the Definition non nullable property
    /// </summary>
    [StringLength(4000)]
    public string? Definition { get; set; }

    /// <summary>
    /// Surrogate key from <see cref="EntityBase"/> identifying the publisher of the reference value.
    /// </summary>
    [ForeignKey("Organization")]
    public Guid? RefJurisdictionId { get; set; }

    /// <summary>
    /// Defines the SortOrder nullable property
    /// </summary>
    public decimal? SortOrder { get; set; }

    /// <summary>
    /// The Organization for the Reference
    /// </summary>
    public virtual OrganizationEntity? Organization { get; set; }
}
