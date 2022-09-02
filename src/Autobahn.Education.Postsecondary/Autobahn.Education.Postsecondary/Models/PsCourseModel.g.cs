//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsCourseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsCourse file
/// </summary>
public partial class PsCourseModel : AutobahnBaseModel, IPsCourse
{
    #region "IPsCourse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    public Guid CourseId { get; set; }

    /// <summary>
    /// Course Number
    /// <para>
    /// The official reference number portion of a course identifier.  This number normally designates the level of the course as well as the level of the individual expected to enroll in the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20280">Course Number</a>
    /// </para>
    /// </summary>
    public System.String CourseNumber { get; set; }

    public Int32? NcaaeligibilityInd { get; set; }

    /// <summary>
    /// Original Course Identifier
    /// <para>
    /// The course identifier as it was listed when the credit was earned (e.g. before a system conversion) to show consistency between present transcripts and older ones.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20389">Original Course Identifier</a>
    /// </para>
    /// </summary>
    public System.String OriginalCourseIdentifier { get; set; }

    /// <summary>
    /// Override School Course Number
    /// <para>
    /// An indication of the way an academic course was identified at an educational institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20391">Override School Course Number</a>
    /// </para>
    /// </summary>
    public System.String OverrideSchoolCourseNumber { get; set; }

    /// <summary>
    /// Classification of Instructional Program Code
    /// <para>
    /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
    /// </para>
    /// </summary>
    public Guid? RefCipCodeId { get; set; }

    /// <summary>
    /// Course Credit Basis Type
    /// <para>
    /// The type of enrollment associated with the credit hours for the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20269">Course Credit Basis Type</a>
    /// </para>
    /// </summary>
    public Guid? RefCourseCreditBasisTypeId { get; set; }

    /// <summary>
    /// Course Credit Level Type
    /// <para>
    /// The level of credit associated with the credit hours earned for the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20270">Course Credit Level Type</a>
    /// </para>
    /// </summary>
    public Guid? RefCourseCreditLevelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNcescollegeCourseMapCode"/> model
    /// </summary>
    public Guid? RefNcescollegeCourseMapCodeId { get; set; }

    #endregion
}
