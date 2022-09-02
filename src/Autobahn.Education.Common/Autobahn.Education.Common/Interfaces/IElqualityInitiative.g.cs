//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElqualityInitiative.g.cs
//***************************************************************************

/// <summary>
/// The IElqualityInitiative file
/// </summary>
public partial interface IElqualityInitiative
{
    #region "IElqualityInitiative Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String MaximumScore { get; set; }

    System.String MinimumScore { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    DateTime? ParticipationEndDate { get; set; }

    Boolean? ParticipationIndicator { get; set; }

    DateTime? ParticipationStartDate { get; set; }

    Boolean? ProgramHeathSafetyChecklistUseStatus { get; set; }

    System.String ScoreLevel { get; set; }

    #endregion
}
