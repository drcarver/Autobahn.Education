//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramProgressReportEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramProgressReport file
/// </summary>
public partial class IndividualizedProgramProgressReportModel : AutobahnBaseModel, IIndividualizedProgramProgressReport
{
    #region "IIndividualizedProgramProgressReport Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReportPlan"/> model
    /// </summary>
    public Guid IndividualizedProgramProgressReportPlanId { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Progress Report Description
    /// <para>
    /// A description of the progress report used to notify parents of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20681">Individualized Program Service Plan Progress Report Description</a>
    /// </para>
    /// </summary>
    public System.String ProgressDescription { get; set; }

    /// <summary>
    /// Individualized Program Service Plan Progress Report Date
    /// <para>
    /// The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20680">Individualized Program Service Plan Progress Report Date</a>
    /// </para>
    /// </summary>
    public DateTime? ProgressReportDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpspprogressReportType"/> model
    /// </summary>
    public Guid? RefIpspprogressReportTypeId { get; set; }

    #endregion
}
