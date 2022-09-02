//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElqualityInitiativeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElqualityInitiative file
/// </summary>
public partial class ElqualityInitiativeModel : AutobahnBaseModel, IElqualityInitiative
{
    #region "IElqualityInitiative Properties"
    public System.String MaximumScore { get; set; }

    public System.String MinimumScore { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    public DateTime? ParticipationEndDate { get; set; }

    public Boolean? ParticipationIndicator { get; set; }

    public DateTime? ParticipationStartDate { get; set; }

    public Boolean? ProgramHeathSafetyChecklistUseStatus { get; set; }

    public System.String ScoreLevel { get; set; }

    #endregion
}
