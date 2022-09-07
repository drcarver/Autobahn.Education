//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaFederalReportingEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaFederalReporting file
/// </summary>
[Table("K12leaFederalReporting", Schema = "K12")]
public partial class K12leaFederalReportingEntity : EntityBase, IK12leaFederalReporting
{
    #region "IK12leaFederalReporting Properties"
    public Boolean? DesegregationOrderOrPlan { get; set; }

    public Boolean? HarassmentOrBullyingPolicy { get; set; }

    public Int32? InterscholasticSportParticipantsFemale { get; set; }

    public Int32? InterscholasticSportParticipantsMale { get; set; }

    public Int32? InterscholasticSportsFemaleOnly { get; set; }

    public Int32? InterscholasticSportsMaleOnly { get; set; }

    public Int32? InterscholasticTeamsFemaleOnly { get; set; }

    public Int32? InterscholasticTeamsMaleOnly { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12lea")]
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomeless"/> model
    /// </summary>
    [ForeignKey("RefBarrierToEducatingHomeless")]
    public Guid? RefBarrierToEducatingHomelessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatus"/> model
    /// </summary>
    [ForeignKey("RefIntegratedTechnologyStatus")]
    public Guid? RefIntegratedTechnologyStatusId { get; set; }

    public Decimal? StateAssessmentAdminFunding { get; set; }

    public Decimal? StateAssessStandardsFunding { get; set; }

    public Boolean? TerminatedTitleIiiprogramFailure { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual K12leaEntity K12leaEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefBarrierToEducatingHomeless"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefBarrierToEducatingHomelessEntity? RefBarrierToEducatingHomelessEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIntegratedTechnologyStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefIntegratedTechnologyStatusEntity? RefIntegratedTechnologyStatusEntity { get; set; }

    #endregion
}
