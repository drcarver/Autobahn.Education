//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   ReferenceBaseModel.cs
//**********************************************************

/// <summary>
/// The base reference Model
/// </summary>
public class ReferenceBaseModel : IReferenceBase
{
    /// <summary>
    /// The primary key
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Defines the Code non nullable property
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Defines the Description non nullable property
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Defines the Definition non nullable property
    /// </summary>
    public string? Definition { get; set; }

    /// <summary>
    /// Surrogate key from <see cref="EntityBase"/> identifying the publisher of the reference value.
    /// </summary>
    public Guid? RefJurisdictionId { get; set; }

    /// <summary>
    /// Defines the SortOrder nullable property
    /// </summary>
    public decimal? SortOrder { get; set; }
}
