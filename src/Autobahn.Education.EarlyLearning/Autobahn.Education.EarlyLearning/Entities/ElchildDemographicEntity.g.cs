//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElchildDemographicEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildDemographic file
/// </summary>
[Table("ElchildDemographic", Schema = "EarlyLearning")]
public partial class ElchildDemographicEntity : EntityBase, IElchildDemographic
{
    #region "IElchildDemographic Properties"
    public DateTime? FosterCareEndDate { get; set; }

    public DateTime? FosterCareStartDate { get; set; }

    public Boolean? OtherRaceIndicator { get; set; }

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
