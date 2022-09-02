//***************************************************************************
//* DomainName: Common Models
//* FileName:   IAssessmentAdministration.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAdministration file
/// </summary>
public partial interface IAssessmentAdministration
{
    #region "IAssessmentAdministration Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Assessment Administration Period Description
    /// <para>
    /// The period or window in which an assessment is supposed to be administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20506">Assessment Administration Period Description</a>
    /// </para>
    /// </summary>
    System.String AssessmentAdministrationPeriodDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    Guid? AssessmentId { get; set; }

    /// <summary>
    /// Assessment Secure Indicator
    /// <para>
    /// Indicates whether or not the assessment is a secure assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19375">Assessment Secure Indicator</a>
    /// </para>
    /// </summary>
    Boolean? AssessmentSecureIndicator { get; set; }

    /// <summary>
    /// Assessment Administration Finish Date
    /// <para>
    /// The finish date of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19965">Assessment Administration Finish Date</a>
    /// </para>
    /// </summary>
    DateTime? FinishDate { get; set; }

    /// <summary>
    /// Assessment Administration Finish Time
    /// <para>
    /// The finish time of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19966">Assessment Administration Finish Time</a>
    /// </para>
    /// </summary>
    TimeSpan? FinishTime { get; set; }

    /// <summary>
    /// Assessment Administration Name
    /// <para>
    /// The name given to an assessment event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19978">Assessment Administration Name</a>
    /// </para>
    /// </summary>
    System.String Name { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentReportingMethod"/> model
    /// </summary>
    Guid? RefAssessmentReportingMethodId { get; set; }

    /// <summary>
    /// Assessment Administration Start Date
    /// <para>
    /// The start date of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19963">Assessment Administration Start Date</a>
    /// </para>
    /// </summary>
    DateTime? StartDate { get; set; }

    /// <summary>
    /// Assessment Administration Start Time
    /// <para>
    /// The start time of the time period designated for the assessment administration.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19964">Assessment Administration Start Time</a>
    /// </para>
    /// </summary>
    TimeSpan? StartTime { get; set; }

    #endregion
}
