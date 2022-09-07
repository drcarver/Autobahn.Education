//***************************************************************************
//* DomainName: Competencies
//* FileName:   ICompetencyDefinition.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefinition file
/// </summary>
public partial interface ICompetencyDefinition
{
    #region "ICompetencyDefinition Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IChildOfCompetencyDefinition"/> model
    /// </summary>
    Guid? ChildOfCompetencyDefinitionId { get; set; }

    /// <summary>
    /// Competency Definition Parent Code
    /// <para>
    /// A human-referenceable code designated by the publisher to identify the parent item in the hierarchy of competency definitions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19873">Competency Definition Parent Code</a>
    /// </para>
    /// </summary>
    System.String CompetencyDefParentCode { get; set; }

    /// <summary>
    /// Competency Definition Parent Identifier
    /// <para>
    /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the parent item in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19872">Competency Definition Parent Identifier</a>
    /// </para>
    /// </summary>
    Guid CompetencyDefParentId { get; set; }

    /// <summary>
    /// Competency Definition Parent URL
    /// <para>
    /// A network-resolvable Uniform Resource Locator (URL) pointing to the authoritative reference for the hierarchal parent of the competency definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20078">Competency Definition Parent URL</a>
    /// </para>
    /// </summary>
    System.String CompetencyDefParentUrl { get; set; }

