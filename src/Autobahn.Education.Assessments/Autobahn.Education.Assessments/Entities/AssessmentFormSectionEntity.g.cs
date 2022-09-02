//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSection file
/// </summary>
[Table("AssessmentFormSection", Schema = "Assessments")]
public partial class AssessmentFormSectionEntity : EntityBase, IAssessmentFormSection
{
    #region "IAssessmentFormSection Properties"
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
    /// Reference to an optional instance of the <see cref="IChildOfFormSection"/> model
    /// </summary>
    [Obsolete("The ChildOfFormSection property is obsolete and will be removed in a later version")]
    [ForeignKey("ChildOfFormSection")]
    public Guid? ChildOfFormSectionId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Guid { get; set; }

    /// <summary>
    /// Assessment Form Section Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to�the Assessment Form Section using the system specified by Identification System for Assessment Form Section.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20142">Assessment Form Section Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A unique number or alphanumeric code assigned to�the Assessment Form Section using the system specified by Identification System for Assessment Form Section.")]
    public System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [ForeignKey("LearningResource")]
    public Guid? LearningResourceId { get; set; }

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
    /// Identification System for Assessment Form Section
    /// <para>
    /// A coding scheme that is used for identification of an Assessment Form Section.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20141">Identification System for Assessment Form Section</a>
    /// </para>
    /// </summary>
    [Obsolete("The RefAssessmentFormSectionentificationSystem property is obsolete and will be removed in a later version")]
    [ForeignKey("RefAssessmentFormSectionentificationSystem")]
    [Comment("A coding scheme that is used for identification of an Assessment Form Section.")]
    public Guid? RefAssessmentFormSectionIdentificationSystemId { get; set; }

    /// <summary>
    /// Assessment Form Section Reentry
    /// <para>
    /// Indicates that this section can be re-entered, meaning the test taker can return to this section after they have left the section. A common example of this is a two section test where one section does not allow the use of a calculator and the other does. Typically the test taker cannot return to the non-calculator section after they have used a calculator.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20145">Assessment Form Section Reentry</a>
    /// </para>
    /// </summary>
    [Comment("Indicates that this section can be re-entered, meaning the test taker can return to this section after they have left the section. A common example of this is a two section test where one section does not allow the use of a calculator and the other does. Typically the test taker cannot return to the non-calculator section after they have used a calculator.")]
    public Boolean? SectionReentry { get; set; }

    /// <summary>
    /// Assessment Form Section Sealed
    /// <para>
    /// Indicates this section is sealed, meaning the test taker cannot enter the section until authorized by the proctor.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20144">Assessment Form Section Sealed</a>
    /// </para>
    /// </summary>
    [Comment("Indicates this section is sealed, meaning the test taker cannot enter the section until authorized by the proctor.")]
    public Boolean? SectionSealed { get; set; }

    /// <summary>
    /// Assessment Form Section Time Limit
    /// <para>
    /// If this section is timed, then this will identify the maximum amount of time the test taker can spend within this section.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20143">Assessment Form Section Time Limit</a>
    /// </para>
    /// </summary>
    [Comment("If this section is timed, then this will identify the maximum amount of time the test taker can spend within this section.")]
    public TimeSpan? SectionTimeLimit { get; set; }

    /// <summary>
    /// Assessment Form Section Version
    /// <para>
    /// The version number of the Assessment Form Section.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20140">Assessment Form Section Version</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The version number of the Assessment Form Section.")]
    public System.String Version { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual LearningResourceEntity LearningResourceEntity { get; set; }

    #endregion
}
