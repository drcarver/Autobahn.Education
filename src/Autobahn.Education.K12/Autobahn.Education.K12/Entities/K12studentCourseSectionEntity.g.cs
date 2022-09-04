//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCourseSectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCourseSection file
/// </summary>
[Table("K12studentCourseSection", Schema = "K12")]
public partial class K12studentCourseSectionEntity : EntityBase, IK12studentCourseSection
{
    #region "IK12studentCourseSection Properties"
    public DateTime? ExitWithdrawalDate { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(15,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GradeEarned { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GradeValueQualifier { get; set; }

    public Decimal? NumberOfCreditsAttempted { get; set; }

    public Decimal? NumberOfCreditsEarned { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
    /// </summary>
    [ForeignKey("RefAdditionalCreditType")]
    public Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    [ForeignKey("RefCourseGpaapplicability")]
    public Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
    /// </summary>
    [ForeignKey("RefCourseRepeatCode")]
    public Guid? RefCourseRepeatCodeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionEnrollmentStatusType"/> model
    /// </summary>
    [ForeignKey("RefCourseSectionEnrollmentStatusType")]
    public Guid? RefCourseSectionEnrollmentStatusTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionEntryType"/> model
    /// </summary>
    [ForeignKey("RefCourseSectionEntryType")]
    public Guid? RefCourseSectionEntryTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionExitType"/> model
    /// </summary>
    [ForeignKey("RefCourseSectionExitType")]
    public Guid? RefCourseSectionExitTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
    /// </summary>
    [ForeignKey("RefCreditTypeEarned")]
    public Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
    /// </summary>
    [ForeignKey("RefExitOrWithdrawalStatus")]
    public Guid? RefExitOrWithdrawalStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
    /// </summary>
    [ForeignKey("RefGradeLevelWhenCourseTaken")]
    public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
    /// </summary>
    [ForeignKey("RefPreAndPostTestIndicator")]
    public Guid? RefPreAndPostTestIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
    /// </summary>
    [ForeignKey("RefProgressLevel")]
    public Guid? RefProgressLevelId { get; set; }

    public Boolean? TuitionFunded { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCourseRepeatCode"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseRepeatCodeEntity? RefCourseRepeatCodeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCourseSectionEnrollmentStatusType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseSectionEnrollmentStatusTypeEntity? RefCourseSectionEnrollmentStatusTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCourseSectionEntryType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseSectionEntryTypeEntity? RefCourseSectionEntryTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCourseSectionExitType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseSectionExitTypeEntity? RefCourseSectionExitTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefExitOrWithdrawalStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefExitOrWithdrawalStatusEntity? RefExitOrWithdrawalStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCreditTypeEarned"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefCreditTypeEarnedEntity? RefCreditTypeEarnedEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAdditionalCreditType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefAdditionalCreditTypeEntity? RefAdditionalCreditTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefPreAndPostTestIndicator"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefPreAndPostTestIndicatorEntity? RefPreAndPostTestIndicatorEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefProgressLevel"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefProgressLevelEntity? RefProgressLevelEntity { get; set; }

    #endregion
}
