//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentEnrollmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentEnrollment file
/// </summary>
[Table("PsStudentEnrollment", Schema = "Postsecondary")]
public partial class PsStudentEnrollmentEntity : EntityBase, IPsStudentEnrollment
{
    #region "IPsStudentEnrollment Properties"
    /// <summary>
    /// Degree or Certificate Seeking Student
    /// <para>
    /// Person is enrolled in courses for credit and recognized by the institution as seeking a degree, certificate, or other formal award. High school students also enrolled in postsecondary courses for credit are not considered degree/certificate-seeking.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19078">Degree or Certificate Seeking Student</a>
    /// </para>
    /// </summary>
    [Comment("Person is enrolled in courses for credit and recognized by the institution as seeking a degree, certificate, or other formal award. High school students also enrolled in postsecondary courses for credit are not considered degree/certificate-seeking.")]
    public Boolean? DegreeOrCertificateSeekingStudent { get; set; }

    public Boolean? DisplacedStudentStatus { get; set; }

    /// <summary>
    /// Distance Education Program Enrollment Indicator
    /// <para>
    /// An individual's enrollment in a program for which all the required coursework for program completion is able to be completed via distance education courses. Distance education is education that uses one or more technologies to deliver instruction to individuals who are separated from the instructor and to support regular and substantive interaction between the individuals and the instructor synchronously or asynchronously.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20289">Distance Education Program Enrollment Indicator</a>
    /// </para>
    /// </summary>
    [Comment("An individual's enrollment in a program for which all the required coursework for program completion is able to be completed via distance education courses. Distance education is education that uses one or more technologies to deliver instruction to individuals who are separated from the instructor and to support regular and substantive interaction between the individuals and the instructor synchronously or asynchronously.")]
    public Boolean? DistanceEducationProgramEnrollmentInd { get; set; }

    /// <summary>
    /// Doctoral Candidacy Admit Indicator
    /// <para>
    /// The individual's status in being admitted as a doctoral candidate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20290">Doctoral Candidacy Admit Indicator</a>
    /// </para>
    /// </summary>
    [Comment("The individual's status in being admitted as a doctoral candidate.")]
    public Boolean? DoctoralCandidacyAdmitInd { get; set; }

    /// <summary>
    /// Doctoral Candidacy Date
    /// <para>
    /// The date on which the individual was admitted to doctoral candidate status.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20291">Doctoral Candidacy Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the individual was admitted to doctoral candidate status.")]
    public DateTime? DoctoralCandidacyDate { get; set; }

    /// <summary>
    /// Doctoral Exam Taken Date
    /// <para>
    /// The date on which the individual took an exam for advancement in, continuation or completion of a doctoral program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20292">Doctoral Exam Taken Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the individual took an exam for advancement in, continuation or completion of a doctoral program.")]
    public DateTime? DoctoralExamTakenDate { get; set; }

    /// <summary>
    /// Entry Date into Postsecondary
    /// <para>
    /// The year, month and day on which a person entered and began to receive instructional services at a postsecondary institution for the first time after completing high school (or its equivalent). 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19098">Entry Date into Postsecondary</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which a person entered and began to receive instructional services at a postsecondary institution for the first time after completing high school (or its equivalent). ")]
    public DateTime? EntryDateIntoPostsecondary { get; set; }

    /// <summary>
    /// First Time Postsecondary Student
    /// <para>
    /// A person who has no prior postsecondary experience  attending any institution for the first time at the undergraduate level since completing high school (or its equivalent). This includes persons enrolled in academic or occupational programs. It also includes persons enrolled in the fall term who attended college for the first time in the prior summer term, and persons who entered with advanced standing (college credits earned before graduation from high school).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19117">First Time Postsecondary Student</a>
    /// </para>
    /// </summary>
    [Comment("A person who has no prior postsecondary experience  attending any institution for the first time at the undergraduate level since completing high school (or its equivalent). This includes persons enrolled in academic or occupational programs. It also includes persons enrolled in the fall term who attended college for the first time in the prior summer term, and persons who entered with advanced standing (college credits earned before graduation from high school).")]
    public Boolean? FirstTimePostsecondaryStudent { get; set; }

