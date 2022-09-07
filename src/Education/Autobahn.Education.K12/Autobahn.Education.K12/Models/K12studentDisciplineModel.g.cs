//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentDisciplineEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentDiscipline file
/// </summary>
public partial class K12studentDisciplineModel : AutobahnBaseModel, IK12studentDiscipline
{
    #region "IK12studentDiscipline Properties"
    public DateTime? DisciplinaryActionEndDate { get; set; }

    public DateTime? DisciplinaryActionStartDate { get; set; }

    public Decimal? DurationOfDisciplinaryAction { get; set; }

    public Boolean? EducationalServicesAfterRemoval { get; set; }

    public Boolean? FullYearExpulsion { get; set; }

    public Boolean? IepplacementMeetingIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIncident"/> model
    /// </summary>
    public Guid? IncidentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTaken"/> model
    /// </summary>
    public Guid? RefDisciplinaryActionTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReason"/> model
    /// </summary>
    public Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
    /// </summary>
    public Guid? RefDisciplineMethodFirearmsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwd"/> model
    /// </summary>
    public Guid? RefDisciplineMethodOfCwdId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineReason"/> model
    /// </summary>
    public Guid? RefDisciplineReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeadisciplineMethodFirearm"/> model
    /// </summary>
    public Guid? RefIdeadisciplineMethodFirearmId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaInterimRemoval"/> model
    /// </summary>
    public Guid? RefIdeaInterimRemovalId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaInterimRemovalReason"/> model
    /// </summary>
    public Guid? RefIdeaInterimRemovalReasonId { get; set; }

    public Boolean? RelatedToZeroTolerancePolicy { get; set; }

    public Boolean? ShortenedExpulsion { get; set; }

    #endregion
}
