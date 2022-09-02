//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElchildDemographic.g.cs
//***************************************************************************

/// <summary>
/// The IElchildDemographic file
/// </summary>
public partial interface IElchildDemographic
{
    #region "IElchildDemographic Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? FosterCareEndDate { get; set; }

    DateTime? FosterCareStartDate { get; set; }

    Boolean? OtherRaceIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    #endregion
}
