//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   CourseSectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICourseSection file
/// </summary>
[Table("CourseSection", Schema = "Invalid")]
public partial class CourseSectionEntity : EntityBase, ICourseSection
{
    #region "ICourseSection Properties"
    /// <summary>
    /// Available Carnegie Unit Credit
    /// <para>
    /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19030">Available Carnegie Unit Credit</a>
    /// </para>
    /// </summary>
    [Comment("Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of \u0022seat time\u0022 rather than a measure of attainment of the course objectives.")]
    public Decimal? AvailableCarnegieUnitCredit { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Course")]
    public Guid CourseId { get; set; }

    /// <summary>
    /// Course Section Maximum Capacity
    /// <para>
    /// The maximum number of students the Course Section can maintain.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20636">Course Section Maximum Capacity</a>
    /// </para>
    /// </summary>
    [Comment("The maximum number of students the Course Section can maintain.")]
    public Int32? MaximumCapacity { get; set; }

    /// <summary>
    /// Course Begin Date
    /// <para>
    /// The year, month and day an instance of a course officially began.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19054">Course Begin Date</a>
    /// </para>
    /// </summary>
    [ForeignKey("OrganizationCalendarSession")]
    [Comment("The year, month and day an instance of a course officially began.")]
    public Guid? OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Additional Credit Type
    /// <para>
    /// The type of credits or units of value available for the completion of a course in addition to Carnegie Units.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19589">Additional Credit Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAdditionalCreditType")]
    [Comment("The type of credits or units of value available for the completion of a course in addition to Carnegie Units.")]
    public Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Advanced Placement Course Code
    /// <para>
    /// Course areas for advanced placement or credit.  For a list of codes see http://apcentral.collegeboard.com/apc/public/courses/teachers_corner/index.html .
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20244">Advanced Placement Course Code</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAdvancedPlacementCourseCode")]
    [Comment("Course areas for advanced placement or credit.  For a list of codes see http://apcentral.collegeboard.com/apc/public/courses/teachers_corner/index.html .")]
    public Guid? RefAdvancedPlacementCourseCodeId { get; set; }

    /// <summary>
    /// Course Section Instructional Delivery Mode
    /// <para>
    /// The primary setting or medium of delivery for the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20168">Course Section Instructional Delivery Mode</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCourseSectionDeliveryMode")]
    [Comment("The primary setting or medium of delivery for the course.")]
    public Guid? RefCourseSectionDeliveryModeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
    /// </summary>
    [ForeignKey("RefCreditTypeEarned")]
    public Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Instruction Language
    /// <para>
    /// The language of instruction, other than English, used in the program or course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19438">Instruction Language</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefInstructionLanguage")]
    [Comment("The language of instruction, other than English, used in the program or course.")]
    public Guid? RefInstructionLanguageId { get; set; }

    /// <summary>
    /// Course Section Single Sex Class Status
    /// <para>
    /// Section in a co-educational school where only male or only female students are permitted to take the course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19258">Course Section Single Sex Class Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefSingleSexClassStatus")]
    [Comment("Section in a co-educational school where only male or only female students are permitted to take the course.")]
    public Guid? RefSingleSexClassStatusId { get; set; }

    /// <summary>
    /// Related Competency Definitions
    /// <para>
    /// An indication of the competency definition(s) addressed in the Course Section.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19231">Related Competency Definitions</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An indication of the competency definition(s) addressed in the Course Section.")]
    public System.String RelatedCompetencyDefinitions { get; set; }

    /// <summary>
    /// Course Section Time Required for Completion
    /// <para>
    /// The actual or estimated number of clock minutes required for course completion. This number is especially important for career and technical education course and may represent (in minutes) the clock hour requirement of the course, the number of minutes (or clock hours) of class time per week, times the number of equivalent weeks the class typically meets.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19101">Course Section Time Required for Completion</a>
    /// </para>
    /// </summary>
    [Comment("The actual or estimated number of clock minutes required for course completion. This number is especially important for career and technical education course and may represent (in minutes) the clock hour requirement of the course, the number of minutes (or clock hours) of class time per week, times the number of equivalent weeks the class typically meets.")]
    public Decimal? TimeRequiredForCompletion { get; set; }

    /// <summary>
    /// Virtual Indicator
    /// <para>
    /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20167">Virtual Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.")]
    public Boolean? VirtualIndicator { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual CourseEntity CourseEntity { get; set; }

    /// <summary>
    /// The year, month and day an instance of a course officially began.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19054">Course Begin Date</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual OrganizationCalendarSessionEntity? OrganizationCalendarSessionEntity { get; set; }

    /// <summary>
    /// The primary setting or medium of delivery for the course.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20168">Course Section Instructional Delivery Mode</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseSectionDeliveryModeEntity? RefCourseSectionDeliveryModeEntity { get; set; }

    /// <summary>
    /// Section in a co-educational school where only male or only female students are permitted to take the course.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19258">Course Section Single Sex Class Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefSingleSexClassStatusEntity? RefSingleSexClassStatusEntity { get; set; }

    /// <summary>
    /// The type of credits or units of value available for the completion of a course in addition to Carnegie Units.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19589">Additional Credit Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefAdditionalCreditTypeEntity? RefAdditionalCreditTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCreditTypeEarned"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefCreditTypeEarnedEntity? RefCreditTypeEarnedEntity { get; set; }

    /// <summary>
    /// Course areas for advanced placement or credit.  For a list of codes see http://apcentral.collegeboard.com/apc/public/courses/teachers_corner/index.html .
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20244">Advanced Placement Course Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefAdvancedPlacementCourseCodeEntity? RefAdvancedPlacementCourseCodeEntity { get; set; }

    #endregion
}
