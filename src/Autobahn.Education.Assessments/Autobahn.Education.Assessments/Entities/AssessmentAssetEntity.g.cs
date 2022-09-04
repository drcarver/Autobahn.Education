//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssetEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAsset file
/// </summary>
[Table("AssessmentAsset", Schema = "Assessments")]
public partial class AssessmentAssetEntity : EntityBase, IAssessmentAsset
{
    #region "IAssessmentAsset Properties"
    /// <summary>
    /// Assessment Asset Content Mime Type
    /// <para>
    /// MIME type to specifically indicate the Assessment Asset content type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20154">Assessment Asset Content Mime Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("MIME type to specifically indicate the Assessment Asset content type.")]
    public System.String ContentMimeType { get; set; }

    /// <summary>
    /// Assessment Asset Content URL
    /// <para>
    /// The Uniform Resource Locator (URL) location of the external Assessment Asset content.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20155">Assessment Asset Content URL</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The Uniform Resource Locator (URL) location of the external Assessment Asset content.")]
    public System.String ContentUrl { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.String ContentXml { get; set; }

    /// <summary>
    /// Assessment Asset Identifier
    /// <para>
    /// A unique code identifying the Assessment Asset provided by the authoring system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20149">Assessment Asset Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A unique code identifying the Assessment Asset provided by the authoring system.")]
    public System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [ForeignKey("LearningResource")]
    public Guid? LearningResourceId { get; set; }

    /// <summary>
    /// Assessment Asset Name
    /// <para>
    /// The name of the Assessment Asset.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20151">Assessment Asset Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the Assessment Asset.")]
    public System.String Name { get; set; }

    /// <summary>
    /// Assessment Asset Owner
    /// <para>
    /// The name of the ownership rights holder or publisher of the asset.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20152">Assessment Asset Owner</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the ownership rights holder or publisher of the asset.")]
    public System.String Owner { get; set; }

    /// <summary>
    /// Assessment Asset Published Date
    /// <para>
    /// The date that this version of the asset was made available for use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20148">Assessment Asset Published Date</a>
    /// </para>
    /// </summary>
    [Comment("The date that this version of the asset was made available for use.")]
    public DateTime? PublishedDate { get; set; }

    /// <summary>
    /// Assessment Asset Identifier Type
    /// <para>
    /// The type of identifier that is provided for this asset.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20150">Assessment Asset Identifier Type</a>
    /// </para>
    /// </summary>
    [Comment("The type of identifier that is provided for this asset.")]
    public Int32? RefAssessmentAssestIdentifierType { get; set; }

    /// <summary>
    /// Assessment Asset Type
    /// <para>
    /// Specifies a predominant type of assessment asset represented by the Learning Resource.  Assessment assets represent any content used to compose an assessment item, is referenced by an item but not part of the item content itself, or is content that is included as part of a section within an assessment form. Assets can be static content such as art work or dynamic assets such as calculators.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20147">Assessment Asset Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentAssetType")]
    [Comment("Specifies a predominant type of assessment asset represented by the Learning Resource.  Assessment assets represent any content used to compose an assessment item, is referenced by an item but not part of the item content itself, or is content that is included as part of a section within an assessment form. Assets can be static content such as art work or dynamic assets such as calculators.")]
    public Guid? RefAssessmentAssetTypeId { get; set; }

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
    /// Assessment Asset Version
    /// <para>
    /// A version number or label defined by the publisher.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20146">Assessment Asset Version</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A version number or label defined by the publisher.")]
    public System.String Version { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Specifies a predominant type of assessment asset represented by the Learning Resource.  Assessment assets represent any content used to compose an assessment item, is referenced by an item but not part of the item content itself, or is content that is included as part of a section within an assessment form. Assets can be static content such as art work or dynamic assets such as calculators.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20147">Assessment Asset Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual RefAssessmentAssetTypeEntity? RefAssessmentAssetTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual LearningResourceEntity? LearningResourceEntity { get; set; }

    #endregion
}
