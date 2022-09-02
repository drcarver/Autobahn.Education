//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityLocationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityLocation file
/// </summary>
[Table("FacilityLocation", Schema = "Facilities")]
public partial class FacilityLocationEntity : EntityBase, IFacilityLocation
{
    #region "IFacilityLocation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Location")]
    public Guid LocationId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityEntity FacilityEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual LocationEntity LocationEntity { get; set; }

    #endregion
}
