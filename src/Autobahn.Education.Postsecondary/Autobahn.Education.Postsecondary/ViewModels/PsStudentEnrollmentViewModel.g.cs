//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentEnrollmentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentEnrollment file
/// </summary>
public partial class PsStudentEnrollmentViewModel : ObservableValidator, IPsStudentEnrollment
{
    #region "PsStudentEnrollmentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsStudentEnrollmentViewModel Constructor
    /// </summary>
    public PsStudentEnrollmentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsStudentEnrollmentViewModelConstruction();
    }

    /// <summary>
    /// PsStudentEnrollmentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsStudentEnrollmentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsStudentEnrollment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // DegreeOrCertificateSeekingStudent -- (backing property for Degree or Certificate Seeking Student)
    private Boolean? degreeOrCertificateSeekingStudent;

    // member variable for the DisplacedStudentStatus property
    private Boolean? displacedStudentStatus;

    // DistanceEducationProgramEnrollmentInd -- (backing property for Distance Education Program Enrollment Indicator)
    private Boolean? distanceEducationProgramEnrollmentInd;

    // DoctoralCandidacyAdmitInd -- (backing property for Doctoral Candidacy Admit Indicator)
    private Boolean? doctoralCandidacyAdmitInd;

    // DoctoralCandidacyDate -- (backing property for Doctoral Candidacy Date)
    private DateTime? doctoralCandidacyDate;

    // DoctoralExamTakenDate -- (backing property for Doctoral Exam Taken Date)
    private DateTime? doctoralExamTakenDate;

    // EntryDateIntoPostsecondary -- (backing property for Entry Date into Postsecondary)
    private DateTime? entryDateIntoPostsecondary;

    // FirstTimePostsecondaryStudent -- (backing property for First Time Postsecondary Student)
    private Boolean? firstTimePostsecondaryStudent;

    // FraternityParticipationStatus -- (backing property for Fraternity Participation Status)
    private Boolean? fraternityParticipationStatus;

    // HousingOnCampus -- (backing property for Postsecondary Student Housing On-Campus)
    private Boolean? housingOnCampus;

    // InitialEnrollmentTerm -- (backing property for Initial Enrollment Term)
    private System.String initialEnrollmentTerm;

    // InstructionalActivityHoursAttempted -- (backing property for Instructional Activity Hours Attempted)
    private Decimal? instructionalActivityHoursAttempted;

    // InstructionalActivityHoursCompleted -- (backing property for Instructional Activity Hours Completed)
    private Decimal? instructionalActivityHoursCompleted;

    // OralDefenseCompletedIndicator -- (backing property for Oral Defense Completed Indicator)
    private Boolean? oralDefenseCompletedIndicator;

    // OralDefenseDate -- (backing property for Oral Defense Date)
    private DateTime? oralDefenseDate;

    // PostsecondaryEnteringStudentInd -- (backing property for Postsecondary Entering Student Indicator)
    private Boolean? postsecondaryEnteringStudentInd;

    // SororityParticipationStatus -- (backing property for Sorority Participation Status)
    private Boolean? sororityParticipationStatus;

    // ThesisOrDissertationTitle -- (backing property for Thesis or Dissertation Title)
    private System.String thesisOrDissertationTitle;

    #endregion

    #region "IAutobahnBase Properties"
    /// <summary>
    /// The title of the View Model
    /// </summary>
    public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

    /// <summary>
    /// The IsNew property is set if the view model has been created but not saved to the database
    /// </summary>
    public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

    /// <summary>
    /// The IsDeleted property is set if the view model is to be delted from the database
    /// </summary>
    public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

    /// <summary>
    /// The primary key of the view model
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The view model is changed and needs to be save to the database.
    /// </summary>
    public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

    /// <summary>
    /// The view model is performing a long running task
    /// </summary>
    public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

    /// <summary>
    /// The view model's changes have been save so update its tracking properties
    /// </summary>
    public void AcceptChanges()
    {
        IsNew = false;
        IsChanged = false;
    }
    #endregion

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
    [DisplayName("Degree or Certificate Seeking Student")]
    public Boolean? DegreeOrCertificateSeekingStudent { get => degreeOrCertificateSeekingStudent; set => SetProperty(ref degreeOrCertificateSeekingStudent, value, false); }

    public Boolean? DisplacedStudentStatus { get => displacedStudentStatus; set => SetProperty(ref displacedStudentStatus, value, false); }

    /// <summary>
    /// Distance Education Program Enrollment Indicator
    /// <para>
    /// An individual's enrollment in a program for which all the required coursework for program completion is able to be completed via distance education courses. Distance education is education that uses one or more technologies to deliver instruction to individuals who are separated from the instructor and to support regular and substantive interaction between the individuals and the instructor synchronously or asynchronously.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20289">Distance Education Program Enrollment Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Distance Education Program Enrollment Indicator")]
    public Boolean? DistanceEducationProgramEnrollmentInd { get => distanceEducationProgramEnrollmentInd; set => SetProperty(ref distanceEducationProgramEnrollmentInd, value, false); }

    /// <summary>
    /// Doctoral Candidacy Admit Indicator
    /// <para>
    /// The individual's status in being admitted as a doctoral candidate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20290">Doctoral Candidacy Admit Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Doctoral Candidacy Admit Indicator")]
    public Boolean? DoctoralCandidacyAdmitInd { get => doctoralCandidacyAdmitInd; set => SetProperty(ref doctoralCandidacyAdmitInd, value, false); }

    /// <summary>
    /// Doctoral Candidacy Date
    /// <para>
    /// The date on which the individual was admitted to doctoral candidate status.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20291">Doctoral Candidacy Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Doctoral Candidacy Date")]
    public DateTime? DoctoralCandidacyDate { get => doctoralCandidacyDate; set => SetProperty(ref doctoralCandidacyDate, value, false); }

    /// <summary>
    /// Doctoral Exam Taken Date
    /// <para>
    /// The date on which the individual took an exam for advancement in, continuation or completion of a doctoral program.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20292">Doctoral Exam Taken Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Doctoral Exam Taken Date")]
    public DateTime? DoctoralExamTakenDate { get => doctoralExamTakenDate; set => SetProperty(ref doctoralExamTakenDate, value, false); }

    /// <summary>
    /// Entry Date into Postsecondary
    /// <para>
    /// The year, month and day on which a person entered and began to receive instructional services at a postsecondary institution for the first time after completing high school (or its equivalent). 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19098">Entry Date into Postsecondary</a>
    /// </para>
    /// </summary>
    [DisplayName("Entry Date into Postsecondary")]
    public DateTime? EntryDateIntoPostsecondary { get => entryDateIntoPostsecondary; set => SetProperty(ref entryDateIntoPostsecondary, value, false); }

    /// <summary>
    /// First Time Postsecondary Student
    /// <para>
    /// A person who has no prior postsecondary experience  attending any institution for the first time at the undergraduate level since completing high school (or its equivalent). This includes persons enrolled in academic or occupational programs. It also includes persons enrolled in the fall term who attended college for the first time in the prior summer term, and persons who entered with advanced standing (college credits earned before graduation from high school).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19117">First Time Postsecondary Student</a>
    /// </para>
    /// </summary>
    [DisplayName("First Time Postsecondary Student")]
    public Boolean? FirstTimePostsecondaryStudent { get => firstTimePostsecondaryStudent; set => SetProperty(ref firstTimePostsecondaryStudent, value, false); }

    /// <summary>
    /// Fraternity Participation Status
    /// <para>
    /// Student is in membership of a chiefly social organization of men students at a college or university, usually designated by Greek letters.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19743">Fraternity Participation Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Fraternity Participation Status")]
    public Boolean? FraternityParticipationStatus { get => fraternityParticipationStatus; set => SetProperty(ref fraternityParticipationStatus, value, false); }

    /// <summary>
    /// Postsecondary Student Housing On-Campus
    /// <para>
    /// The student resides in a residence hall or housing facility owned or controlled by an institution within the same reasonably contiguous geographic area and used by the institution in direct support of or in a manner related to, the institution's educational purposes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19741">Postsecondary Student Housing On-Campus</a>
    /// </para>
    /// </summary>
    [DisplayName("Postsecondary Student Housing On-Campus")]
    public Boolean? HousingOnCampus { get => housingOnCampus; set => SetProperty(ref housingOnCampus, value, false); }

    /// <summary>
    /// Initial Enrollment Term
    /// <para>
    /// The first registration term of a person enrolling in credit-granting courses at a postsecondary institution after completing high school (or its equivalent).  
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19165">Initial Enrollment Term</a>
    /// </para>
    /// </summary>
    [DisplayName("Initial Enrollment Term")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String InitialEnrollmentTerm { get => initialEnrollmentTerm; set => SetProperty(ref initialEnrollmentTerm, value, true); }

    /// <summary>
    /// Instructional Activity Hours Attempted
    /// <para>
    /// The number of credit hours and/or contact hours attempted by a person during a term.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19168">Instructional Activity Hours Attempted</a>
    /// </para>
    /// </summary>
    [DisplayName("Instructional Activity Hours Attempted")]
    public Decimal? InstructionalActivityHoursAttempted { get => instructionalActivityHoursAttempted; set => SetProperty(ref instructionalActivityHoursAttempted, value, false); }

    /// <summary>
    /// Instructional Activity Hours Completed
    /// <para>
    /// The number of credit hours and/or contact hours successfully completed by a person during a term.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19361">Instructional Activity Hours Completed</a>
    /// </para>
    /// </summary>
    [DisplayName("Instructional Activity Hours Completed")]
    public Decimal? InstructionalActivityHoursCompleted { get => instructionalActivityHoursCompleted; set => SetProperty(ref instructionalActivityHoursCompleted, value, false); }

    /// <summary>
    /// Oral Defense Completed Indicator
    /// <para>
    /// An indication of the individual's completion of an oral defense. The requirement to conduct an oral defense by doctoral individuals may vary across institutions, programs, or fields of study.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20385">Oral Defense Completed Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Oral Defense Completed Indicator")]
    public Boolean? OralDefenseCompletedIndicator { get => oralDefenseCompletedIndicator; set => SetProperty(ref oralDefenseCompletedIndicator, value, false); }

    /// <summary>
    /// Oral Defense Date
    /// <para>
    /// The date on which the individual gave an oral defense.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20386">Oral Defense Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Oral Defense Date")]
    public DateTime? OralDefenseDate { get => oralDefenseDate; set => SetProperty(ref oralDefenseDate, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
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
    [DisplayName("Postsecondary Entering Student Indicator")]
    public Boolean? PostsecondaryEnteringStudentInd { get => postsecondaryEnteringStudentInd; set => SetProperty(ref postsecondaryEnteringStudentInd, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsstudentEnrollment"/> model
    /// </summary>
    public Guid PsstudentEnrollmentId { get; set; }

    /// <summary>
    /// Developmental Education Referral Status
    /// <para>
    /// The status of a student's referral to or placement into  developmental education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20567">Developmental Education Referral Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Developmental Education Referral Status")]
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
    [DisplayName("Developmental Education Type")]
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
    [DisplayName("Distance Education Course Enrollment")]
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
    [DisplayName("Doctoral Exams Required Type")]
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
    [DisplayName("Graduate or Doctoral Exam Results Status")]
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
    [DisplayName("Instructional Activity Hours Type")]
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
    [DisplayName("Enrollment in Postsecondary Award Type")]
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
    [DisplayName("Postsecondary Enrollment Status")]
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
    [DisplayName("Postsecondary Enrollment Type")]
    public Guid? RefPsEnrollmentTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPsexitOrWithdrawalType"/> model
    /// </summary>
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
    [DisplayName("Student Level")]
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
    [DisplayName("Transfer-ready")]
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
    [DisplayName("Sorority Participation Status")]
    public Boolean? SororityParticipationStatus { get => sororityParticipationStatus; set => SetProperty(ref sororityParticipationStatus, value, false); }

    /// <summary>
    /// Thesis or Dissertation Title
    /// <para>
    /// The title of the thesis or dissertation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20468">Thesis or Dissertation Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Thesis or Dissertation Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ThesisOrDissertationTitle { get => thesisOrDissertationTitle; set => SetProperty(ref thesisOrDissertationTitle, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsStudentEnrollment model)
    {
        IsBusy = true;
        Id = model.Id;
        DegreeOrCertificateSeekingStudent = model.DegreeOrCertificateSeekingStudent; // Degree or Certificate Seeking Student
        DisplacedStudentStatus = model.DisplacedStudentStatus; // 
        DistanceEducationProgramEnrollmentInd = model.DistanceEducationProgramEnrollmentInd; // Distance Education Program Enrollment Indicator
        DoctoralCandidacyAdmitInd = model.DoctoralCandidacyAdmitInd; // Doctoral Candidacy Admit Indicator
        DoctoralCandidacyDate = model.DoctoralCandidacyDate; // Doctoral Candidacy Date
        DoctoralExamTakenDate = model.DoctoralExamTakenDate; // Doctoral Exam Taken Date
        EntryDateIntoPostsecondary = model.EntryDateIntoPostsecondary; // Entry Date into Postsecondary
        FirstTimePostsecondaryStudent = model.FirstTimePostsecondaryStudent; // First Time Postsecondary Student
        FraternityParticipationStatus = model.FraternityParticipationStatus; // Fraternity Participation Status
        HousingOnCampus = model.HousingOnCampus; // Postsecondary Student Housing On-Campus
        InitialEnrollmentTerm = model.InitialEnrollmentTerm; // Initial Enrollment Term
        InstructionalActivityHoursAttempted = model.InstructionalActivityHoursAttempted; // Instructional Activity Hours Attempted
        InstructionalActivityHoursCompleted = model.InstructionalActivityHoursCompleted; // Instructional Activity Hours Completed
        OralDefenseCompletedIndicator = model.OralDefenseCompletedIndicator; // Oral Defense Completed Indicator
        OralDefenseDate = model.OralDefenseDate; // Oral Defense Date
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        PostsecondaryEnteringStudentInd = model.PostsecondaryEnteringStudentInd; // Postsecondary Entering Student Indicator
        PsstudentEnrollmentId = model.PsstudentEnrollmentId; // 
        RefDevelopmentalEducationReferralStatusId = model.RefDevelopmentalEducationReferralStatusId; // Developmental Education Referral Status
        RefDevelopmentalEducationTypeId = model.RefDevelopmentalEducationTypeId; // Developmental Education Type
        RefDistanceEducationCourseEnrollmentId = model.RefDistanceEducationCourseEnrollmentId; // Distance Education Course Enrollment
        RefDoctoralExamsRequiredCodeId = model.RefDoctoralExamsRequiredCodeId; // Doctoral Exams Required Type
        RefGraduateOrDoctoralExamResultsStatusId = model.RefGraduateOrDoctoralExamResultsStatusId; // Graduate or Doctoral Exam Results Status
        RefInstructionalActivityHoursId = model.RefInstructionalActivityHoursId; // Instructional Activity Hours Type
        RefPsEnrollmentAwardTypeId = model.RefPsEnrollmentAwardTypeId; // Enrollment in Postsecondary Award Type
        RefPsEnrollmentStatusId = model.RefPsEnrollmentStatusId; // Postsecondary Enrollment Status
        RefPsEnrollmentTypeId = model.RefPsEnrollmentTypeId; // Postsecondary Enrollment Type
        RefPsexitOrWithdrawalTypeId = model.RefPsexitOrWithdrawalTypeId; // 
        RefPsStudentLevelId = model.RefPsStudentLevelId; // Student Level
        RefTransferReadyId = model.RefTransferReadyId; // Transfer-ready
        SororityParticipationStatus = model.SororityParticipationStatus; // Sorority Participation Status
        ThesisOrDissertationTitle = model.ThesisOrDissertationTitle; // Thesis or Dissertation Title
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
