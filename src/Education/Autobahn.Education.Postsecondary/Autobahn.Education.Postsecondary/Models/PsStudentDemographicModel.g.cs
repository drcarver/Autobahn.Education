//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentDemographicEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentDemographic file
/// </summary>
public partial class PsStudentDemographicModel : AutobahnBaseModel, IPsStudentDemographic
{
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
    public Boolean? ChildrenOfFallenHeroesIndicator { get; set; }

    /// <summary>
    /// Emancipated Minor
    /// <para>
    /// A minor student under the age of 18 who has been granted by legal action to have the power and capacity of an adult.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20931">Emancipated Minor</a>
    /// </para>
    /// </summary>
    public Boolean? EmancipatedMinor { get; set; }

    /// <summary>
    /// First Generation College Student
    /// <para>
    /// The term First Generation College Student means an individual both of whose parents did not complete a baccalaureate degree or in the case of any individual who regularly resided with and received support from only one parent, an individual whose only such parent did not complete a baccalaureate degree.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20933">First Generation College Student</a>
    /// </para>
    /// </summary>
    public Boolean? FirstGenerationCollegeStudent { get; set; }

    /// <summary>
    /// Number of Dependents
    /// <para>
    /// The number of dependents who live with the student and receive more than half their support from them.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20384">Number of Dependents</a>
    /// </para>
    /// </summary>
    public Int32? NumberOfDependents { get; set; }

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
    public Guid? RefTuitionResidencyTypeId { get; set; }

    #endregion
}
