//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentApplicationViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentApplication file
/// </summary>
public partial class PsStudentApplicationViewModel : ObservableValidator, IPsStudentApplication
{
    #region "PsStudentApplicationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsStudentApplicationViewModel Constructor
    /// </summary>
    public PsStudentApplicationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsStudentApplicationViewModelConstruction();
    }

    /// <summary>
    /// PsStudentApplicationViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsStudentApplicationViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsStudentApplication";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // GradePointAverageCumulative -- (backing property for Grade Point Average Cumulative)
    private Decimal? gradePointAverageCumulative;

    // HighSchoolGraduatingClassSize -- (backing property for Size of High School Graduating Class)
    private Int32? highSchoolGraduatingClassSize;

    // HighSchoolPercentile -- (backing property for High School Percentile)
    private Decimal? highSchoolPercentile;

    // HighSchoolStudentClassRank -- (backing property for High School Student Class Rank)
    private Int32? highSchoolStudentClassRank;

    // PostsecondaryApplicant -- (backing property for Postsecondary Applicant)
    private Boolean? postsecondaryApplicant;

    // WaitListedStudent -- (backing property for Wait Listed Student)
    private Boolean? waitListedStudent;

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

    #region "IPsStudentApplication Properties"
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
    /// Size of High School Graduating Class
    /// <para>
    /// The total number of students in the student's high school graduating class.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19294">Size of High School Graduating Class</a>
    /// </para>
    /// </summary>
    [DisplayName("Size of High School Graduating Class")]
    public Int32? HighSchoolGraduatingClassSize { get => highSchoolGraduatingClassSize; set => SetProperty(ref highSchoolGraduatingClassSize, value, false); }

    /// <summary>
    /// High School Percentile
    /// <para>
    /// The High School Rank divided by the Size of High School Graduating Class expressed as a percentage.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19740">High School Percentile</a>
    /// </para>
    /// </summary>
    [DisplayName("High School Percentile")]
    public Decimal? HighSchoolPercentile { get => highSchoolPercentile; set => SetProperty(ref highSchoolPercentile, value, false); }

    /// <summary>
    /// High School Student Class Rank
    /// <para>
    /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19041">High School Student Class Rank</a>
    /// </para>
    /// </summary>
    [DisplayName("High School Student Class Rank")]
    public Int32? HighSchoolStudentClassRank { get => highSchoolStudentClassRank; set => SetProperty(ref highSchoolStudentClassRank, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Postsecondary Applicant
    /// <para>
    /// An individual who has fulfilled the institution's requirements to be considered for admission (including payment or waiving of the application fee, if any) and who has been notified of one of the following actions: admission, nonadmission, placement on waiting list, or application withdrawn (by applicant or institution). Include early decision, early action, and students who began studies during summer in this cohort.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19735">Postsecondary Applicant</a>
    /// </para>
    /// </summary>
    [DisplayName("Postsecondary Applicant")]
    public Boolean? PostsecondaryApplicant { get => postsecondaryApplicant; set => SetProperty(ref postsecondaryApplicant, value, false); }

    /// <summary>
    /// Admitted Student
    /// <para>
    /// Applicant who has been granted an official offer to enroll in a postsecondary institution. Admitted applicants should include wait-listed students who were subsequently offered admission.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19736">Admitted Student</a>
    /// </para>
    /// </summary>
    [DisplayName("Admitted Student")]
    public Guid? RefAdmittedStudentId { get; set; }

    /// <summary>
    /// Grade Point Average Weighted Indicator
    /// <para>
    /// An indication of whether the reported Grade Point Average is weighted or unweighted.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19123">Grade Point Average Weighted Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Grade Point Average Weighted Indicator")]
    public Guid? RefGpaWeightedIndicatorId { get; set; }

    /// <summary>
    /// Grade Point Average Domain
    /// <para>
    /// The domain to which the Grade Point Average is referencing.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19739">Grade Point Average Domain</a>
    /// </para>
    /// </summary>
    [DisplayName("Grade Point Average Domain")]
    public Guid? RefGradePointAverageDomainId { get; set; }

    /// <summary>
    /// Wait Listed Student
    /// <para>
    /// A person who meets the admission requirements but will only be offered a place in the class if space becomes available.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19738">Wait Listed Student</a>
    /// </para>
    /// </summary>
    [DisplayName("Wait Listed Student")]
    public Boolean? WaitListedStudent { get => waitListedStudent; set => SetProperty(ref waitListedStudent, value, false); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsStudentApplication model)
    {
        IsBusy = true;
        Id = model.Id;
        GradePointAverageCumulative = model.GradePointAverageCumulative; // Grade Point Average Cumulative
        HighSchoolGraduatingClassSize = model.HighSchoolGraduatingClassSize; // Size of High School Graduating Class
        HighSchoolPercentile = model.HighSchoolPercentile; // High School Percentile
        HighSchoolStudentClassRank = model.HighSchoolStudentClassRank; // High School Student Class Rank
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        PostsecondaryApplicant = model.PostsecondaryApplicant; // Postsecondary Applicant
        RefAdmittedStudentId = model.RefAdmittedStudentId; // Admitted Student
        RefGpaWeightedIndicatorId = model.RefGpaWeightedIndicatorId; // Grade Point Average Weighted Indicator
        RefGradePointAverageDomainId = model.RefGradePointAverageDomainId; // Grade Point Average Domain
        WaitListedStudent = model.WaitListedStudent; // Wait Listed Student
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
