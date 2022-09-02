//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentDiscipline.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentDiscipline file
/// </summary>
public partial interface IK12studentDiscipline
{
    #region "IK12studentDiscipline Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? DisciplinaryActionEndDate { get; set; }

    DateTime? DisciplinaryActionStartDate { get; set; }

    Decimal? DurationOfDisciplinaryAction { get; set; }

    Boolean? EducationalServicesAfterRemoval { get; set; }

    Boolean? FullYearExpulsion { get; set; }

    Boolean? IepplacementMeetingIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIncident"/> model
    /// </summary>
    Guid? IncidentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTaken"/> model
    /// </summary>
    Guid? RefDisciplinaryActionTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReason"/> model
    /// </summary>
    Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
    /// </summary>
    Guid? RefDisciplineMethodFirearmsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwd"/> model
    /// </summary>
    Guid? RefDisciplineMethodOfCwdId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineReason"/> model
    /// </summary>
    Guid? RefDisciplineReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeadisciplineMethodFirearm"/> model
    /// </summary>
    Guid? RefIdeadisciplineMethodFirearmId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaInterimRemoval"/> model
    /// </summary>
    Guid? RefIdeaInterimRemovalId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaInterimRemovalReason"/> model
    /// </summary>
    Guid? RefIdeaInterimRemovalReasonId { get; set; }

    Boolean? RelatedToZeroTolerancePolicy { get; set; }

    Boolean? ShortenedExpulsion { get; set; }

    #endregion
}
