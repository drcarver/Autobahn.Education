//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProgramParticipationSpecialEducationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationSpecialEducation file
/// </summary>
[Table("ProgramParticipationSpecialEducation", Schema = "Invalid")]
public partial class ProgramParticipationSpecialEducationEntity : EntityBase, IProgramParticipationSpecialEducation
{
    #region "IProgramParticipationSpecialEducation Properties"
    public Boolean? AwaitingInitialIdeaevaluationStatus { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String IdeaplacementRationale { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
    public Guid PersonProgramParticipationId { get; set; }

    public Int32? RefIdeaeducationalEnvironmentEcid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaeducationalEnvironmentSchoolAge"/> model
    /// </summary>
    [ForeignKey("RefeaeducationalEnvironmentSchoolAge")]
    public Guid? RefIdeaeducationalEnvironmentSchoolAgeId { get; set; }

    /// <summary>
    /// Special Education Exit Reason
    /// <para>
    /// The reason children who were in special education at the start of the reporting period were not in special education at the end of the reporting period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19260">Special Education Exit Reason</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefSpecialEducationExitReason")]
    [Comment("The reason children who were in special education at the start of the reporting period were not in special education at the end of the reporting period.")]
    public Guid? RefSpecialEducationExitReasonId { get; set; }

    public Decimal? SpecialEducationFte { get; set; }

    /// <summary>
    /// Special Education Services Exit Date
    /// <para>
    /// The year, month and day a child with disabilities (IDEA) ages 14 through 21 exited special education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19263">Special Education Services Exit Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day a child with disabilities (IDEA) ages 14 through 21 exited special education.")]
    public DateTime? SpecialEducationServicesExitDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual PersonProgramParticipationEntity PersonProgramParticipationEntity { get; set; }

    /// <summary>
    /// The reason children who were in special education at the start of the reporting period were not in special education at the end of the reporting period.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19260">Special Education Exit Reason</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefSpecialEducationExitReasonEntity? RefSpecialEducationExitReasonEntity { get; set; }

    #endregion
}
