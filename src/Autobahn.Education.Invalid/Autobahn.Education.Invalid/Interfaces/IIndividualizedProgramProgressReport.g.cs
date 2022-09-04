//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IIndividualizedProgramProgressReport.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramProgressReport file
/// </summary>
public partial interface IIndividualizedProgramProgressReport
{
    #region "IIndividualizedProgramProgressReport Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReportPlan"/> model
    /// </summary>
    Guid IndividualizedProgramProgressReportPlanId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Progress Report Description
    /// <para>
    /// A description of the progress report used to notify parents of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20681">Individualized Program Service Plan Progress Report Description</a>
    /// </para>
    /// </summary>
    System.String ProgressDescription { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Progress Report Date
    /// <para>
    /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20680">Individualized Program Service Plan Progress Report Date</a>
    /// </para>
    /// </summary>
    DateTime? ProgressReportDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpspprogressReportType"/> model
    /// </summary>
    Guid? RefIpspprogressReportTypeId { get; set; }

    #endregion
}
