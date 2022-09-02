//***************************************************************************
//* DomainName: Common Models
//* FileName:   IIndividualizedProgramProgressReportPlan.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramProgressReportPlan file
/// </summary>
public partial interface IIndividualizedProgramProgressReportPlan
{
    #region "IIndividualizedProgramProgressReportPlan Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpspprogressReportSchedule"/> model
    /// </summary>
    Guid? RefIpspprogressReportScheduleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpspprogressReportType"/> model
    /// </summary>
    Guid? RefIpspprogressReportTypeId { get; set; }

    #endregion
}
