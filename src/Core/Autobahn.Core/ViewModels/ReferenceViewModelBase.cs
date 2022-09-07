//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   ReferenceViewModelBase.cs
//***************************************************************************

/// <summary>
/// The Reference View Model Base
/// </summary>
public abstract class ReferenceViewModelBase : IReferenceBase
{
    /// <summary>
    /// The primary key
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Defines the Code non nullable property
    /// </summary>
    [Required]
    [StringLength(50)]
    public string? Code { get; set; }

    /// <summary>
    /// Defines the Description non nullable property
    /// </summary>
    [Required]
    [StringLength(150)]
    public string? Description { get; set; }

    /// <summary>
    /// Defines the Definition non nullable property
    /// </summary>
    [StringLength(4000)]
    public string? Definition { get; set; }

    /// <summary>
    /// Surrogate key from <see cref="IOrganization"/> identifying the publisher of the reference value.
    /// </summary>
    [ForeignKey("Organization")]
    public Guid? RefJurisdictionId { get; set; }

    /// <summary>
    /// Defines the SortOrder nullable property
    /// </summary>
    public decimal? SortOrder { get; set; }
}
