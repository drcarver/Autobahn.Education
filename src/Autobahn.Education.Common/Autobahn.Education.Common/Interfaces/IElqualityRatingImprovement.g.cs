//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElqualityRatingImprovement.g.cs
//***************************************************************************

/// <summary>
/// The IElqualityRatingImprovement file
/// </summary>
public partial interface IElqualityRatingImprovement
{
    #region "IElqualityRatingImprovement Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Int32? NumberQrisLevels { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    DateTime? QrisAwardDate { get; set; }

    DateTime? QrisexpirationDate { get; set; }

    System.String QrisScore { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefQrisParticipation"/> model
    /// </summary>
    Guid? RefQrisParticipationId { get; set; }

    #endregion
}
