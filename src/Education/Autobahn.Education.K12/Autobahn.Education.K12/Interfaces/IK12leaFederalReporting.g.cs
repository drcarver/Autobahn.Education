//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12leaFederalReporting.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaFederalReporting file
/// </summary>
public partial interface IK12leaFederalReporting
{
    #region "IK12leaFederalReporting Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? DesegregationOrderOrPlan { get; set; }

    Boolean? HarassmentOrBullyingPolicy { get; set; }

    Int32? InterscholasticSportParticipantsFemale { get; set; }

    Int32? InterscholasticSportParticipantsMale { get; set; }

    Int32? InterscholasticSportsFemaleOnly { get; set; }

    Int32? InterscholasticSportsMaleOnly { get; set; }

    Int32? InterscholasticTeamsFemaleOnly { get; set; }

    Int32? InterscholasticTeamsMaleOnly { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomeless"/> model
    /// </summary>
    Guid? RefBarrierToEducatingHomelessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatus"/> model
    /// </summary>
    Guid? RefIntegratedTechnologyStatusId { get; set; }

    Decimal? StateAssessmentAdminFunding { get; set; }

    Decimal? StateAssessStandardsFunding { get; set; }

    Boolean? TerminatedTitleIiiprogramFailure { get; set; }

    #endregion
}
