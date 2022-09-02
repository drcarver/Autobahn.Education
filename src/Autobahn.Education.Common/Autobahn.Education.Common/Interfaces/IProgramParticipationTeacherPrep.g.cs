//***************************************************************************
//* DomainName: Common Models
//* FileName:   IProgramParticipationTeacherPrep.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationTeacherPrep file
/// </summary>
public partial interface IProgramParticipationTeacherPrep
{
    #region "IProgramParticipationTeacherPrep Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Supervised Clinical Experience Clock Hours
    /// <para>
    /// An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19755">Supervised Clinical Experience Clock Hours</a>
    /// </para>
    /// </summary>
    Int32? ClinicalExperienceClockHours { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Alternative Route to Certification or Licensure
    /// <para>
    /// An indication of whether a person is enrolled in an alternative teacher preparation program as defined by Title II.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19751">Alternative Route to Certification or Licensure</a>
    /// </para>
    /// </summary>
    Guid? RefAltRouteToCertificationOrLicensureId { get; set; }

    /// <summary>
    /// Critical Teacher Shortage Area Candidate
    /// <para>
    /// An indication of whether a person is pursuing licensure/certification in a field designated as a shortage area as defined by Title II.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19753">Critical Teacher Shortage Area Candidate</a>
    /// </para>
    /// </summary>
    Guid? RefCriticalTeacherShortageCandidateId { get; set; }

    /// <summary>
    /// Supervised Clinical Experience
    /// <para>
    /// An indication of whether a person is enrolled in a supervised clinical experience (including student teaching) as part of a teacher preparation program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19754">Supervised Clinical Experience</a>
    /// </para>
    /// </summary>
    Guid? RefSupervisedClinicalExperienceId { get; set; }

    /// <summary>
    /// Teacher Preparation Program Completer Status
    /// <para>
    /// An indication of whether a person completed a state-approved teacher preparation program.  The fact that a person has or has not been recommended to the state for initial certification or licensure may not be used as a criterion for determining who is a program completer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19750">Teacher Preparation Program Completer Status</a>
    /// </para>
    /// </summary>
    Guid? RefTeacherPrepCompleterStatusId { get; set; }

    /// <summary>
    /// Teacher Preparation Program Enrollment Status
    /// <para>
    /// An indication of whether a person is pursuing certification as a teacher.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19749">Teacher Preparation Program Enrollment Status</a>
    /// </para>
    /// </summary>
    Guid? RefTeacherPrepEnrollmentStatusId { get; set; }

    /// <summary>
    /// Teaching Credential Basis
    /// <para>
    /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19277">Teaching Credential Basis</a>
    /// </para>
    /// </summary>
    Guid? RefTeachingCredentialBasisId { get; set; }

    /// <summary>
    /// Teaching Credential Type
    /// <para>
    /// An indication of the category of a legal document giving authorization to perform teaching assignment services.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19278">Teaching Credential Type</a>
    /// </para>
    /// </summary>
    Guid? RefTeachingCredentialTypeId { get; set; }

    Decimal? SchoolAgeEducationPscredits { get; set; }

    #endregion
}
