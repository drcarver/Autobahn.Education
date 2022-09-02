//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentDemographicViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentDemographic file
/// </summary>
public partial class PsStudentDemographicViewModel : ObservableValidator, IPsStudentDemographic
{
    #region "PsStudentDemographicViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsStudentDemographicViewModel Constructor
    /// </summary>
    public PsStudentDemographicViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsStudentDemographicViewModelConstruction();
    }

    /// <summary>
    /// PsStudentDemographicViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsStudentDemographicViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsStudentDemographic";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ChildrenOfFallenHeroesIndicator -- (backing property for Children of Fallen Heroes Indicator)
    private Boolean? childrenOfFallenHeroesIndicator;

    // EmancipatedMinor -- (backing property for Emancipated Minor)
    private Boolean? emancipatedMinor;

    // FirstGenerationCollegeStudent -- (backing property for First Generation College Student)
    private Boolean? firstGenerationCollegeStudent;

    // NumberOfDependents -- (backing property for Number of Dependents)
    private Int32? numberOfDependents;

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

    #region "IPsStudentDemographic Properties"
    /// <summary>
    /// Children of Fallen Heroes Indicator
    /// <para>
    /// Pell-eligible students whose parent or guardian was a member of the U.S. armed forces and died as a result of military service performed in Iraq or Afghanistan after the events of 9/11 or a public safety officer and died as a result of active service in the line of duty. At the time of the parent's or guardian's death, the student must be less than 24 years of age or enrolled in college or career school at least part-time.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20917">Children of Fallen Heroes Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Children of Fallen Heroes Indicator")]
    public Boolean? ChildrenOfFallenHeroesIndicator { get => childrenOfFallenHeroesIndicator; set => SetProperty(ref childrenOfFallenHeroesIndicator, value, false); }

    /// <summary>
    /// Emancipated Minor
    /// <para>
    /// A minor student under the age of 18 who has been granted by legal action to have the power and capacity of an adult.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20931">Emancipated Minor</a>
    /// </para>
    /// </summary>
    [DisplayName("Emancipated Minor")]
    public Boolean? EmancipatedMinor { get => emancipatedMinor; set => SetProperty(ref emancipatedMinor, value, false); }

    /// <summary>
    /// First Generation College Student
    /// <para>
    /// The term First Generation College Student means an individual both of whose parents did not complete a baccalaureate degree or in the case of any individual who regularly resided with and received support from only one parent, an individual whose only such parent did not complete a baccalaureate degree.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20933">First Generation College Student</a>
    /// </para>
    /// </summary>
    [DisplayName("First Generation College Student")]
    public Boolean? FirstGenerationCollegeStudent { get => firstGenerationCollegeStudent; set => SetProperty(ref firstGenerationCollegeStudent, value, false); }

    /// <summary>
    /// Number of Dependents
    /// <para>
    /// The number of dependents who live with the student and receive more than half their support from them.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20384">Number of Dependents</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of Dependents")]
    public Int32? NumberOfDependents { get => numberOfDependents; set => SetProperty(ref numberOfDependents, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Campus Residency Type
    /// <para>
    /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19035">Campus Residency Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Campus Residency Type")]
    public Guid? RefCampusResidencyTypeId { get; set; }

    /// <summary>
    /// Cohort Exclusion
    /// <para>
    /// Those persons who may be removed (deleted) from a cohort (or subcohort). For the Graduation Rates and Fall Enrollment retention rate reporting, persons may be removed from a cohort if they left the institution for one of the following reasons: death or total and permanent disability; service in the armed forces (including those called to active duty); service with a foreign aid service of the federal government, such as the Peace Corps; or service on official church missions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19106">Cohort Exclusion</a>
    /// </para>
    /// </summary>
    [DisplayName("Cohort Exclusion")]
    public Guid? RefCohortExclusionId { get; set; }

    /// <summary>
    /// Dependency Status
    /// <para>
    /// A person's classification as dependent or independent with regards to eligibility for Title IV Federal Student aid.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19079">Dependency Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Dependency Status")]
    public Guid? RefDependencyStatusId { get; set; }

    /// <summary>
    /// Maternal Guardian Education
    /// <para>
    /// The highest level of education attained by a person's mother or maternal guardian
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20194">Maternal Guardian Education</a>
    /// </para>
    /// </summary>
    [DisplayName("Maternal Guardian Education")]
    public Guid? RefMaternalEducationLevelId { get; set; }

    /// <summary>
    /// Number of Dependents Type
    /// <para>
    /// The student's relationship to the dependents who live with the student or receive more than half of the student's support
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20949">Number of Dependents Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Number of Dependents Type")]
    public Guid? RefNumberOfDependentsTypeId { get; set; }

    /// <summary>
    /// Paternal Guardian Education
    /// <para>
    /// The highest level of education attained by a person's father or paternal guardian
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20195">Paternal Guardian Education</a>
    /// </para>
    /// </summary>
    [DisplayName("Paternal Guardian Education")]
    public Guid? RefPaternalEducationLevelId { get; set; }

    /// <summary>
    /// Limited English Proficiency - Postsecondary
    /// <para>
    /// The term "individual with limited English proficiency" means a secondary school student, an adult, or an out-of-school youth, who has limited ability in speaking, reading, writing, or understanding the English language AND whose native language is a language other than English; OR who lives in a family or community environment in which a language other than English is the dominant language. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19179">Limited English Proficiency - Postsecondary</a>
    /// </para>
    /// </summary>
    [DisplayName("Limited English Proficiency - Postsecondary")]
    public Guid? RefPsLepTypeId { get; set; }

    /// <summary>
    /// Tuition Residency Type
    /// <para>
    /// A person's residency status for tuition purposes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19297">Tuition Residency Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Tuition Residency Type")]
    public Guid? RefTuitionResidencyTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsStudentDemographic model)
    {
        IsBusy = true;
        Id = model.Id;
        ChildrenOfFallenHeroesIndicator = model.ChildrenOfFallenHeroesIndicator; // Children of Fallen Heroes Indicator
        EmancipatedMinor = model.EmancipatedMinor; // Emancipated Minor
        FirstGenerationCollegeStudent = model.FirstGenerationCollegeStudent; // First Generation College Student
        NumberOfDependents = model.NumberOfDependents; // Number of Dependents
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefCampusResidencyTypeId = model.RefCampusResidencyTypeId; // Campus Residency Type
        RefCohortExclusionId = model.RefCohortExclusionId; // Cohort Exclusion
        RefDependencyStatusId = model.RefDependencyStatusId; // Dependency Status
        RefMaternalEducationLevelId = model.RefMaternalEducationLevelId; // Maternal Guardian Education
        RefNumberOfDependentsTypeId = model.RefNumberOfDependentsTypeId; // Number of Dependents Type
        RefPaternalEducationLevelId = model.RefPaternalEducationLevelId; // Paternal Guardian Education
        RefPsLepTypeId = model.RefPsLepTypeId; // Limited English Proficiency - Postsecondary
        RefTuitionResidencyTypeId = model.RefTuitionResidencyTypeId; // Tuition Residency Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
