//***************************************************************************
//* DomainName: Common Models
//* FileName:   CompetencyDefinitionEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefinition file
/// </summary>
[Table("CompetencyDefinition", Schema = "Common")]
public partial class CompetencyDefinitionEntity : EntityBase, ICompetencyDefinition
{
    #region "ICompetencyDefinition Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IChildOfCompetencyDefinition"/> model
    /// </summary>
    [Obsolete("The ChildOfCompetencyDefinition property is obsolete and will be removed in a later version")]
    [ForeignKey("ChildOfCompetencyDefinition")]
    public Guid? ChildOfCompetencyDefinitionId { get; set; }

    /// <summary>
    /// Competency Definition Parent Code
    /// <para>
    /// A human-referenceable code designated by the publisher to identify the parent item in the hierarchy of competency definitions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19873">Competency Definition Parent Code</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A human-referenceable code designated by the publisher to identify the parent item in the hierarchy of competency definitions.")]
    public System.String CompetencyDefParentCode { get; set; }

    /// <summary>
    /// Competency Definition Parent Identifier
    /// <para>
    /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the parent item in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19872">Competency Definition Parent Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The CompetencyDefParent property is obsolete and will be removed in a later version")]
    [ForeignKey("CompetencyDefParent")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the parent item in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.")]
    public Guid CompetencyDefParentId { get; set; }

    /// <summary>
    /// Competency Definition Parent URL
    /// <para>
    /// A network-resolvable Uniform Resource Locator (URL) pointing to the authoritative reference for the hierarchal parent of the competency definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20078">Competency Definition Parent URL</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A network-resolvable Uniform Resource Locator (URL) pointing to the authoritative reference for the hierarchal parent of the competency definition.")]
    public System.String CompetencyDefParentUrl { get; set; }

    /// <summary>
    /// Competency Definition Sequence
    /// <para>
    /// A set of one or more alphanumeric characters and/or symbols denoting the positioning of the statement being described in a sequential listing of statements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20549">Competency Definition Sequence</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A set of one or more alphanumeric characters and/or symbols denoting the positioning of the statement being described in a sequential listing of statements.")]
    public System.String CompetencyDefSequence { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyFramework"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CompetencyFramework")]
    public Guid CompetencyFrameworkId { get; set; }

    /// <summary>
    /// Competency Definition Concept Keyword
    /// <para>
    /// The significant topicality of the competency definition using free-text keywords and phrases.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19887">Competency Definition Concept Keyword</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The significant topicality of the competency definition using free-text keywords and phrases.")]
    public System.String ConceptKeyword { get; set; }

    /// <summary>
    /// Competency Definition Concept Term
    /// <para>
    /// The topicality of the competency definition, e.g. "Pythagorean Theorem," "Trigonometric functions," "Forces and energy," "Scientific method," "Oral history," etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19888">Competency Definition Concept Term</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The topicality of the competency definition, e.g. \u0022Pythagorean Theorem,\u0022 \u0022Trigonometric functions,\u0022 \u0022Forces and energy,\u0022 \u0022Scientific method,\u0022 \u0022Oral history,\u0022 etc.")]
    public System.String ConceptTerm { get; set; }

    /// <summary>
    /// Competency Definition Current Version Indicator
    /// <para>
    /// Indicates that this is the most current version of the Competency Definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20499">Competency Definition Current Version Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates that this is the most current version of the Competency Definition.")]
    public Boolean? CurrentVersionIndicator { get; set; }

    /// <summary>
    /// Competency Definition Identifier
    /// <para>
    /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19666">Competency Definition Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.")]
    public System.String Identifier { get; set; }

    /// <summary>
    /// Competency Definition License
    /// <para>
    /// The full text or URL reference to a legal document giving official permission to do something with the competency definition statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19883">Competency Definition License</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The full text or URL reference to a legal document giving official permission to do something with the competency definition statement.")]
    public System.String License { get; set; }

    /// <summary>
    /// Competency Definition Notes
    /// <para>
    /// Information about the derivation of a Competency Definition Statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20215">Competency Definition Notes</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Information about the derivation of a Competency Definition Statement.")]
    public System.String Notes { get; set; }

    /// <summary>
    /// Competency Definition Previous Version Identifier
    /// <para>
    /// The unique identifier of the previous version of the Competency Definition if the statement was modified.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20498">Competency Definition Previous Version Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The unique identifier of the previous version of the Competency Definition if the statement was modified.")]
    public System.String PreviousVersionIdentifier { get; set; }

    /// <summary>
    /// Competency Definition Blooms Taxonomy Domain
    /// <para>
    /// Classification of the Competency Definition using Bloom's Taxonomy Domains.�
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19875">Competency Definition Blooms Taxonomy Domain</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBloomsTaxonomyDomain")]
    [Comment("Classification of the Competency Definition using Bloom's Taxonomy Domains.�")]
    public Guid? RefBloomsTaxonomyDomainId { get; set; }

    /// <summary>
    /// Competency Definition Node Accessibility Profile
    /// <para>
    /// When the Competency Definition is used as a node in a learning map, this element supports alternative pathways based on a learner's accessibility profile. The type selected indicates which accessibility profile the node is designed to address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20377">Competency Definition Node Accessibility Profile</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCompetencyDefNodeAccessibilityProfile")]
    [Comment("When the Competency Definition is used as a node in a learning map, this element supports alternative pathways based on a learner's accessibility profile. The type selected indicates which accessibility profile the node is designed to address.")]
    public Guid? RefCompetencyDefNodeAccessibilityProfileId { get; set; }

    /// <summary>
    /// Competency Definition Testability Type
    /// <para>
    /// Indicates if the competency described in the Competency Definition Statement can be tested using one or more assessment items.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20380">Competency Definition Testability Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCompetencyDefTestabilityType")]
    [Comment("Indicates if the competency described in the Competency Definition Statement can be tested using one or more assessment items.")]
    public Guid? RefCompetencyDefTestabilityTypeId { get; set; }

    /// <summary>
    /// Competency Definition Language
    /// <para>
    /// The default language of the text used for the content in the competency definition statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19881">Competency Definition Language</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefLanguage")]
    [Comment("The default language of the text used for the content in the competency definition statement.")]
    public Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Competency Definition Multiple Intelligence
    /// <para>
    /// Classification of the Competency Definition using intelligences defined for Howard Earl Gardner's Theory of Multiple Intelligences.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19876">Competency Definition Multiple Intelligence</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefMultipleIntelligenceType")]
    [Comment("Classification of the Competency Definition using intelligences defined for Howard Earl Gardner's Theory of Multiple Intelligences.")]
    public Guid? RefMultipleIntelligenceTypeId { get; set; }

    /// <summary>
    /// Competency Definition Short Name
    /// <para>
    /// The short name or label for the competency definition or its node in a competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20378">Competency Definition Short Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The short name or label for the competency definition or its node in a competency framework.")]
    public System.String ShortName { get; set; }

    /// <summary>
    /// Competency Definition Statement
    /// <para>
    /// The text of the statement. The textual content that either describes a specific competency or describes a less granular group of competencies within the taxonomy of the competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19667">Competency Definition Statement</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The text of the statement. The textual content that either describes a specific competency or describes a less granular group of competencies within the taxonomy of the competency framework.")]
    public System.String Statement { get; set; }

    /// <summary>
    /// Competency Definition Text Complexity Maximum Value
    /// <para>
    /// The maximum value in the range of text complexity applicable to a language competency definition using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20115">Competency Definition Text Complexity Maximum Value</a>
    /// </para>
    /// </summary>
    [Comment("The maximum value in the range of text complexity applicable to a language competency definition using the scaling system defined by Text Complexity System, e.g. Lexile(tm).")]
    public Decimal? TextComplexityMaximumValue { get; set; }

    /// <summary>
    /// Competency Definition Text Complexity Minimum Value
    /// <para>
    /// The minimum value in the range of text complexity applicable to a language competency definition using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20114">Competency Definition Text Complexity Minimum Value</a>
    /// </para>
    /// </summary>
    [Comment("The minimum value in the range of text complexity applicable to a language competency definition using the scaling system defined by Text Complexity System, e.g. Lexile(tm).")]
    public Decimal? TextComplexityMinimumValue { get; set; }

    /// <summary>
    /// Competency Definition Text Complexity System
    /// <para>
    /// The scaling system used to specify the text complexity of a competency item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19910">Competency Definition Text Complexity System</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The scaling system used to specify the text complexity of a competency item.")]
    public System.String TextComplexitySystem { get; set; }

    /// <summary>
    /// Competency Definition Type
    /// <para>
    /// The class of statement in the structure of statements in the Competency Framework according to a controlled vocabulary, specified as a textual label.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19668">Competency Definition Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The class of statement in the structure of statements in the Competency Framework according to a controlled vocabulary, specified as a textual label.")]
    public System.String Type { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TypeUrl { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TypicalAgeRange { get; set; }

    /// <summary>
    /// Competency Definition Typical Age Range Maximum
    /// <para>
    /// The typical maximum age at which a person learns the defined competency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20890">Competency Definition Typical Age Range Maximum</a>
    /// </para>
    /// </summary>
    [Comment("The typical maximum age at which a person learns the defined competency.")]
    public Int32? TypicalAgeRangeMaximum { get; set; }

    /// <summary>
    /// Competency Definition Typical Age Range Minimum
    /// <para>
    /// The typical minimum age at which a person learns the defined competency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20889">Competency Definition Typical Age Range Minimum</a>
    /// </para>
    /// </summary>
    [Comment("The typical minimum age at which a person learns the defined competency.")]
    public Int32? TypicalAgeRangeMinimum { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Url { get; set; }

    /// <summary>
    /// Competency Definition Valid End Date
    /// <para>
    /// The year, month and day the competency definition was deprecated/replaced by the jurisdiction in which it was intended to apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20483">Competency Definition Valid End Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day the competency definition was deprecated/replaced by the jurisdiction in which it was intended to apply.")]
    public DateTime? ValidEndDate { get; set; }

    /// <summary>
    /// Competency Definition Valid Start Date
    /// <para>
    /// The year, month and day the competency definition was adopted by the jurisdiction in which it was intended to apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20484">Competency Definition Valid Start Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day the competency definition was adopted by the jurisdiction in which it was intended to apply.")]
    public DateTime? ValidStartDate { get; set; }

    /// <summary>
    /// Competency Definition Version
    /// <para>
    /// A label assigned by the publisher indicating the version of the competency framework statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20216">Competency Definition Version</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("A label assigned by the publisher indicating the version of the competency framework statement.")]
    public System.String Version { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyFramework"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual CompetencyFrameworkEntity CompetencyFrameworkEntity { get; set; }

    /// <summary>
    /// The default language of the text used for the content in the competency definition statement.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19881">Competency Definition Language</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefLanguageEntity RefLanguageEntity { get; set; }

    /// <summary>
    /// Classification of the Competency Definition using Bloom's Taxonomy Domains.�
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19875">Competency Definition Blooms Taxonomy Domain</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefBloomsTaxonomyDomainEntity RefBloomsTaxonomyDomainEntity { get; set; }

    /// <summary>
    /// Classification of the Competency Definition using intelligences defined for Howard Earl Gardner's Theory of Multiple Intelligences.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19876">Competency Definition Multiple Intelligence</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefMultipleIntelligenceTypeEntity RefMultipleIntelligenceTypeEntity { get; set; }

    /// <summary>
    /// When the Competency Definition is used as a node in a learning map, this element supports alternative pathways based on a learner's accessibility profile. The type selected indicates which accessibility profile the node is designed to address.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20377">Competency Definition Node Accessibility Profile</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCompetencyDefNodeAccessibilityProfileEntity RefCompetencyDefNodeAccessibilityProfileEntity { get; set; }

    /// <summary>
    /// Indicates if the competency described in the Competency Definition Statement can be tested using one or more assessment items.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20380">Competency Definition Testability Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefCompetencyDefTestabilityTypeEntity RefCompetencyDefTestabilityTypeEntity { get; set; }

    #endregion
}
