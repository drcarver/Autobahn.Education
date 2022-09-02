//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffProfessionalDevelopmentActivity file
/// </summary>
[Table("StaffProfessionalDevelopmentActivity", Schema = "Common")]
public partial class StaffProfessionalDevelopmentActivityEntity : EntityBase, IStaffProfessionalDevelopmentActivity
{
    #region "IStaffProfessionalDevelopmentActivity Properties"
    /// <summary>
    /// Staff Professional Development Activity Completion Date
    /// <para>
    /// The year, month and day on which an individual completed a course, an education program or a staff development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20068">Staff Professional Development Activity Completion Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which an individual completed a course, an education program or a staff development activity.")]
    public DateTime? ActivityCompletionDate { get; set; }

    /// <summary>
    /// Professional Development Activity Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to the Professional Development Activity as assigned by the organization offering the training.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19808">Professional Development Activity Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A unique number or alphanumeric code assigned to the Professional Development Activity as assigned by the organization offering the training.")]
    public System.String ActivityIdentifier { get; set; }

    /// <summary>
    /// Staff Professional Development Activity Start Date
    /// <para>
    /// The year, month and day on which an individual begins a course, an education program or a staff development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20067">Staff Professional Development Activity Start Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day on which an individual begins a course, an education program or a staff development activity.")]
    public DateTime? ActivityStartDate { get; set; }

    /// <summary>
    /// Professional Development Activity Title
    /// <para>
    /// The title of an activity designed for the purpose of developing someone professionally.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19809">Professional Development Activity Title</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The title of an activity designed for the purpose of developing someone professionally.")]
    public System.String ActivityTitle { get; set; }

    /// <summary>
    /// Number of Credits Earned
    /// <para>
    /// The number of credits an individual earns by the successful completion of a course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19200">Number of Credits Earned</a>
    /// </para>
    /// </summary>
    [Comment("The number of credits an individual earns by the successful completion of a course.")]
    public Decimal? NumberOfCreditsEarned { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ProfessionalDevelopmentActivity")]
    public Guid ProfessionalDevelopmentActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ProfessionalDevelopmentRequirement")]
    public Guid ProfessionalDevelopmentRequirementId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentSession"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ProfessionalDevelopmentSession")]
    public Guid ProfessionalDevelopmentSessionId { get; set; }

    /// <summary>
    /// Course Credit Units
    /// <para>
    /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCourseCreditUnit")]
    [Comment("The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. ")]
    public Guid? RefCourseCreditUnitId { get; set; }

    /// <summary>
    /// Professional Development Financial Support Type
    /// <para>
    /// The type of financial assistance received in support of non-credit professional development activities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19811">Professional Development Financial Support Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefProfessionalDevelopmentFinancialSupport")]
    [Comment("The type of financial assistance received in support of non-credit professional development activities.")]
    public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

    /// <summary>
    /// Professional Development Scholarship Status
    /// <para>
    /// An indication of whether a scholarship was received for the person to participate in the professional development.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19810">Professional Development Scholarship Status</a>
    /// </para>
    /// </summary>
    [Comment("An indication of whether a scholarship was received for the person to participate in the professional development.")]
    public Boolean? ScholarshipStatus { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual ProfessionalDevelopmentRequirementEntity ProfessionalDevelopmentRequirementEntity { get; set; }

    /// <summary>
    /// The type of financial assistance received in support of non-credit professional development activities.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19811">Professional Development Financial Support Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefProfessionalDevelopmentFinancialSupportEntity RefProfessionalDevelopmentFinancialSupportEntity { get; set; }

    /// <summary>
    /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseCreditUnitEntity RefCourseCreditUnitEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual ProfessionalDevelopmentActivityEntity ProfessionalDevelopmentActivityEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentSession"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual ProfessionalDevelopmentSessionEntity ProfessionalDevelopmentSessionEntity { get; set; }

    #endregion
}
