//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12courseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12course file
/// </summary>
public partial class K12courseModel : AutobahnBaseModel, IK12course
{
    #region "IK12course Properties"
    public Decimal? AvailableCarnegieUnitCredit { get; set; }

    public Boolean? CoreAcademicCourse { get; set; }

    public Boolean? CourseAlignedWithStandards { get; set; }

    public System.String CourseDepartmentName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    public Guid CourseId { get; set; }

    public Boolean? FamilyConsumerSciencesCourseInd { get; set; }

    public System.String FundingProgram { get; set; }

    public Boolean? HighSchoolCourseRequirement { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
    /// </summary>
    public Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
    /// </summary>
    public Guid? RefBlendedLearningModelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
    /// </summary>
    public Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    public Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseInteractionMode"/> model
    /// </summary>
    public Guid? RefCourseInteractionModeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
    /// </summary>
    public Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCurriculumFrameworkType"/> model
    /// </summary>
    public Guid? RefCurriculumFrameworkTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12endOfCourseRequirement"/> model
    /// </summary>
    public Guid? RefK12endOfCourseRequirementId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseLevel"/> model
    /// </summary>
    public Guid? RefScedcourseLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    public Guid? RefScedcourseSubjectAreaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
    /// </summary>
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    public System.String ScedcourseCode { get; set; }

    public System.String ScedgradeSpan { get; set; }

    #endregion
}
