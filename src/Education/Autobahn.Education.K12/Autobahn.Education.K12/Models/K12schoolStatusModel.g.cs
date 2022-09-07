//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolStatusEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolStatus file
/// </summary>
public partial class K12schoolStatusModel : AutobahnBaseModel, IK12schoolStatus
{
    #region "IK12schoolStatus Properties"
    public Boolean? ConsolidatedMepFundsStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    public Guid K12schoolId { get; set; }

    public System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocus"/> model
    /// </summary>
    public Guid? RefAlternativeSchoolFocusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
    /// </summary>
    public Guid? RefBlendedLearningModelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefComprehensiveAndTargetedSupport"/> model
    /// </summary>
    public Guid? RefComprehensiveAndTargetedSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefComprehensiveSupport"/> model
    /// </summary>
    public Guid? RefComprehensiveSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefInternetAccess"/> model
    /// </summary>
    public Guid? RefInternetAccessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMagnetSpecialProgram"/> model
    /// </summary>
    public Guid? RefMagnetSpecialProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNationalSchoolLunchProgramStatus"/> model
    /// </summary>
    public Guid? RefNationalSchoolLunchProgramStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNslpstatus"/> model
    /// </summary>
    public Guid? RefNslpstatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> model
    /// </summary>
    public Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRestructuringAction"/> model
    /// </summary>
    public Guid? RefRestructuringActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolDangerousStatus"/> model
    /// </summary>
    public Guid? RefSchoolDangerousStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
    /// </summary>
    public Guid? RefSchoolImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTargetedSupport"/> model
    /// </summary>
    public Guid? RefTargetedSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIschoolStatus"/> model
    /// </summary>
    public Guid? RefTitleIschoolStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefVirtualSchoolStatus"/> model
    /// </summary>
    public Guid? RefVirtualSchoolStatusId { get; set; }

    #endregion
}
