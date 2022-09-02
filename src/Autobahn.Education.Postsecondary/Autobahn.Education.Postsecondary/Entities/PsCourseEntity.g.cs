//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsCourseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsCourse file
/// </summary>
[Table("PsCourse", Schema = "Postsecondary")]
public partial class PsCourseEntity : EntityBase, IPsCourse
{
    #region "IPsCourse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Course")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The official reference number portion of a course identifier.  This number normally designates the level of the course as well as the level of the individual expected to enroll in the course.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The course identifier as it was listed when the credit was earned (e.g. before a system conversion) to show consistency between present transcripts and older ones.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An indication of the way an academic course was identified at an educational institution.")]
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
    [ForeignKey("RefCipCode")]
    [Comment("A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.")]
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
    [ForeignKey("RefCourseCreditBasisType")]
    [Comment("The type of enrollment associated with the credit hours for the course.")]
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
    [ForeignKey("RefCourseCreditLevelType")]
    [Comment("The level of credit associated with the credit hours earned for the course.")]
    public Guid? RefCourseCreditLevelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNcescollegeCourseMapCode"/> model
    /// </summary>
    [ForeignKey("RefNcescollegeCourseMapCode")]
    public Guid? RefNcescollegeCourseMapCodeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual CourseEntity CourseEntity { get; set; }

    /// <summary>
    /// The type of enrollment associated with the credit hours for the course.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20269">Course Credit Basis Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseCreditBasisTypeEntity RefCourseCreditBasisTypeEntity { get; set; }

    /// <summary>
    /// The level of credit associated with the credit hours earned for the course.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20270">Course Credit Level Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseCreditLevelTypeEntity RefCourseCreditLevelTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefNcescollegeCourseMapCode"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefNcescollegeCourseMapCodeEntity RefNcescollegeCourseMapCodeEntity { get; set; }

    /// <summary>
    /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCipCodeEntity RefCipCodeEntity { get; set; }

    #endregion
}
