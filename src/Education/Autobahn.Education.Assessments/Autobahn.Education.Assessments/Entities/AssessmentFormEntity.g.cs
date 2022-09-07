//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentForm file
/// </summary>
[Table("AssessmentForm", Schema = "Assessments")]
public partial class AssessmentFormEntity : EntityBase, IAssessmentForm
{
    #region "IAssessmentForm Properties"
    /// <summary>
    /// Assessment Form Accommodation List
    /// <para>
    /// The human readable list of one or more of the specific accommodations available. If no accommodations are provided, then this list will not be present.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20136">Assessment Form Accommodation List</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The human readable list of one or more of the specific accommodations available. If no accommodations are provided, then this list will not be present.")]
    public System.String AccommodationList { get; set; }

    /// <summary>
    /// Assessment Form Adaptive Indicator
    /// <para>
    /// Indicates that the assessment form was generated using an algorithm rather than a fixed form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20507">Assessment Form Adaptive Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates that the assessment form was generated using an algorithm rather than a fixed form.")]
    public Boolean? AssessmentFormAdaptiveIndicator { get; set; }

    /// <summary>
    /// Assessment Form Algorithm Identifier
    /// <para>
    /// An identifier for algorithm used to generate a custom form for an adaptive test.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20508">Assessment Form Algorithm Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("An identifier for algorithm used to generate a custom form for an adaptive test.")]
    public System.String AssessmentFormAlgorithmIdentifier { get; set; }

    /// <summary>
    /// Assessment Form Algorithm Version
    /// <para>
    /// The version of the algorithm used to generate a custom form for an adaptive test.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20509">Assessment Form Algorithm Version</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The version of the algorithm used to generate a custom form for an adaptive test.")]
    public System.String AssessmentFormAlgorithmVersion { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AssessmentFormGuid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Assessment")]
    public Guid AssessmentId { get; set; }

    /// <summary>
    /// Assessment Item Bank Identifier
    /// <para>
    /// If the assessment is provided with an item bank, then this identifies the item bank: a unique code or number used by the item banking system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20132">Assessment Item Bank Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("If the assessment is provided with an item bank, then this identifies the item bank: a unique code or number used by the item banking system.")]
    public System.String AssessmentItemBankIdentifier { get; set; }

    /// <summary>
    /// Assessment Item Bank Name
    /// <para>
    /// If the assessment is provided with an item bank, then this is the name of the item bank.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20133">Assessment Item Bank Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("If the assessment is provided with an item bank, then this is the name of the item bank.")]
    public System.String AssessmentItemBankName { get; set; }

    /// <summary>
    /// Assessment Secure Indicator
    /// <para>
    /// Indicates whether or not the assessment is a secure assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19375">Assessment Secure Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates whether or not the assessment is a secure assessment.")]
    public Boolean? AssessmentSecureIndicator { get; set; }

    /// <summary>
    /// Assessment Form Number
    /// <para>
    /// The number of a given assessment form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19365">Assessment Form Number</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The number of a given assessment form.")]
    public System.String FormNumber { get; set; }

    /// <summary>
    /// Assessment Form Intended Administration End Date
    /// <para>
    /// The ending date of the time period in which the assessment form is intended to be administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20138">Assessment Form Intended Administration End Date</a>
    /// </para>
    /// </summary>
    [Comment("The ending date of the time period in which the assessment form is intended to be administered.")]
    public DateTime? IntendedAdministrationEndDate { get; set; }

    /// <summary>
    /// Intended Administration Start Date
    /// <para>
    /// The beginning date of the time period in which the form is intended to be administered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20137">Intended Administration Start Date</a>
    /// </para>
    /// </summary>
    [Comment("The beginning date of the time period in which the form is intended to be administered.")]
    public DateTime? IntendedAdministrationStartDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [ForeignKey("LearningResource")]
    public Guid? LearningResourceId { get; set; }

    /// <summary>
    /// Assessment Form Name
    /// <para>
    /// The name of a given assessment form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19024">Assessment Form Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of a given assessment form.")]
    public System.String Name { get; set; }

    /// <summary>
    /// Assessment Form Platforms Supported
    /// <para>
    /// A human readable list of delivery platforms the form will support.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20139">Assessment Form Platforms Supported</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("A human readable list of delivery platforms the form will support.")]
    public System.String PlatformsSupported { get; set; }

    /// <summary>
    /// Learning Resource Published Date
    /// <para>
    /// The published date of an educational resource, such as instructional media, an assessment form, or section of an assessment form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20135">Learning Resource Published Date</a>
    /// </para>
    /// </summary>
    [Comment("The published date of an educational resource, such as instructional media, an assessment form, or section of an assessment form.")]
    public DateTime? PublishedDate { get; set; }

    /// <summary>
    /// Assessment Language
    /// <para>
    /// The language in which the assessment form is designed to be delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20073">Assessment Language</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentLanguage")]
    [Comment("The language in which the assessment form is designed to be delivered.")]
    public Guid? RefAssessmentLanguageId { get; set; }

    /// <summary>
    /// Assessment Form Version
    /// <para>
    /// The version number of the Assessment Form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20134">Assessment Form Version</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The version number of the Assessment Form.")]
    public System.String Version { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentEntity AssessmentEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual LearningResourceEntity? LearningResourceEntity { get; set; }

    #endregion
}
