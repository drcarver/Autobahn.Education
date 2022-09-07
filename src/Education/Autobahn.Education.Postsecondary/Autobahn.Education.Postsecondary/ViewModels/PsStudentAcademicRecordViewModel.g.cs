//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicRecordViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentAcademicRecord file
/// </summary>
public partial class PsStudentAcademicRecordViewModel : ObservableValidator, IPsStudentAcademicRecord
{
    #region "PsStudentAcademicRecordViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsStudentAcademicRecordViewModel Constructor
    /// </summary>
    public PsStudentAcademicRecordViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsStudentAcademicRecordViewModelConstruction();
    }

    /// <summary>
    /// PsStudentAcademicRecordViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsStudentAcademicRecordViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsStudentAcademicRecord";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AcademicYearDesignator -- (backing property for Academic Year Designator)
    private System.String academicYearDesignator;

    // AdvancedPlacementCreditsAwarded -- (backing property for Advanced Placement Credits Awarded)
    private Int32? advancedPlacementCreditsAwarded;

    // CourseTotal -- (backing property for Course Total)
    private Int32? courseTotal;

    // CreditsAttemptedCumulative -- (backing property for Credits Attempted Cumulative)
    private Decimal? creditsAttemptedCumulative;

    // CreditsEarnedCumulative -- (backing property for Credits Earned Cumulative)
    private Decimal? creditsEarnedCumulative;

    // DiplomaOrCredentialAwardDate -- (backing property for Diploma or Credential Award Date)
    private System.String diplomaOrCredentialAwardDate;

    // DualCreditDualEnrollmentCredits -- (backing property for Dual Credit Dual Enrollment Credits Awarded)
    private Decimal? dualCreditDualEnrollmentCredits;

    // EnteringTerm -- (backing property for Postsecondary Student Entering Term)
    private System.String enteringTerm;

    // GradePointAverage -- (backing property for Grade Point Average)
    private Decimal? gradePointAverage;

    // GradePointAverageCumulative -- (backing property for Grade Point Average Cumulative)
    private Decimal? gradePointAverageCumulative;

    // NumberOfCreditsAttempted -- (backing property for Number of Credits Attempted)
    private Decimal? numberOfCreditsAttempted;

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

    #region "IPsStudentAcademicRecord Properties"
    /// <summary>
    /// Academic Year Designator
    /// <para>
    /// The academic year for which the data apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19702">Academic Year Designator</a>
    /// </para>
    /// </summary>
    [DisplayName("Academic Year Designator")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(9,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AcademicYearDesignator { get => academicYearDesignator; set => SetProperty(ref academicYearDesignator, value, true); }

    /// <summary>
    /// Advanced Placement Credits Awarded
    /// <para>
    /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19018">Advanced Placement Credits Awarded</a>
    /// </para>
    /// </summary>
    [DisplayName("Advanced Placement Credits Awarded")]
    public Int32? AdvancedPlacementCreditsAwarded { get => advancedPlacementCreditsAwarded; set => SetProperty(ref advancedPlacementCreditsAwarded, value, false); }

    /// <summary>
    /// Course Total
    /// <para>
    /// The total number of courses listed on a transcript. Used as a check digit for integrity purposes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20282">Course Total</a>
    /// </para>
    /// </summary>
    [DisplayName("Course Total")]
    public Int32? CourseTotal { get => courseTotal; set => SetProperty(ref courseTotal, value, false); }

    /// <summary>
    /// Credits Attempted Cumulative
    /// <para>
    /// The cumulative number of credits a person attempts to earn by taking courses during their enrollment in their current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19073">Credits Attempted Cumulative</a>
    /// </para>
    /// </summary>
    [DisplayName("Credits Attempted Cumulative")]
    public Decimal? CreditsAttemptedCumulative { get => creditsAttemptedCumulative; set => SetProperty(ref creditsAttemptedCumulative, value, false); }

    /// <summary>
    /// Credits Earned Cumulative
    /// <para>
    /// The cumulative number of credits a person earns by completing courses or examinations during their enrollment in the current education institution as well as those credits transferred from an education institution in which the person had been previously enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19074">Credits Earned Cumulative</a>
    /// </para>
    /// </summary>
    [DisplayName("Credits Earned Cumulative")]
    public Decimal? CreditsEarnedCumulative { get => creditsEarnedCumulative; set => SetProperty(ref creditsEarnedCumulative, value, false); }

    /// <summary>
    /// Diploma or Credential Award Date
    /// <para>
    /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Diploma or Credential Award Date")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(7,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String DiplomaOrCredentialAwardDate { get => diplomaOrCredentialAwardDate; set => SetProperty(ref diplomaOrCredentialAwardDate, value, true); }

    /// <summary>
    /// Dual Credit Dual Enrollment Credits Awarded
    /// <para>
    /// The number of credits awarded a student by the postsecondary institution based on successful completion of dual credit/dual enrollment courses. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19085">Dual Credit Dual Enrollment Credits Awarded</a>
    /// </para>
    /// </summary>
    [DisplayName("Dual Credit Dual Enrollment Credits Awarded")]
    public Decimal? DualCreditDualEnrollmentCredits { get => dualCreditDualEnrollmentCredits; set => SetProperty(ref dualCreditDualEnrollmentCredits, value, false); }

    /// <summary>
    /// Postsecondary Student Entering Term
    /// <para>
    /// The term and year of the initial enrollment of an individual in credit bearing courses or developmental/remedial courses at an institution after completing high school or a high school equivalency program (e.g., GED, Adult High School Diploma).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20396">Postsecondary Student Entering Term</a>
    /// </para>
    /// </summary>
    [DisplayName("Postsecondary Student Entering Term")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String EnteringTerm { get => enteringTerm; set => SetProperty(ref enteringTerm, value, true); }

    /// <summary>
    /// Grade Point Average
    /// <para>
    /// The value of the total quality points divided by the Credit Hours for Grade Point Average. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19127">Grade Point Average</a>
    /// </para>
    /// </summary>
    [DisplayName("Grade Point Average")]
    public Decimal? GradePointAverage { get => gradePointAverage; set => SetProperty(ref gradePointAverage, value, false); }

    /// <summary>
    /// Grade Point Average Cumulative
    /// <para>
    /// A measure of average performance in all courses taken by a person during his or her school career as determined for record-keeping purposes. This is obtained by dividing the total grade points received by the total number of credits attempted. This usually includes grade points received and credits attempted in his or her current school as well as those transferred from schools in which the person was previously enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19128">Grade Point Average Cumulative</a>
    /// </para>
    /// </summary>
    [DisplayName("Grade Point Average Cumulative")]
    public Decimal? GradePointAverageCumulative { get => gradePointAverageCumulative; set => SetProperty(ref gradePointAverageCumulative, value, false); }

    /// <summary>
    /// Number of Credits Attempted
    /// <para>
    /// The number of credits that a student can earn for enrolling in and completing a given course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19199">Number of Credits Attempted</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of Credits Attempted")]
    public Decimal? NumberOfCreditsAttempted { get => numberOfCreditsAttempted; set => SetProperty(ref numberOfCreditsAttempted, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Academic Term Designator
    /// <para>
    /// The academic term for which the data apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19703">Academic Term Designator</a>
    /// </para>
    /// </summary>
    [DisplayName("Academic Term Designator")]
    public Guid? RefAcademicTermDesignatorId { get; set; }

    /// <summary>
    /// Credit Hours Applied Other Program
    /// <para>
    /// Codes identifying the set of credit hours taken in other programs or degrees that were applied to the individual's degree.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20283">Credit Hours Applied Other Program</a>
    /// </para>
    /// </summary>
    [DisplayName("Credit Hours Applied Other Program")]
    public Guid? RefCreditHoursAppliedOtherProgramId { get; set; }

    /// <summary>
    /// Professional or Technical Credential Conferred
    /// <para>
    /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
    /// </para>
    /// </summary>
    [DisplayName("Professional or Technical Credential Conferred")]
    public Guid? RefProfessionalTechCredentialTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsStudentAcademicRecord model)
    {
        IsBusy = true;
        Id = model.Id;
        AcademicYearDesignator = model.AcademicYearDesignator; // Academic Year Designator
        AdvancedPlacementCreditsAwarded = model.AdvancedPlacementCreditsAwarded; // Advanced Placement Credits Awarded
        CourseTotal = model.CourseTotal; // Course Total
        CreditsAttemptedCumulative = model.CreditsAttemptedCumulative; // Credits Attempted Cumulative
        CreditsEarnedCumulative = model.CreditsEarnedCumulative; // Credits Earned Cumulative
        DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
        DualCreditDualEnrollmentCredits = model.DualCreditDualEnrollmentCredits; // Dual Credit Dual Enrollment Credits Awarded
        EnteringTerm = model.EnteringTerm; // Postsecondary Student Entering Term
        GradePointAverage = model.GradePointAverage; // Grade Point Average
        GradePointAverageCumulative = model.GradePointAverageCumulative; // Grade Point Average Cumulative
        NumberOfCreditsAttempted = model.NumberOfCreditsAttempted; // Number of Credits Attempted
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefAcademicTermDesignatorId = model.RefAcademicTermDesignatorId; // Academic Term Designator
        RefCreditHoursAppliedOtherProgramId = model.RefCreditHoursAppliedOtherProgramId; // Credit Hours Applied Other Program
        RefProfessionalTechCredentialTypeId = model.RefProfessionalTechCredentialTypeId; // Professional or Technical Credential Conferred
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
