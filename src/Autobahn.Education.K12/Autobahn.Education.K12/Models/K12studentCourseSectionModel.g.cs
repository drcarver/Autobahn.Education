//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCourseSectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCourseSection file
/// </summary>
public partial class K12studentCourseSectionModel : AutobahnBaseModel, IK12studentCourseSection
{
    #region "IK12studentCourseSection Properties"
    public DateTime? ExitWithdrawalDate { get; set; }

    public System.String GradeEarned { get; set; }

    public System.String GradeValueQualifier { get; set; }

    public Decimal? NumberOfCreditsAttempted { get; set; }

    public Decimal? NumberOfCreditsEarned { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
    /// </summary>
    public Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    public Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
    /// </summary>
    public Guid? RefCourseRepeatCodeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionEnrollmentStatusType"/> model
    /// </summary>
    public Guid? RefCourseSectionEnrollmentStatusTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionEntryType"/> model
    /// </summary>
    public Guid? RefCourseSectionEntryTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionExitType"/> model
    /// </summary>
    public Guid? RefCourseSectionExitTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
    /// </summary>
    public Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
    /// </summary>
    public Guid? RefExitOrWithdrawalStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
    /// </summary>
    public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
    /// </summary>
    public Guid? RefPreAndPostTestIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
    /// </summary>
    public Guid? RefProgressLevelId { get; set; }

    public Boolean? TuitionFunded { get; set; }

    #endregion
}
