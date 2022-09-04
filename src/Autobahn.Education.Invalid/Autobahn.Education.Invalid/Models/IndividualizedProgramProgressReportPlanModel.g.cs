//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramProgressReportPlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramProgressReportPlan file
/// </summary>
public partial class IndividualizedProgramProgressReportPlanModel : AutobahnBaseModel, IIndividualizedProgramProgressReportPlan
{
    #region "IIndividualizedProgramProgressReportPlan Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpspprogressReportSchedule"/> model
    /// </summary>
    public Guid? RefIpspprogressReportScheduleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpspprogressReportType"/> model
    /// </summary>
    public Guid? RefIpspprogressReportTypeId { get; set; }

    #endregion
}
