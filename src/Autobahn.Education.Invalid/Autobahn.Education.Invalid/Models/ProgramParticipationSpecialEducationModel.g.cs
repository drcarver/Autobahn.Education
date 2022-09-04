//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProgramParticipationSpecialEducationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationSpecialEducation file
/// </summary>
public partial class ProgramParticipationSpecialEducationModel : AutobahnBaseModel, IProgramParticipationSpecialEducation
{
    #region "IProgramParticipationSpecialEducation Properties"
    public Boolean? AwaitingInitialIdeaevaluationStatus { get; set; }

    public System.String IdeaplacementRationale { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    public Guid PersonProgramParticipationId { get; set; }

    public Int32? RefIdeaeducationalEnvironmentEcid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaeducationalEnvironmentSchoolAge"/> model
    /// </summary>
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
    public DateTime? SpecialEducationServicesExitDate { get; set; }

    #endregion
}
