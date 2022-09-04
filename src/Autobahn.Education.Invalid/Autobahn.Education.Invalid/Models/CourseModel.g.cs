//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   CourseEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICourse file
/// </summary>
public partial class CourseModel : AutobahnBaseModel, ICourse
{
    #region "ICourse Properties"
    /// <summary>
    /// Course Certification Description
    /// <para>
    /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20268">Course Certification Description</a>
    /// </para>
    /// </summary>
    public System.String CertificationDescription { get; set; }

    /// <summary>
    /// Credit Value
    /// <para>
    /// The amount of credit available to the student who successfully meets the objectives of the course or learning opportunity based on the units defined by Credit Unit Type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19058">Credit Value</a>
    /// </para>
    /// </summary>
    public Decimal? CreditValue { get; set; }

    /// <summary>
    /// Instructional Minutes
    /// <para>
    /// The total number of instruction minutes in a given session, as determined by time in class, time on task (e.g., engaged in a class), or as estimated by a qualified course designer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19490">Instructional Minutes</a>
    /// </para>
    /// </summary>
    public Int32? InstructionalMinutes { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Course Applicable Education Level
    /// <para>
    /// The education level, grade level or primary instructional level at which a course is intended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20267">Course Applicable Education Level</a>
    /// </para>
    /// </summary>
    public Guid? RefCourseApplicableEducationLevelId { get; set; }

    /// <summary>
    /// Course Credit Units
    /// <para>
    /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
    /// </para>
    /// </summary>
    public Guid? RefCourseCreditUnitId { get; set; }

    /// <summary>
    /// Course Level Characteristic
    /// <para>
    /// An indication of the general nature and difficulty of instruction provided throughout a course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19061">Course Level Characteristic</a>
    /// </para>
    /// </summary>
    public Guid? RefCourseLevelCharacteristicsId { get; set; }

    /// <summary>
    /// Instruction Language
    /// <para>
    /// The language of instruction, other than English, used in the program or course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19438">Instruction Language</a>
    /// </para>
    /// </summary>
    public Guid? RefInstructionLanguageId { get; set; }

    /// <summary>
    /// Course Repeatability Maximum Number
    /// <para>
    /// The maximum number of times the course may be taken or completed for credit.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20648">Course Repeatability Maximum Number</a>
    /// </para>
    /// </summary>
    public Int32? RepeatabilityMaximumNumber { get; set; }

    public System.String ScedsequenceOfCourse { get; set; }

    /// <summary>
    /// Course Subject Abbreviation
    /// <para>
    /// The alphabetic abbreviation of the academic department or discipline offering the course. It is one part of the total course identifier number. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19066">Course Subject Abbreviation</a>
    /// </para>
    /// </summary>
    public System.String SubjectAbbreviation { get; set; }

    #endregion
}
