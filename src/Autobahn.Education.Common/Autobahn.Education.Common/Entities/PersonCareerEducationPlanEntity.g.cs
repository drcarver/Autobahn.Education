//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonCareerEducationPlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonCareerEducationPlan file
/// </summary>
[Table("PersonCareerEducationPlan", Schema = "Common")]
public partial class PersonCareerEducationPlanEntity : EntityBase, IPersonCareerEducationPlan
{
    #region "IPersonCareerEducationPlan Properties"
    /// <summary>
    /// Career Education Plan Date
    /// <para>
    /// The date on which an individual's professional development career plan was last updated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20255">Career Education Plan Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which an individual's professional development career plan was last updated.")]
    public DateTime? LastUpdated { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Professional Development Plan Approved by Supervisor
    /// <para>
    /// Professional development plan is approved by the employee's supervisor.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20599">Professional Development Plan Approved by Supervisor</a>
    /// </para>
    /// </summary>
    [Comment("Professional development plan is approved by the employee's supervisor.")]
    public Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get; set; }

    /// <summary>
    /// Professional Development Plan Completion
    /// <para>
    /// The date the professional development plan is completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20600">Professional Development Plan Completion</a>
    /// </para>
    /// </summary>
    [Comment("The date the professional development plan is completed.")]
    public DateTime? ProfessionalDevelopmentPlanCompletion { get; set; }

    /// <summary>
    /// Career Education Plan Type
    /// <para>
    /// An indication of whether an individual completed an individualized guidance and counseling plan
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20256">Career Education Plan Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCareerEducationPlanType")]
    [Comment("An indication of whether an individual completed an individualized guidance and counseling plan")]
    public Guid? RefCareerEducationPlanTypeId { get; set; }

    /// <summary>
    /// Tuition Funded
    /// <para>
    /// Indicates that tuition for person's participation in a program, service, or course is funded or partially funded by an external grant program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20554">Tuition Funded</a>
    /// </para>
    /// </summary>
    [Comment("Indicates that tuition for person's participation in a program, service, or course is funded or partially funded by an external grant program.")]
    public Boolean? TuitionFunded { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indication of whether an individual completed an individualized guidance and counseling plan
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20256">Career Education Plan Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCareerEducationPlanTypeEntity RefCareerEducationPlanTypeEntity { get; set; }

    #endregion
}
