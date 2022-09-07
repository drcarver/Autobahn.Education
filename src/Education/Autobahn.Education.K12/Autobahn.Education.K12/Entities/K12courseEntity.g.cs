//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12courseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12course file
/// </summary>
[Table("K12course", Schema = "K12")]
public partial class K12courseEntity : EntityBase, IK12course
{
    #region "IK12course Properties"
    public Decimal? AvailableCarnegieUnitCredit { get; set; }

    public Boolean? CoreAcademicCourse { get; set; }

    public Boolean? CourseAlignedWithStandards { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CourseDepartmentName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Course")]
    public Guid CourseId { get; set; }

    public Boolean? FamilyConsumerSciencesCourseInd { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String FundingProgram { get; set; }

    public Boolean? HighSchoolCourseRequirement { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
    /// </summary>
    [ForeignKey("RefAdditionalCreditType")]
    public Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBlendedLearningModelType"/> model
    /// </summary>
    [ForeignKey("RefBlendedLearningModelType")]
    public Guid? RefBlendedLearningModelTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
    /// </summary>
    [ForeignKey("RefCareerCluster")]
    public Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    [ForeignKey("RefCourseGpaapplicability")]
    public Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseInteractionMode"/> model
    /// </summary>
    [ForeignKey("RefCourseInteractionMode")]
    public Guid? RefCourseInteractionModeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
    /// </summary>
    [ForeignKey("RefCreditTypeEarned")]
    public Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCurriculumFrameworkType"/> model
    /// </summary>
    [ForeignKey("RefCurriculumFrameworkType")]
    public Guid? RefCurriculumFrameworkTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12endOfCourseRequirement"/> model
    /// </summary>
    [ForeignKey("RefK12endOfCourseRequirement")]
    public Guid? RefK12endOfCourseRequirementId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseLevel"/> model
    /// </summary>
    [ForeignKey("RefScedcourseLevel")]
    public Guid? RefScedcourseLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    [ForeignKey("RefScedcourseSubjectArea")]
    public Guid? RefScedcourseSubjectAreaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
    /// </summary>
    [ForeignKey("RefWorkbasedLearningOpportunityType")]
    public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(5,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScedcourseCode { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScedgradeSpan { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual CourseEntity CourseEntity { get; set; }

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
    /// Reference to an optional instance of the <see cref="IRefCurriculumFrameworkType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefCurriculumFrameworkTypeEntity? RefCurriculumFrameworkTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefScedcourseLevel"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefScedcourseLevelEntity? RefScedcourseLevelEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefScedcourseSubjectArea"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefScedcourseSubjectAreaEntity? RefScedcourseSubjectAreaEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCareerCluster"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefCareerClusterEntity? RefCareerClusterEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefBlendedLearningModelType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefBlendedLearningModelTypeEntity? RefBlendedLearningModelTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefCourseInteractionMode"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseInteractionModeEntity? RefCourseInteractionModeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefK12endOfCourseRequirement"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefK12endOfCourseRequirementEntity? RefK12endOfCourseRequirementEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefWorkbasedLearningOpportunityType"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual RefWorkbasedLearningOpportunityTypeEntity? RefWorkbasedLearningOpportunityTypeEntity { get; set; }

    #endregion
}
