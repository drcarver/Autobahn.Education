//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12course.g.cs
//***************************************************************************

/// <summary>
/// The IK12course file
/// </summary>
public partial interface IK12course
{
    #region "IK12course Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Decimal? AvailableCarnegieUnitCredit { get; set; }

    Boolean? CoreAcademicCourse { get; set; }

    Boolean? CourseAlignedWithStandards { get; set; }

    System.String CourseDepartmentName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    Guid CourseId { get; set; }

    Boolean? FamilyConsumerSciencesCourseInd { get; set; }

    System.String FundingProgram { get; set; }

    Boolean? HighSchoolCourseRequirement { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
    /// </summary>
    Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
    /// </summary>
    Guid? RefBlendedLearningModelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
    /// </summary>
    Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseInteractionMode"/> model
    /// </summary>
    Guid? RefCourseInteractionModeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
    /// </summary>
    Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCurriculumFrameworkType"/> model
    /// </summary>
    Guid? RefCurriculumFrameworkTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12endOfCourseRequirement"/> model
    /// </summary>
    Guid? RefK12endOfCourseRequirementId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseLevel"/> model
    /// </summary>
    Guid? RefScedcourseLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    Guid? RefScedcourseSubjectAreaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
    /// </summary>
    Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    System.String ScedcourseCode { get; set; }

    System.String ScedgradeSpan { get; set; }

    #endregion
}
