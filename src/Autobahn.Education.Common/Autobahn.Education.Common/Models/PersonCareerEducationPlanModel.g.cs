//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonCareerEducationPlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonCareerEducationPlan file
/// </summary>
public partial class PersonCareerEducationPlanModel : AutobahnBaseModel, IPersonCareerEducationPlan
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
    public DateTime? LastUpdated { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
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
    public Boolean? TuitionFunded { get; set; }

    #endregion
}
