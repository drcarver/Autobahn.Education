//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildDemographicEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildDemographic file
/// </summary>
public partial class ElchildDemographicModel : AutobahnBaseModel, IElchildDemographic
{
    #region "IElchildDemographic Properties"
    public DateTime? FosterCareEndDate { get; set; }

    public DateTime? FosterCareStartDate { get; set; }

    public Boolean? OtherRaceIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    #endregion
}
