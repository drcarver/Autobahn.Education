//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubTestEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubTest file
/// </summary>
[Table("AssessmentSubTest", Schema = "Assessments")]
public partial class AssessmentSubTestEntity : EntityBase, IAssessmentSubTest
{
    #region "IAssessmentSubTest Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Abbreviation { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    [ForeignKey("AssessmentForm")]
    public Guid? AssessmentFormId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IChildOfAssessmentSubtest"/> model
    /// </summary>
    [ForeignKey("ChildOfAssessmentSubtest")]
    public Guid? ChildOfAssessmentSubtestId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ContainerOnly { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MaximumValue { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String MinimumValue { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OptimalValue { get; set; }

    public DateTime? PublishedDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAcademicSubject"/> model
    /// </summary>
    [ForeignKey("RefAcademicSubject")]
    public Guid? RefAcademicSubjectId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
    /// </summary>
    [ForeignKey("RefAssessmentPurpose")]
    public Guid? RefAssessmentPurposeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentSubtestentifierType"/> model
    /// </summary>
    [ForeignKey("RefAssessmentSubtestentifierType")]
    public Guid? RefAssessmentSubtestIdentifierTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefContentStandardType"/> model
    /// </summary>
    [ForeignKey("RefContentStandardType")]
    public Guid? RefContentStandardTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
    /// </summary>
    [ForeignKey("RefScoreMetricType")]
    public Guid? RefScoreMetricTypeId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String Rules { get; set; }

    public Int32? Tier { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Version { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefScoreMetricType"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefScoreMetricTypeEntity? RefScoreMetricTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAssessmentPurpose"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentPurposeEntity? RefAssessmentPurposeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefContentStandardType"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefContentStandardTypeEntity? RefContentStandardTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefAcademicSubject"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAcademicSubjectEntity? RefAcademicSubjectEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentFormEntity? AssessmentFormEntity { get; set; }

    #endregion
}
