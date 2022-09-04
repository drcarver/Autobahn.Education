//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElqualityRatingImprovementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElqualityRatingImprovement file
/// </summary>
public partial class ElqualityRatingImprovementModel : AutobahnBaseModel, IElqualityRatingImprovement
{
    #region "IElqualityRatingImprovement Properties"
    public Int32? NumberQrisLevels { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    public DateTime? QrisAwardDate { get; set; }

    public DateTime? QrisexpirationDate { get; set; }

    public System.String QrisScore { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefQrisParticipation"/> model
    /// </summary>
    public Guid? RefQrisParticipationId { get; set; }

    #endregion
}
