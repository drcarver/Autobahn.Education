//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityRelationshipEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityRelationship file
/// </summary>
public partial class FacilityRelationshipModel : AutobahnBaseModel, IFacilityRelationship
{
    #region "IFacilityRelationship Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IParentFacility"/> model
    /// </summary>
    public Guid ParentFacilityId { get; set; }

    #endregion
}
