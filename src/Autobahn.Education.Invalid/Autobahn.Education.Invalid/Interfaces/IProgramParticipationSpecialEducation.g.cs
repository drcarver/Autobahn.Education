//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IProgramParticipationSpecialEducation.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationSpecialEducation file
/// </summary>
public partial interface IProgramParticipationSpecialEducation
{
    #region "IProgramParticipationSpecialEducation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? AwaitingInitialIdeaevaluationStatus { get; set; }

    System.String IdeaplacementRationale { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

    Int32? RefIdeaeducationalEnvironmentEcid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeaeducationalEnvironmentSchoolAge"/> model
    /// </summary>
    Guid? RefIdeaeducationalEnvironmentSchoolAgeId { get; set; }

    /// <summary>
    /// Special Education Exit Reason
    /// <para>
    /// The reason children who were in special education at the start of the reporting period were not in special education at the end of the reporting period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19260">Special Education Exit Reason</a>
    /// </para>
    /// </summary>
    Guid? RefSpecialEducationExitReasonId { get; set; }

    Decimal? SpecialEducationFte { get; set; }

    /// <summary>
    /// Special Education Services Exit Date
    /// <para>
    /// The year, month and day a child with disabilities (IDEA) ages 14 through 21 exited special education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19263">Special Education Services Exit Date</a>
    /// </para>
    /// </summary>
    DateTime? SpecialEducationServicesExitDate { get; set; }

    #endregion
}
