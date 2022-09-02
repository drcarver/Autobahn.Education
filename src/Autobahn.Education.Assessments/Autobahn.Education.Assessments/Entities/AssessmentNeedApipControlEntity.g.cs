//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipControlEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedApipControl file
/// </summary>
[Table("AssessmentNeedApipControl", Schema = "Assessments")]
public partial class AssessmentNeedApipControlEntity : EntityBase, IAssessmentNeedApipControl
{
    #region "IAssessmentNeedApipControl Properties"
    /// <summary>
    /// Assessment Need Time Multiplier
    /// <para>
    /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20055">Assessment Need Time Multiplier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(9,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.")]
    public System.String AssessmentNeedTimeMultiplier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileControl"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentPersonalNeedsProfileControl")]
    public Guid AssessmentPersonalNeedsProfileControlId { get; set; }

    /// <summary>
    /// Assessment Need Background Color
    /// <para>
    /// This is the preferred Background color for screen enhancement defined as part of an Assessment Personal Needs Profile.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20059">Assessment Need Background Color</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("This is the preferred Background color for screen enhancement defined as part of an Assessment Personal Needs Profile.")]
    public System.String BackgroundColor { get; set; }

    /// <summary>
    /// Assessment Need Line Reader Highlight Color
    /// <para>
    /// The color defined as part of an Assessment Personal Needs Profile to be used to highlight the point of line reader activity i.e. the line being read.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20056">Assessment Need Line Reader Highlight Color</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The color defined as part of an Assessment Personal Needs Profile to be used to highlight the point of line reader activity i.e. the line being read.")]
    public System.String LineReaderHighlightColor { get; set; }

    /// <summary>
    /// Assessment Need Overlay Color
    /// <para>
    /// This is the preferred color for the overlay for screen enhancement defined as part of an Assessment Personal Needs Profile.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20057">Assessment Need Overlay Color</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(6,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("This is the preferred color for the overlay for screen enhancement defined as part of an Assessment Personal Needs Profile.")]
    public System.String OverlayColor { get; set; }

    /// <summary>
    /// Assessment Need Increased Whitespacing Type
    /// <para>
    /// Defines the user preferences for white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20060">Assessment Need Increased Whitespacing Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentNeedIncreasedWhitespacingType")]
    [Comment("Defines the user preferences for white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.")]
    public Guid? RefAssessmentNeedIncreasedWhitespacingTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileControl"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentPersonalNeedsProfileControlEntity AssessmentPersonalNeedsProfileControlEntity { get; set; }

    /// <summary>
    /// Defines the user preferences for white spacing in lines, words and characters as part of an Assessment Personal Needs Profile.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20060">Assessment Need Increased Whitespacing Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentNeedIncreasedWhitespacingTypeEntity RefAssessmentNeedIncreasedWhitespacingTypeEntity { get; set; }

    #endregion
}