    /// <summary>
    /// Fraternity Participation Status
    /// <para>
    /// Student is in membership of a chiefly social organization of men students at a college or university, usually designated by Greek letters.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19743">Fraternity Participation Status</a>
    /// </para>
    /// </summary>
    [Comment("Student is in membership of a chiefly social organization of men students at a college or university, usually designated by Greek letters.")]
    public Boolean? FraternityParticipationStatus { get; set; }

    /// <summary>
    /// Postsecondary Student Housing On-Campus
    /// <para>
    /// The student resides in a residence hall or housing facility owned or controlled by an institution within the same reasonably contiguous geographic area and used by the institution in direct support of or in a manner related to, the institution's educational purposes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19741">Postsecondary Student Housing On-Campus</a>
    /// </para>
    /// </summary>
    [Comment("The student resides in a residence hall or housing facility owned or controlled by an institution within the same reasonably contiguous geographic area and used by the institution in direct support of or in a manner related to, the institution's educational purposes.")]
    public Boolean? HousingOnCampus { get; set; }

    /// <summary>
    /// Initial Enrollment Term
    /// <para>
    /// The first registration term of a person enrolling in credit-granting courses at a postsecondary institution after completing high school (or its equivalent).  
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19165">Initial Enrollment Term</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The first registration term of a person enrolling in credit-granting courses at a postsecondary institution after completing high school (or its equivalent).  ")]
    public System.String InitialEnrollmentTerm { get; set; }

    /// <summary>
    /// Instructional Activity Hours Attempted
    /// <para>
    /// The number of credit hours and/or contact hours attempted by a person during a term.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19168">Instructional Activity Hours Attempted</a>
    /// </para>
    /// </summary>
    [Comment("The number of credit hours and/or contact hours attempted by a person during a term.")]
    public Decimal? InstructionalActivityHoursAttempted { get; set; }

    /// <summary>
    /// Instructional Activity Hours Completed
    /// <para>
    /// The number of credit hours and/or contact hours successfully completed by a person during a term.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19361">Instructional Activity Hours Completed</a>
    /// </para>
    /// </summary>
    [Comment("The number of credit hours and/or contact hours successfully completed by a person during a term.")]
    public Decimal? InstructionalActivityHoursCompleted { get; set; }

    /// <summary>
    /// Oral Defense Completed Indicator
    /// <para>
    /// An indication of the individual's completion of an oral defense. The requirement to conduct an oral defense by doctoral individuals may vary across institutions, programs, or fields of study.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20385">Oral Defense Completed Indicator</a>
    /// </para>
    /// </summary>
    [Comment("An indication of the individual's completion of an oral defense. The requirement to conduct an oral defense by doctoral individuals may vary across institutions, programs, or fields of study.")]
    public Boolean? OralDefenseCompletedIndicator { get; set; }

    /// <summary>
    /// Oral Defense Date
    /// <para>
    /// The date on which the individual gave an oral defense.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20386">Oral Defense Date</a>
    /// </para>
    /// </summary>
    [Comment("The date on which the individual gave an oral defense.")]
    public DateTime? OralDefenseDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Postsecondary Entering Student Indicator
    /// <para>
    /// The initial enrollment of an individual in credit bearing courses or developmental/remedial courses at an institution after completing high school or a high school equivalency program (e.g. GED, Adult High School Diploma).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20395">Postsecondary Entering Student Indicator</a>
    /// </para>
    /// </summary>
    [Comment("The initial enrollment of an individual in credit bearing courses or developmental/remedial courses at an institution after completing high school or a high school equivalency program (e.g. GED, Adult High School Diploma).")]
    public Boolean? PostsecondaryEnteringStudentInd { get; set; }

    /// <summary>
    /// Developmental Education Referral Status
    /// <para>
    /// The status of a student's referral to or placement into  developmental education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20567">Developmental Education Referral Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDevelopmentalEducationReferralStatus")]
    [Comment("The status of a student's referral to or placement into  developmental education.")]
    public Guid? RefDevelopmentalEducationReferralStatusId { get; set; }

    /// <summary>
    /// Developmental Education Type
    /// <para>
    /// An indicator of the category of developmental education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20568">Developmental Education Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDevelopmentalEducationType")]
    [Comment("An indicator of the category of developmental education.")]
    public Guid? RefDevelopmentalEducationTypeId { get; set; }

    /// <summary>
    /// Distance Education Course Enrollment
    /// <para>
    /// An individual's enrollment in a course or courses in which the instructional content is delivered exclusively via distance education.  Distance education is education that uses one or more technologies to deliver instruction to students who are separated from the instructor and to support regular and substantive interaction between the students and the instructor synchronously or asynchronously.  Technologies used for instruction may include: Internet; one-way and two-way transmissions through open broadcasts, closed circuit, cable, microwave, broadband lines, fiber optics, satellite or wireless communication devices; audio conferencing; and video cassette, DVDs, and CD-ROMs, if the cassette, DVDs, and CD-ROMs are used in a course in conjunction with the technologies listed above.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19704">Distance Education Course Enrollment</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDistanceEducationCourseEnrollment")]
    [Comment("An individual's enrollment in a course or courses in which the instructional content is delivered exclusively via distance education.  Distance education is education that uses one or more technologies to deliver instruction to students who are separated from the instructor and to support regular and substantive interaction between the students and the instructor synchronously or asynchronously.  Technologies used for instruction may include: Internet; one-way and two-way transmissions through open broadcasts, closed circuit, cable, microwave, broadband lines, fiber optics, satellite or wireless communication devices; audio conferencing; and video cassette, DVDs, and CD-ROMs, if the cassette, DVDs, and CD-ROMs are used in a course in conjunction with the technologies listed above.")]
    public Guid? RefDistanceEducationCourseEnrollmentId { get; set; }

    /// <summary>
    /// Doctoral Exams Required Type
    /// <para>
    /// A qualifier identifying the types of exams required of doctoral level individuals.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20293">Doctoral Exams Required Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDoctoralExamsRequiredCode")]
    [Comment("A qualifier identifying the types of exams required of doctoral level individuals.")]
    public Guid? RefDoctoralExamsRequiredCodeId { get; set; }

    /// <summary>
    /// Graduate or Doctoral Exam Results Status
    /// <para>
    /// The individual's status in completing exams required for graduate or doctoral degree programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20324">Graduate or Doctoral Exam Results Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefGraduateOrDoctoralExamResultsStatus")]
    [Comment("The individual's status in completing exams required for graduate or doctoral degree programs.")]
    public Guid? RefGraduateOrDoctoralExamResultsStatusId { get; set; }

    /// <summary>
    /// Instructional Activity Hours Type
    /// <para>
    /// The unit of measure of student instructional activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19169">Instructional Activity Hours Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefInstructionalActivityHours")]
    [Comment("The unit of measure of student instructional activity.")]
    public Guid? RefInstructionalActivityHoursId { get; set; }

    /// <summary>
    /// Enrollment in Postsecondary Award Type
    /// <para>
    /// An indicator of the award level in which the person is currently enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19360">Enrollment in Postsecondary Award Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPsEnrollmentAwardType")]
    [Comment("An indicator of the award level in which the person is currently enrolled.")]
    public Guid? RefPsEnrollmentAwardTypeId { get; set; }

    /// <summary>
    /// Postsecondary Enrollment Status
    /// <para>
    /// An indication of the student's enrollment status for a particular term as defined by the institution
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19096">Postsecondary Enrollment Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPsEnrollmentStatus")]
    [Comment("An indication of the student's enrollment status for a particular term as defined by the institution")]
    public Guid? RefPsEnrollmentStatusId { get; set; }

    /// <summary>
    /// Postsecondary Enrollment Type
    /// <para>
    /// An indicator of the enrollment type associated with the enrollment award level of a person at the beginning of a term.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19095">Postsecondary Enrollment Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPsEnrollmentType")]
    [Comment("An indicator of the enrollment type associated with the enrollment award level of a person at the beginning of a term.")]
    public Guid? RefPsEnrollmentTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPsexitOrWithdrawalType"/> model
    /// </summary>
    [ForeignKey("RefPsexitOrWithdrawalType")]
    public Guid? RefPsexitOrWithdrawalTypeId { get; set; }

    /// <summary>
    /// Student Level
    /// <para>
    /// Classification of a person enrolling in credit-granting courses at a postsecondary institution since completing high school (or its equivalent) as either an undergraduate or graduate student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19272">Student Level</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPsStudentLevel")]
    [Comment("Classification of a person enrolling in credit-granting courses at a postsecondary institution since completing high school (or its equivalent) as either an undergraduate or graduate student.")]
    public Guid? RefPsStudentLevelId { get; set; }

    /// <summary>
    /// Transfer-ready
    /// <para>
    /// A person who has successfully completed a transfer-preparatory program as defined by the state or by the institution if no official state definition exists.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19296">Transfer-ready</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTransferReady")]
    [Comment("A person who has successfully completed a transfer-preparatory program as defined by the state or by the institution if no official state definition exists.")]
    public Guid? RefTransferReadyId { get; set; }

    /// <summary>
    /// Sorority Participation Status
    /// <para>
    /// Student is in membership in a chiefly social organization of women students at a college or university, usually designated by Greek letters.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19744">Sorority Participation Status</a>
    /// </para>
    /// </summary>
    [Comment("Student is in membership in a chiefly social organization of women students at a college or university, usually designated by Greek letters.")]
    public Boolean? SororityParticipationStatus { get; set; }

    /// <summary>
    /// Thesis or Dissertation Title
    /// <para>
    /// The title of the thesis or dissertation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20468">Thesis or Dissertation Title</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The title of the thesis or dissertation.")]
    public System.String ThesisOrDissertationTitle { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indicator of the enrollment type associated with the enrollment award level of a person at the beginning of a term.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19095">Postsecondary Enrollment Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefPsEnrollmentTypeEntity? RefPsEnrollmentTypeEntity { get; set; }

    /// <summary>
    /// An indication of the student's enrollment status for a particular term as defined by the institution
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19096">Postsecondary Enrollment Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefPsEnrollmentStatusEntity? RefPsEnrollmentStatusEntity { get; set; }

    /// <summary>
    /// Classification of a person enrolling in credit-granting courses at a postsecondary institution since completing high school (or its equivalent) as either an undergraduate or graduate student.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19272">Student Level</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefPsStudentLevelEntity? RefPsStudentLevelEntity { get; set; }

    /// <summary>
    /// An indicator of the award level in which the person is currently enrolled.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19360">Enrollment in Postsecondary Award Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefPsEnrollmentAwardTypeEntity? RefPsEnrollmentAwardTypeEntity { get; set; }

    /// <summary>
    /// A person who has successfully completed a transfer-preparatory program as defined by the state or by the institution if no official state definition exists.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19296">Transfer-ready</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefTransferReadyEntity? RefTransferReadyEntity { get; set; }

    /// <summary>
    /// An individual's enrollment in a course or courses in which the instructional content is delivered exclusively via distance education.  Distance education is education that uses one or more technologies to deliver instruction to students who are separated from the instructor and to support regular and substantive interaction between the students and the instructor synchronously or asynchronously.  Technologies used for instruction may include: Internet; one-way and two-way transmissions through open broadcasts, closed circuit, cable, microwave, broadband lines, fiber optics, satellite or wireless communication devices; audio conferencing; and video cassette, DVDs, and CD-ROMs, if the cassette, DVDs, and CD-ROMs are used in a course in conjunction with the technologies listed above.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19704">Distance Education Course Enrollment</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefDistanceEducationCourseEnrollmentEntity? RefDistanceEducationCourseEnrollmentEntity { get; set; }

    /// <summary>
    /// A qualifier identifying the types of exams required of doctoral level individuals.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20293">Doctoral Exams Required Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefDoctoralExamsRequiredCodeEntity? RefDoctoralExamsRequiredCodeEntity { get; set; }

    /// <summary>
    /// The individual's status in completing exams required for graduate or doctoral degree programs.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20324">Graduate or Doctoral Exam Results Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefGraduateOrDoctoralExamResultsStatusEntity? RefGraduateOrDoctoralExamResultsStatusEntity { get; set; }

    /// <summary>
    /// The status of a student's referral to or placement into  developmental education.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20567">Developmental Education Referral Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefDevelopmentalEducationReferralStatusEntity? RefDevelopmentalEducationReferralStatusEntity { get; set; }

    /// <summary>
    /// An indicator of the category of developmental education.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20568">Developmental Education Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefDevelopmentalEducationTypeEntity? RefDevelopmentalEducationTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefPsexitOrWithdrawalType"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefPsexitOrWithdrawalTypeEntity? RefPsexitOrWithdrawalTypeEntity { get; set; }

    #endregion
}
