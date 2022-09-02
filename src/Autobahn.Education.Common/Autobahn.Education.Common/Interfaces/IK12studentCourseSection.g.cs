//***************************************************************************
//* DomainName: Common Models
//* FileName:   IK12studentCourseSection.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCourseSection file
/// </summary>
public partial interface IK12studentCourseSection
{
    #region "IK12studentCourseSection Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? ExitWithdrawalDate { get; set; }

    System.String GradeEarned { get; set; }

    System.String GradeValueQualifier { get; set; }

    Decimal? NumberOfCreditsAttempted { get; set; }

    Decimal? NumberOfCreditsEarned { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
    /// </summary>
    Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseRepeatCode"/> model
    /// </summary>
    Guid? RefCourseRepeatCodeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionEnrollmentStatusType"/> model
    /// </summary>
    Guid? RefCourseSectionEnrollmentStatusTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionEntryType"/> model
    /// </summary>
    Guid? RefCourseSectionEntryTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseSectionExitType"/> model
    /// </summary>
    Guid? RefCourseSectionExitTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
    /// </summary>
    Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
    /// </summary>
    Guid? RefExitOrWithdrawalStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
    /// </summary>
    Guid? RefGradeLevelWhenCourseTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPreAndPostTestIndicator"/> model
    /// </summary>
    Guid? RefPreAndPostTestIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressLevel"/> model
    /// </summary>
    Guid? RefProgressLevelId { get; set; }

    Boolean? TuitionFunded { get; set; }

    #endregion
}
