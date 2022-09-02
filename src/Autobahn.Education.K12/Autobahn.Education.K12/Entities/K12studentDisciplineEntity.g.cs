//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentDisciplineEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentDiscipline file
/// </summary>
[Table("K12studentDiscipline", Schema = "K12")]
public partial class K12studentDisciplineEntity : EntityBase, IK12studentDiscipline
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
    [ForeignKey("Incident")]
    public Guid? IncidentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTaken"/> model
    /// </summary>
    [ForeignKey("RefDisciplinaryActionTaken")]
    public Guid? RefDisciplinaryActionTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReason"/> model
    /// </summary>
    [ForeignKey("RefDisciplineLengthDifferenceReason")]
    public Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
    /// </summary>
    [Obsolete("The RefDisciplineMethodFirearms property is obsolete and will be removed in a later version")]
    [ForeignKey("RefDisciplineMethodFirearms")]
    public Guid? RefDisciplineMethodFirearmsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwd"/> model
    /// </summary>
    [ForeignKey("RefDisciplineMethodOfCwd")]
    public Guid? RefDisciplineMethodOfCwdId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineReason"/> model
    /// </summary>
    [ForeignKey("RefDisciplineReason")]
    public Guid? RefDisciplineReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeadisciplineMethodFirearm"/> model
    /// </summary>
    [Obsolete("The RefeadisciplineMethodFirearm property is obsolete and will be removed in a later version")]
    [ForeignKey("RefeadisciplineMethodFirearm")]
    public Guid? RefIdeadisciplineMethodFirearmId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaInterimRemoval"/> model
    /// </summary>
    [Obsolete("The RefeaInterimRemoval property is obsolete and will be removed in a later version")]
    [ForeignKey("RefeaInterimRemoval")]
    public Guid? RefIdeaInterimRemovalId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaInterimRemovalReason"/> model
    /// </summary>
    [Obsolete("The RefeaInterimRemovalReason property is obsolete and will be removed in a later version")]
    [ForeignKey("RefeaInterimRemovalReason")]
    public Guid? RefIdeaInterimRemovalReasonId { get; set; }

    public Boolean? RelatedToZeroTolerancePolicy { get; set; }

    public Boolean? ShortenedExpulsion { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefDisciplineReason"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefDisciplineReasonEntity RefDisciplineReasonEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefDisciplinaryActionTaken"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefDisciplinaryActionTakenEntity RefDisciplinaryActionTakenEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefDisciplineLengthDifferenceReason"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefDisciplineLengthDifferenceReasonEntity RefDisciplineLengthDifferenceReasonEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIncident"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual IncidentEntity IncidentEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefDisciplineMethodOfCwd"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefDisciplineMethodOfCwdEntity RefDisciplineMethodOfCwdEntity { get; set; }

    #endregion
}
