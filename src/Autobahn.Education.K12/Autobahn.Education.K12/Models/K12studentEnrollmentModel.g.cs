//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentEnrollmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentEnrollment file
/// </summary>
public partial class K12studentEnrollmentModel : AutobahnBaseModel, IK12studentEnrollment
{
    #region "IK12studentEnrollment Properties"
    public Boolean? DisplacedStudentStatus { get; set; }

    public DateTime? FirstEntryDateIntoUsschool { get; set; }

    public Boolean? NslpdirectCertificationIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
    /// </summary>
    public Guid? RefDirectoryInformationBlockStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEndOfTermStatus"/> model
    /// </summary>
    public Guid? RefEndOfTermStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEnrollmentStatus"/> model
    /// </summary>
    public Guid? RefEnrollmentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEntryGradeLevel"/> model
    /// </summary>
    public Guid? RefEntryGradeLevelId { get; set; }

    public Int32? RefEntryType { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitGradeLevel"/> model
    /// </summary>
    public Guid? RefExitGradeLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
    /// </summary>
    public Guid? RefExitOrWithdrawalStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalType"/> model
    /// </summary>
    public Guid? RefExitOrWithdrawalTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
    /// </summary>
    public Guid? RefFoodServiceEligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNonPromotionReason"/> model
    /// </summary>
    public Guid? RefNonPromotionReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPromotionReason"/> model
    /// </summary>
    public Guid? RefPromotionReasonId { get; set; }

    public Int32? RefPublicSchoolResidence { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessType"/> model
    /// </summary>
    public Guid? RefStudentEnrollmentAccessTypeId { get; set; }

    #endregion
}
