//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramProgressReportEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramProgressReport file
/// </summary>
[Table("IndividualizedProgramProgressReport", Schema = "Common")]
public partial class IndividualizedProgramProgressReportEntity : EntityBase, IIndividualizedProgramProgressReport
{
    #region "IIndividualizedProgramProgressReport Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReportPlan"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgramProgressReportPlan")]
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
    [Required(ErrorMessage="{0} is required.")]
    [Comment("A description of the progress report used to notify parents of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.")]
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
    [Comment("The date parents are notified of the student's progress on annual goals and if the progress is sufficient to achieve the goals by the end of the individualized program service plan.")]
    public DateTime? ProgressReportDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpspprogressReportType"/> model
    /// </summary>
    [ForeignKey("RefIpspprogressReportType")]
    public Guid? RefIpspprogressReportTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramProgressReportPlan"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramProgressReportPlanEntity IndividualizedProgramProgressReportPlanEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpspprogressReportType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefIpspprogressReportTypeEntity RefIpspprogressReportTypeEntity { get; set; }

    #endregion
}
