//***************************************************************************
//* DomainName: Common Models
//* FileName:   LearningResourceViewModel.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResource file
/// </summary>
public partial class LearningResourceViewModel : ObservableValidator, ILearningResource
{
    #region "LearningResourceViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// LearningResourceViewModel Constructor
    /// </summary>
    public LearningResourceViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnLearningResourceViewModelConstruction();
    }

    /// <summary>
    /// LearningResourceViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnLearningResourceViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from LearningResource";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // member variable for the AdaptedFromUrl property
    private System.String adaptedFromUrl;

    // AssistiveTechnologiesCompatibleInd -- (backing property for Learning Resource Assistive Technologies Compatible Indicator)
    private Boolean? assistiveTechnologiesCompatibleInd;

    // BasedOnUrl -- (backing property for Learning Resource Based on URL)
    private System.String basedOnUrl;

    // ConceptKeyword -- (backing property for Learning Resource Concept Keyword)
    private System.String conceptKeyword;

    // CopyrightHolderName -- (backing property for Learning Resource Copyright Holder Name)
    private System.String copyrightHolderName;

    // CopyrightYear -- (backing property for Learning Resource Copyright Year)
    private System.String copyrightYear;

    // Creator -- (backing property for Learning Resource Creator)
    private System.String creator;

    // DateCreated -- (backing property for Learning Resource Date Created)
    private DateTime? dateCreated;

    // LearningResourceAuthorEmail -- (backing property for Learning Resource Author Email)
    private System.String learningResourceAuthorEmail;

    // member variable for the LearningResourceAuthorUrl property
    private System.String learningResourceAuthorUrl;

    // LearningResourceDateModified -- (backing property for Learning Resource Date Modified)
    private DateTime? learningResourceDateModified;

    // member variable for the LearningResourceLicenseUrl property
    private System.String learningResourceLicenseUrl;

    // LearningResourcePublisherEmail -- (backing property for Learning Resource Publisher Email)
    private System.String learningResourcePublisherEmail;

    // member variable for the LearningResourcePublisherUrl property
    private System.String learningResourcePublisherUrl;

    // PeerRatingSampleSize -- (backing property for Learning Resource Peer Rating Sample Size)
    private Int32? peerRatingSampleSize;

    // PublishedDate -- (backing property for Learning Resource Published Date)
    private DateTime? publishedDate;

    // PublisherName -- (backing property for Learning Resource Publisher Name)
    private System.String publisherName;

    // SubjectCode -- (backing property for Learning Resource Subject Code)
    private System.String subjectCode;

    // SubjectCodeSystem -- (backing property for Learning Resource Subject Code System)
    private System.String subjectCodeSystem;

    // SubjectName -- (backing property for Learning Resource Subject Name)
    private System.String subjectName;

    // TextComplexitySystem -- (backing property for Learning Resource Text Complexity System)
    private System.String textComplexitySystem;

    // TextComplexityValue -- (backing property for Learning Resource Text Complexity Value)
    private System.String textComplexityValue;

    // TimeRequired -- (backing property for Learning Resource Time Required)
    private Decimal? timeRequired;

    // Title -- (backing property for Learning Resource Title)
    private System.String title;

    // TypicalAgeRangeMaximum -- (backing property for Learning Resource Typical Age Range Maximum)
    private Byte? typicalAgeRangeMaximum;

    // TypicalAgeRangeMinimum -- (backing property for Learning Resource Typical Age Range Minimum)
    private Byte? typicalAgeRangeMinimum;

    // Url -- (backing property for Learning Resource URL)
    private System.String url;

    // Version -- (backing property for Learning Resource Version)
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

    #region "ILearningResource Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AdaptedFromUrl { get => adaptedFromUrl; set => SetProperty(ref adaptedFromUrl, value, true); }

    /// <summary>
    /// Learning Resource Assistive Technologies Compatible Indicator
    /// <para>
    /// Indicates that the learning resource is compatible with assistive technologies.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20362">Learning Resource Assistive Technologies Compatible Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Assistive Technologies Compatible Indicator")]
    public Boolean? AssistiveTechnologiesCompatibleInd { get => assistiveTechnologiesCompatibleInd; set => SetProperty(ref assistiveTechnologiesCompatibleInd, value, false); }

    /// <summary>
    /// Learning Resource Based on URL
    /// <para>
    /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19923">Learning Resource Based on URL</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Based on URL")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String BasedOnUrl { get => basedOnUrl; set => SetProperty(ref basedOnUrl, value, true); }

    /// <summary>
    /// Learning Resource Concept Keyword
    /// <para>
    /// The significant topicality of the Learning Resource using free-text keywords and phrases.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20159">Learning Resource Concept Keyword</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Concept Keyword")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ConceptKeyword { get => conceptKeyword; set => SetProperty(ref conceptKeyword, value, true); }

    /// <summary>
    /// Learning Resource Copyright Holder Name
    /// <para>
    /// The name(s) of the person(s) or organization(s) holding the copyright for the Learning Resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20157">Learning Resource Copyright Holder Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Copyright Holder Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CopyrightHolderName { get => copyrightHolderName; set => SetProperty(ref copyrightHolderName, value, true); }

    /// <summary>
    /// Learning Resource Copyright Year
    /// <para>
    /// The copyright year for the Learning Resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20158">Learning Resource Copyright Year</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Copyright Year")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CopyrightYear { get => copyrightYear; set => SetProperty(ref copyrightYear, value, true); }

    /// <summary>
    /// Learning Resource Creator
    /// <para>
    /// The name of a person or organization credited with the creation of the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19918">Learning Resource Creator</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Creator")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Creator { get => creator; set => SetProperty(ref creator, value, true); }

    /// <summary>
    /// Learning Resource Date Created
    /// <para>
    /// The date on which the resource was created.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19916">Learning Resource Date Created</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Date Created")]
    public DateTime? DateCreated { get => dateCreated; set => SetProperty(ref dateCreated, value, false); }

    /// <summary>
    /// Learning Resource Author Email
    /// <para>
    /// An email address for the author of the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20544">Learning Resource Author Email</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Author Email")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(128,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearningResourceAuthorEmail { get => learningResourceAuthorEmail; set => SetProperty(ref learningResourceAuthorEmail, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearningResourceAuthorUrl { get => learningResourceAuthorUrl; set => SetProperty(ref learningResourceAuthorUrl, value, true); }

    /// <summary>
    /// Learning Resource Date Modified
    /// <para>
    /// The most recent date that the learning resource was updated.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20542">Learning Resource Date Modified</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Date Modified")]
    public DateTime? LearningResourceDateModified { get => learningResourceDateModified; set => SetProperty(ref learningResourceDateModified, value, false); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearningResourceLicenseUrl { get => learningResourceLicenseUrl; set => SetProperty(ref learningResourceLicenseUrl, value, true); }

    /// <summary>
    /// Learning Resource Publisher Email
    /// <para>
    /// An email address for the publisher of the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20545">Learning Resource Publisher Email</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Publisher Email")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(128,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearningResourcePublisherEmail { get => learningResourcePublisherEmail; set => SetProperty(ref learningResourcePublisherEmail, value, true); }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String LearningResourcePublisherUrl { get => learningResourcePublisherUrl; set => SetProperty(ref learningResourcePublisherUrl, value, true); }

    /// <summary>
    /// Learning Resource Peer Rating Sample Size
    /// <para>
    /// The sample size of a peer rating value. Only used when the Peer Rating Value is collected in aggregate as an average of multiple atomic/individual ratings.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20369">Learning Resource Peer Rating Sample Size</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Peer Rating Sample Size")]
    public Int32? PeerRatingSampleSize { get => peerRatingSampleSize; set => SetProperty(ref peerRatingSampleSize, value, false); }

    /// <summary>
    /// Learning Resource Published Date
    /// <para>
    /// The published date of an educational resource, such as instructional media, an assessment form, or section of an assessment form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20135">Learning Resource Published Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Published Date")]
    public DateTime? PublishedDate { get => publishedDate; set => SetProperty(ref publishedDate, value, false); }

    /// <summary>
    /// Learning Resource Publisher Name
    /// <para>
    /// The name of the organization credited with publishing the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19919">Learning Resource Publisher Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Publisher Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String PublisherName { get => publisherName; set => SetProperty(ref publisherName, value, true); }

    /// <summary>
    /// Learning Resource Language
    /// <para>
    /// The primary language of the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19920">Learning Resource Language</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Language")]
    public Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLearningResourceAccessApitype"/> model
    /// </summary>
    public Guid? RefLearningResourceAccessApitypeId { get; set; }

    /// <summary>
    /// Learning Resource Access Hazard Type
    /// <para>
    /// A characteristic of the described learning resource that is physiologically dangerous to some users.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20359">Learning Resource Access Hazard Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Access Hazard Type")]
    public Guid? RefLearningResourceAccessHazardTypeId { get; set; }

    /// <summary>
    /// Learning Resource Access Mode Type
    /// <para>
    /// An access mode through which the intellectual content of a described learning resource or adaptation is communicated; if adaptations for the resource are known, the access modes of those adaptations are not included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20360">Learning Resource Access Mode Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Access Mode Type")]
    public Guid? RefLearningResourceAccessModeTypeId { get; set; }

    /// <summary>
    /// Learning Resource Access Rights URL
    /// <para>
    /// A Uniform Resource Locator (URL) that identifies the conditions that govern the user's ability to access a learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20537">Learning Resource Access Rights URL</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Access Rights URL")]
    public Guid? RefLearningResourceAccessRightsUrlId { get; set; }

    /// <summary>
    /// Learning Resource Author Type
    /// <para>
    /// The type of entity, organization or person, that authored the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20540">Learning Resource Author Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Author Type")]
    public Guid? RefLearningResourceAuthorTypeId { get; set; }

    /// <summary>
    /// Learning Resource Book Format Type
    /// <para>
    /// Specifies the format for a learning resource that is a book.  Other options may be considered for inclusion in the option set.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20363">Learning Resource Book Format Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Book Format Type")]
    public Guid? RefLearningResourceBookFormatTypeId { get; set; }

    /// <summary>
    /// Learning Resource Control Flexibility Type
    /// <para>
    /// Identifies a single input method that is sufficient to control the described learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20364">Learning Resource Control Flexibility Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Control Flexibility Type")]
    public Guid? RefLearningResourceControlFlexibilityTypeId { get; set; }

    /// <summary>
    /// Learning Resource Digital Media Sub Type
    /// <para>
    /// The media or file subtype of the digital resource being based on the Media Types and Subtypes, formerly known as MIME types, defined by the Internet Assigned Numbers Authority (IANA).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20365">Learning Resource Digital Media Sub Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Digital Media Sub Type")]
    public Guid? RefLearningResourceDigitalMediaSubTypeId { get; set; }

    /// <summary>
    /// Learning Resource Digital Media Type
    /// <para>
    /// The media or file type of the digital resource being based on the media types defined by the Internet Assigned Numbers Authority (AINA) at http://www.iana.org/assignments/media-types.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20366">Learning Resource Digital Media Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Digital Media Type")]
    public Guid? RefLearningResourceDigitalMediaTypeId { get; set; }

    /// <summary>
    /// Learning Resource Educational Use
    /// <para>
    /// The purpose of the work in the context of education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20005">Learning Resource Educational Use</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Educational Use")]
    public Guid? RefLearningResourceEducationalUseId { get; set; }

    /// <summary>
    /// Learning Resource Intended End User Role
    /// <para>
    /// The individual or group for which the resource was produced.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19924">Learning Resource Intended End User Role</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Intended End User Role")]
    public Guid? RefLearningResourceIntendedEndUserRoleId { get; set; }

    /// <summary>
    /// Learning Resource Interaction Mode
    /// <para>
    /// The primary type of interaction, synchronous or asynchronous, defined for the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20543">Learning Resource Interaction Mode</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Interaction Mode")]
    public Guid? RefLearningResourceInteractionModeId { get; set; }

    /// <summary>
    /// Learning Resource Interactivity Type
    /// <para>
    /// The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19928">Learning Resource Interactivity Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Interactivity Type")]
    public Guid? RefLearningResourceInteractivityTypeId { get; set; }

    /// <summary>
    /// Learning Resource Type
    /// <para>
    /// The predominate type or kind characterizing the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19929">Learning Resource Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Type")]
    public Guid? RefLearningResourceTypeId { get; set; }

    /// <summary>
    /// Learning Resource Subject Code
    /// <para>
    /// The code used to identify the organization of subject matter and related learning experiences addressed by the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19914">Learning Resource Subject Code</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Subject Code")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SubjectCode { get => subjectCode; set => SetProperty(ref subjectCode, value, true); }

    /// <summary>
    /// Learning Resource Subject Code System
    /// <para>
    /// The system that is used to identify the organization of subject matter and related learning experiences addressed by the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19915">Learning Resource Subject Code System</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Subject Code System")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SubjectCodeSystem { get => subjectCodeSystem; set => SetProperty(ref subjectCodeSystem, value, true); }

    /// <summary>
    /// Learning Resource Subject Name
    /// <para>
    /// The descriptive name for the subject of the content for the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19913">Learning Resource Subject Name</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Subject Name")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SubjectName { get => subjectName; set => SetProperty(ref subjectName, value, true); }

    /// <summary>
    /// Learning Resource Text Complexity System
    /// <para>
    /// The scaling system used to specify the text complexity of an Learning Resource
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19931">Learning Resource Text Complexity System</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Text Complexity System")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TextComplexitySystem { get => textComplexitySystem; set => SetProperty(ref textComplexitySystem, value, true); }

    /// <summary>
    /// Learning Resource Text Complexity Value
    /// <para>
    /// The complexity of the text using the scaling system defined by Text Complexity System, e.g. Lexile(tm).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19930">Learning Resource Text Complexity Value</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Text Complexity Value")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TextComplexityValue { get => textComplexityValue; set => SetProperty(ref textComplexityValue, value, true); }

    /// <summary>
    /// Learning Resource Time Required
    /// <para>
    /// The approximate or typical time it takes to work with or through this learning resource for the typical intended target audience.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19925">Learning Resource Time Required</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Time Required")]
    public Decimal? TimeRequired { get => timeRequired; set => SetProperty(ref timeRequired, value, false); }

    /// <summary>
    /// Learning Resource Title
    /// <para>
    /// The title of the resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19912">Learning Resource Title</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Title")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get => title; set => SetProperty(ref title, value, true); }

    /// <summary>
    /// Learning Resource Typical Age Range Maximum
    /// <para>
    /// The maximum for the typical range of ages of the content's intended end user.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19927">Learning Resource Typical Age Range Maximum</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Typical Age Range Maximum")]
    public Byte? TypicalAgeRangeMaximum { get => typicalAgeRangeMaximum; set => SetProperty(ref typicalAgeRangeMaximum, value, false); }

    /// <summary>
    /// Learning Resource Typical Age Range Minimum
    /// <para>
    /// The minimum for the typical range of ages of the content's intended end user.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19926">Learning Resource Typical Age Range Minimum</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Typical Age Range Minimum")]
    public Byte? TypicalAgeRangeMinimum { get => typicalAgeRangeMinimum; set => SetProperty(ref typicalAgeRangeMinimum, value, false); }

    /// <summary>
    /// Learning Resource URL
    /// <para>
    /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19911">Learning Resource URL</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource URL")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Url { get => url; set => SetProperty(ref url, value, true); }

    /// <summary>
    /// Learning Resource Version
    /// <para>
    /// Defines the version of the learning resource as defined by the publisher.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20182">Learning Resource Version</a>
    /// </para>
    /// </summary>
    [DisplayName("Learning Resource Version")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Version { get => version; set => SetProperty(ref version, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(ILearningResource model)
    {
        IsBusy = true;
        Id = model.Id;
        AdaptedFromUrl = model.AdaptedFromUrl; // 
        AssistiveTechnologiesCompatibleInd = model.AssistiveTechnologiesCompatibleInd; // Learning Resource Assistive Technologies Compatible Indicator
        BasedOnUrl = model.BasedOnUrl; // Learning Resource Based on URL
        ConceptKeyword = model.ConceptKeyword; // Learning Resource Concept Keyword
        CopyrightHolderName = model.CopyrightHolderName; // Learning Resource Copyright Holder Name
        CopyrightYear = model.CopyrightYear; // Learning Resource Copyright Year
        Creator = model.Creator; // Learning Resource Creator
        DateCreated = model.DateCreated; // Learning Resource Date Created
        LearningResourceAuthorEmail = model.LearningResourceAuthorEmail; // Learning Resource Author Email
        LearningResourceAuthorUrl = model.LearningResourceAuthorUrl; // 
        LearningResourceDateModified = model.LearningResourceDateModified; // Learning Resource Date Modified
        LearningResourceLicenseUrl = model.LearningResourceLicenseUrl; // 
        LearningResourcePublisherEmail = model.LearningResourcePublisherEmail; // Learning Resource Publisher Email
        LearningResourcePublisherUrl = model.LearningResourcePublisherUrl; // 
        PeerRatingSampleSize = model.PeerRatingSampleSize; // Learning Resource Peer Rating Sample Size
        PublishedDate = model.PublishedDate; // Learning Resource Published Date
        PublisherName = model.PublisherName; // Learning Resource Publisher Name
        RefLanguageId = model.RefLanguageId; // Learning Resource Language
        RefLearningResourceAccessApitypeId = model.RefLearningResourceAccessApitypeId; // 
        RefLearningResourceAccessHazardTypeId = model.RefLearningResourceAccessHazardTypeId; // Learning Resource Access Hazard Type
        RefLearningResourceAccessModeTypeId = model.RefLearningResourceAccessModeTypeId; // Learning Resource Access Mode Type
        RefLearningResourceAccessRightsUrlId = model.RefLearningResourceAccessRightsUrlId; // Learning Resource Access Rights URL
        RefLearningResourceAuthorTypeId = model.RefLearningResourceAuthorTypeId; // Learning Resource Author Type
        RefLearningResourceBookFormatTypeId = model.RefLearningResourceBookFormatTypeId; // Learning Resource Book Format Type
        RefLearningResourceControlFlexibilityTypeId = model.RefLearningResourceControlFlexibilityTypeId; // Learning Resource Control Flexibility Type
        RefLearningResourceDigitalMediaSubTypeId = model.RefLearningResourceDigitalMediaSubTypeId; // Learning Resource Digital Media Sub Type
        RefLearningResourceDigitalMediaTypeId = model.RefLearningResourceDigitalMediaTypeId; // Learning Resource Digital Media Type
        RefLearningResourceEducationalUseId = model.RefLearningResourceEducationalUseId; // Learning Resource Educational Use
        RefLearningResourceIntendedEndUserRoleId = model.RefLearningResourceIntendedEndUserRoleId; // Learning Resource Intended End User Role
        RefLearningResourceInteractionModeId = model.RefLearningResourceInteractionModeId; // Learning Resource Interaction Mode
        RefLearningResourceInteractivityTypeId = model.RefLearningResourceInteractivityTypeId; // Learning Resource Interactivity Type
        RefLearningResourceTypeId = model.RefLearningResourceTypeId; // Learning Resource Type
        SubjectCode = model.SubjectCode; // Learning Resource Subject Code
        SubjectCodeSystem = model.SubjectCodeSystem; // Learning Resource Subject Code System
        SubjectName = model.SubjectName; // Learning Resource Subject Name
        TextComplexitySystem = model.TextComplexitySystem; // Learning Resource Text Complexity System
        TextComplexityValue = model.TextComplexityValue; // Learning Resource Text Complexity Value
        TimeRequired = model.TimeRequired; // Learning Resource Time Required
        Title = model.Title; // Learning Resource Title
        TypicalAgeRangeMaximum = model.TypicalAgeRangeMaximum; // Learning Resource Typical Age Range Maximum
        TypicalAgeRangeMinimum = model.TypicalAgeRangeMinimum; // Learning Resource Typical Age Range Minimum
        Url = model.Url; // Learning Resource URL
        Version = model.Version; // Learning Resource Version
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
