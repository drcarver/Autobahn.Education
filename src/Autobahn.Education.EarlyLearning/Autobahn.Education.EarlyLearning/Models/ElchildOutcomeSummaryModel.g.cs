//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildOutcomeSummaryEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildOutcomeSummary file
/// </summary>
public partial class ElchildOutcomeSummaryModel : AutobahnBaseModel, IElchildOutcomeSummary
{
    #region "IElchildOutcomeSummary Properties"
    public Boolean? CosprogressAindicator { get; set; }

    public Boolean? CosprogressBindicator { get; set; }

    public Boolean? CosprogressCindicator { get; set; }

    public Int32? CosratingAid { get; set; }

    public Int32? CosratingBid { get; set; }

    public Int32? CosratingCid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    #endregion
}
