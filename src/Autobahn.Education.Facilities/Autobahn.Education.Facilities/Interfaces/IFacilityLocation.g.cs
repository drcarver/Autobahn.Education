//***************************************************************************
//* DomainName: Facilities
//* FileName:   IFacilityLocation.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityLocation file
/// </summary>
public partial interface IFacilityLocation
{
    #region "IFacilityLocation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    Guid FacilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    Guid LocationId { get; set; }

    #endregion
}
