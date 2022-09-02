//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsSection file
/// </summary>
[Table("PsSection", Schema = "Postsecondary")]
public partial class PsSectionEntity : EntityBase, IPsSection
{
    #region "IPsSection Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CourseSection")]
    public Guid CourseSectionId { get; set; }

    /// <summary>
    /// Course Academic Grade Scale Code
    /// <para>
    /// The grading scale used by an academic educational institution for an academic course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20264">Course Academic Grade Scale Code</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The grading scale used by an academic educational institution for an academic course.")]
    public System.String GradeValueQualifier { get; set; }

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
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    [Obsolete("The RefCourseGpaapplicability property is obsolete and will be removed in a later version")]
    [ForeignKey("RefCourseGpaapplicability")]
    public Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Course Honors Type
    /// <para>
    /// An indication that the course is or can be counted as an honors course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20273">Course Honors Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCourseHonorsType")]
    [Comment("An indication that the course is or can be counted as an honors course.")]
    public Guid? RefCourseHonorsTypeId { get; set; }

    /// <summary>
    /// Course Instruction Method
    /// <para>
    /// The primary method of instruction used for the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20274">Course Instruction Method</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCourseInstructionMethod")]
    [Comment("The primary method of instruction used for the course.")]
    public Guid? RefCourseInstructionMethodId { get; set; }

    /// <summary>
    /// Course Level Type
    /// <para>
    /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCourseLevelType")]
    [Comment("The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.")]
    public Guid? RefCourseLevelTypeId { get; set; }

    /// <summary>
    /// Developmental Education Type
    /// <para>
    /// An indicator of the category of developmental education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20568">Developmental Education Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDevelopmentalEducationType")]
    [Comment("An indicator of the category of developmental education.")]
    public Guid? RefDevelopmentalEducationTypeId { get; set; }

    /// <summary>
    /// Work-based Learning Opportunity Type
    /// <para>
    /// The type of work-based learning opportunity a student participated in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefWorkbasedLearningOpportunityType")]
    [Comment("The type of work-based learning opportunity a student participated in.")]
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual CourseSectionEntity CourseSectionEntity { get; set; }

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

    /// <summary>
    /// An indication that the course is or can be counted as an honors course.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20273">Course Honors Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseHonorsTypeEntity RefCourseHonorsTypeEntity { get; set; }

    /// <summary>
    /// The primary method of instruction used for the course.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20274">Course Instruction Method</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseInstructionMethodEntity RefCourseInstructionMethodEntity { get; set; }

    /// <summary>
    /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseLevelTypeEntity RefCourseLevelTypeEntity { get; set; }

    /// <summary>
    /// An indicator of the category of developmental education.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20568">Developmental Education Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefDevelopmentalEducationTypeEntity RefDevelopmentalEducationTypeEntity { get; set; }

    /// <summary>
    /// The type of work-based learning opportunity a student participated in.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20471">Work-based Learning Opportunity Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefWorkbasedLearningOpportunityTypeEntity RefWorkbasedLearningOpportunityTypeEntity { get; set; }

    #endregion
}
