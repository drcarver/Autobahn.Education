//***************************************************************************
//* DomainName: Workforce
//* FileName:   WorkforceEmploymentQuarterlyDatumEntity.g.cs
//***************************************************************************

/// <summary>
/// The IWorkforceEmploymentQuarterlyDatum file
/// </summary>
[Table("WorkforceEmploymentQuarterlyDatum", Schema = "Workforce")]
public partial class WorkforceEmploymentQuarterlyDatumEntity : EntityBase, IWorkforceEmploymentQuarterlyDatum
{
    #region "IWorkforceEmploymentQuarterlyDatum Properties"
    public Decimal? EmployedInMultipleJobsCount { get; set; }

    public Boolean? MilitaryEnlistmentAfterExit { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
    /// </summary>
    [ForeignKey("RefEmployedAfterExit")]
    public Guid? RefEmployedAfterExitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
    /// </summary>
    [ForeignKey("RefEmployedWhileEnrolled")]
    public Guid? RefEmployedWhileEnrolledId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IWorkforceEmploymentQuarterlyData"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The WorkforceEmploymentQuarterlyData property is obsolete and will be removed in a later version")]
    [ForeignKey("WorkforceEmploymentQuarterlyData")]
    public Guid WorkforceEmploymentQuarterlyDataId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEmployedWhileEnrolled"/> implementation
    /// <remarks>
    /// This entity is in the Workforce domain
    /// </remarks>
    /// </summary>
    public virtual RefEmployedWhileEnrolledEntity RefEmployedWhileEnrolledEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEmployedAfterExit"/> implementation
    /// <remarks>
    /// This entity is in the Workforce domain
    /// </remarks>
    /// </summary>
    public virtual RefEmployedAfterExitEntity RefEmployedAfterExitEntity { get; set; }

    #endregion
}
