//***************************************************************************
//* DomainName: Common Models
//* FileName:   ICourse.g.cs
//***************************************************************************

/// <summary>
/// The ICourse file
/// </summary>
public partial interface ICourse
{
    #region "ICourse Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Course Certification Description
    /// <para>
    /// A description of the certification or recognition associated with this course (ex. Networking, CAD, etc.)
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20268">Course Certification Description</a>
    /// </para>
    /// </summary>
    System.String CertificationDescription { get; set; }

    /// <summary>
    /// Credit Value
    /// <para>
    /// The amount of credit available to the student who successfully meets the objectives of the course or learning opportunity based on the units defined by Credit Unit Type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19058">Credit Value</a>
    /// </para>
    /// </summary>
    Decimal? CreditValue { get; set; }

    /// <summary>
    /// Instructional Minutes
    /// <para>
    /// The total number of instruction minutes in a given session, as determined by time in class, time on task (e.g., engaged in a class), or as estimated by a qualified course designer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19490">Instructional Minutes</a>
    /// </para>
    /// </summary>
    Int32? InstructionalMinutes { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Course Applicable Education Level
    /// <para>
    /// The education level, grade level or primary instructional level at which a course is intended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20267">Course Applicable Education Level</a>
    /// </para>
    /// </summary>
    Guid? RefCourseApplicableEducationLevelId { get; set; }

    /// <summary>
    /// Course Credit Units
    /// <para>
    /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
    /// </para>
    /// </summary>
    Guid? RefCourseCreditUnitId { get; set; }

    /// <summary>
    /// Course Level Characteristic
    /// <para>
    /// An indication of the general nature and difficulty of instruction provided throughout a course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19061">Course Level Characteristic</a>
    /// </para>
    /// </summary>
    Guid? RefCourseLevelCharacteristicsId { get; set; }

    /// <summary>
    /// Instruction Language
    /// <para>
    /// The language of instruction, other than English, used in the program or course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19438">Instruction Language</a>
    /// </para>
    /// </summary>
    Guid? RefInstructionLanguageId { get; set; }

    /// <summary>
    /// Course Repeatability Maximum Number
    /// <para>
    /// The maximum number of times the course may be taken or completed for credit.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20648">Course Repeatability Maximum Number</a>
    /// </para>
    /// </summary>
    Int32? RepeatabilityMaximumNumber { get; set; }

    System.String ScedsequenceOfCourse { get; set; }

    /// <summary>
    /// Course Subject Abbreviation
    /// <para>
    /// The alphabetic abbreviation of the academic department or discipline offering the course. It is one part of the total course identifier number. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19066">Course Subject Abbreviation</a>
    /// </para>
    /// </summary>
    System.String SubjectAbbreviation { get; set; }

    #endregion
}
