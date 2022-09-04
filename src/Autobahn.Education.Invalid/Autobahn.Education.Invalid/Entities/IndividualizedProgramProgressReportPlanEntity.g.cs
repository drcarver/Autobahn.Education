//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramProgressReportPlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramProgressReportPlan file
/// </summary>
[Table("IndividualizedProgramProgressReportPlan", Schema = "Invalid")]
public partial class IndividualizedProgramProgressReportPlanEntity : EntityBase, IIndividualizedProgramProgressReportPlan
{
    #region "IIndividualizedProgramProgressReportPlan Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpspprogressReportSchedule"/> model
    /// </summary>
    [ForeignKey("RefIpspprogressReportSchedule")]
    public Guid? RefIpspprogressReportScheduleId { get; set; }

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
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpspprogressReportSchedule"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefIpspprogressReportScheduleEntity? RefIpspprogressReportScheduleEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefIpspprogressReportType"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefIpspprogressReportTypeEntity? RefIpspprogressReportTypeEntity { get; set; }

    #endregion
}
