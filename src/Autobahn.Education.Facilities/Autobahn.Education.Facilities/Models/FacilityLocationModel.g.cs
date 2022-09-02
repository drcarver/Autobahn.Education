//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityLocationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityLocation file
/// </summary>
public partial class FacilityLocationModel : AutobahnBaseModel, IFacilityLocation
{
    #region "IFacilityLocation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    public Guid LocationId { get; set; }

    #endregion
}
