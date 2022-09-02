//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12schoolStatus.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolStatus file
/// </summary>
public partial interface IK12schoolStatus
{
    #region "IK12schoolStatus Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? ConsolidatedMepFundsStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    Guid K12schoolId { get; set; }

    System.String ProgressAcheivingEnglishLearnerProficiencyStateDefinedStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocus"/> model
    /// </summary>
    Guid? RefAlternativeSchoolFocusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
    /// </summary>
    Guid? RefBlendedLearningModelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefComprehensiveAndTargetedSupport"/> model
    /// </summary>
    Guid? RefComprehensiveAndTargetedSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefComprehensiveSupport"/> model
    /// </summary>
    Guid? RefComprehensiveSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefInternetAccess"/> model
    /// </summary>
    Guid? RefInternetAccessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMagnetSpecialProgram"/> model
    /// </summary>
    Guid? RefMagnetSpecialProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNationalSchoolLunchProgramStatus"/> model
    /// </summary>
    Guid? RefNationalSchoolLunchProgramStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNslpstatus"/> model
    /// </summary>
    Guid? RefNslpstatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgressAchievingEnglishLanguageProficiencyIndicatorStatus"/> model
    /// </summary>
    Guid? RefProgressAchievingEnglishLanguageProficiencyIndicatorStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRestructuringAction"/> model
    /// </summary>
    Guid? RefRestructuringActionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolDangerousStatus"/> model
    /// </summary>
    Guid? RefSchoolDangerousStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
    /// </summary>
    Guid? RefSchoolImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTargetedSupport"/> model
    /// </summary>
    Guid? RefTargetedSupportId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIschoolStatus"/> model
    /// </summary>
    Guid? RefTitleIschoolStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefVirtualSchoolStatus"/> model
    /// </summary>
    Guid? RefVirtualSchoolStatusId { get; set; }

    #endregion
}
