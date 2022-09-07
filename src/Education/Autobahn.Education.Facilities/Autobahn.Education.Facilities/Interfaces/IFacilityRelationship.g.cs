//***************************************************************************
//* DomainName: Facilities
//* FileName:   IFacilityRelationship.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityRelationship file
/// </summary>
public partial interface IFacilityRelationship
{
    #region "IFacilityRelationship Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    Guid FacilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IParentFacility"/> model
    /// </summary>
    Guid ParentFacilityId { get; set; }

    #endregion
}
