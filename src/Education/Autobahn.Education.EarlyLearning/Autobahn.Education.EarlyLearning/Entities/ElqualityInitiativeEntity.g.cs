//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElqualityInitiativeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElqualityInitiative file
/// </summary>
[Table("ElqualityInitiative", Schema = "EarlyLearning")]
public partial class ElqualityInitiativeEntity : EntityBase, IElqualityInitiative
{
    #region "IElqualityInitiative Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MaximumScore { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MinimumScore { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    public DateTime? ParticipationEndDate { get; set; }

    public Boolean? ParticipationIndicator { get; set; }

    public DateTime? ParticipationStartDate { get; set; }

    public Boolean? ProgramHeathSafetyChecklistUseStatus { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScoreLevel { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
