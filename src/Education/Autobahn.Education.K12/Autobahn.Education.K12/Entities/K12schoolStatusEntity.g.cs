//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolStatusEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolStatus file
/// </summary>
[Table("K12schoolStatus", Schema = "K12")]
public partial class K12schoolStatusEntity : EntityBase, IK12schoolStatus
{
    #region "IK12schoolStatus Properties"
    public Boolean? ConsolidatedMepFundsStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12school")]
    public Guid K12schoolId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocus"/> model
    /// </summary>
    [ForeignKey("RefAlternativeSchoolFocus")]
    public Guid? RefAlternativeSchoolFocusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
    /// </summary>
    [ForeignKey("RefBlendedLearningModelType")]
    public Guid? RefBlendedLearningModelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefComprehensiveAndTargetedSupport"/> model
    /// </summary>
    [ForeignKey("RefComprehensiveAndTargetedSupport")]
    public Guid? RefComprehensiveAndTargetedSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefComprehensiveSupport"/> model
    /// </summary>
    [ForeignKey("RefComprehensiveSupport")]
    public Guid? RefComprehensiveSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefInternetAccess"/> model
    /// </summary>
    [ForeignKey("RefInternetAccess")]
    public Guid? RefInternetAccessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMagnetSpecialProgram"/> model
    /// </summary>
    [ForeignKey("RefMagnetSpecialProgram")]
    public Guid? RefMagnetSpecialProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNationalSchoolLunchProgramStatus"/> model
    /// </summary>
    [ForeignKey("RefNationalSchoolLunchProgramStatus")]
    public Guid? RefNationalSchoolLunchProgramStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNslpstatus"/> model
    /// </summary>
    [ForeignKey("RefNslpstatus")]
    public Guid? RefNslpstatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> model
    /// </summary>
    [ForeignKey("RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus")]
    public Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRestructuringAction"/> model
    /// </summary>
    [ForeignKey("RefRestructuringAction")]
    public Guid? RefRestructuringActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolDangerousStatus"/> model
    /// </summary>
    [ForeignKey("RefSchoolDangerousStatus")]
    public Guid? RefSchoolDangerousStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
    /// </summary>
    [ForeignKey("RefSchoolImprovementStatus")]
    public Guid? RefSchoolImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTargetedSupport"/> model
    /// </summary>
    [ForeignKey("RefTargetedSupport")]
    public Guid? RefTargetedSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIschoolStatus"/> model
    /// </summary>
    [ForeignKey("RefTitleIschoolStatus")]
    public Guid? RefTitleIschoolStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefVirtualSchoolStatus"/> model
    /// </summary>
    [ForeignKey("RefVirtualSchoolStatus")]
    public Guid? RefVirtualSchoolStatusId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual K12schoolEntity K12schoolEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefMagnetSpecialProgram"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefMagnetSpecialProgramEntity? RefMagnetSpecialProgramEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAlternativeSchoolFocus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefAlternativeSchoolFocusEntity? RefAlternativeSchoolFocusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefInternetAccess"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefInternetAccessEntity? RefInternetAccessEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefRestructuringAction"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefRestructuringActionEntity? RefRestructuringActionEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefTitleIschoolStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefTitleIschoolStatusEntity? RefTitleIschoolStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefNslpstatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefNslpstatusEntity? RefNslpstatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefSchoolDangerousStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefSchoolDangerousStatusEntity? RefSchoolDangerousStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefSchoolImprovementStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefSchoolImprovementStatusEntity? RefSchoolImprovementStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusEntity? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefComprehensiveAndTargetedSupport"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefComprehensiveAndTargetedSupportEntity? RefComprehensiveAndTargetedSupportEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefComprehensiveSupport"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefComprehensiveSupportEntity? RefComprehensiveSupportEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefTargetedSupport"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefTargetedSupportEntity? RefTargetedSupportEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefNationalSchoolLunchProgramStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefNationalSchoolLunchProgramStatusEntity? RefNationalSchoolLunchProgramStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefVirtualSchoolStatus"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefVirtualSchoolStatusEntity? RefVirtualSchoolStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefBlendedLearningModelType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefBlendedLearningModelTypeEntity? RefBlendedLearningModelTypeEntity { get; set; }

    #endregion
}
