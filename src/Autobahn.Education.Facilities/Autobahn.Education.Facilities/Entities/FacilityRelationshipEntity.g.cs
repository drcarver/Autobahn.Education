//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityRelationshipEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityRelationship file
/// </summary>
[Table("FacilityRelationship", Schema = "Facilities")]
public partial class FacilityRelationshipEntity : EntityBase, IFacilityRelationship
{
    #region "IFacilityRelationship Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IParentFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The ParentFacility property is obsolete and will be removed in a later version")]
    [ForeignKey("ParentFacility")]
    public Guid ParentFacilityId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityEntity FacilityEntity { get; set; }

    #endregion
}
