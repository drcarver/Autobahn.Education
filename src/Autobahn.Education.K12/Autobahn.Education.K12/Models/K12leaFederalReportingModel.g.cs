//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaFederalReportingEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaFederalReporting file
/// </summary>
public partial class K12leaFederalReportingModel : AutobahnBaseModel, IK12leaFederalReporting
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
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomeless"/> model
    /// </summary>
    public Guid? RefBarrierToEducatingHomelessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatus"/> model
    /// </summary>
    public Guid? RefIntegratedTechnologyStatusId { get; set; }

    public Decimal? StateAssessmentAdminFunding { get; set; }

    public Decimal? StateAssessStandardsFunding { get; set; }

    public Boolean? TerminatedTitleIiiprogramFailure { get; set; }

    #endregion
}
