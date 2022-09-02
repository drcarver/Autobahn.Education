//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTeacherPrepEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationTeacherPrep file
/// </summary>
[Table("ProgramParticipationTeacherPrep", Schema = "Common")]
public partial class ProgramParticipationTeacherPrepEntity : EntityBase, IProgramParticipationTeacherPrep
{
    #region "IProgramParticipationTeacherPrep Properties"
    /// <summary>
    /// Supervised Clinical Experience Clock Hours
    /// <para>
    /// An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19755">Supervised Clinical Experience Clock Hours</a>
    /// </para>
    /// </summary>
    [Comment("An indication of  the number of clock hours (minimum) a student is required to complete associated with a supervised clinical experience.")]
    public Int32? ClinicalExperienceClockHours { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Alternative Route to Certification or Licensure
    /// <para>
    /// An indication of whether a person is enrolled in an alternative teacher preparation program as defined by Title II.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19751">Alternative Route to Certification or Licensure</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAltRouteToCertificationOrLicensure")]
    [Comment("An indication of whether a person is enrolled in an alternative teacher preparation program as defined by Title II.")]
    public Guid? RefAltRouteToCertificationOrLicensureId { get; set; }

    /// <summary>
    /// Critical Teacher Shortage Area Candidate
    /// <para>
    /// An indication of whether a person is pursuing licensure/certification in a field designated as a shortage area as defined by Title II.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19753">Critical Teacher Shortage Area Candidate</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCriticalTeacherShortageCandidate")]
    [Comment("An indication of whether a person is pursuing licensure/certification in a field designated as a shortage area as defined by Title II.")]
    public Guid? RefCriticalTeacherShortageCandidateId { get; set; }

    /// <summary>
    /// Supervised Clinical Experience
    /// <para>
    /// An indication of whether a person is enrolled in a supervised clinical experience (including student teaching) as part of a teacher preparation program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19754">Supervised Clinical Experience</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefSupervisedClinicalExperience")]
    [Comment("An indication of whether a person is enrolled in a supervised clinical experience (including student teaching) as part of a teacher preparation program.")]
    public Guid? RefSupervisedClinicalExperienceId { get; set; }

    /// <summary>
    /// Teacher Preparation Program Completer Status
    /// <para>
    /// An indication of whether a person completed a state-approved teacher preparation program.  The fact that a person has or has not been recommended to the state for initial certification or licensure may not be used as a criterion for determining who is a program completer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19750">Teacher Preparation Program Completer Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTeacherPrepCompleterStatus")]
    [Comment("An indication of whether a person completed a state-approved teacher preparation program.  The fact that a person has or has not been recommended to the state for initial certification or licensure may not be used as a criterion for determining who is a program completer.")]
    public Guid? RefTeacherPrepCompleterStatusId { get; set; }

    /// <summary>
    /// Teacher Preparation Program Enrollment Status
    /// <para>
    /// An indication of whether a person is pursuing certification as a teacher.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19749">Teacher Preparation Program Enrollment Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTeacherPrepEnrollmentStatus")]
    [Comment("An indication of whether a person is pursuing certification as a teacher.")]
    public Guid? RefTeacherPrepEnrollmentStatusId { get; set; }

    /// <summary>
    /// Teaching Credential Basis
    /// <para>
    /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19277">Teaching Credential Basis</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTeachingCredentialBasis")]
    [Comment("An indication of the pre-determined criteria for granting the teaching credential that a person holds.")]
    public Guid? RefTeachingCredentialBasisId { get; set; }

    /// <summary>
    /// Teaching Credential Type
    /// <para>
    /// An indication of the category of a legal document giving authorization to perform teaching assignment services.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19278">Teaching Credential Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTeachingCredentialType")]
    [Comment("An indication of the category of a legal document giving authorization to perform teaching assignment services.")]
    public Guid? RefTeachingCredentialTypeId { get; set; }

    public Decimal? SchoolAgeEducationPscredits { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indication of whether a person is pursuing certification as a teacher.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19749">Teacher Preparation Program Enrollment Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTeacherPrepEnrollmentStatusEntity RefTeacherPrepEnrollmentStatusEntity { get; set; }

    /// <summary>
    /// An indication of whether a person completed a state-approved teacher preparation program.  The fact that a person has or has not been recommended to the state for initial certification or licensure may not be used as a criterion for determining who is a program completer.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19750">Teacher Preparation Program Completer Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTeacherPrepCompleterStatusEntity RefTeacherPrepCompleterStatusEntity { get; set; }

    /// <summary>
    /// An indication of whether a person is enrolled in a supervised clinical experience (including student teaching) as part of a teacher preparation program.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19754">Supervised Clinical Experience</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefSupervisedClinicalExperienceEntity RefSupervisedClinicalExperienceEntity { get; set; }

    /// <summary>
    /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19277">Teaching Credential Basis</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTeachingCredentialBasisEntity RefTeachingCredentialBasisEntity { get; set; }

    /// <summary>
    /// An indication of the category of a legal document giving authorization to perform teaching assignment services.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19278">Teaching Credential Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTeachingCredentialTypeEntity RefTeachingCredentialTypeEntity { get; set; }

    /// <summary>
    /// An indication of whether a person is pursuing licensure/certification in a field designated as a shortage area as defined by Title II.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19753">Critical Teacher Shortage Area Candidate</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCriticalTeacherShortageCandidateEntity RefCriticalTeacherShortageCandidateEntity { get; set; }

    /// <summary>
    /// An indication of whether a person is enrolled in an alternative teacher preparation program as defined by Title II.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19751">Alternative Route to Certification or Licensure</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAltRouteToCertificationOrLicensureEntity RefAltRouteToCertificationOrLicensureEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual PersonProgramParticipationEntity PersonProgramParticipationEntity { get; set; }

    #endregion
}
