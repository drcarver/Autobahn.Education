//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStaffEmploymentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IPsStaffEmployment file
/// </summary>
public partial class PsStaffEmploymentViewModel : ObservableValidator, IPsStaffEmployment
{
    #region "PsStaffEmploymentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// PsStaffEmploymentViewModel Constructor
    /// </summary>
    public PsStaffEmploymentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnPsStaffEmploymentViewModelConstruction();
    }

    /// <summary>
    /// PsStaffEmploymentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnPsStaffEmploymentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from PsStaffEmployment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AnnualBaseContractualSalary -- (backing property for Annual Base Contractual Salary)
    private Decimal? annualBaseContractualSalary;

    // FacultyStatus -- (backing property for Faculty Status)
    private Boolean? facultyStatus;

    // GraduateAssistantStatus -- (backing property for Graduate Assistant Status)
    private Boolean? graduateAssistantStatus;

    // InstructionalStaffStatus -- (backing property for Instructional Staff Status)
    private Boolean? instructionalStaffStatus;

    // MedicalSchoolStaffStatus -- (backing property for Medical School Staff Status)
    private Boolean? medicalSchoolStaffStatus;

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

    #region "IPsStaffEmployment Properties"
    /// <summary>
    /// Annual Base Contractual Salary
    /// <para>
    /// The total annual base contractual salary of a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19722">Annual Base Contractual Salary</a>
    /// </para>
    /// </summary>
    [DisplayName("Annual Base Contractual Salary")]
    public Decimal? AnnualBaseContractualSalary { get => annualBaseContractualSalary; set => SetProperty(ref annualBaseContractualSalary, value, false); }

    /// <summary>
    /// Faculty Status
    /// <para>
    /// Persons identified by the institution as such and typically those whose initial assignments are made for the purpose of conducting instruction, research or public service as a principal activity (or activities). They may hold academic rank titles of professor, associate professor, assistant professor, instructor, lecturer or the equivalent of any of those academic ranks. Faculty may also include the chancellor/president, provost, vice provosts, deans, directors or the equivalent, as well as associate deans, assistant deans and executive officers of academic departments (chairpersons, heads or the equivalent) if their principal activity is instruction combined with research and/or public service. The designation as "faculty" is separate from the activities to which they may be currently assigned. For example, a newly appointed president of an institution may also be appointed as a faculty member. Graduate, instruction, and research assistants are not included in this category.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19711">Faculty Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Faculty Status")]
    public Boolean? FacultyStatus { get => facultyStatus; set => SetProperty(ref facultyStatus, value, false); }

    /// <summary>
    /// Graduate Assistant Status
    /// <para>
    /// Graduate-level students employed on a part-time basis, not limited to, but often employed for the primary purpose of assisting in classroom or laboratory instruction or in the conduct of research.  Graduate students having titles such as graduate assistant, teaching assistant, teaching associate, teaching fellow, or research assistant typically hold these positions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19720">Graduate Assistant Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Graduate Assistant Status")]
    public Boolean? GraduateAssistantStatus { get => graduateAssistantStatus; set => SetProperty(ref graduateAssistantStatus, value, false); }

    /// <summary>
    /// Instructional Staff Status
    /// <para>
    /// Staff whose primary function/occupational activity is primarily instruction or instruction combined with research and/or public service.  Does not include medical school staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19709">Instructional Staff Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Instructional Staff Status")]
    public Boolean? InstructionalStaffStatus { get => instructionalStaffStatus; set => SetProperty(ref instructionalStaffStatus, value, false); }

    /// <summary>
    /// Medical School Staff Status
    /// <para>
    /// Staff employed by or employees working in the medical school component of a postsecondary institution or in a free standing medical school.  Does not include staff employed by or employees working strictly in a hospital associated with a medical school or those who work in health or allied health schools or departments such as dentistry, veterinary medicine, nursing or dental hygiene.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19710">Medical School Staff Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Medical School Staff Status")]
    public Boolean? MedicalSchoolStaffStatus { get => medicalSchoolStaffStatus; set => SetProperty(ref medicalSchoolStaffStatus, value, false); }

    /// <summary>
    /// Academic Rank
    /// <para>
    /// The academic rank of staff whose primary responsibility is instruction, research, and/or public service.  Institutions without standard academic ranks should code staff whose primary responsibility is instruction, research, and/or public service as "No Academic Rank."
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19717">Academic Rank</a>
    /// </para>
    /// </summary>
    [DisplayName("Academic Rank")]
    public Guid? RefAcademicRankId { get; set; }

    /// <summary>
    /// Contract Type
    /// <para>
    /// The type of employment contract used by an institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19714">Contract Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Contract Type")]
    public Guid? RefEmploymentContractTypeId { get; set; }

    /// <summary>
    /// Full-time Status
    /// <para>
    /// An indication of whether an individual is employed for a standard number of hours (as determined by civil or organizational policies) in a week, month, or other period of time.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19713">Full-time Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Full-time Status")]
    public Guid? RefFullTimeStatusId { get; set; }

    /// <summary>
    /// Graduate Assistant IPEDS Occupation Category
    /// <para>
    /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report graduate assistants.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19721">Graduate Assistant IPEDS Occupation Category</a>
    /// </para>
    /// </summary>
    [DisplayName("Graduate Assistant IPEDS Occupation Category")]
    public Guid? RefGraduateAssistantIpedsCategoryId { get; set; }

    /// <summary>
    /// Instructional Staff Contract Length
    /// <para>
    /// The contracted teaching period for faculty.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19712">Instructional Staff Contract Length</a>
    /// </para>
    /// </summary>
    [DisplayName("Instructional Staff Contract Length")]
    public Guid? RefInstructionalStaffContractLengthId { get; set; }

    /// <summary>
    /// Instructional Staff Faculty Tenure Status
    /// <para>
    /// An indicator of the type of faculty status a person has if, by institutional definition, a staff member has faculty status.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19716">Instructional Staff Faculty Tenure Status</a>
    /// </para>
    /// </summary>
    [DisplayName("Instructional Staff Faculty Tenure Status")]
    public Guid? RefInstructionalStaffFacultyTenureId { get; set; }

    /// <summary>
    /// Instruction Credit Type
    /// <para>
    /// A designation of the type(s) of instruction being delivered by staff whose primary responsibility is instruction.  Instruction that is for "credit" can be applied toward the requirements for a postsecondary degree, diploma, certificate or other formal award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19719">Instruction Credit Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Instruction Credit Type")]
    public Guid? RefInstructionCreditTypeId { get; set; }

    /// <summary>
    /// IPEDS Occupational Category
    /// <para>
    /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19708">IPEDS Occupational Category</a>
    /// </para>
    /// </summary>
    [DisplayName("IPEDS Occupational Category")]
    public Guid? RefIpedsOccupationalCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
    /// </summary>
    public Guid StaffEmploymentId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IPsStaffEmployment model)
    {
        IsBusy = true;
        Id = model.Id;
        AnnualBaseContractualSalary = model.AnnualBaseContractualSalary; // Annual Base Contractual Salary
        FacultyStatus = model.FacultyStatus; // Faculty Status
        GraduateAssistantStatus = model.GraduateAssistantStatus; // Graduate Assistant Status
        InstructionalStaffStatus = model.InstructionalStaffStatus; // Instructional Staff Status
        MedicalSchoolStaffStatus = model.MedicalSchoolStaffStatus; // Medical School Staff Status
        RefAcademicRankId = model.RefAcademicRankId; // Academic Rank
        RefEmploymentContractTypeId = model.RefEmploymentContractTypeId; // Contract Type
        RefFullTimeStatusId = model.RefFullTimeStatusId; // Full-time Status
        RefGraduateAssistantIpedsCategoryId = model.RefGraduateAssistantIpedsCategoryId; // Graduate Assistant IPEDS Occupation Category
        RefInstructionalStaffContractLengthId = model.RefInstructionalStaffContractLengthId; // Instructional Staff Contract Length
        RefInstructionalStaffFacultyTenureId = model.RefInstructionalStaffFacultyTenureId; // Instructional Staff Faculty Tenure Status
        RefInstructionCreditTypeId = model.RefInstructionCreditTypeId; // Instruction Credit Type
        RefIpedsOccupationalCategoryId = model.RefIpedsOccupationalCategoryId; // IPEDS Occupational Category
        StaffEmploymentId = model.StaffEmploymentId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
