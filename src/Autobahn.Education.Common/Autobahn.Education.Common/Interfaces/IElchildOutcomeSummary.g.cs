//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElchildOutcomeSummary.g.cs
//***************************************************************************

/// <summary>
/// The IElchildOutcomeSummary file
/// </summary>
public partial interface IElchildOutcomeSummary
{
    #region "IElchildOutcomeSummary Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? CosprogressAindicator { get; set; }

    Boolean? CosprogressBindicator { get; set; }

    Boolean? CosprogressCindicator { get; set; }

    Int32? CosratingAid { get; set; }

    Int32? CosratingBid { get; set; }

    Int32? CosratingCid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    #endregion
}
