//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildOutcomeSummaryEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildOutcomeSummary file
/// </summary>
[Table("ElchildOutcomeSummary", Schema = "Common")]
public partial class ElchildOutcomeSummaryEntity : EntityBase, IElchildOutcomeSummary
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
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
