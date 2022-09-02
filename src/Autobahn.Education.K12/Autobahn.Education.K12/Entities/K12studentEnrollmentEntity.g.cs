//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentEnrollmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentEnrollment file
/// </summary>
[Table("K12studentEnrollment", Schema = "K12")]
public partial class K12studentEnrollmentEntity : EntityBase, IK12studentEnrollment
{
    #region "IK12studentEnrollment Properties"
    public Boolean? DisplacedStudentStatus { get; set; }

    public DateTime? FirstEntryDateIntoUsschool { get; set; }

    public Boolean? NslpdirectCertificationIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
    /// </summary>
    [ForeignKey("RefDirectoryInformationBlockStatus")]
    public Guid? RefDirectoryInformationBlockStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEndOfTermStatus"/> model
    /// </summary>
    [ForeignKey("RefEndOfTermStatus")]
    public Guid? RefEndOfTermStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEnrollmentStatus"/> model
    /// </summary>
    [ForeignKey("RefEnrollmentStatus")]
    public Guid? RefEnrollmentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEntryGradeLevel"/> model
    /// </summary>
    [Obsolete("The RefEntryGradeLevel property is obsolete and will be removed in a later version")]
    [ForeignKey("RefEntryGradeLevel")]
    public Guid? RefEntryGradeLevelId { get; set; }

    public Int32? RefEntryType { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitGradeLevel"/> model
    /// </summary>
    [Obsolete("The RefExitGradeLevel property is obsolete and will be removed in a later version")]
    [ForeignKey("RefExitGradeLevel")]
    public Guid? RefExitGradeLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
    /// </summary>
    [ForeignKey("RefExitOrWithdrawalStatus")]
    public Guid? RefExitOrWithdrawalStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalType"/> model
    /// </summary>
    [ForeignKey("RefExitOrWithdrawalType")]
    public Guid? RefExitOrWithdrawalTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
    /// </summary>
    [ForeignKey("RefFoodServiceEligibility")]
    public Guid? RefFoodServiceEligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNonPromotionReason"/> model
    /// </summary>
    [ForeignKey("RefNonPromotionReason")]
    public Guid? RefNonPromotionReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPromotionReason"/> model
    /// </summary>
    [ForeignKey("RefPromotionReason")]
    public Guid? RefPromotionReasonId { get; set; }

    public Int32? RefPublicSchoolResidence { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessType"/> model
    /// </summary>
    [ForeignKey("RefStudentEnrollmentAccessType")]
    public Guid? RefStudentEnrollmentAccessTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEnrollmentStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefEnrollmentStatusEntity RefEnrollmentStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefExitOrWithdrawalStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefExitOrWithdrawalStatusEntity RefExitOrWithdrawalStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefExitOrWithdrawalType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefExitOrWithdrawalTypeEntity RefExitOrWithdrawalTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEndOfTermStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefEndOfTermStatusEntity RefEndOfTermStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefPromotionReason"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefPromotionReasonEntity RefPromotionReasonEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefNonPromotionReason"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefNonPromotionReasonEntity RefNonPromotionReasonEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefFoodServiceEligibility"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefFoodServiceEligibilityEntity RefFoodServiceEligibilityEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefDirectoryInformationBlockStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefDirectoryInformationBlockStatusEntity RefDirectoryInformationBlockStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefStudentEnrollmentAccessType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefStudentEnrollmentAccessTypeEntity RefStudentEnrollmentAccessTypeEntity { get; set; }

    #endregion
}
