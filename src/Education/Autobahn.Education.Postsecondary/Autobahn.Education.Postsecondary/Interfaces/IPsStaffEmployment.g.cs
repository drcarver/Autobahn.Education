//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPsStaffEmployment.g.cs
//***************************************************************************

/// <summary>
/// The IPsStaffEmployment file
/// </summary>
public partial interface IPsStaffEmployment
{
    #region "IPsStaffEmployment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Annual Base Contractual Salary
    /// <para>
    /// The total annual base contractual salary of a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19722">Annual Base Contractual Salary</a>
    /// </para>
    /// </summary>
    Decimal? AnnualBaseContractualSalary { get; set; }

    /// <summary>
    /// Faculty Status
    /// <para>
    /// Persons identified by the institution as such and typically those whose initial assignments are made for the purpose of conducting instruction, research or public service as a principal activity (or activities). They may hold academic rank titles of professor, associate professor, assistant professor, instructor, lecturer or the equivalent of any of those academic ranks. Faculty may also include the chancellor/president, provost, vice provosts, deans, directors or the equivalent, as well as associate deans, assistant deans and executive officers of academic departments (chairpersons, heads or the equivalent) if their principal activity is instruction combined with research and/or public service. The designation as "faculty" is separate from the activities to which they may be currently assigned. For example, a newly appointed president of an institution may also be appointed as a faculty member. Graduate, instruction, and research assistants are not included in this category.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19711">Faculty Status</a>
    /// </para>
    /// </summary>
    Boolean? FacultyStatus { get; set; }

    /// <summary>
    /// Graduate Assistant Status
    /// <para>
    /// Graduate-level students employed on a part-time basis, not limited to, but often employed for the primary purpose of assisting in classroom or laboratory instruction or in the conduct of research.  Graduate students having titles such as graduate assistant, teaching assistant, teaching associate, teaching fellow, or research assistant typically hold these positions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19720">Graduate Assistant Status</a>
    /// </para>
    /// </summary>
    Boolean? GraduateAssistantStatus { get; set; }

    /// <summary>
    /// Instructional Staff Status
    /// <para>
    /// Staff whose primary function/occupational activity is primarily instruction or instruction combined with research and/or public service.  Does not include medical school staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19709">Instructional Staff Status</a>
    /// </para>
    /// </summary>
    Boolean? InstructionalStaffStatus { get; set; }

    /// <summary>
    /// Medical School Staff Status
    /// <para>
    /// Staff employed by or employees working in the medical school component of a postsecondary institution or in a free standing medical school.  Does not include staff employed by or employees working strictly in a hospital associated with a medical school or those who work in health or allied health schools or departments such as dentistry, veterinary medicine, nursing or dental hygiene.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19710">Medical School Staff Status</a>
    /// </para>
    /// </summary>
    Boolean? MedicalSchoolStaffStatus { get; set; }

    /// <summary>
    /// Academic Rank
    /// <para>
    /// The academic rank of staff whose primary responsibility is instruction, research, and/or public service.  Institutions without standard academic ranks should code staff whose primary responsibility is instruction, research, and/or public service as "No Academic Rank."
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19717">Academic Rank</a>
    /// </para>
    /// </summary>
    Guid? RefAcademicRankId { get; set; }

    /// <summary>
    /// Contract Type
    /// <para>
    /// The type of employment contract used by an institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19714">Contract Type</a>
    /// </para>
    /// </summary>
    Guid? RefEmploymentContractTypeId { get; set; }

    /// <summary>
    /// Full-time Status
    /// <para>
    /// An indication of whether an individual is employed for a standard number of hours (as determined by civil or organizational policies) in a week, month, or other period of time.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19713">Full-time Status</a>
    /// </para>
    /// </summary>
    Guid? RefFullTimeStatusId { get; set; }

    /// <summary>
    /// Graduate Assistant IPEDS Occupation Category
    /// <para>
    /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report graduate assistants.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19721">Graduate Assistant IPEDS Occupation Category</a>
    /// </para>
    /// </summary>
    Guid? RefGraduateAssistantIpedsCategoryId { get; set; }

    /// <summary>
    /// Instructional Staff Contract Length
    /// <para>
    /// The contracted teaching period for faculty.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19712">Instructional Staff Contract Length</a>
    /// </para>
    /// </summary>
    Guid? RefInstructionalStaffContractLengthId { get; set; }

    /// <summary>
    /// Instructional Staff Faculty Tenure Status
    /// <para>
    /// An indicator of the type of faculty status a person has if, by institutional definition, a staff member has faculty status.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19716">Instructional Staff Faculty Tenure Status</a>
    /// </para>
    /// </summary>
    Guid? RefInstructionalStaffFacultyTenureId { get; set; }

    /// <summary>
    /// Instruction Credit Type
    /// <para>
    /// A designation of the type(s) of instruction being delivered by staff whose primary responsibility is instruction.  Instruction that is for "credit" can be applied toward the requirements for a postsecondary degree, diploma, certificate or other formal award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19719">Instruction Credit Type</a>
    /// </para>
    /// </summary>
    Guid? RefInstructionCreditTypeId { get; set; }

    /// <summary>
    /// IPEDS Occupational Category
    /// <para>
    /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19708">IPEDS Occupational Category</a>
    /// </para>
    /// </summary>
    Guid? RefIpedsOccupationalCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
    /// </summary>
    Guid StaffEmploymentId { get; set; }

    #endregion
}
