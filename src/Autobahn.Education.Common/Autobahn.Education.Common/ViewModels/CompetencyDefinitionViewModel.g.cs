//***************************************************************************
//* DomainName: Common Models
//* FileName:   CompetencyDefinitionViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefinition file
/// </summary>
public partial class CompetencyDefinitionViewModel : ObservableValidator, ICompetencyDefinition
{
    #region "CompetencyDefinitionViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// CompetencyDefinitionViewModel Constructor
    /// </summary>
    public CompetencyDefinitionViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnCompetencyDefinitionViewModelConstruction();
    }

    /// <summary>
    /// CompetencyDefinitionViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnCompetencyDefinitionViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from CompetencyDefinition";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // CompetencyDefParentCode -- (backing property for Competency Definition Parent Code)
    private System.String competencyDefParentCode;

    // CompetencyDefParentUrl -- (backing property for Competency Definition Parent URL)
    private System.String competencyDefParentUrl;

    // CompetencyDefSequence -- (backing property for Competency Definition Sequence)
    private System.String competencyDefSequence;

    // ConceptKeyword -- (backing property for Competency Definition Concept Keyword)
    private System.String conceptKeyword;

    // ConceptTerm -- (backing property for Competency Definition Concept Term)
    private System.String conceptTerm;

    // CurrentVersionIndicator -- (backing property for Competency Definition Current Version Indicator)
    private Boolean? currentVersionIndicator;

    // Identifier -- (backing property for Competency Definition Identifier)
    private System.String identifier;

    // License -- (backing property for Competency Definition License)
    private System.String license;

    // Notes -- (backing property for Competency Definition Notes)
    private System.String notes;

    // PreviousVersionIdentifier -- (backing property for Competency Definition Previous Version Identifier)
    private System.String previousVersionIdentifier;

    // ShortName -- (backing property for Competency Definition Short Name)
    private System.String shortName;

    // Statement -- (backing property for Competency Definition Statement)
    private System.String statement;

    // TextComplexityMaximumValue -- (backing property for Competency Definition Text Complexity Maximum Value)
    private Decimal? textComplexityMaximumValue;

    // TextComplexityMinimumValue -- (backing property for Competency Definition Text Complexity Minimum Value)
    private Decimal? textComplexityMinimumValue;

    // TextComplexitySystem -- (backing property for Competency Definition Text Complexity System)
    private System.String textComplexitySystem;

    // Type -- (backing property for Competency Definition Type)
    private System.String type;

    // member variable for the TypeUrl property
    private System.String typeUrl;

    // member variable for the TypicalAgeRange property
    private System.String typicalAgeRange;

    // TypicalAgeRangeMaximum -- (backing property for Competency Definition Typical Age Range Maximum)
    private Int32? typicalAgeRangeMaximum;

    // TypicalAgeRangeMinimum -- (backing property for Competency Definition Typical Age Range Minimum)
    private Int32? typicalAgeRangeMinimum;

    // member variable for the Url property
    private System.String url;

    // ValidEndDate -- (backing property for Competency Definition Valid End Date)
    private DateTime? validEndDate;

    // ValidStartDate -- (backing property for Competency Definition Valid Start Date)
    private DateTime? validStartDate;

    // Version -- (backing property for Competency Definition Version)
    private System.String version;

    #endregion

    #region "IAutobahnBase Properties"
    /// <summary>
    /// The title of the View Model
    /// </summary>
    public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

    /// <summary>
    /// The IsNew property is set if the view model has been created but not saved to the database
    /// </summary>
    public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

    /// <summary>
    /// The IsDeleted property is set if the view model is to be delted from the database
    /// </summary>
    public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

    /// <summary>
    /// The primary key of the view model
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The view model is changed and needs to be save to the database.
    /// </summary>
    public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

    /// <summary>
    /// The view model is performing a long running task
    /// </summary>
    public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

    /// <summary>
    /// The view model's changes have been save so update its tracking properties
    /// </summary>
    public void AcceptChanges()
    {
        IsNew = false;
        IsChanged = false;
    }
    #endregion

    #region "ICompetencyDefinition Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IChildOfCompetencyDefinition"/> model
    /// </summary>
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
    [DisplayName("Competency Definition Parent Code")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CompetencyDefParentCode { get => competencyDefParentCode; set => SetProperty(ref competencyDefParentCode, value, true); }

    /// <summary>
    /// Competency Definition Parent Identifier
    /// <para>
    /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the parent item in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19872">Competency Definition Parent Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Parent Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
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
    [DisplayName("Competency Definition Parent URL")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CompetencyDefParentUrl { get => competencyDefParentUrl; set => SetProperty(ref competencyDefParentUrl, value, true); }

    /// <summary>
    /// Competency Definition Sequence
    /// <para>
    /// A set of one or more alphanumeric characters and/or symbols denoting the positioning of the statement being described in a sequential listing of statements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20549">Competency Definition Sequence</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Sequence")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CompetencyDefSequence { get => competencyDefSequence; set => SetProperty(ref competencyDefSequence, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyFramework"/> model
    /// </summary>
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
    [DisplayName("Competency Definition Concept Keyword")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ConceptKeyword { get => conceptKeyword; set => SetProperty(ref conceptKeyword, value, true); }

    /// <summary>
    /// Competency Definition Concept Term
    /// <para>
    /// The topicality of the competency definition, e.g. "Pythagorean Theorem," "Trigonometric functions," "Forces and energy," "Scientific method," "Oral history," etc.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19888">Competency Definition Concept Term</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Concept Term")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ConceptTerm { get => conceptTerm; set => SetProperty(ref conceptTerm, value, true); }

    /// <summary>
    /// Competency Definition Current Version Indicator
    /// <para>
    /// Indicates that this is the most current version of the Competency Definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20499">Competency Definition Current Version Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Current Version Indicator")]
    public Boolean? CurrentVersionIndicator { get => currentVersionIndicator; set => SetProperty(ref currentVersionIndicator, value, false); }

    /// <summary>
    /// Competency Definition Identifier
    /// <para>
    /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19666">Competency Definition Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get => identifier; set => SetProperty(ref identifier, value, true); }

    /// <summary>
    /// Competency Definition License
    /// <para>
    /// The full text or URL reference to a legal document giving official permission to do something with the competency definition statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19883">Competency Definition License</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition License")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String License { get => license; set => SetProperty(ref license, value, true); }

    /// <summary>
    /// Competency Definition Notes
    /// <para>
    /// Information about the derivation of a Competency Definition Statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20215">Competency Definition Notes</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Notes")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Notes { get => notes; set => SetProperty(ref notes, value, true); }

    /// <summary>
    /// Competency Definition Previous Version Identifier
    /// <para>
    /// The unique identifier of the previous version of the Competency Definition if the statement was modified.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20498">Competency Definition Previous Version Identifier</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Previous Version Identifier")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String PreviousVersionIdentifier { get => previousVersionIdentifier; set => SetProperty(ref previousVersionIdentifier, value, true); }

    /// <summary>
    /// Competency Definition Blooms Taxonomy Domain
    /// <para>
    /// Classification of the Competency Definition using Bloom's Taxonomy Domains.�
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19875">Competency Definition Blooms Taxonomy Domain</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Blooms Taxonomy Domain")]
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
    [DisplayName("Competency Definition Node Accessibility Profile")]
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
    [DisplayName("Competency Definition Testability Type")]
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
    [DisplayName("Competency Definition Language")]
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
    [DisplayName("Competency Definition Multiple Intelligence")]
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
    [DisplayName("Competency Definition Short Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ShortName { get => shortName; set => SetProperty(ref shortName, value, true); }

    /// <summary>
    /// Competency Definition Statement
    /// <para>
    /// The text of the statement. The textual content that either describes a specific competency or describes a less granular group of competencies within the taxonomy of the competency framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19667">Competency Definition Statement</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Statement")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Statement { get => statement; set => SetProperty(ref statement, value, true); }

    /// <summary>
    /// Competency Definition Text Complexity Maximum Value
    /// <para>
    /// The maximum value in the range of text complexity applicable to a language competency definition using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20115">Competency Definition Text Complexity Maximum Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Text Complexity Maximum Value")]
    public Decimal? TextComplexityMaximumValue { get => textComplexityMaximumValue; set => SetProperty(ref textComplexityMaximumValue, value, false); }

    /// <summary>
    /// Competency Definition Text Complexity Minimum Value
    /// <para>
    /// The minimum value in the range of text complexity applicable to a language competency definition using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20114">Competency Definition Text Complexity Minimum Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Text Complexity Minimum Value")]
    public Decimal? TextComplexityMinimumValue { get => textComplexityMinimumValue; set => SetProperty(ref textComplexityMinimumValue, value, false); }

    /// <summary>
    /// Competency Definition Text Complexity System
    /// <para>
    /// The scaling system used to specify the text complexity of a competency item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19910">Competency Definition Text Complexity System</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Text Complexity System")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TextComplexitySystem { get => textComplexitySystem; set => SetProperty(ref textComplexitySystem, value, true); }

    /// <summary>
    /// Competency Definition Type
    /// <para>
    /// The class of statement in the structure of statements in the Competency Framework according to a controlled vocabulary, specified as a textual label.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19668">Competency Definition Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Type")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Type { get => type; set => SetProperty(ref type, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TypeUrl { get => typeUrl; set => SetProperty(ref typeUrl, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(20,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TypicalAgeRange { get => typicalAgeRange; set => SetProperty(ref typicalAgeRange, value, true); }

    /// <summary>
    /// Competency Definition Typical Age Range Maximum
    /// <para>
    /// The typical maximum age at which a person learns the defined competency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20890">Competency Definition Typical Age Range Maximum</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Typical Age Range Maximum")]
    public Int32? TypicalAgeRangeMaximum { get => typicalAgeRangeMaximum; set => SetProperty(ref typicalAgeRangeMaximum, value, false); }

    /// <summary>
    /// Competency Definition Typical Age Range Minimum
    /// <para>
    /// The typical minimum age at which a person learns the defined competency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20889">Competency Definition Typical Age Range Minimum</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Typical Age Range Minimum")]
    public Int32? TypicalAgeRangeMinimum { get => typicalAgeRangeMinimum; set => SetProperty(ref typicalAgeRangeMinimum, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Url { get => url; set => SetProperty(ref url, value, true); }

    /// <summary>
    /// Competency Definition Valid End Date
    /// <para>
    /// The year, month and day the competency definition was deprecated/replaced by the jurisdiction in which it was intended to apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20483">Competency Definition Valid End Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Valid End Date")]
    public DateTime? ValidEndDate { get => validEndDate; set => SetProperty(ref validEndDate, value, false); }

    /// <summary>
    /// Competency Definition Valid Start Date
    /// <para>
    /// The year, month and day the competency definition was adopted by the jurisdiction in which it was intended to apply.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20484">Competency Definition Valid Start Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Valid Start Date")]
    public DateTime? ValidStartDate { get => validStartDate; set => SetProperty(ref validStartDate, value, false); }

    /// <summary>
    /// Competency Definition Version
    /// <para>
    /// A label assigned by the publisher indicating the version of the competency framework statement.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20216">Competency Definition Version</a>
    /// </para>
    /// </summary>
    [DisplayName("Competency Definition Version")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String Version { get => version; set => SetProperty(ref version, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ICompetencyDefinition model)
    {
        IsBusy = true;
        Id = model.Id;
        ChildOfCompetencyDefinitionId = model.ChildOfCompetencyDefinitionId; // 
        CompetencyDefParentCode = model.CompetencyDefParentCode; // Competency Definition Parent Code
        CompetencyDefParentId = model.CompetencyDefParentId; // Competency Definition Parent Identifier
        CompetencyDefParentUrl = model.CompetencyDefParentUrl; // Competency Definition Parent URL
        CompetencyDefSequence = model.CompetencyDefSequence; // Competency Definition Sequence
        CompetencyFrameworkId = model.CompetencyFrameworkId; // 
        ConceptKeyword = model.ConceptKeyword; // Competency Definition Concept Keyword
        ConceptTerm = model.ConceptTerm; // Competency Definition Concept Term
        CurrentVersionIndicator = model.CurrentVersionIndicator; // Competency Definition Current Version Indicator
        Identifier = model.Identifier; // Competency Definition Identifier
        License = model.License; // Competency Definition License
        Notes = model.Notes; // Competency Definition Notes
        PreviousVersionIdentifier = model.PreviousVersionIdentifier; // Competency Definition Previous Version Identifier
        RefBloomsTaxonomyDomainId = model.RefBloomsTaxonomyDomainId; // Competency Definition Blooms Taxonomy Domain
        RefCompetencyDefNodeAccessibilityProfileId = model.RefCompetencyDefNodeAccessibilityProfileId; // Competency Definition Node Accessibility Profile
        RefCompetencyDefTestabilityTypeId = model.RefCompetencyDefTestabilityTypeId; // Competency Definition Testability Type
        RefLanguageId = model.RefLanguageId; // Competency Definition Language
        RefMultipleIntelligenceTypeId = model.RefMultipleIntelligenceTypeId; // Competency Definition Multiple Intelligence
        ShortName = model.ShortName; // Competency Definition Short Name
        Statement = model.Statement; // Competency Definition Statement
        TextComplexityMaximumValue = model.TextComplexityMaximumValue; // Competency Definition Text Complexity Maximum Value
        TextComplexityMinimumValue = model.TextComplexityMinimumValue; // Competency Definition Text Complexity Minimum Value
        TextComplexitySystem = model.TextComplexitySystem; // Competency Definition Text Complexity System
        Type = model.Type; // Competency Definition Type
        TypeUrl = model.TypeUrl; // 
        TypicalAgeRange = model.TypicalAgeRange; // 
        TypicalAgeRangeMaximum = model.TypicalAgeRangeMaximum; // Competency Definition Typical Age Range Maximum
        TypicalAgeRangeMinimum = model.TypicalAgeRangeMinimum; // Competency Definition Typical Age Range Minimum
        Url = model.Url; // 
        ValidEndDate = model.ValidEndDate; // Competency Definition Valid End Date
        ValidStartDate = model.ValidStartDate; // Competency Definition Valid Start Date
        Version = model.Version; // Competency Definition Version
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
