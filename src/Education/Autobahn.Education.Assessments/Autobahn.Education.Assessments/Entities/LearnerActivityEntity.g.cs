//***************************************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearnerActivity file
/// </summary>
[Table("LearnerActivity", Schema = "Assessments")]
public partial class LearnerActivityEntity : EntityBase, ILearnerActivity
{
    #region "ILearnerActivity Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
    /// </summary>
    [ForeignKey("AssessmentRegistration")]
    public Guid? AssessmentRegistrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssignedByPerson"/> model
    /// </summary>
    [ForeignKey("AssignedByPerson")]
    public Guid? AssignedByPersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> model
    /// </summary>
    [ForeignKey("CourseSection")]
    public Guid? CourseSectionId { get; set; }

    /// <summary>
    /// Learner Activity Creation Date
    /// <para>
    /// The creation date of the assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19944">Learner Activity Creation Date</a>
    /// </para>
    /// </summary>
    [Comment("The creation date of the assignment.")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Learner Activity Due Date
    /// <para>
    /// The date assignment is due.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19947">Learner Activity Due Date</a>
    /// </para>
    /// </summary>
    [Comment("The date assignment is due.")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Learner Activity Due Time
    /// <para>
    /// The time the assignment is due.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19948">Learner Activity Due Time</a>
    /// </para>
    /// </summary>
    [Comment("The time the assignment is due.")]
    public TimeSpan? DueTime { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILeaOrganization"/> model
    /// </summary>
    [ForeignKey("LeaOrganization")]
    public Guid? LeaOrganizationId { get; set; }

    /// <summary>
    /// Learner Activity Maximum Attempts Allowed
    /// <para>
    /// The number attempts a student may make on this assignment. Assumed to be unlimited if zero or omitted.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19949">Learner Activity Maximum Attempts Allowed</a>
    /// </para>
    /// </summary>
    [Comment("The number attempts a student may make on this assignment. Assumed to be unlimited if zero or omitted.")]
    public Decimal? MaximumAttemptsAllowed { get; set; }

    /// <summary>
    /// Learner Activity Maximum Time Allowed
    /// <para>
    /// The time required to complete the assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19945">Learner Activity Maximum Time Allowed</a>
    /// </para>
    /// </summary>
    [Comment("The time required to complete the assignment.")]
    public Decimal? MaximumTimeAllowed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    [ForeignKey("OrganizationCalendarSession")]
    public Guid? OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Learner Activity Possible Points
    /// <para>
    /// The number of possible points for an assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19953">Learner Activity Possible Points</a>
    /// </para>
    /// </summary>
    [Comment("The number of possible points for an assignment.")]
    public Decimal? PossiblePoints { get; set; }

    /// <summary>
    /// Learner Activity Prerequisite
    /// <para>
    /// The description of the skills or competencies the student must have to engage in assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19942">Learner Activity Prerequisite</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The description of the skills or competencies the student must have to engage in assignment.")]
    public System.String Prerequisite { get; set; }

    /// <summary>
    /// Learner Activity Language
    /// <para>
    /// The default language used for the assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19939">Learner Activity Language</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLanguage")]
    [Comment("The default language used for the assignment.")]
    public Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Learner Activity Add to Grade Book Flag
    /// <para>
    /// Identifies the assignment as one that is graded.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19950">Learner Activity Add to Grade Book Flag</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearnerActivityAddToGradeBookFlag")]
    [Comment("Identifies the assignment as one that is graded.")]
    public Guid? RefLearnerActivityAddToGradeBookFlagId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnit"/> model
    /// </summary>
    [ForeignKey("RefLearnerActivityMaximumTimeAllowedUnit")]
    public Guid? RefLearnerActivityMaximumTimeAllowedUnitId { get; set; }

    /// <summary>
    /// Learner Activity Type
    /// <para>
    /// The type of work assigned to the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19943">Learner Activity Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLearnerActivityType")]
    [Comment("The type of work assigned to the learner.")]
    public Guid? RefLearnerActivityTypeId { get; set; }

    /// <summary>
    /// Learner Activity Release Date
    /// <para>
    /// The date the student was informed about an assignment or that an automated system displays the assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19951">Learner Activity Release Date</a>
    /// </para>
    /// </summary>
    [Comment("The date the student was informed about an assignment or that an automated system displays the assignment.")]
    public DateTime? ReleaseDate { get; set; }

    /// <summary>
    /// Learner Activity Rubric URL
    /// <para>
    /// The Uniform Resource Locator pointing to a rubric that may be used to evaluate learner performance on the assignment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19954">Learner Activity Rubric URL</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The Uniform Resource Locator pointing to a rubric that may be used to evaluate learner performance on the assignment.")]
    public System.String RubricUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ISchoolOrganization"/> model
    /// </summary>
    [ForeignKey("SchoolOrganization")]
    public Guid? SchoolOrganizationId { get; set; }

    /// <summary>
    /// Learner Activity Title
    /// <para>
    /// The title�for work assigned to the learner, which can comprise of learning resources, activities, and assessments.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19940">Learner Activity Title</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The title�for work assigned to the learner, which can comprise of learning resources, activities, and assessments.")]
    public System.String Title { get; set; }

    /// <summary>
    /// Learner Activity Weight
    /// <para>
    /// The percentage weight of the assignment during the particular course or term.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19952">Learner Activity Weight</a>
    /// </para>
    /// </summary>
    [Comment("The percentage weight of the assignment during the particular course or term.")]
    public Decimal? Weight { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentRegistrationEntity? AssessmentRegistrationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourseSection"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual CourseSectionEntity? CourseSectionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual OrganizationCalendarSessionEntity? OrganizationCalendarSessionEntity { get; set; }

    /// <summary>
    /// The type of work assigned to the learner.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19943">Learner Activity Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefLearnerActivityTypeEntity? RefLearnerActivityTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefLearnerActivityMaximumTimeAllowedUnit"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefLearnerActivityMaximumTimeAllowedUnitEntity? RefLearnerActivityMaximumTimeAllowedUnitEntity { get; set; }

    /// <summary>
    /// Identifies the assignment as one that is graded.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19950">Learner Activity Add to Grade Book Flag</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefLearnerActivityAddToGradeBookFlagEntity? RefLearnerActivityAddToGradeBookFlagEntity { get; set; }

    #endregion
}
