//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedScreenReaderEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedScreenReader file
/// </summary>
[Table("AssessmentPersonalNeedScreenReader", Schema = "Assessments")]
public partial class AssessmentPersonalNeedScreenReaderEntity : EntityBase, IAssessmentPersonalNeedScreenReader
{
    #region "IAssessmentPersonalNeedScreenReader Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentPersonalNeedsProfileDisplay")]
    public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

    /// <summary>
    /// Assessment Need Pitch
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the pitch of a speech synthesizer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20031">Assessment Need Pitch</a>
    /// </para>
    /// </summary>
    [Comment("Defines as part of an Assessment Personal Needs Profile the pitch of a speech synthesizer.")]
    public Decimal? Pitch { get; set; }

    /// <summary>
    /// Assessment Need Link Indication Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the characteristics of presentation for a hyperlink when using a screen reader.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20029">Assessment Need Link Indication Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentNeedLinkIndicationType")]
    [Comment("Defines as part of an Assessment Personal Needs Profile the characteristics of presentation for a hyperlink when using a screen reader.")]
    public Guid? RefAssessmentNeedLinkIndicationTypeId { get; set; }

    /// <summary>
    /// Assessment Need Usage Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20028">Assessment Need Usage Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentNeedUsageType")]
    [Comment("Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.")]
    public Guid? RefAssessmentNeedUsageTypeId { get; set; }

    /// <summary>
    /// Assessment Need Speech Rate
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the rate of speech of a speech synthesizer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20030">Assessment Need Speech Rate</a>
    /// </para>
    /// </summary>
    [Comment("Defines as part of an Assessment Personal Needs Profile the rate of speech of a speech synthesizer.")]
    public Int32? SpeechRate { get; set; }

    /// <summary>
    /// Assessment Need Volume
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the volume of a speech synthesizer.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20032">Assessment Need Volume</a>
    /// </para>
    /// </summary>
    [Comment("Defines as part of an Assessment Personal Needs Profile the volume of a speech synthesizer.")]
    public Decimal? Volume { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentPersonalNeedsProfileDisplayEntity AssessmentPersonalNeedsProfileDisplayEntity { get; set; }

    /// <summary>
    /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20028">Assessment Need Usage Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentNeedUsageTypeEntity RefAssessmentNeedUsageTypeEntity { get; set; }

    /// <summary>
    /// Defines as part of an Assessment Personal Needs Profile the characteristics of presentation for a hyperlink when using a screen reader.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20029">Assessment Need Link Indication Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentNeedLinkIndicationTypeEntity RefAssessmentNeedLinkIndicationTypeEntity { get; set; }

    #endregion
}