    /// <summary>
    /// Competency Definition Sequence
    /// <para>
    /// A set of one or more alphanumeric characters and/or symbols denoting the positioning of the statement being described in a sequential listing of statements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20549">Competency Definition Sequence</a>
    /// </para>
    /// </summary>
    System.String CompetencyDefSequence { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyFramework"/> model
    /// </summary>
    Guid CompetencyFrameworkId { get; set; }

    /// <summary>
    /// Competency Definition Concept Keyword
    /// <para>
    /// The significant topicality of the competency definition using free-text keywords and phrases.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19887">Competency Definition Concept Keyword</a>
    /// </para>
    /// </summary>
    System.String ConceptKeyword { get; set; }

    /// <summary>
    /// Competency Definition Concept Term
    /// <para>
    /// The topicality of the competency definition, e.g. "Pythagorean Theorem," "Trigonometric functions," "Forces and energy," "Scientific method," "Oral history," etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19888">Competency Definition Concept Term</a>
    /// </para>
    /// </summary>
    System.String ConceptTerm { get; set; }

    /// <summary>
    /// Competency Definition Current Version Indicator
    /// <para>
    /// Indicates that this is the most current version of the Competency Definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20499">Competency Definition Current Version Indicator</a>
    /// </para>
    /// </summary>
    Boolean? CurrentVersionIndicator { get; set; }

    /// <summary>
    /// Competency Definition Identifier
    /// <para>
    /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19666">Competency Definition Identifier</a>
    /// </para>
    /// </summary>
    System.String Identifier { get; set; }

    /// <summary>
    /// Competency Definition License
    /// <para>
    /// The full text or URL reference to a legal document giving official permission to do something with the competency definition statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19883">Competency Definition License</a>
    /// </para>
    /// </summary>
    System.String License { get; set; }

    /// <summary>
    /// Competency Definition Notes
    /// <para>
    /// Information about the derivation of a Competency Definition Statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20215">Competency Definition Notes</a>
    /// </para>
    /// </summary>
    System.String Notes { get; set; }

    /// <summary>
    /// Competency Definition Previous Version Identifier
    /// <para>
    /// The unique identifier of the previous version of the Competency Definition if the statement was modified.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20498">Competency Definition Previous Version Identifier</a>
    /// </para>
    /// </summary>
    System.String PreviousVersionIdentifier { get; set; }

    /// <summary>
    /// Competency Definition Blooms Taxonomy Domain
    /// <para>
    /// Classification of the Competency Definition using Bloom's Taxonomy Domains.�
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19875">Competency Definition Blooms Taxonomy Domain</a>
    /// </para>
    /// </summary>
    Guid? RefBloomsTaxonomyDomainId { get; set; }

    /// <summary>
    /// Competency Definition Node Accessibility Profile
    /// <para>
    /// When the Competency Definition is used as a node in a learning map, this element supports alternative pathways based on a learner's accessibility profile. The type selected indicates which accessibility profile the node is designed to address.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20377">Competency Definition Node Accessibility Profile</a>
    /// </para>
    /// </summary>
    Guid? RefCompetencyDefNodeAccessibilityProfileId { get; set; }

    /// <summary>
    /// Competency Definition Testability Type
    /// <para>
    /// Indicates if the competency described in the Competency Definition Statement can be tested using one or more assessment items.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20380">Competency Definition Testability Type</a>
    /// </para>
    /// </summary>
    Guid? RefCompetencyDefTestabilityTypeId { get; set; }

    /// <summary>
    /// Competency Definition Language
    /// <para>
    /// The default language of the text used for the content in the competency definition statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19881">Competency Definition Language</a>
    /// </para>
    /// </summary>
    Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Competency Definition Multiple Intelligence
    /// <para>
    /// Classification of the Competency Definition using intelligences defined for Howard Earl Gardner's Theory of Multiple Intelligences.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19876">Competency Definition Multiple Intelligence</a>
    /// </para>
    /// </summary>
    Guid? RefMultipleIntelligenceTypeId { get; set; }

    /// <summary>
    /// Competency Definition Short Name
    /// <para>
    /// The short name or label for the competency definition or its node in a competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20378">Competency Definition Short Name</a>
    /// </para>
    /// </summary>
    System.String ShortName { get; set; }

    /// <summary>
    /// Competency Definition Statement
    /// <para>
    /// The text of the statement. The textual content that either describes a specific competency or describes a less granular group of competencies within the taxonomy of the competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19667">Competency Definition Statement</a>
    /// </para>
    /// </summary>
    System.String Statement { get; set; }

    /// <summary>
    /// Competency Definition Text Complexity Maximum Value
    /// <para>
    /// The maximum value in the range of text complexity applicable to a language competency definition using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20115">Competency Definition Text Complexity Maximum Value</a>
    /// </para>
    /// </summary>
    Decimal? TextComplexityMaximumValue { get; set; }

    /// <summary>
    /// Competency Definition Text Complexity Minimum Value
    /// <para>
    /// The minimum value in the range of text complexity applicable to a language competency definition using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20114">Competency Definition Text Complexity Minimum Value</a>
    /// </para>
    /// </summary>
    Decimal? TextComplexityMinimumValue { get; set; }

    /// <summary>
    /// Competency Definition Text Complexity System
    /// <para>
    /// The scaling system used to specify the text complexity of a competency item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19910">Competency Definition Text Complexity System</a>
    /// </para>
    /// </summary>
    System.String TextComplexitySystem { get; set; }

    /// <summary>
    /// Competency Definition Type
    /// <para>
    /// The class of statement in the structure of statements in the Competency Framework according to a controlled vocabulary, specified as a textual label.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19668">Competency Definition Type</a>
    /// </para>
    /// </summary>
    System.String Type { get; set; }

    System.String TypeUrl { get; set; }

    System.String TypicalAgeRange { get; set; }

    /// <summary>
    /// Competency Definition Typical Age Range Maximum
    /// <para>
    /// The typical maximum age at which a person learns the defined competency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20890">Competency Definition Typical Age Range Maximum</a>
    /// </para>
    /// </summary>
    Int32? TypicalAgeRangeMaximum { get; set; }

    /// <summary>
    /// Competency Definition Typical Age Range Minimum
    /// <para>
    /// The typical minimum age at which a person learns the defined competency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20889">Competency Definition Typical Age Range Minimum</a>
    /// </para>
    /// </summary>
    Int32? TypicalAgeRangeMinimum { get; set; }

    System.String Url { get; set; }

    /// <summary>
    /// Competency Definition Valid End Date
    /// <para>
    /// The year, month and day the competency definition was deprecated/replaced by the jurisdiction in which it was intended to apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20483">Competency Definition Valid End Date</a>
    /// </para>
    /// </summary>
    DateTime? ValidEndDate { get; set; }

    /// <summary>
    /// Competency Definition Valid Start Date
    /// <para>
    /// The year, month and day the competency definition was adopted by the jurisdiction in which it was intended to apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20484">Competency Definition Valid Start Date</a>
    /// </para>
    /// </summary>
    DateTime? ValidStartDate { get; set; }

    /// <summary>
    /// Competency Definition Version
    /// <para>
    /// A label assigned by the publisher indicating the version of the competency framework statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20216">Competency Definition Version</a>
    /// </para>
    /// </summary>
    System.String Version { get; set; }

    #endregion
}
